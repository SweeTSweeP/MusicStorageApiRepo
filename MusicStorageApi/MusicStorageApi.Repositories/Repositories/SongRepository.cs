using MusicStorageApi.Data.Context;
using MusicStorageApi.Models.Entities;
using MusicStorageApi.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MusicStorageApi.Repositories.Repositories
{
    public class SongRepository : ISongRepository
    {
        private readonly ApplicationContext context;

        public SongRepository(ApplicationContext _context)
        {
            context = _context;
        }

        public Song CreateSong(Song song)
        {
            song.SongId = Guid.NewGuid();

            context.Songs.Add(song);
            context.SaveChanges();

            return song;
        }

        public Song DeleteSong(Guid songId)
        {
            var songToDelete = context.Songs.Find(songId);

            context.Songs.Remove(songToDelete);
            context.SaveChanges();

            return songToDelete;
        }

        public Song GetSongById(Guid songId)
        {
            return context.Songs.Find(songId);
        }

        public List<Song> GetSongs()
        {
            return context.Songs.ToList();
        }

        public Song UpdateSong(Guid songId, Song song)
        {
            song.SongId = songId;

            context.Songs.Update(song);
            context.SaveChanges();

            return song;
        }
    }
}
