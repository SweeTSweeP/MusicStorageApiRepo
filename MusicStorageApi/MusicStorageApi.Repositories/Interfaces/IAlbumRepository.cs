using MusicStorageApi.Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MusicStorageApi.Repositories.Interfaces
{
    public interface IAlbumRepository
    {
        public List<Album> GetAlbums();
        public Album GetAlbumById(Guid albumId);
        public Album CreateAlbum(Album album);
        public Album UpdateAlbum(Guid albumId, Album album);
        public Album DeleteAlbum(Guid albumId);
    }
}
