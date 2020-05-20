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
            album.AlbumId = Guid.NewGuid();
            album.AuthorId = authorId;

            context.Albums.AddAsync(album);
            context.SaveChanges();

            return Task.FromResult(album);
        }

        public Task<Album> DeleteAlbum(Guid albumId)
        {
            var albumToDelete = context.Albums.Find(albumId);
            context.Albums.Remove(albumToDelete);

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

        public Task<Album> UpdateAlbum(Guid albumId, Album album)
        {
            album.AlbumId = albumId;
            context.Albums.Update(album);
            context.SaveChanges();

            return Task.FromResult(album);
        }
    }
}
