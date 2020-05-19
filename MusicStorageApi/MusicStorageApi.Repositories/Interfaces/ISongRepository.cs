using MusicStorageApi.Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MusicStorageApi.Repositories.Interfaces
{
    public interface ISongRepository
    {
        public List<Song> GetSongs();
        public Song GetSongById(Guid songId);
        public Song CreateSong(Song song);
        public Song UpdateSong(Guid songId, Song song);
        public Song DeleteSong(Guid songId);
    }
}
