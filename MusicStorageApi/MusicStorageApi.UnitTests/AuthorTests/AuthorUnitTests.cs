using NUnit.Framework;
using Moq;
using MusicStorageApi.Repositories.Interfaces;
using MusicStorageApi.Models.Entities;
using System.Collections.Generic;
using MusicStorageApi.UnitTests.TestData;
using System.Threading.Tasks;
using MusicStorageApi.Controllers.Controllers;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System;

namespace MusicStorageApi.UnitTests.AuthorTests
{
    class AuthorUnitTests
    {
        private AuthorTestData AuthorTestData;
        private Mock<IAuthorRepository> AuthorRepositoryMock;

        [SetUp]
        public void SetUp()
        {
            AuthorTestData = new AuthorTestData();
            AuthorRepositoryMock = new Mock<IAuthorRepository>();
        }

        [Test]
        public async Task GetAllAuthors()
        {
            var authorsNumber = 5;

            var authors = AuthorTestData.CreateMultipleAuthors(5);

            AuthorRepositoryMock
                .Setup(m => m.GetAuthors())
                .Returns(Task.FromResult(authors));

            AuthorController controller = new AuthorController(AuthorRepositoryMock.Object);

            var response = await controller.GetAuthorsAsync();

            var result = (response as OkObjectResult).Value as List<Author>;

            var expected = authors.Select(s => s.AuthorName).ToList();
            var actual = result.Select(s => s.AuthorName).ToList();

            Assert.IsNotNull(result);
            Assert.AreEqual(authorsNumber, result.Count);
            Assert.AreEqual(authors, result);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public async Task GetAuthorById()
        {
            var author = AuthorTestData.CreateAthor("Test Author");

            AuthorRepositoryMock
                .Setup(m => m.GetAuthorById(author.AuthorId))
                .Returns(Task.FromResult(author));

            AuthorController controller = new AuthorController(AuthorRepositoryMock.Object);

            var response = await controller.GetAuthorByIdAsync(author.AuthorId);

            var actual = (response as OkObjectResult).Value as Author;

            Assert.IsNotNull(actual);
            Assert.AreEqual(author.AuthorName, actual.AuthorName);
        }

        [Test]
        public async Task GetNonExistAuthorById()
        {
            var author = AuthorTestData.CreateAthor("Test Author");

            AuthorRepositoryMock
                .Setup(m => m.GetAuthorById(author.AuthorId))
                .Returns(Task.FromResult(author));

            AuthorController controller = new AuthorController(AuthorRepositoryMock.Object);

            var response = await controller.GetAuthorByIdAsync(Guid.NewGuid());

            var expected = new NotFoundResult();
            var actual = response as NotFoundResult;

            Assert.IsNotNull(actual);
            Assert.AreEqual(expected.StatusCode, actual.StatusCode);
        }

        [Test]
        public async Task CreateAuthor()
        {
            var author = AuthorTestData.CreateAthor("Test Author");

            AuthorRepositoryMock
                .Setup(m => m.CreateAuthor(author))
                .Returns(Task.FromResult(author));

            AuthorController controller = new AuthorController(AuthorRepositoryMock.Object);

            var response = await controller.CreateAuthorAsync(author);

            var result = (response as CreatedAtActionResult).Value as Author;

            Assert.IsNotNull(result);
            Assert.AreEqual(author.AuthorName, result.AuthorName);
        }

        [Test]
        public async Task UpdateAuthor()
        {
            var author = AuthorTestData.CreateAthor("Test Author");

            AuthorRepositoryMock
                .Setup(m => m.CreateAuthor(author))
                .Returns(Task.FromResult(author));

            AuthorRepositoryMock
                .Setup(m => m.GetAuthorById(author.AuthorId))
                .Returns(Task.FromResult(author));

            var updatedAuthor = AuthorTestData.CreateAthor("Updated Test Author");

            AuthorRepositoryMock
                .Setup(m => m.UpdateAuthor(author.AuthorId, updatedAuthor))
                .Returns(Task.FromResult(updatedAuthor));

            AuthorController controller = new AuthorController(AuthorRepositoryMock.Object);

            await controller.CreateAuthorAsync(author);

            var response = await controller.UpdateAuthorAsync(author.AuthorId, updatedAuthor);

            var result = (response as OkObjectResult).Value as Author;

            Assert.IsNotNull(result);
            Assert.AreEqual(updatedAuthor.AuthorName, result.AuthorName);
        }

        [Test]
        public async Task UpdateNonExistAuthor()
        {
            var author = AuthorTestData.CreateAthor("Test Author");

            AuthorRepositoryMock
                .Setup(m => m.CreateAuthor(author))
                .Returns(Task.FromResult(author));

            AuthorRepositoryMock
                .Setup(m => m.GetAuthorById(author.AuthorId))
                .Returns(Task.FromResult(author));

            var updatedAuthor = AuthorTestData.CreateAthor("Updated Test Author");

            AuthorRepositoryMock
                .Setup(m => m.UpdateAuthor(author.AuthorId, updatedAuthor))
                .Returns(Task.FromResult(updatedAuthor));

            AuthorController controller = new AuthorController(AuthorRepositoryMock.Object);

            await controller.CreateAuthorAsync(author);

            var response = await controller.UpdateAuthorAsync(Guid.NewGuid(), updatedAuthor);

            var result = response as NotFoundResult;
            var expected = new NotFoundResult();

            Assert.IsNotNull(result);
            Assert.AreEqual(expected.StatusCode, result.StatusCode);
        }

        [Test]
        public async Task DeleteAuthor()
        {
            var author = AuthorTestData.CreateAthor("Test Author");

            AuthorRepositoryMock
               .Setup(m => m.CreateAuthor(author))
               .Returns(Task.FromResult(author));

            AuthorRepositoryMock
                .Setup(m => m.GetAuthorById(author.AuthorId))
                .Returns(Task.FromResult(author));

            AuthorRepositoryMock
               .Setup(m => m.DeleteAuthor(author.AuthorId))
               .Returns(Task.FromResult(author));

            AuthorController controller = new AuthorController(AuthorRepositoryMock.Object);

            var response = await controller.DeleteAuthorAsync(author.AuthorId);

            var result = (response as OkObjectResult).Value as Author;

            Assert.IsNotNull(result);
            Assert.AreEqual(author.AuthorName, result.AuthorName);
        }

        [Test]
        public async Task DeleteNonExistAuthor()
        {
            var author = AuthorTestData.CreateAthor("Test Author");

            AuthorRepositoryMock
               .Setup(m => m.CreateAuthor(author))
               .Returns(Task.FromResult(author));

            AuthorRepositoryMock
                .Setup(m => m.GetAuthorById(author.AuthorId))
                .Returns(Task.FromResult(author));

            AuthorRepositoryMock
               .Setup(m => m.DeleteAuthor(author.AuthorId))
               .Returns(Task.FromResult(author));

            AuthorController controller = new AuthorController(AuthorRepositoryMock.Object);

            var response = await controller.DeleteAuthorAsync(Guid.NewGuid());

            var result = response as NotFoundResult;
            var expected = new NotFoundResult();

            Assert.IsNotNull(result);
            Assert.AreEqual(expected.StatusCode, result.StatusCode);
        }

        [TearDown]
        public void TearDown()
        {
            AuthorTestData = null;
            AuthorRepositoryMock = null;
        }
    }
}
