using MusicStorageApi.Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MusicStorageApi.Repositories.Interfaces
{
    public interface IAuthorRepository
    {
        public List<Author> GetAuthors();
        public Author GetAuthorById(Guid authorId);
        public Author CreateAuthor(Author author);
        public Author UpdateAuthor(Guid authorId, Author author);
        public Author DeleteAuthor(Guid authorId);
    }
}
