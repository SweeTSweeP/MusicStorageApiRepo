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
    class SongUnitTests
    {
        private SongTestData SongTestData;
        private Mock<ISongRepository> SongRepositoryMock;

        [SetUp]
        public void SetUp()
        {
            SongTestData = new SongTestData();
            SongRepositoryMock = new Mock<ISongRepository>();
        }

        [Test]
        public async Task GetAllSongs()
        {
            var songsNumber = 5;

            var songs = SongTestData.CreateMultipleSongs(songsNumber);

            SongRepositoryMock
                .Setup(m => m.GetSongs())
                .Returns(Task.FromResult(songs));

            SongController controller = new SongController(SongRepositoryMock.Object);

            var response = await controller.GetSongsAsync();

            var result = (response as OkObjectResult).Value as List<Song>;

            var actual = result.Select(s => s.Title).ToList();
            var expected = songs.Select(s => s.Title).ToList();

            Assert.IsNotNull(result);
            Assert.AreEqual(songsNumber, result.Count());
            Assert.AreEqual(result, songs);
            Assert.AreEqual(actual, expected);
        }

        [Test]
        public async Task GetSongById()
        {
            var song = SongTestData.CreateSong("Test Album");

            SongRepositoryMock
                .Setup(m => m.GetSongById(song.SongId))
                .Returns(Task.FromResult(song));

            SongController controller = new SongController(SongRepositoryMock.Object);

            var response = await controller.GetSongByIdAsync(song.SongId);

            var result = (response as OkObjectResult).Value as Song;

            Assert.IsNotNull(result);
            Assert.AreEqual(song.Title, result.Title);
        }

        [Test]
        public async Task GetNonExistSongById()
        {
            var song = SongTestData.CreateSong("Test Album");

            SongRepositoryMock
                .Setup(m => m.GetSongById(song.SongId))
                .Returns(Task.FromResult(song));

            SongController controller = new SongController(SongRepositoryMock.Object);

            var response = await controller.GetSongByIdAsync(Guid.NewGuid());

            var result = new NotFoundResult();
            var expected = new NotFoundResult();

            Assert.IsNotNull(result);
            Assert.AreEqual(expected.StatusCode, result.StatusCode);
        }

        [TearDown]
        public void TearDown()
        {
            SongTestData = null;
            SongRepositoryMock = null;
        }
    }
}
