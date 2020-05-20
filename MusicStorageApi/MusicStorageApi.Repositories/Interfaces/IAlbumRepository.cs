using MusicStorageApi.Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MusicStorageApi.Repositories.Interfaces
{
    public interface IAlbumRepository
    {
        public Task<List<Album>> GetAlbums();
        public Task<List<Album>> GetAlbumByAuthorId(Guid authorId);
        public Task<Album> GetAlbumById(Guid albumId);
        public Task<Album> CreateAlbum(Guid authorId, Album album);
        public Task<Album> UpdateAlbum(Guid albumId, Album album);
        public Task<Album> DeleteAlbum(Guid albumId);
    }
}
