using Microsoft.EntityFrameworkCore;
using MusicStorageApi.Models.Entities;
using System;

namespace MusicStorageApi.Data.Context
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Song> Songs { get; set; }
        public DbSet<Album> Albums { get; set; }
        public DbSet<Author> Authors { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var tool = new Author
            {
                AuthorId = Guid.NewGuid(),
                AuthorName = "Tool"
            };

            var mastodon = new Author
            {
                AuthorId = Guid.NewGuid(),
                AuthorName = "Mastodon"
            };

            var staticX = new Author
            {
                AuthorId = Guid.NewGuid(),
                AuthorName = "Static-X"
            };

            modelBuilder.Entity<Author>().HasData(tool, mastodon, staticX);

            var toolUndertow = new Album
            {
                AlbumId = Guid.NewGuid(),
                Title = "Undertow",
                Genre = "Progressive Metal",
                RecordLabel = "Zoo Entertainment",
                ReleaseYear = "1993",
                AuthorId = tool.AuthorId
            };

            var toolAenima = new Album
            {
                AlbumId = Guid.NewGuid(),
                Title = "AEnima",
                Genre = "Progressive Metal",
                RecordLabel = "Zoo Entertainment",
                ReleaseYear = "1996",
                AuthorId = tool.AuthorId
            };

            var toolLateralus = new Album
            {
                AlbumId = Guid.NewGuid(),
                Title = "Lateralus",
                Genre = "Progressive Metal",
                RecordLabel = "Volcano Entertainment",
                ReleaseYear = "2001",
                AuthorId = tool.AuthorId
            };

            var toolTenThousandDays = new Album
            {
                AlbumId = Guid.NewGuid(),
                Title = "10,000 Days",
                Genre = "Progressive Metal",
                RecordLabel = "Tool Dissectional/Volcano Entertainment",
                ReleaseYear = "2006",
                AuthorId = tool.AuthorId
            };

            var toolFearInoculum = new Album
            {
                AlbumId = Guid.NewGuid(),
                Title = "Fear Inoculum",
                Genre = "Progressive Metal",
                RecordLabel = "Tool Dissectional/Volcano Entertainment",
                ReleaseYear = "2019",
                AuthorId = tool.AuthorId
            };

            var mastodonRemission = new Album
            {
                AlbumId = Guid.NewGuid(),
                Title = "Remission",
                Genre = "Progressive/Trash Metal",
                RecordLabel = "Relapse",
                ReleaseYear = "2002",
                AuthorId = mastodon.AuthorId
            };

            var mastodonLeviathan = new Album
            {
                AlbumId = Guid.NewGuid(),
                Title = "Leviathan",
                Genre = "Progressive/Heavy Metal",
                RecordLabel = "Relapse",
                ReleaseYear = "2004",
                AuthorId = mastodon.AuthorId
            };

            var mastodonBloodMountain = new Album
            {
                AlbumId = Guid.NewGuid(),
                Title = "Blood Mountain",
                Genre = "Progressive Metal",
                RecordLabel = "Warner Bros./Reprise",
                ReleaseYear = "2006",
                AuthorId = mastodon.AuthorId
            };

            var mastodonCrackTheSkye = new Album
            {
                AlbumId = Guid.NewGuid(),
                Title = "Crack The Skye",
                Genre = "Alternative/Heavy Metal",
                RecordLabel = "Reprise",
                ReleaseYear = "2009",
                AuthorId = mastodon.AuthorId
            };

            var mastodonTheHunter = new Album
            {
                AlbumId = Guid.NewGuid(),
                Title = "The Hunter",
                Genre = "Heavy/Avant-Gard Metal",
                RecordLabel = "Reprise/Roadrunner",
                ReleaseYear = "2011",
                AuthorId = mastodon.AuthorId
            };

            var mastodonOnceMoreRoundTheSun = new Album
            {
                AlbumId = Guid.NewGuid(),
                Title = "Once More 'Round the Sun",
                Genre = "Progressive/Heavy Metal",
                RecordLabel = "Reprise",
                ReleaseYear = "2014",
                AuthorId = mastodon.AuthorId
            };

            var mastodonEmperorOfSand = new Album
            {
                AlbumId = Guid.NewGuid(),
                Title = "Emperor of Sand",
                Genre = "Progressive Metal",
                RecordLabel = "Reprise",
                ReleaseYear = "2017",
                AuthorId = mastodon.AuthorId
            };

            var staticxWisconsinDeathTrip = new Album
            {
                AlbumId = Guid.NewGuid(),
                Title = "Wisconsin Death Trip",
                Genre = "Indastrial/Nu Metal",
                RecordLabel = "Warner Bros Records",
                ReleaseYear = "1999",
                AuthorId = staticX.AuthorId
            };

            var staticxMachine = new Album
            {
                AlbumId = Guid.NewGuid(),
                Title = "Machine",
                Genre = "Indastrial/Nu Metal",
                RecordLabel = "Warner Bros Records",
                ReleaseYear = "2001",
                AuthorId = staticX.AuthorId
            };

            var staticxShadowZone = new Album
            {
                AlbumId = Guid.NewGuid(),
                Title = "Shadow Zone",
                Genre = "Indastrial/Nu Metal",
                RecordLabel = "Warner Bros Records",
                ReleaseYear = "2003",
                AuthorId = staticX.AuthorId
            };

            var staticxStartAWar = new Album
            {
                AlbumId = Guid.NewGuid(),
                Title = "Start a War",
                Genre = "Indastrial/Nu Metal",
                RecordLabel = "Warner Bros Records",
                ReleaseYear = "2005",
                AuthorId = staticX.AuthorId
            };

            var staticxCannibal = new Album
            {
                AlbumId = Guid.NewGuid(),
                Title = "Cannibal",
                Genre = "Indastrial/Nu Metal",
                RecordLabel = "Reprise Records",
                ReleaseYear = "2007",
                AuthorId = staticX.AuthorId
            };

            var staticxCultOfStatic = new Album
            {
                AlbumId = Guid.NewGuid(),
                Title = "Cult of Static",
                Genre = "Indastrial/Nu Metal",
                RecordLabel = "Reprise Records",
                ReleaseYear = "2009",
                AuthorId = staticX.AuthorId
            };

            modelBuilder.Entity<Album>().HasData(
                toolUndertow,
                toolAenima,
                toolLateralus,
                toolTenThousandDays,
                toolFearInoculum,
                mastodonRemission,
                mastodonLeviathan,
                mastodonBloodMountain,
                mastodonCrackTheSkye,
                mastodonTheHunter,
                mastodonOnceMoreRoundTheSun,
                mastodonEmperorOfSand,
                staticxWisconsinDeathTrip,
                staticxMachine,
                staticxShadowZone,
                staticxStartAWar,
                staticxCannibal,
                staticxCultOfStatic
                );

            modelBuilder.Entity<Song>().HasData(
                new Song 
                { 
                    SongId = Guid.NewGuid(),
                    title = "Intolerance",
                    RecordLabel = toolUndertow.RecordLabel,
                    ReleaseYear = toolUndertow.ReleaseYear,
                    AuthorId = tool.AuthorId,
                    AlbumId = toolUndertow.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Prison Sex",
                    RecordLabel = toolUndertow.RecordLabel,
                    ReleaseYear = toolUndertow.ReleaseYear,
                    AuthorId = tool.AuthorId,
                    AlbumId = toolUndertow.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Sober",
                    RecordLabel = toolUndertow.RecordLabel,
                    ReleaseYear = toolUndertow.ReleaseYear,
                    AuthorId = tool.AuthorId,
                    AlbumId = toolUndertow.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Bottom",
                    RecordLabel = toolUndertow.RecordLabel,
                    ReleaseYear = toolUndertow.ReleaseYear,
                    AuthorId = tool.AuthorId,
                    AlbumId = toolUndertow.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Crawl Away",
                    RecordLabel = toolUndertow.RecordLabel,
                    ReleaseYear = toolUndertow.ReleaseYear,
                    AuthorId = tool.AuthorId,
                    AlbumId = toolUndertow.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Swamp Song",
                    RecordLabel = toolUndertow.RecordLabel,
                    ReleaseYear = toolUndertow.ReleaseYear,
                    AuthorId = tool.AuthorId,
                    AlbumId = toolUndertow.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Undertow",
                    RecordLabel = toolUndertow.RecordLabel,
                    ReleaseYear = toolUndertow.ReleaseYear,
                    AuthorId = tool.AuthorId,
                    AlbumId = toolUndertow.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "4degree",
                    RecordLabel = toolUndertow.RecordLabel,
                    ReleaseYear = toolUndertow.ReleaseYear,
                    AuthorId = tool.AuthorId,
                    AlbumId = toolUndertow.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Flood",
                    RecordLabel = toolUndertow.RecordLabel,
                    ReleaseYear = toolUndertow.ReleaseYear,
                    AuthorId = tool.AuthorId,
                    AlbumId = toolUndertow.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Disgustipated",
                    RecordLabel = toolUndertow.RecordLabel,
                    ReleaseYear = toolUndertow.ReleaseYear,
                    AuthorId = tool.AuthorId,
                    AlbumId = toolUndertow.AlbumId
                }
                );
        }
    }
}
