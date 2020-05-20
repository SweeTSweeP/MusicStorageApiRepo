using MusicStorageApi.Models.Entities;
using System;
using System.Collections.Generic;

namespace MusicStorageApi.UnitTests.TestData
{
    class AlbumTestData
    {
        public List<Album> CreateMultipleAlubums(int count)
        {
            var authors = new List<Album>();

            for (int i = 0; i < count; i++)
            {
                authors.Add(CreateAlbum($"Author {i + 1}"));
            }

            return authors;
        }

        public Album CreateAlbum(string albumTitle)
        {
            return new Album
            {
                AlbumId = Guid.NewGuid(),
                Genre = "Some Genre",
                RecordLabel = "Label records",
                ReleaseYear = "2000",
                Title = albumTitle
            };
        }
    }
}
