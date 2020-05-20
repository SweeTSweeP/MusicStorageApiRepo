using MusicStorageApi.Data.Context;
using MusicStorageApi.Models.Entities;
using MusicStorageApi.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MusicStorageApi.Repositories.Repositories
{
    public class AlbumRepository : IAlbumRepository
    {
        private readonly ApplicationContext context;

        public AlbumRepository(ApplicationContext _context)
        {
            context = _context;
        }

        public Album CreateAlbum(Album album)
        {
            album.AlbumId = Guid.NewGuid();

            context.Albums.Add(album);
            context.SaveChanges();

            return album;
        }

        public Album DeleteAlbum(Guid albumId)
        {
            var albumToDelete = context.Albums.Find(albumId);
            context.Albums.Remove(albumToDelete);

            return albumToDelete;
        }

        public Album GetAlbumById(Guid albumId)
        {
            return context.Albums.Find(albumId);
        }

        public List<Album> GetAlbums()
        {
            return context.Albums.ToList();
        }

        public Album UpdateAlbum(Guid albumId, Album album)
        {
            album.AlbumId = albumId;
            context.Albums.Update(album);
            context.SaveChanges();

            return album;
        }
    }
}
