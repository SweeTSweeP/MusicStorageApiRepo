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
    public class AlbumRepository : IAlbumRepository
    {
        private readonly ApplicationContext context;

        public AlbumRepository(ApplicationContext _context)
        {
            context = _context;
        }

        public Task<Album> CreateAlbum(Guid authorId, Album album)
        {
            var author = context.Authors.Find(authorId);

            if (author == null)
            {
                return null;
            }

            album.AlbumId = Guid.NewGuid();
            album.AuthorId = authorId;

            context.Albums.AddAsync(album);
            context.SaveChanges();

            return Task.FromResult(album);
        }

        public Task<Album> DeleteAlbum(Guid albumId)
        {
            var albumToDelete = context.Albums.Find(albumId);
            context.Remove(albumToDelete);
            context.SaveChanges();

            return Task.FromResult(albumToDelete);
        }

        public Task<Album> GetAlbumById(Guid albumId)
        {
            return context.Albums.FirstOrDefaultAsync(s => s.AlbumId == albumId);
        }

        public Task<List<Album>> GetAlbums()
        {
            return context.Albums.ToListAsync();
        }

        public Task<List<Album>> GetAlbumsByAuthorId(Guid authorId)
        {
            return context.Albums.Where(s => s.AuthorId == authorId).ToListAsync();
        }

        public Task<Album> UpdateAlbum(Guid albumId, Album album)
        {
            var albumToUpdate = context.Albums.FirstOrDefault(s => s.AlbumId == albumId);

            albumToUpdate.AlbumId = albumId;
            albumToUpdate.Genre = album.Genre;
            albumToUpdate.RecordLabel = album.RecordLabel;
            albumToUpdate.ReleaseYear = album.ReleaseYear;
            albumToUpdate.Title = album.Title;

            context.SaveChanges();

            return Task.FromResult(albumToUpdate);
        }
    }
}
