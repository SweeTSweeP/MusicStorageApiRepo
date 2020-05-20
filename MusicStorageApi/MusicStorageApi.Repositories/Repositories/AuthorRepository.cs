using Microsoft.EntityFrameworkCore;
using MusicStorageApi.Data.Context;
using MusicStorageApi.Models.Entities;
using MusicStorageApi.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStorageApi.Repositories.Repositories
{
    public class AuthorRepository : IAuthorRepository
    {
        private readonly ApplicationContext context;

        public AuthorRepository(ApplicationContext _context)
        {
            context = _context;
        }

        public Task<Author> CreateAuthor(Author author)
        {
            author.AuthorId = Guid.NewGuid();

            context.Authors.AddAsync(author);
            context.SaveChanges();

            return Task.FromResult(author);
        }

        public Task<Author> DeleteAuthor(Guid authorId)
        {
            var authorToDelete = context.Authors.Find(authorId);
            context.Authors.Remove(authorToDelete);
            context.SaveChanges();

            return Task.FromResult(authorToDelete);
        }

        public Task<Author> GetAuthorById(Guid authorId)
        {
            return context.Authors.FirstOrDefaultAsync(s => s.AuthorId == authorId);
        }

        public Task<List<Author>> GetAuthors()
        {
            return context.Authors.ToListAsync();
        }

        public Task<Author> UpdateAuthor(Guid authorId, Author author)
        {
            author.AuthorId = authorId;
            context.Authors.Update(author);
            context.SaveChanges();

            return Task.FromResult(author);
        }
    }
}
