using Microsoft.AspNetCore.Mvc;
using MusicStorageApi.Models.Entities;
using MusicStorageApi.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MusicStorageApi.Controllers.Controllers
{
    [ApiController]
    [Route("api/songs")]
    public class SongController : ControllerBase
    {
        private readonly ISongRepository repository;

        public SongController(ISongRepository repository)
        {
            this.repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> GetSongsAsync()
        {
            var songs = await repository.GetSongs();

            return Ok(songs);
        }

        [HttpGet("{songId}")]
        public async Task<IActionResult> GetSongByIdAsync(Guid songId)
        {
            var song = await repository.GetSongById(songId);

            if (song == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(song);
            }
        }

        [HttpGet("albums/{albumId}")]
        public async Task<IActionResult> GetSongsByAlbumIdAsync(Guid albumId)
        {
            var songs = await repository.GetSongsByAlbumId(albumId);

            if (songs == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(songs);
            }
        }

        [HttpGet("authors/{authorId}")]
        public async Task<IActionResult> GetSongsByAuthorIdAsync(Guid authorId)
        {
            var songs = await repository.GetSongsByAuthorId(authorId);

            if (songs == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(songs);
            }
        }

        [HttpPost("albums/{albumId}/authors/{authorId}")]
        public async Task<IActionResult> CreateSongAsync(Guid albumId, Guid authorId, Song song)
        {
            var createrdSong = await repository.CreateSong(albumId, authorId, song);

            if (createrdSong == null)
            {
                return NotFound();
            }
            else
            {
                return Created("Create", createrdSong);
            }
        }

        [HttpPut("{songId}")]
        public async Task<IActionResult> UpdateSongAsync(Guid songId, Song song)
        {
            var searchSong = await repository.GetSongById(songId);

            if (searchSong == null)
            {
                return NotFound();
            }
            else
            {
                var updatedSong = await repository.UpdateSong(songId, song);

                return Ok(updatedSong);
            }
        }

        [HttpDelete("{songId}")]
        public async Task<IActionResult> DeleteSongAsync(Guid songId)
        {
            var searchSong = await repository.GetSongById(songId);

            if (searchSong == null)
            {
                return NotFound();
            }
            else
            {
                var updatedSong = await repository.DeleteSong(songId);

                return Ok(updatedSong);
            }
        }
    }
}
