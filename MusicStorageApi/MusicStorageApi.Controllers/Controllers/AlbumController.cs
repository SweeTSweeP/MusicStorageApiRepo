using Microsoft.AspNetCore.Mvc;
using MusicStorageApi.Models.Entities;
using MusicStorageApi.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MusicStorageApi.Controllers.Controllers
{
    [ApiController]
    [Route("api/albums")]
    public class AlbumController : ControllerBase
    {
        private readonly IAlbumRepository repository;

        public AlbumController(IAlbumRepository repository)
        {
            this.repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAlbumsAsync()
        {
            var albums = await repository.GetAlbums();

            return Ok(albums);
        }

        [HttpGet("{albumId}")]
        public async Task<IActionResult> GetAlbumByIdAsync(Guid albumId)
        {
            var album = await repository.GetAlbumById(albumId);

            if (album == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(album);
            }
        }

        [HttpGet("/authors/{authorId}")]
        public async Task<IActionResult> GetAlbumsByAuthorIdAsync(Guid authorId)
        {
            var albums = await repository.GetAlbumsByAuthorId(authorId);

            if (albums == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(albums);
            }
        }

        [HttpPost("/authors/{authorId}")]
        public async Task<IActionResult> CreateAlbumAsync(Guid authorId, Album album)
        {
            var createdAlbum = await repository.CreateAlbum(authorId, album);

            if (createdAlbum == null)
            {
                return NotFound();
            }
            else
            {
                return CreatedAtAction("Create", new { id = createdAlbum.AlbumId }, createdAlbum);
            }
        }

        [HttpPut("{albumId}")]
        public async Task<IActionResult> UpdateAlbumAsync(Guid albumId, Album album)
        {
            var searchAlbum = await repository.GetAlbumById(albumId);

            if (searchAlbum == null)
            {
                return NotFound();
            }
            else
            {
                var updatedAlbum = await repository.UpdateAlbum(albumId, album);

                return Ok(updatedAlbum);
            }
        }

        [HttpDelete("{albumId}")]
        public async Task<IActionResult> DeleteAlbumAsync(Guid albumId)
        {
            var searchAlbum = await repository.GetAlbumById(albumId);

            if (searchAlbum == null)
            {
                return NotFound();
            }
            else
            {
                var deletedAlbum = await repository.DeleteAlbum(albumId);

                return Ok(deletedAlbum);
            }
        }
    }
}
