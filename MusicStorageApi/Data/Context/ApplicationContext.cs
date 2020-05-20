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
                    Title = "Intolerance",
                    RecordLabel = toolUndertow.RecordLabel,
                    ReleaseYear = toolUndertow.ReleaseYear,
                    AuthorId = tool.AuthorId,
                    AlbumId = toolUndertow.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Prison Sex",
                    RecordLabel = toolUndertow.RecordLabel,
                    ReleaseYear = toolUndertow.ReleaseYear,
                    AuthorId = tool.AuthorId,
                    AlbumId = toolUndertow.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Sober",
                    RecordLabel = toolUndertow.RecordLabel,
                    ReleaseYear = toolUndertow.ReleaseYear,
                    AuthorId = tool.AuthorId,
                    AlbumId = toolUndertow.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Bottom",
                    RecordLabel = toolUndertow.RecordLabel,
                    ReleaseYear = toolUndertow.ReleaseYear,
                    AuthorId = tool.AuthorId,
                    AlbumId = toolUndertow.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Crawl Away",
                    RecordLabel = toolUndertow.RecordLabel,
                    ReleaseYear = toolUndertow.ReleaseYear,
                    AuthorId = tool.AuthorId,
                    AlbumId = toolUndertow.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Swamp Song",
                    RecordLabel = toolUndertow.RecordLabel,
                    ReleaseYear = toolUndertow.ReleaseYear,
                    AuthorId = tool.AuthorId,
                    AlbumId = toolUndertow.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Undertow",
                    RecordLabel = toolUndertow.RecordLabel,
                    ReleaseYear = toolUndertow.ReleaseYear,
                    AuthorId = tool.AuthorId,
                    AlbumId = toolUndertow.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "4degree",
                    RecordLabel = toolUndertow.RecordLabel,
                    ReleaseYear = toolUndertow.ReleaseYear,
                    AuthorId = tool.AuthorId,
                    AlbumId = toolUndertow.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Flood",
                    RecordLabel = toolUndertow.RecordLabel,
                    ReleaseYear = toolUndertow.ReleaseYear,
                    AuthorId = tool.AuthorId,
                    AlbumId = toolUndertow.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Disgustipated",
                    RecordLabel = toolUndertow.RecordLabel,
                    ReleaseYear = toolUndertow.ReleaseYear,
                    AuthorId = tool.AuthorId,
                    AlbumId = toolUndertow.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Stinkfist",
                    RecordLabel = toolAenima.RecordLabel,
                    ReleaseYear = toolAenima.ReleaseYear,
                    AuthorId = tool.AuthorId,
                    AlbumId = toolAenima.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Eulogy",
                    RecordLabel = toolAenima.RecordLabel,
                    ReleaseYear = toolAenima.ReleaseYear,
                    AuthorId = tool.AuthorId,
                    AlbumId = toolAenima.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "H.",
                    RecordLabel = toolAenima.RecordLabel,
                    ReleaseYear = toolAenima.ReleaseYear,
                    AuthorId = tool.AuthorId,
                    AlbumId = toolAenima.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Useful Idiot",
                    RecordLabel = toolAenima.RecordLabel,
                    ReleaseYear = toolAenima.ReleaseYear,
                    AuthorId = tool.AuthorId,
                    AlbumId = toolAenima.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Forty Six & 2",
                    RecordLabel = toolAenima.RecordLabel,
                    ReleaseYear = toolAenima.ReleaseYear,
                    AuthorId = tool.AuthorId,
                    AlbumId = toolAenima.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Message to Harry Manback",
                    RecordLabel = toolAenima.RecordLabel,
                    ReleaseYear = toolAenima.ReleaseYear,
                    AuthorId = tool.AuthorId,
                    AlbumId = toolAenima.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Hooker with a Denis",
                    RecordLabel = toolAenima.RecordLabel,
                    ReleaseYear = toolAenima.ReleaseYear,
                    AuthorId = tool.AuthorId,
                    AlbumId = toolAenima.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Intermission",
                    RecordLabel = toolAenima.RecordLabel,
                    ReleaseYear = toolAenima.ReleaseYear,
                    AuthorId = tool.AuthorId,
                    AlbumId = toolAenima.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "jimmy",
                    RecordLabel = toolAenima.RecordLabel,
                    ReleaseYear = toolAenima.ReleaseYear,
                    AuthorId = tool.AuthorId,
                    AlbumId = toolAenima.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Die Eier von Satan",
                    RecordLabel = toolAenima.RecordLabel,
                    ReleaseYear = toolAenima.ReleaseYear,
                    AuthorId = tool.AuthorId,
                    AlbumId = toolAenima.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Pushit",
                    RecordLabel = toolAenima.RecordLabel,
                    ReleaseYear = toolAenima.ReleaseYear,
                    AuthorId = tool.AuthorId,
                    AlbumId = toolAenima.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Cesaro Summability",
                    RecordLabel = toolAenima.RecordLabel,
                    ReleaseYear = toolAenima.ReleaseYear,
                    AuthorId = tool.AuthorId,
                    AlbumId = toolAenima.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "AEnema",
                    RecordLabel = toolAenima.RecordLabel,
                    ReleaseYear = toolAenima.ReleaseYear,
                    AuthorId = tool.AuthorId,
                    AlbumId = toolAenima.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "(-) Ions",
                    RecordLabel = toolAenima.RecordLabel,
                    ReleaseYear = toolAenima.ReleaseYear,
                    AuthorId = tool.AuthorId,
                    AlbumId = toolAenima.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Third Eye",
                    RecordLabel = toolAenima.RecordLabel,
                    ReleaseYear = toolAenima.ReleaseYear,
                    AuthorId = tool.AuthorId,
                    AlbumId = toolAenima.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Eulogy",
                    RecordLabel = toolAenima.RecordLabel,
                    ReleaseYear = toolAenima.ReleaseYear,
                    AuthorId = tool.AuthorId,
                    AlbumId = toolAenima.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "The Grudge",
                    RecordLabel = toolLateralus.RecordLabel,
                    ReleaseYear = toolLateralus.ReleaseYear,
                    AuthorId = tool.AuthorId,
                    AlbumId = toolLateralus.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Eon Blue Apocalypse",
                    RecordLabel = toolLateralus.RecordLabel,
                    ReleaseYear = toolLateralus.ReleaseYear,
                    AuthorId = tool.AuthorId,
                    AlbumId = toolLateralus.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "The Patient",
                    RecordLabel = toolLateralus.RecordLabel,
                    ReleaseYear = toolLateralus.ReleaseYear,
                    AuthorId = tool.AuthorId,
                    AlbumId = toolLateralus.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Mantra",
                    RecordLabel = toolLateralus.RecordLabel,
                    ReleaseYear = toolLateralus.ReleaseYear,
                    AuthorId = tool.AuthorId,
                    AlbumId = toolLateralus.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Schism",
                    RecordLabel = toolLateralus.RecordLabel,
                    ReleaseYear = toolLateralus.ReleaseYear,
                    AuthorId = tool.AuthorId,
                    AlbumId = toolLateralus.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Parabol",
                    RecordLabel = toolLateralus.RecordLabel,
                    ReleaseYear = toolLateralus.ReleaseYear,
                    AuthorId = tool.AuthorId,
                    AlbumId = toolLateralus.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Parabola",
                    RecordLabel = toolLateralus.RecordLabel,
                    ReleaseYear = toolLateralus.ReleaseYear,
                    AuthorId = tool.AuthorId,
                    AlbumId = toolLateralus.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Ticks & Leeches",
                    RecordLabel = toolLateralus.RecordLabel,
                    ReleaseYear = toolLateralus.ReleaseYear,
                    AuthorId = tool.AuthorId,
                    AlbumId = toolLateralus.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Lateralus",
                    RecordLabel = toolLateralus.RecordLabel,
                    ReleaseYear = toolLateralus.ReleaseYear,
                    AuthorId = tool.AuthorId,
                    AlbumId = toolLateralus.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Disposition",
                    RecordLabel = toolLateralus.RecordLabel,
                    ReleaseYear = toolLateralus.ReleaseYear,
                    AuthorId = tool.AuthorId,
                    AlbumId = toolLateralus.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Reflection",
                    RecordLabel = toolLateralus.RecordLabel,
                    ReleaseYear = toolLateralus.ReleaseYear,
                    AuthorId = tool.AuthorId,
                    AlbumId = toolLateralus.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Triad",
                    RecordLabel = toolLateralus.RecordLabel,
                    ReleaseYear = toolLateralus.ReleaseYear,
                    AuthorId = tool.AuthorId,
                    AlbumId = toolLateralus.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Faaip de Oiad",
                    RecordLabel = toolLateralus.RecordLabel,
                    ReleaseYear = toolLateralus.ReleaseYear,
                    AuthorId = tool.AuthorId,
                    AlbumId = toolLateralus.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Vicarious",
                    RecordLabel = toolTenThousandDays.RecordLabel,
                    ReleaseYear = toolTenThousandDays.ReleaseYear,
                    AuthorId = tool.AuthorId,
                    AlbumId = toolTenThousandDays.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Jambi",
                    RecordLabel = toolTenThousandDays.RecordLabel,
                    ReleaseYear = toolTenThousandDays.ReleaseYear,
                    AuthorId = tool.AuthorId,
                    AlbumId = toolTenThousandDays.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Wings for Marie",
                    RecordLabel = toolTenThousandDays.RecordLabel,
                    ReleaseYear = toolTenThousandDays.ReleaseYear,
                    AuthorId = tool.AuthorId,
                    AlbumId = toolTenThousandDays.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "10,000 Days",
                    RecordLabel = toolTenThousandDays.RecordLabel,
                    ReleaseYear = toolTenThousandDays.ReleaseYear,
                    AuthorId = tool.AuthorId,
                    AlbumId = toolTenThousandDays.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "The Pot",
                    RecordLabel = toolTenThousandDays.RecordLabel,
                    ReleaseYear = toolTenThousandDays.ReleaseYear,
                    AuthorId = tool.AuthorId,
                    AlbumId = toolTenThousandDays.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Lipan Conjuring",
                    RecordLabel = toolTenThousandDays.RecordLabel,
                    ReleaseYear = toolTenThousandDays.ReleaseYear,
                    AuthorId = tool.AuthorId,
                    AlbumId = toolTenThousandDays.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Lost Keys",
                    RecordLabel = toolTenThousandDays.RecordLabel,
                    ReleaseYear = toolTenThousandDays.ReleaseYear,
                    AuthorId = tool.AuthorId,
                    AlbumId = toolTenThousandDays.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Rosetta Stoned",
                    RecordLabel = toolTenThousandDays.RecordLabel,
                    ReleaseYear = toolTenThousandDays.ReleaseYear,
                    AuthorId = tool.AuthorId,
                    AlbumId = toolTenThousandDays.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Intension",
                    RecordLabel = toolTenThousandDays.RecordLabel,
                    ReleaseYear = toolTenThousandDays.ReleaseYear,
                    AuthorId = tool.AuthorId,
                    AlbumId = toolTenThousandDays.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Right in Two",
                    RecordLabel = toolTenThousandDays.RecordLabel,
                    ReleaseYear = toolTenThousandDays.ReleaseYear,
                    AuthorId = tool.AuthorId,
                    AlbumId = toolTenThousandDays.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Viginti Tres",
                    RecordLabel = toolTenThousandDays.RecordLabel,
                    ReleaseYear = toolTenThousandDays.ReleaseYear,
                    AuthorId = tool.AuthorId,
                    AlbumId = toolTenThousandDays.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Fear Inoculum",
                    RecordLabel = toolFearInoculum.RecordLabel,
                    ReleaseYear = toolFearInoculum.ReleaseYear,
                    AuthorId = tool.AuthorId,
                    AlbumId = toolFearInoculum.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Pneuma",
                    RecordLabel = toolFearInoculum.RecordLabel,
                    ReleaseYear = toolFearInoculum.ReleaseYear,
                    AuthorId = tool.AuthorId,
                    AlbumId = toolFearInoculum.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Litanie contre la peur",
                    RecordLabel = toolFearInoculum.RecordLabel,
                    ReleaseYear = toolFearInoculum.ReleaseYear,
                    AuthorId = tool.AuthorId,
                    AlbumId = toolFearInoculum.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Invincible",
                    RecordLabel = toolFearInoculum.RecordLabel,
                    ReleaseYear = toolFearInoculum.ReleaseYear,
                    AuthorId = tool.AuthorId,
                    AlbumId = toolFearInoculum.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Legion Inoculant",
                    RecordLabel = toolFearInoculum.RecordLabel,
                    ReleaseYear = toolFearInoculum.ReleaseYear,
                    AuthorId = tool.AuthorId,
                    AlbumId = toolFearInoculum.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Descending",
                    RecordLabel = toolFearInoculum.RecordLabel,
                    ReleaseYear = toolFearInoculum.ReleaseYear,
                    AuthorId = tool.AuthorId,
                    AlbumId = toolFearInoculum.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Culling Voices",
                    RecordLabel = toolFearInoculum.RecordLabel,
                    ReleaseYear = toolFearInoculum.ReleaseYear,
                    AuthorId = tool.AuthorId,
                    AlbumId = toolFearInoculum.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Chocolate Chip Trip",
                    RecordLabel = toolFearInoculum.RecordLabel,
                    ReleaseYear = toolFearInoculum.ReleaseYear,
                    AuthorId = tool.AuthorId,
                    AlbumId = toolFearInoculum.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "7empest",
                    RecordLabel = toolFearInoculum.RecordLabel,
                    ReleaseYear = toolFearInoculum.ReleaseYear,
                    AuthorId = tool.AuthorId,
                    AlbumId = toolFearInoculum.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Mockingbeat",
                    RecordLabel = toolFearInoculum.RecordLabel,
                    ReleaseYear = toolFearInoculum.ReleaseYear,
                    AuthorId = tool.AuthorId,
                    AlbumId = toolFearInoculum.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Crusher Destroyer",
                    RecordLabel = mastodonRemission.RecordLabel,
                    ReleaseYear = mastodonRemission.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonRemission.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "March of the Fire Ants",
                    RecordLabel = mastodonRemission.RecordLabel,
                    ReleaseYear = mastodonRemission.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonRemission.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Where Strides the Behemoth",
                    RecordLabel = mastodonRemission.RecordLabel,
                    ReleaseYear = mastodonRemission.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonRemission.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Workhorse",
                    RecordLabel = mastodonRemission.RecordLabel,
                    ReleaseYear = mastodonRemission.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonRemission.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Ol'e Nessie",
                    RecordLabel = mastodonRemission.RecordLabel,
                    ReleaseYear = mastodonRemission.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonRemission.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Burning Man",
                    RecordLabel = mastodonRemission.RecordLabel,
                    ReleaseYear = mastodonRemission.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonRemission.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Trainwreck",
                    RecordLabel = mastodonRemission.RecordLabel,
                    ReleaseYear = mastodonRemission.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonRemission.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Trempled Under Hoof",
                    RecordLabel = mastodonRemission.RecordLabel,
                    ReleaseYear = mastodonRemission.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonRemission.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Triobite",
                    RecordLabel = mastodonRemission.RecordLabel,
                    ReleaseYear = mastodonRemission.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonRemission.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Mother Puncher",
                    RecordLabel = mastodonRemission.RecordLabel,
                    ReleaseYear = mastodonRemission.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonRemission.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Elephant Man",
                    RecordLabel = mastodonRemission.RecordLabel,
                    ReleaseYear = mastodonRemission.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonRemission.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Blood and Thunder",
                    RecordLabel = mastodonLeviathan.RecordLabel,
                    ReleaseYear = mastodonLeviathan.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonLeviathan.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "I Am Ahab",
                    RecordLabel = mastodonLeviathan.RecordLabel,
                    ReleaseYear = mastodonLeviathan.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonLeviathan.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Seabeast",
                    RecordLabel = mastodonLeviathan.RecordLabel,
                    ReleaseYear = mastodonLeviathan.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonLeviathan.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Island",
                    RecordLabel = mastodonLeviathan.RecordLabel,
                    ReleaseYear = mastodonLeviathan.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonLeviathan.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Iron Tusk",
                    RecordLabel = mastodonLeviathan.RecordLabel,
                    ReleaseYear = mastodonLeviathan.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonLeviathan.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Megalodon",
                    RecordLabel = mastodonLeviathan.RecordLabel,
                    ReleaseYear = mastodonLeviathan.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonLeviathan.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Naked Burn",
                    RecordLabel = mastodonLeviathan.RecordLabel,
                    ReleaseYear = mastodonLeviathan.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonLeviathan.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Aqua Dementia",
                    RecordLabel = mastodonLeviathan.RecordLabel,
                    ReleaseYear = mastodonLeviathan.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonLeviathan.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Hearts Alive",
                    RecordLabel = mastodonLeviathan.RecordLabel,
                    ReleaseYear = mastodonLeviathan.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonLeviathan.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Joseph Merrick",
                    RecordLabel = mastodonLeviathan.RecordLabel,
                    ReleaseYear = mastodonLeviathan.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonLeviathan.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "The Wolf Is Loose",
                    RecordLabel = mastodonBloodMountain.RecordLabel,
                    ReleaseYear = mastodonBloodMountain.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonBloodMountain.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Crystal Skull",
                    RecordLabel = mastodonBloodMountain.RecordLabel,
                    ReleaseYear = mastodonBloodMountain.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonBloodMountain.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Sleeping Giant",
                    RecordLabel = mastodonBloodMountain.RecordLabel,
                    ReleaseYear = mastodonBloodMountain.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonBloodMountain.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Capillarian Crest",
                    RecordLabel = mastodonBloodMountain.RecordLabel,
                    ReleaseYear = mastodonBloodMountain.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonBloodMountain.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Circle of Cysquatch",
                    RecordLabel = mastodonBloodMountain.RecordLabel,
                    ReleaseYear = mastodonBloodMountain.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonBloodMountain.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Bladecatcher",
                    RecordLabel = mastodonBloodMountain.RecordLabel,
                    ReleaseYear = mastodonBloodMountain.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonBloodMountain.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Colony of Birchmen",
                    RecordLabel = mastodonBloodMountain.RecordLabel,
                    ReleaseYear = mastodonBloodMountain.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonBloodMountain.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Hunters of the Sky",
                    RecordLabel = mastodonBloodMountain.RecordLabel,
                    ReleaseYear = mastodonBloodMountain.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonBloodMountain.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Hand of Stone",
                    RecordLabel = mastodonBloodMountain.RecordLabel,
                    ReleaseYear = mastodonBloodMountain.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonBloodMountain.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "This Mortal Soil",
                    RecordLabel = mastodonBloodMountain.RecordLabel,
                    ReleaseYear = mastodonBloodMountain.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonBloodMountain.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Siberian Divide",
                    RecordLabel = mastodonBloodMountain.RecordLabel,
                    ReleaseYear = mastodonBloodMountain.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonBloodMountain.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Pendulous Skin",
                    RecordLabel = mastodonBloodMountain.RecordLabel,
                    ReleaseYear = mastodonBloodMountain.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonBloodMountain.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Oblivion",
                    RecordLabel = mastodonCrackTheSkye.RecordLabel,
                    ReleaseYear = mastodonCrackTheSkye.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonCrackTheSkye.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Divinations",
                    RecordLabel = mastodonCrackTheSkye.RecordLabel,
                    ReleaseYear = mastodonCrackTheSkye.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonCrackTheSkye.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Quintessence",
                    RecordLabel = mastodonCrackTheSkye.RecordLabel,
                    ReleaseYear = mastodonCrackTheSkye.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonCrackTheSkye.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "The Czar",
                    RecordLabel = mastodonCrackTheSkye.RecordLabel,
                    ReleaseYear = mastodonCrackTheSkye.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonCrackTheSkye.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Ghost of Karelia",
                    RecordLabel = mastodonCrackTheSkye.RecordLabel,
                    ReleaseYear = mastodonCrackTheSkye.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonCrackTheSkye.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Crack the Skye",
                    RecordLabel = mastodonCrackTheSkye.RecordLabel,
                    ReleaseYear = mastodonCrackTheSkye.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonCrackTheSkye.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "The Last Baron",
                    RecordLabel = mastodonCrackTheSkye.RecordLabel,
                    ReleaseYear = mastodonCrackTheSkye.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonCrackTheSkye.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Black Tongue",
                    RecordLabel = mastodonTheHunter.RecordLabel,
                    ReleaseYear = mastodonTheHunter.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonTheHunter.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Curl of the Buri",
                    RecordLabel = mastodonTheHunter.RecordLabel,
                    ReleaseYear = mastodonTheHunter.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonTheHunter.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Blasteroid",
                    RecordLabel = mastodonTheHunter.RecordLabel,
                    ReleaseYear = mastodonTheHunter.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonTheHunter.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Stargasm",
                    RecordLabel = mastodonTheHunter.RecordLabel,
                    ReleaseYear = mastodonTheHunter.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonTheHunter.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Octupus Has No Friends",
                    RecordLabel = mastodonTheHunter.RecordLabel,
                    ReleaseYear = mastodonTheHunter.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonTheHunter.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "All the Heavy Lifting",
                    RecordLabel = mastodonTheHunter.RecordLabel,
                    ReleaseYear = mastodonTheHunter.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonTheHunter.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "The Hunter",
                    RecordLabel = mastodonTheHunter.RecordLabel,
                    ReleaseYear = mastodonTheHunter.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonTheHunter.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Dry Bone Valley",
                    RecordLabel = mastodonTheHunter.RecordLabel,
                    ReleaseYear = mastodonTheHunter.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonTheHunter.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Thickening",
                    RecordLabel = mastodonTheHunter.RecordLabel,
                    ReleaseYear = mastodonTheHunter.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonTheHunter.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Creature Lives",
                    RecordLabel = mastodonTheHunter.RecordLabel,
                    ReleaseYear = mastodonTheHunter.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonTheHunter.AlbumId
                }
                ,
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Spectrelight",
                    RecordLabel = mastodonTheHunter.RecordLabel,
                    ReleaseYear = mastodonTheHunter.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonTheHunter.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Bedazzled Fingernails",
                    RecordLabel = mastodonTheHunter.RecordLabel,
                    ReleaseYear = mastodonTheHunter.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonTheHunter.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "The Sparrow",
                    RecordLabel = mastodonTheHunter.RecordLabel,
                    ReleaseYear = mastodonTheHunter.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonTheHunter.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "The Ruiner",
                    RecordLabel = mastodonTheHunter.RecordLabel,
                    ReleaseYear = mastodonTheHunter.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonTheHunter.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Deathbound",
                    RecordLabel = mastodonTheHunter.RecordLabel,
                    ReleaseYear = mastodonTheHunter.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonTheHunter.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Tread Lightly",
                    RecordLabel = mastodonOnceMoreRoundTheSun.RecordLabel,
                    ReleaseYear = mastodonOnceMoreRoundTheSun.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonOnceMoreRoundTheSun.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "The Motherload",
                    RecordLabel = mastodonOnceMoreRoundTheSun.RecordLabel,
                    ReleaseYear = mastodonOnceMoreRoundTheSun.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonOnceMoreRoundTheSun.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "High Road",
                    RecordLabel = mastodonOnceMoreRoundTheSun.RecordLabel,
                    ReleaseYear = mastodonOnceMoreRoundTheSun.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonOnceMoreRoundTheSun.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Once More 'Round the Sun",
                    RecordLabel = mastodonOnceMoreRoundTheSun.RecordLabel,
                    ReleaseYear = mastodonOnceMoreRoundTheSun.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonOnceMoreRoundTheSun.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Chimes at Midnight",
                    RecordLabel = mastodonOnceMoreRoundTheSun.RecordLabel,
                    ReleaseYear = mastodonOnceMoreRoundTheSun.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonOnceMoreRoundTheSun.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Asleep in the Deep",
                    RecordLabel = mastodonOnceMoreRoundTheSun.RecordLabel,
                    ReleaseYear = mastodonOnceMoreRoundTheSun.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonOnceMoreRoundTheSun.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Feast Your Eyes",
                    RecordLabel = mastodonOnceMoreRoundTheSun.RecordLabel,
                    ReleaseYear = mastodonOnceMoreRoundTheSun.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonOnceMoreRoundTheSun.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Aunt Lisa",
                    RecordLabel = mastodonOnceMoreRoundTheSun.RecordLabel,
                    ReleaseYear = mastodonOnceMoreRoundTheSun.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonOnceMoreRoundTheSun.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Ember City",
                    RecordLabel = mastodonOnceMoreRoundTheSun.RecordLabel,
                    ReleaseYear = mastodonOnceMoreRoundTheSun.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonOnceMoreRoundTheSun.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Halloween",
                    RecordLabel = mastodonOnceMoreRoundTheSun.RecordLabel,
                    ReleaseYear = mastodonOnceMoreRoundTheSun.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonOnceMoreRoundTheSun.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Diamond in the Witch House",
                    RecordLabel = mastodonOnceMoreRoundTheSun.RecordLabel,
                    ReleaseYear = mastodonOnceMoreRoundTheSun.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonOnceMoreRoundTheSun.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Sultan's Curse",
                    RecordLabel = mastodonEmperorOfSand.RecordLabel,
                    ReleaseYear = mastodonEmperorOfSand.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonEmperorOfSand.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Show Yourself",
                    RecordLabel = mastodonEmperorOfSand.RecordLabel,
                    ReleaseYear = mastodonEmperorOfSand.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonEmperorOfSand.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Precious Stones",
                    RecordLabel = mastodonEmperorOfSand.RecordLabel,
                    ReleaseYear = mastodonEmperorOfSand.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonEmperorOfSand.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Steambreather",
                    RecordLabel = mastodonEmperorOfSand.RecordLabel,
                    ReleaseYear = mastodonEmperorOfSand.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonEmperorOfSand.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Roots Remain",
                    RecordLabel = mastodonEmperorOfSand.RecordLabel,
                    ReleaseYear = mastodonEmperorOfSand.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonEmperorOfSand.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Word to the Wise",
                    RecordLabel = mastodonEmperorOfSand.RecordLabel,
                    ReleaseYear = mastodonEmperorOfSand.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonEmperorOfSand.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Ancient to the Wise",
                    RecordLabel = mastodonEmperorOfSand.RecordLabel,
                    ReleaseYear = mastodonEmperorOfSand.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonEmperorOfSand.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Ancient Kingdom",
                    RecordLabel = mastodonEmperorOfSand.RecordLabel,
                    ReleaseYear = mastodonEmperorOfSand.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonEmperorOfSand.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Cleandestiny",
                    RecordLabel = mastodonEmperorOfSand.RecordLabel,
                    ReleaseYear = mastodonEmperorOfSand.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonEmperorOfSand.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Andromeda",
                    RecordLabel = mastodonEmperorOfSand.RecordLabel,
                    ReleaseYear = mastodonEmperorOfSand.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonEmperorOfSand.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Scorpion Breath",
                    RecordLabel = mastodonEmperorOfSand.RecordLabel,
                    ReleaseYear = mastodonEmperorOfSand.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonEmperorOfSand.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Jaguar God",
                    RecordLabel = mastodonEmperorOfSand.RecordLabel,
                    ReleaseYear = mastodonEmperorOfSand.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonEmperorOfSand.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Push It",
                    RecordLabel = staticxWisconsinDeathTrip.RecordLabel,
                    ReleaseYear = staticxWisconsinDeathTrip.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxWisconsinDeathTrip.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "I'm with Stupid",
                    RecordLabel = staticxWisconsinDeathTrip.RecordLabel,
                    ReleaseYear = staticxWisconsinDeathTrip.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxWisconsinDeathTrip.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Bled for Days",
                    RecordLabel = staticxWisconsinDeathTrip.RecordLabel,
                    ReleaseYear = staticxWisconsinDeathTrip.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxWisconsinDeathTrip.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Love Dump",
                    RecordLabel = staticxWisconsinDeathTrip.RecordLabel,
                    ReleaseYear = staticxWisconsinDeathTrip.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxWisconsinDeathTrip.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "I Am",
                    RecordLabel = staticxWisconsinDeathTrip.RecordLabel,
                    ReleaseYear = staticxWisconsinDeathTrip.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxWisconsinDeathTrip.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Otsegoldation",
                    RecordLabel = staticxWisconsinDeathTrip.RecordLabel,
                    ReleaseYear = staticxWisconsinDeathTrip.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxWisconsinDeathTrip.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Stem",
                    RecordLabel = staticxWisconsinDeathTrip.RecordLabel,
                    ReleaseYear = staticxWisconsinDeathTrip.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxWisconsinDeathTrip.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Sweat of the Bud",
                    RecordLabel = staticxWisconsinDeathTrip.RecordLabel,
                    ReleaseYear = staticxWisconsinDeathTrip.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxWisconsinDeathTrip.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Fix",
                    RecordLabel = staticxWisconsinDeathTrip.RecordLabel,
                    ReleaseYear = staticxWisconsinDeathTrip.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxWisconsinDeathTrip.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Wisconsin Death Trip",
                    RecordLabel = staticxWisconsinDeathTrip.RecordLabel,
                    ReleaseYear = staticxWisconsinDeathTrip.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxWisconsinDeathTrip.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "December",
                    RecordLabel = staticxWisconsinDeathTrip.RecordLabel,
                    ReleaseYear = staticxWisconsinDeathTrip.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxWisconsinDeathTrip.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Down",
                    RecordLabel = staticxWisconsinDeathTrip.RecordLabel,
                    ReleaseYear = staticxWisconsinDeathTrip.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxWisconsinDeathTrip.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Bien Venidos",
                    RecordLabel = staticxMachine.RecordLabel,
                    ReleaseYear = staticxMachine.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxMachine.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Get to the Gone",
                    RecordLabel = staticxMachine.RecordLabel,
                    ReleaseYear = staticxMachine.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxMachine.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Permance",
                    RecordLabel = staticxMachine.RecordLabel,
                    ReleaseYear = staticxMachine.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxMachine.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Black and White",
                    RecordLabel = staticxMachine.RecordLabel,
                    ReleaseYear = staticxMachine.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxMachine.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "This Is Not",
                    RecordLabel = staticxMachine.RecordLabel,
                    ReleaseYear = staticxMachine.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxMachine.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Otsego Undead",
                    RecordLabel = staticxMachine.RecordLabel,
                    ReleaseYear = staticxMachine.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxMachine.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Cold",
                    RecordLabel = staticxMachine.RecordLabel,
                    ReleaseYear = staticxMachine.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxMachine.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Structural Defect",
                    RecordLabel = staticxMachine.RecordLabel,
                    ReleaseYear = staticxMachine.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxMachine.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "... In a Bag",
                    RecordLabel = staticxMachine.RecordLabel,
                    ReleaseYear = staticxMachine.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxMachine.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Burn to Burn",
                    RecordLabel = staticxMachine.RecordLabel,
                    ReleaseYear = staticxMachine.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxMachine.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Machine",
                    RecordLabel = staticxMachine.RecordLabel,
                    ReleaseYear = staticxMachine.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxMachine.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "A Dios Alma Perdida",
                    RecordLabel = staticxMachine.RecordLabel,
                    ReleaseYear = staticxMachine.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxMachine.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Destroy All",
                    RecordLabel = staticxShadowZone.RecordLabel,
                    ReleaseYear = staticxShadowZone.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxShadowZone.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Control It",
                    RecordLabel = staticxShadowZone.RecordLabel,
                    ReleaseYear = staticxShadowZone.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxShadowZone.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "New Plain",
                    RecordLabel = staticxShadowZone.RecordLabel,
                    ReleaseYear = staticxShadowZone.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxShadowZone.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Shadow Zone",
                    RecordLabel = staticxShadowZone.RecordLabel,
                    ReleaseYear = staticxShadowZone.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxShadowZone.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Dead World",
                    RecordLabel = staticxShadowZone.RecordLabel,
                    ReleaseYear = staticxShadowZone.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxShadowZone.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Monster",
                    RecordLabel = staticxShadowZone.RecordLabel,
                    ReleaseYear = staticxShadowZone.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxShadowZone.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "The Only",
                    RecordLabel = staticxShadowZone.RecordLabel,
                    ReleaseYear = staticxShadowZone.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxShadowZone.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Kill Your Idols",
                    RecordLabel = staticxShadowZone.RecordLabel,
                    ReleaseYear = staticxShadowZone.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxShadowZone.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "All in Wait",
                    RecordLabel = staticxShadowZone.RecordLabel,
                    ReleaseYear = staticxShadowZone.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxShadowZone.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Otsegolectric",
                    RecordLabel = staticxShadowZone.RecordLabel,
                    ReleaseYear = staticxShadowZone.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxShadowZone.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "So",
                    RecordLabel = staticxShadowZone.RecordLabel,
                    ReleaseYear = staticxShadowZone.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxShadowZone.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Transmission",
                    RecordLabel = staticxShadowZone.RecordLabel,
                    ReleaseYear = staticxShadowZone.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxShadowZone.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Invincible",
                    RecordLabel = staticxShadowZone.RecordLabel,
                    ReleaseYear = staticxShadowZone.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxShadowZone.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Gimme Gimme Shock Treatment",
                    RecordLabel = staticxShadowZone.RecordLabel,
                    ReleaseYear = staticxShadowZone.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxShadowZone.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "The Enemy",
                    RecordLabel = staticxStartAWar.RecordLabel,
                    ReleaseYear = staticxStartAWar.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxStartAWar.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "I'm the One",
                    RecordLabel = staticxStartAWar.RecordLabel,
                    ReleaseYear = staticxStartAWar.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxStartAWar.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Start a War",
                    RecordLabel = staticxStartAWar.RecordLabel,
                    ReleaseYear = staticxStartAWar.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxStartAWar.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Pieces",
                    RecordLabel = staticxStartAWar.RecordLabel,
                    ReleaseYear = staticxStartAWar.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxStartAWar.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Dirthouse",
                    RecordLabel = staticxStartAWar.RecordLabel,
                    ReleaseYear = staticxStartAWar.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxStartAWar.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Skinnyman",
                    RecordLabel = staticxStartAWar.RecordLabel,
                    ReleaseYear = staticxStartAWar.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxStartAWar.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Just in Case",
                    RecordLabel = staticxStartAWar.RecordLabel,
                    ReleaseYear = staticxStartAWar.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxStartAWar.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Set It Off",
                    RecordLabel = staticxStartAWar.RecordLabel,
                    ReleaseYear = staticxStartAWar.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxStartAWar.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "I Want to Fucking break It",
                    RecordLabel = staticxStartAWar.RecordLabel,
                    ReleaseYear = staticxStartAWar.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxStartAWar.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Night Terrors",
                    RecordLabel = staticxStartAWar.RecordLabel,
                    ReleaseYear = staticxStartAWar.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxStartAWar.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Otsego Amigo",
                    RecordLabel = staticxStartAWar.RecordLabel,
                    ReleaseYear = staticxStartAWar.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxStartAWar.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "My Damnation",
                    RecordLabel = staticxStartAWar.RecordLabel,
                    ReleaseYear = staticxStartAWar.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxStartAWar.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Brainfog",
                    RecordLabel = staticxStartAWar.RecordLabel,
                    ReleaseYear = staticxStartAWar.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxStartAWar.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Get to the Gone",
                    RecordLabel = staticxStartAWar.RecordLabel,
                    ReleaseYear = staticxStartAWar.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxStartAWar.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Cannibal",
                    RecordLabel = staticxCannibal.RecordLabel,
                    ReleaseYear = staticxCannibal.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxCannibal.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "No Submission",
                    RecordLabel = staticxCannibal.RecordLabel,
                    ReleaseYear = staticxCannibal.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxCannibal.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Behemoth",
                    RecordLabel = staticxCannibal.RecordLabel,
                    ReleaseYear = staticxCannibal.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxCannibal.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Chemical Logic",
                    RecordLabel = staticxCannibal.RecordLabel,
                    ReleaseYear = staticxCannibal.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxCannibal.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Destroyer",
                    RecordLabel = staticxCannibal.RecordLabel,
                    ReleaseYear = staticxCannibal.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxCannibal.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Forty Ways",
                    RecordLabel = staticxCannibal.RecordLabel,
                    ReleaseYear = staticxCannibal.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxCannibal.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Chroma-Matic",
                    RecordLabel = staticxCannibal.RecordLabel,
                    ReleaseYear = staticxCannibal.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxCannibal.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Cuts You Up",
                    RecordLabel = staticxCannibal.RecordLabel,
                    ReleaseYear = staticxCannibal.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxCannibal.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Reptile",
                    RecordLabel = staticxCannibal.RecordLabel,
                    ReleaseYear = staticxCannibal.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxCannibal.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Electric Pulse",
                    RecordLabel = staticxCannibal.RecordLabel,
                    ReleaseYear = staticxCannibal.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxCannibal.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Goat",
                    RecordLabel = staticxCannibal.RecordLabel,
                    ReleaseYear = staticxCannibal.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxCannibal.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Team Hate",
                    RecordLabel = staticxCannibal.RecordLabel,
                    ReleaseYear = staticxCannibal.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxCannibal.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Light It Up",
                    RecordLabel = staticxCannibal.RecordLabel,
                    ReleaseYear = staticxCannibal.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxCannibal.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "I'm the One",
                    RecordLabel = staticxCannibal.RecordLabel,
                    ReleaseYear = staticxCannibal.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxCannibal.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Get Up and Boogie",
                    RecordLabel = staticxCannibal.RecordLabel,
                    ReleaseYear = staticxCannibal.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxCannibal.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Beneath, Between, Beyond",
                    RecordLabel = staticxCannibal.RecordLabel,
                    ReleaseYear = staticxCannibal.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxCannibal.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Lunatic",
                    RecordLabel = staticxCultOfStatic.RecordLabel,
                    ReleaseYear = staticxCultOfStatic.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxCultOfStatic.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Z28",
                    RecordLabel = staticxCultOfStatic.RecordLabel,
                    ReleaseYear = staticxCultOfStatic.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxCultOfStatic.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Terminal",
                    RecordLabel = staticxCultOfStatic.RecordLabel,
                    ReleaseYear = staticxCultOfStatic.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxCultOfStatic.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Hypure",
                    RecordLabel = staticxCultOfStatic.RecordLabel,
                    ReleaseYear = staticxCultOfStatic.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxCultOfStatic.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Tera-Fied",
                    RecordLabel = staticxCultOfStatic.RecordLabel,
                    ReleaseYear = staticxCultOfStatic.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxCultOfStatic.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Stringwray",
                    RecordLabel = staticxCultOfStatic.RecordLabel,
                    ReleaseYear = staticxCultOfStatic.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxCultOfStatic.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "You Am I",
                    RecordLabel = staticxCultOfStatic.RecordLabel,
                    ReleaseYear = staticxCultOfStatic.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxCultOfStatic.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Isolaytore",
                    RecordLabel = staticxCultOfStatic.RecordLabel,
                    ReleaseYear = staticxCultOfStatic.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxCultOfStatic.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Nocturnally",
                    RecordLabel = staticxCultOfStatic.RecordLabel,
                    ReleaseYear = staticxCultOfStatic.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxCultOfStatic.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Skinned",
                    RecordLabel = staticxCultOfStatic.RecordLabel,
                    ReleaseYear = staticxCultOfStatic.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxCultOfStatic.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Grind 2 Halt",
                    RecordLabel = staticxCultOfStatic.RecordLabel,
                    ReleaseYear = staticxCultOfStatic.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxCultOfStatic.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Still of the Night",
                    RecordLabel = staticxCultOfStatic.RecordLabel,
                    ReleaseYear = staticxCultOfStatic.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxCultOfStatic.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "W.F.O",
                    RecordLabel = staticxCultOfStatic.RecordLabel,
                    ReleaseYear = staticxCultOfStatic.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxCultOfStatic.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Looks That Kill",
                    RecordLabel = staticxCultOfStatic.RecordLabel,
                    ReleaseYear = staticxCultOfStatic.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxCultOfStatic.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Talk Dirty to Me",
                    RecordLabel = staticxCultOfStatic.RecordLabel,
                    ReleaseYear = staticxCultOfStatic.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxCultOfStatic.AlbumId
                }
                );
        }
    }
}
