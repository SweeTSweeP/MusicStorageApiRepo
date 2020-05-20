using MusicStorageApi.Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MusicStorageApi.Repositories.Interfaces
{
    public interface ISongRepository
    {
        public Task<List<Song>> GetSongs();
        public Task<Song> GetSongById(Guid songId);
        public Task<List<Song>> GetSongsByAlbumId(Guid albumId);
        public Task<List<Song>> GetSongsByAuthorId(Guid authorId);
        public Task<Song> CreateSong(Guid authorId, Guid albumId, Song song);
        public Task<Song> UpdateSong(Guid songId, Song song);
        public Task<Song> DeleteSong(Guid songId);
    }
}
