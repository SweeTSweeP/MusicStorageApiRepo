﻿using Microsoft.EntityFrameworkCore;
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
    public class SongRepository : ISongRepository
    {
        private readonly ApplicationContext context;

        public SongRepository(ApplicationContext _context)
        {
            context = _context;
        }

        public Task<Song> CreateSong(Guid albumId, Guid authorId, Song song)
        {
            var author = context.Authors.Find(authorId);

            if (author == null)
            {
                return null;
            }

            var album = context.Albums.Find(albumId);

            if (album == null || album.AuthorId != authorId)
            {
                return null;
            }

            song.SongId = Guid.NewGuid();
            song.AlbumId = albumId;
            song.AuthorId = authorId;

            context.Songs.Add(song);
            context.SaveChanges();

            return Task.FromResult(song);
        }

        public Task<Song> DeleteSong(Guid songId)
        {
            var songToDelete = context.Songs.Find(songId);

            context.Songs.Remove(songToDelete);
            context.SaveChanges();

            return Task.FromResult(songToDelete);
        }

        public Task<List<Song>> GetSongsByAlbumId(Guid albumId)
        {
            return context.Songs.Where(s => s.AlbumId == albumId).ToListAsync();
        }

        public Task<List<Song>> GetSongsByAuthorId(Guid authorId)
        {
            return context.Songs.Where(s => s.AuthorId == authorId).ToListAsync();
        }

        public Task<Song> GetSongById(Guid songId)
        {
            return context.Songs.FirstOrDefaultAsync(s => s.SongId == songId);
        }

        public Task<List<Song>> GetSongs()
        {
            return context.Songs.ToListAsync();
        }

        public Task<Song> UpdateSong(Guid songId, Song song)
        {
            var songToUpdate = context.Songs.FirstOrDefault(s => s.SongId == songId);

            songToUpdate.SongId = songId;
            songToUpdate.RecordLabel = song.RecordLabel;
            songToUpdate.ReleaseYear = song.ReleaseYear;
            songToUpdate.Title = song.Title;
            
            context.SaveChanges();

            return Task.FromResult(songToUpdate);
        }
    }
}
