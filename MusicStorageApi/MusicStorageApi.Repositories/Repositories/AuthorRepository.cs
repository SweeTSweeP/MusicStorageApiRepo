using MusicStorageApi.Data.Context;
using MusicStorageApi.Models.Entities;
using MusicStorageApi.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MusicStorageApi.Repositories.Repositories
{
    public class AuthorRepository : IAuthorRepository
    {
        private readonly ApplicationContext context;

        public AuthorRepository(ApplicationContext _context)
        {
            context = _context;
        }

        public Author CreateAuthor(Author author)
        {
            author.AuthorId = Guid.NewGuid();

            context.Authors.Add(author);
            context.SaveChanges();

            return author;
        }

        public Author DeleteAuthor(Guid authorId)
        {
            var authorToDelete = context.Authors.Find(authorId);
            context.Authors.Remove(authorToDelete);
            context.SaveChanges();

            return authorToDelete;
        }

        public Author GetAuthorById(Guid authorId)
        {
            return context.Authors.Find(authorId);
        }

        public List<Author> GetAuthors()
        {
            return context.Authors.ToList();
        }

        public Author UpdateAuthor(Guid authorId, Author author)
        {
            author.AuthorId = authorId;
            context.Authors.Update(author);
            context.SaveChanges();

            return author;
        }
    }
}
