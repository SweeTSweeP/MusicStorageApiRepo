using Microsoft.AspNetCore.Mvc;
using Moq;
using MusicStorageApi.Controllers.Controllers;
using MusicStorageApi.Models.Entities;
using MusicStorageApi.Repositories.Interfaces;
using MusicStorageApi.UnitTests.TestData;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStorageApi.UnitTests.AuthorTests
{
    class AlbumUnitTests
    {
        private AlbumTestData AlbumTestData;
        private Mock<IAlbumRepository> AlbumRepositoryMock;

        [SetUp]
        public void SetUp()
        {
            AlbumTestData = new AlbumTestData();
            AlbumRepositoryMock = new Mock<IAlbumRepository>();
        }

        [Test]
        public async Task GetAllAlbums()
        {
            var albumsNumber = 5;

            var albums = AlbumTestData.CreateMultipleAlubums(albumsNumber);

            AlbumRepositoryMock
                .Setup(m => m.GetAlbums())
                .Returns(Task.FromResult(albums));

            AlbumController controller = new AlbumController(AlbumRepositoryMock.Object);

            var response = await controller.GetAlbumsAsync();

            var result = (response as OkObjectResult).Value as List<Album>;

            var actual = result.Select(s => s.Title).ToList();
            var expected = albums.Select(s => s.Title).ToList();

            Assert.IsNotNull(result);
            Assert.AreEqual(albumsNumber, result.Count());
            Assert.AreEqual(result, albums);
            Assert.AreEqual(actual, expected);
        }

        [Test]
        public async Task GetAlbumById()
        {
            var album = AlbumTestData.CreateAlbum(Guid.Empty, "Test Album");

            AlbumRepositoryMock
                .Setup(m => m.GetAlbumById(album.AlbumId))
                .Returns(Task.FromResult(album));

            AlbumController controller = new AlbumController(AlbumRepositoryMock.Object);

            var response = await controller.GetAlbumByIdAsync(album.AlbumId);

            var result = (response as OkObjectResult).Value as Album;

            Assert.IsNotNull(result);
            Assert.AreEqual(album.Title, result.Title);
        }

        [Test]
        public async Task GetNonExistAlbumById()
        {
            var album = AlbumTestData.CreateAlbum(Guid.Empty, "Test Album");

            AlbumRepositoryMock
                .Setup(m => m.GetAlbumById(album.AlbumId))
                .Returns(Task.FromResult(album));

            AlbumController controller = new AlbumController(AlbumRepositoryMock.Object);

            var response = await controller.GetAlbumByIdAsync(Guid.NewGuid());

            var result = new NotFoundResult();
            var expected = new NotFoundResult();

            Assert.IsNotNull(result);
            Assert.AreEqual(expected.StatusCode, result.StatusCode);
        }

        [TearDown]
        public void TearDown()
        {
            AlbumTestData = null;
            AlbumRepositoryMock = null;
        }
    }
}
