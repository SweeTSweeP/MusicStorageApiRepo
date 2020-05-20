using MusicStorageApi.Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MusicStorageApi.UnitTests.TestData
{
    class SongTestData
    {
        public List<Song> CreateMultipleSongs(int count)
        {
            var songs = new List<Song>();

            for (int i = 0; i < count; i++)
            {
                songs.Add(CreateSong($"Song {i + 1}"));
            }

            return songs;
        }

        public Song CreateSong(string songName)
        {
            return new Song
            {
                RecordLabel = "Label Records",
                ReleaseYear = "2000",
                Title = "Test title"
            };
        }
    }
}
