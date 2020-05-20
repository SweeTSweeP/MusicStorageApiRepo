using MusicStorageApi.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Collections.Generic;
using MusicStorageApi.Models.Entities;
using System;

namespace MusicStorageApi.Controllers.Controllers
{
    [ApiController]
    [Route("api/authors")]
    public class AuthorController : ControllerBase
    {
        private readonly IAuthorRepository repository;

        public AuthorController(IAuthorRepository repository)
        {
            this.repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAuthorsAsync()
        {
            var authors = await repository.GetAuthors();

            return Ok(authors);
        }

        [HttpGet("{authorId}")]
        public async Task<IActionResult> GetAuthorByIdAsync(Guid authorId)
        {
            var author = await repository.GetAuthorById(authorId);

            if (author == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(author);
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateAuthorAsync(Author author)
        {
            var createdAuthor = await repository.CreateAuthor(author);

            return CreatedAtAction("Create", new { id = createdAuthor.AuthorId}, createdAuthor);
        }

        [HttpPut("{authorId}")]
        public async Task<IActionResult> UpdateAuthorAsync(Guid authorId, Author author)
        {
            var searchAuthor = await repository.GetAuthorById(authorId);

            if (searchAuthor != null)
            {
                var updatedAuthor = await repository.UpdateAuthor(authorId, author);

                return Ok(updatedAuthor);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpDelete("{authorId}")]
        public async Task<IActionResult> DeleteAuthorAsync(Guid authorId)
        {
            var searchAuthor = await repository.GetAuthorById(authorId);

            if (searchAuthor != null)
            {
                var deletedAuthor = await repository.DeleteAuthor(authorId);

                return Ok(deletedAuthor);
            }
            else
            {
                return NotFound();
            }
        }
    }
}
