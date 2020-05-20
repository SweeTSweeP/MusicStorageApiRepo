using MusicStorageApi.Models.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;

namespace MusicStorageApi.UnitTests.TestData
{
    public class AuthorTestData
    {
        public List<Author> CreateMultipleAuthors(int count)
        {
            var authors = new List<Author>();

            for (int i = 0; i < count; i++)
            {
                authors.Add(CreateAthor($"Author {i+1}"));
            }

            return authors;
        }
        
        public Author CreateAthor(string authorName)
        {
            return new Author
            {
                AuthorId = Guid.NewGuid(),
                AuthorName = authorName
            };
        }
    }
}
