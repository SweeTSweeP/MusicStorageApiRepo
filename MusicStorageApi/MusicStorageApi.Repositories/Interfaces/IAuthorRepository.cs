using MusicStorageApi.Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MusicStorageApi.Repositories.Interfaces
{
    public interface IAuthorRepository
    {
        public Task<List<Author>> GetAuthors();
        public Task<Author> GetAuthorById(Guid authorId);
        public Task<Author> CreateAuthor(Author author);
        public Task<Author> UpdateAuthor(Guid authorId, Author author);
        public Author DeleteAuthor(Guid authorId);
    }
}
