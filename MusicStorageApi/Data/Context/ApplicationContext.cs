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
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Stinkfist",
                    RecordLabel = toolAenima.RecordLabel,
                    ReleaseYear = toolAenima.ReleaseYear,
                    AuthorId = tool.AuthorId,
                    AlbumId = toolAenima.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Eulogy",
                    RecordLabel = toolAenima.RecordLabel,
                    ReleaseYear = toolAenima.ReleaseYear,
                    AuthorId = tool.AuthorId,
                    AlbumId = toolAenima.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "H.",
                    RecordLabel = toolAenima.RecordLabel,
                    ReleaseYear = toolAenima.ReleaseYear,
                    AuthorId = tool.AuthorId,
                    AlbumId = toolAenima.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Useful Idiot",
                    RecordLabel = toolAenima.RecordLabel,
                    ReleaseYear = toolAenima.ReleaseYear,
                    AuthorId = tool.AuthorId,
                    AlbumId = toolAenima.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Forty Six & 2",
                    RecordLabel = toolAenima.RecordLabel,
                    ReleaseYear = toolAenima.ReleaseYear,
                    AuthorId = tool.AuthorId,
                    AlbumId = toolAenima.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Message to Harry Manback",
                    RecordLabel = toolAenima.RecordLabel,
                    ReleaseYear = toolAenima.ReleaseYear,
                    AuthorId = tool.AuthorId,
                    AlbumId = toolAenima.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Hooker with a Denis",
                    RecordLabel = toolAenima.RecordLabel,
                    ReleaseYear = toolAenima.ReleaseYear,
                    AuthorId = tool.AuthorId,
                    AlbumId = toolAenima.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Intermission",
                    RecordLabel = toolAenima.RecordLabel,
                    ReleaseYear = toolAenima.ReleaseYear,
                    AuthorId = tool.AuthorId,
                    AlbumId = toolAenima.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "jimmy",
                    RecordLabel = toolAenima.RecordLabel,
                    ReleaseYear = toolAenima.ReleaseYear,
                    AuthorId = tool.AuthorId,
                    AlbumId = toolAenima.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Die Eier von Satan",
                    RecordLabel = toolAenima.RecordLabel,
                    ReleaseYear = toolAenima.ReleaseYear,
                    AuthorId = tool.AuthorId,
                    AlbumId = toolAenima.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Pushit",
                    RecordLabel = toolAenima.RecordLabel,
                    ReleaseYear = toolAenima.ReleaseYear,
                    AuthorId = tool.AuthorId,
                    AlbumId = toolAenima.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Cesaro Summability",
                    RecordLabel = toolAenima.RecordLabel,
                    ReleaseYear = toolAenima.ReleaseYear,
                    AuthorId = tool.AuthorId,
                    AlbumId = toolAenima.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "AEnema",
                    RecordLabel = toolAenima.RecordLabel,
                    ReleaseYear = toolAenima.ReleaseYear,
                    AuthorId = tool.AuthorId,
                    AlbumId = toolAenima.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "(-) Ions",
                    RecordLabel = toolAenima.RecordLabel,
                    ReleaseYear = toolAenima.ReleaseYear,
                    AuthorId = tool.AuthorId,
                    AlbumId = toolAenima.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Third Eye",
                    RecordLabel = toolAenima.RecordLabel,
                    ReleaseYear = toolAenima.ReleaseYear,
                    AuthorId = tool.AuthorId,
                    AlbumId = toolAenima.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Eulogy",
                    RecordLabel = toolAenima.RecordLabel,
                    ReleaseYear = toolAenima.ReleaseYear,
                    AuthorId = tool.AuthorId,
                    AlbumId = toolAenima.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "The Grudge",
                    RecordLabel = toolLateralus.RecordLabel,
                    ReleaseYear = toolLateralus.ReleaseYear,
                    AuthorId = tool.AuthorId,
                    AlbumId = toolLateralus.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Eon Blue Apocalypse",
                    RecordLabel = toolLateralus.RecordLabel,
                    ReleaseYear = toolLateralus.ReleaseYear,
                    AuthorId = tool.AuthorId,
                    AlbumId = toolLateralus.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "The Patient",
                    RecordLabel = toolLateralus.RecordLabel,
                    ReleaseYear = toolLateralus.ReleaseYear,
                    AuthorId = tool.AuthorId,
                    AlbumId = toolLateralus.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Mantra",
                    RecordLabel = toolLateralus.RecordLabel,
                    ReleaseYear = toolLateralus.ReleaseYear,
                    AuthorId = tool.AuthorId,
                    AlbumId = toolLateralus.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Schism",
                    RecordLabel = toolLateralus.RecordLabel,
                    ReleaseYear = toolLateralus.ReleaseYear,
                    AuthorId = tool.AuthorId,
                    AlbumId = toolLateralus.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Parabol",
                    RecordLabel = toolLateralus.RecordLabel,
                    ReleaseYear = toolLateralus.ReleaseYear,
                    AuthorId = tool.AuthorId,
                    AlbumId = toolLateralus.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Parabola",
                    RecordLabel = toolLateralus.RecordLabel,
                    ReleaseYear = toolLateralus.ReleaseYear,
                    AuthorId = tool.AuthorId,
                    AlbumId = toolLateralus.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Ticks & Leeches",
                    RecordLabel = toolLateralus.RecordLabel,
                    ReleaseYear = toolLateralus.ReleaseYear,
                    AuthorId = tool.AuthorId,
                    AlbumId = toolLateralus.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Lateralus",
                    RecordLabel = toolLateralus.RecordLabel,
                    ReleaseYear = toolLateralus.ReleaseYear,
                    AuthorId = tool.AuthorId,
                    AlbumId = toolLateralus.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Disposition",
                    RecordLabel = toolLateralus.RecordLabel,
                    ReleaseYear = toolLateralus.ReleaseYear,
                    AuthorId = tool.AuthorId,
                    AlbumId = toolLateralus.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Reflection",
                    RecordLabel = toolLateralus.RecordLabel,
                    ReleaseYear = toolLateralus.ReleaseYear,
                    AuthorId = tool.AuthorId,
                    AlbumId = toolLateralus.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Triad",
                    RecordLabel = toolLateralus.RecordLabel,
                    ReleaseYear = toolLateralus.ReleaseYear,
                    AuthorId = tool.AuthorId,
                    AlbumId = toolLateralus.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Faaip de Oiad",
                    RecordLabel = toolLateralus.RecordLabel,
                    ReleaseYear = toolLateralus.ReleaseYear,
                    AuthorId = tool.AuthorId,
                    AlbumId = toolLateralus.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Vicarious",
                    RecordLabel = toolTenThousandDays.RecordLabel,
                    ReleaseYear = toolTenThousandDays.ReleaseYear,
                    AuthorId = tool.AuthorId,
                    AlbumId = toolTenThousandDays.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Jambi",
                    RecordLabel = toolTenThousandDays.RecordLabel,
                    ReleaseYear = toolTenThousandDays.ReleaseYear,
                    AuthorId = tool.AuthorId,
                    AlbumId = toolTenThousandDays.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Wings for Marie",
                    RecordLabel = toolTenThousandDays.RecordLabel,
                    ReleaseYear = toolTenThousandDays.ReleaseYear,
                    AuthorId = tool.AuthorId,
                    AlbumId = toolTenThousandDays.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "10,000 Days",
                    RecordLabel = toolTenThousandDays.RecordLabel,
                    ReleaseYear = toolTenThousandDays.ReleaseYear,
                    AuthorId = tool.AuthorId,
                    AlbumId = toolTenThousandDays.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "The Pot",
                    RecordLabel = toolTenThousandDays.RecordLabel,
                    ReleaseYear = toolTenThousandDays.ReleaseYear,
                    AuthorId = tool.AuthorId,
                    AlbumId = toolTenThousandDays.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Lipan Conjuring",
                    RecordLabel = toolTenThousandDays.RecordLabel,
                    ReleaseYear = toolTenThousandDays.ReleaseYear,
                    AuthorId = tool.AuthorId,
                    AlbumId = toolTenThousandDays.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Lost Keys",
                    RecordLabel = toolTenThousandDays.RecordLabel,
                    ReleaseYear = toolTenThousandDays.ReleaseYear,
                    AuthorId = tool.AuthorId,
                    AlbumId = toolTenThousandDays.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Rosetta Stoned",
                    RecordLabel = toolTenThousandDays.RecordLabel,
                    ReleaseYear = toolTenThousandDays.ReleaseYear,
                    AuthorId = tool.AuthorId,
                    AlbumId = toolTenThousandDays.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Intension",
                    RecordLabel = toolTenThousandDays.RecordLabel,
                    ReleaseYear = toolTenThousandDays.ReleaseYear,
                    AuthorId = tool.AuthorId,
                    AlbumId = toolTenThousandDays.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Right in Two",
                    RecordLabel = toolTenThousandDays.RecordLabel,
                    ReleaseYear = toolTenThousandDays.ReleaseYear,
                    AuthorId = tool.AuthorId,
                    AlbumId = toolTenThousandDays.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Viginti Tres",
                    RecordLabel = toolTenThousandDays.RecordLabel,
                    ReleaseYear = toolTenThousandDays.ReleaseYear,
                    AuthorId = tool.AuthorId,
                    AlbumId = toolTenThousandDays.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Fear Inoculum",
                    RecordLabel = toolFearInoculum.RecordLabel,
                    ReleaseYear = toolFearInoculum.ReleaseYear,
                    AuthorId = tool.AuthorId,
                    AlbumId = toolFearInoculum.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Pneuma",
                    RecordLabel = toolFearInoculum.RecordLabel,
                    ReleaseYear = toolFearInoculum.ReleaseYear,
                    AuthorId = tool.AuthorId,
                    AlbumId = toolFearInoculum.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Litanie contre la peur",
                    RecordLabel = toolFearInoculum.RecordLabel,
                    ReleaseYear = toolFearInoculum.ReleaseYear,
                    AuthorId = tool.AuthorId,
                    AlbumId = toolFearInoculum.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Invincible",
                    RecordLabel = toolFearInoculum.RecordLabel,
                    ReleaseYear = toolFearInoculum.ReleaseYear,
                    AuthorId = tool.AuthorId,
                    AlbumId = toolFearInoculum.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Legion Inoculant",
                    RecordLabel = toolFearInoculum.RecordLabel,
                    ReleaseYear = toolFearInoculum.ReleaseYear,
                    AuthorId = tool.AuthorId,
                    AlbumId = toolFearInoculum.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Descending",
                    RecordLabel = toolFearInoculum.RecordLabel,
                    ReleaseYear = toolFearInoculum.ReleaseYear,
                    AuthorId = tool.AuthorId,
                    AlbumId = toolFearInoculum.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Culling Voices",
                    RecordLabel = toolFearInoculum.RecordLabel,
                    ReleaseYear = toolFearInoculum.ReleaseYear,
                    AuthorId = tool.AuthorId,
                    AlbumId = toolFearInoculum.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Chocolate Chip Trip",
                    RecordLabel = toolFearInoculum.RecordLabel,
                    ReleaseYear = toolFearInoculum.ReleaseYear,
                    AuthorId = tool.AuthorId,
                    AlbumId = toolFearInoculum.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "7empest",
                    RecordLabel = toolFearInoculum.RecordLabel,
                    ReleaseYear = toolFearInoculum.ReleaseYear,
                    AuthorId = tool.AuthorId,
                    AlbumId = toolFearInoculum.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Mockingbeat",
                    RecordLabel = toolFearInoculum.RecordLabel,
                    ReleaseYear = toolFearInoculum.ReleaseYear,
                    AuthorId = tool.AuthorId,
                    AlbumId = toolFearInoculum.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Crusher Destroyer",
                    RecordLabel = mastodonRemission.RecordLabel,
                    ReleaseYear = mastodonRemission.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonRemission.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "March of the Fire Ants",
                    RecordLabel = mastodonRemission.RecordLabel,
                    ReleaseYear = mastodonRemission.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonRemission.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Where Strides the Behemoth",
                    RecordLabel = mastodonRemission.RecordLabel,
                    ReleaseYear = mastodonRemission.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonRemission.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Workhorse",
                    RecordLabel = mastodonRemission.RecordLabel,
                    ReleaseYear = mastodonRemission.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonRemission.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Ol'e Nessie",
                    RecordLabel = mastodonRemission.RecordLabel,
                    ReleaseYear = mastodonRemission.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonRemission.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Burning Man",
                    RecordLabel = mastodonRemission.RecordLabel,
                    ReleaseYear = mastodonRemission.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonRemission.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Trainwreck",
                    RecordLabel = mastodonRemission.RecordLabel,
                    ReleaseYear = mastodonRemission.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonRemission.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Trempled Under Hoof",
                    RecordLabel = mastodonRemission.RecordLabel,
                    ReleaseYear = mastodonRemission.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonRemission.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Triobite",
                    RecordLabel = mastodonRemission.RecordLabel,
                    ReleaseYear = mastodonRemission.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonRemission.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Mother Puncher",
                    RecordLabel = mastodonRemission.RecordLabel,
                    ReleaseYear = mastodonRemission.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonRemission.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Elephant Man",
                    RecordLabel = mastodonRemission.RecordLabel,
                    ReleaseYear = mastodonRemission.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonRemission.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Blood and Thunder",
                    RecordLabel = mastodonLeviathan.RecordLabel,
                    ReleaseYear = mastodonLeviathan.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonLeviathan.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "I Am Ahab",
                    RecordLabel = mastodonLeviathan.RecordLabel,
                    ReleaseYear = mastodonLeviathan.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonLeviathan.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Seabeast",
                    RecordLabel = mastodonLeviathan.RecordLabel,
                    ReleaseYear = mastodonLeviathan.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonLeviathan.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Island",
                    RecordLabel = mastodonLeviathan.RecordLabel,
                    ReleaseYear = mastodonLeviathan.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonLeviathan.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Iron Tusk",
                    RecordLabel = mastodonLeviathan.RecordLabel,
                    ReleaseYear = mastodonLeviathan.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonLeviathan.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Megalodon",
                    RecordLabel = mastodonLeviathan.RecordLabel,
                    ReleaseYear = mastodonLeviathan.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonLeviathan.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Naked Burn",
                    RecordLabel = mastodonLeviathan.RecordLabel,
                    ReleaseYear = mastodonLeviathan.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonLeviathan.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Aqua Dementia",
                    RecordLabel = mastodonLeviathan.RecordLabel,
                    ReleaseYear = mastodonLeviathan.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonLeviathan.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Hearts Alive",
                    RecordLabel = mastodonLeviathan.RecordLabel,
                    ReleaseYear = mastodonLeviathan.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonLeviathan.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Joseph Merrick",
                    RecordLabel = mastodonLeviathan.RecordLabel,
                    ReleaseYear = mastodonLeviathan.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonLeviathan.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "The Wolf Is Loose",
                    RecordLabel = mastodonBloodMountain.RecordLabel,
                    ReleaseYear = mastodonBloodMountain.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonBloodMountain.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Crystal Skull",
                    RecordLabel = mastodonBloodMountain.RecordLabel,
                    ReleaseYear = mastodonBloodMountain.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonBloodMountain.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Sleeping Giant",
                    RecordLabel = mastodonBloodMountain.RecordLabel,
                    ReleaseYear = mastodonBloodMountain.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonBloodMountain.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Capillarian Crest",
                    RecordLabel = mastodonBloodMountain.RecordLabel,
                    ReleaseYear = mastodonBloodMountain.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonBloodMountain.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Circle of Cysquatch",
                    RecordLabel = mastodonBloodMountain.RecordLabel,
                    ReleaseYear = mastodonBloodMountain.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonBloodMountain.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Bladecatcher",
                    RecordLabel = mastodonBloodMountain.RecordLabel,
                    ReleaseYear = mastodonBloodMountain.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonBloodMountain.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Colony of Birchmen",
                    RecordLabel = mastodonBloodMountain.RecordLabel,
                    ReleaseYear = mastodonBloodMountain.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonBloodMountain.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Hunters of the Sky",
                    RecordLabel = mastodonBloodMountain.RecordLabel,
                    ReleaseYear = mastodonBloodMountain.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonBloodMountain.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Hand of Stone",
                    RecordLabel = mastodonBloodMountain.RecordLabel,
                    ReleaseYear = mastodonBloodMountain.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonBloodMountain.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "This Mortal Soil",
                    RecordLabel = mastodonBloodMountain.RecordLabel,
                    ReleaseYear = mastodonBloodMountain.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonBloodMountain.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Siberian Divide",
                    RecordLabel = mastodonBloodMountain.RecordLabel,
                    ReleaseYear = mastodonBloodMountain.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonBloodMountain.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Pendulous Skin",
                    RecordLabel = mastodonBloodMountain.RecordLabel,
                    ReleaseYear = mastodonBloodMountain.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonBloodMountain.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Oblivion",
                    RecordLabel = mastodonCrackTheSkye.RecordLabel,
                    ReleaseYear = mastodonCrackTheSkye.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonCrackTheSkye.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Divinations",
                    RecordLabel = mastodonCrackTheSkye.RecordLabel,
                    ReleaseYear = mastodonCrackTheSkye.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonCrackTheSkye.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Quintessence",
                    RecordLabel = mastodonCrackTheSkye.RecordLabel,
                    ReleaseYear = mastodonCrackTheSkye.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonCrackTheSkye.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "The Czar",
                    RecordLabel = mastodonCrackTheSkye.RecordLabel,
                    ReleaseYear = mastodonCrackTheSkye.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonCrackTheSkye.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Ghost of Karelia",
                    RecordLabel = mastodonCrackTheSkye.RecordLabel,
                    ReleaseYear = mastodonCrackTheSkye.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonCrackTheSkye.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Crack the Skye",
                    RecordLabel = mastodonCrackTheSkye.RecordLabel,
                    ReleaseYear = mastodonCrackTheSkye.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonCrackTheSkye.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "The Last Baron",
                    RecordLabel = mastodonCrackTheSkye.RecordLabel,
                    ReleaseYear = mastodonCrackTheSkye.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonCrackTheSkye.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Black Tongue",
                    RecordLabel = mastodonTheHunter.RecordLabel,
                    ReleaseYear = mastodonTheHunter.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonTheHunter.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Curl of the Buri",
                    RecordLabel = mastodonTheHunter.RecordLabel,
                    ReleaseYear = mastodonTheHunter.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonTheHunter.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Blasteroid",
                    RecordLabel = mastodonTheHunter.RecordLabel,
                    ReleaseYear = mastodonTheHunter.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonTheHunter.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Stargasm",
                    RecordLabel = mastodonTheHunter.RecordLabel,
                    ReleaseYear = mastodonTheHunter.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonTheHunter.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Octupus Has No Friends",
                    RecordLabel = mastodonTheHunter.RecordLabel,
                    ReleaseYear = mastodonTheHunter.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonTheHunter.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "All the Heavy Lifting",
                    RecordLabel = mastodonTheHunter.RecordLabel,
                    ReleaseYear = mastodonTheHunter.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonTheHunter.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "The Hunter",
                    RecordLabel = mastodonTheHunter.RecordLabel,
                    ReleaseYear = mastodonTheHunter.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonTheHunter.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Dry Bone Valley",
                    RecordLabel = mastodonTheHunter.RecordLabel,
                    ReleaseYear = mastodonTheHunter.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonTheHunter.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Thickening",
                    RecordLabel = mastodonTheHunter.RecordLabel,
                    ReleaseYear = mastodonTheHunter.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonTheHunter.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Creature Lives",
                    RecordLabel = mastodonTheHunter.RecordLabel,
                    ReleaseYear = mastodonTheHunter.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonTheHunter.AlbumId
                }
                ,
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Spectrelight",
                    RecordLabel = mastodonTheHunter.RecordLabel,
                    ReleaseYear = mastodonTheHunter.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonTheHunter.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Bedazzled Fingernails",
                    RecordLabel = mastodonTheHunter.RecordLabel,
                    ReleaseYear = mastodonTheHunter.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonTheHunter.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "The Sparrow",
                    RecordLabel = mastodonTheHunter.RecordLabel,
                    ReleaseYear = mastodonTheHunter.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonTheHunter.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "The Ruiner",
                    RecordLabel = mastodonTheHunter.RecordLabel,
                    ReleaseYear = mastodonTheHunter.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonTheHunter.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Deathbound",
                    RecordLabel = mastodonTheHunter.RecordLabel,
                    ReleaseYear = mastodonTheHunter.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonTheHunter.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Tread Lightly",
                    RecordLabel = mastodonOnceMoreRoundTheSun.RecordLabel,
                    ReleaseYear = mastodonOnceMoreRoundTheSun.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonOnceMoreRoundTheSun.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "The Motherload",
                    RecordLabel = mastodonOnceMoreRoundTheSun.RecordLabel,
                    ReleaseYear = mastodonOnceMoreRoundTheSun.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonOnceMoreRoundTheSun.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "High Road",
                    RecordLabel = mastodonOnceMoreRoundTheSun.RecordLabel,
                    ReleaseYear = mastodonOnceMoreRoundTheSun.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonOnceMoreRoundTheSun.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Once More 'Round the Sun",
                    RecordLabel = mastodonOnceMoreRoundTheSun.RecordLabel,
                    ReleaseYear = mastodonOnceMoreRoundTheSun.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonOnceMoreRoundTheSun.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Chimes at Midnight",
                    RecordLabel = mastodonOnceMoreRoundTheSun.RecordLabel,
                    ReleaseYear = mastodonOnceMoreRoundTheSun.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonOnceMoreRoundTheSun.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Asleep in the Deep",
                    RecordLabel = mastodonOnceMoreRoundTheSun.RecordLabel,
                    ReleaseYear = mastodonOnceMoreRoundTheSun.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonOnceMoreRoundTheSun.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Feast Your Eyes",
                    RecordLabel = mastodonOnceMoreRoundTheSun.RecordLabel,
                    ReleaseYear = mastodonOnceMoreRoundTheSun.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonOnceMoreRoundTheSun.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Aunt Lisa",
                    RecordLabel = mastodonOnceMoreRoundTheSun.RecordLabel,
                    ReleaseYear = mastodonOnceMoreRoundTheSun.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonOnceMoreRoundTheSun.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Ember City",
                    RecordLabel = mastodonOnceMoreRoundTheSun.RecordLabel,
                    ReleaseYear = mastodonOnceMoreRoundTheSun.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonOnceMoreRoundTheSun.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Halloween",
                    RecordLabel = mastodonOnceMoreRoundTheSun.RecordLabel,
                    ReleaseYear = mastodonOnceMoreRoundTheSun.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonOnceMoreRoundTheSun.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Diamond in the Witch House",
                    RecordLabel = mastodonOnceMoreRoundTheSun.RecordLabel,
                    ReleaseYear = mastodonOnceMoreRoundTheSun.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonOnceMoreRoundTheSun.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Sultan's Curse",
                    RecordLabel = mastodonEmperorOfSand.RecordLabel,
                    ReleaseYear = mastodonEmperorOfSand.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonEmperorOfSand.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Show Yourself",
                    RecordLabel = mastodonEmperorOfSand.RecordLabel,
                    ReleaseYear = mastodonEmperorOfSand.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonEmperorOfSand.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Precious Stones",
                    RecordLabel = mastodonEmperorOfSand.RecordLabel,
                    ReleaseYear = mastodonEmperorOfSand.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonEmperorOfSand.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Steambreather",
                    RecordLabel = mastodonEmperorOfSand.RecordLabel,
                    ReleaseYear = mastodonEmperorOfSand.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonEmperorOfSand.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Roots Remain",
                    RecordLabel = mastodonEmperorOfSand.RecordLabel,
                    ReleaseYear = mastodonEmperorOfSand.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonEmperorOfSand.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Word to the Wise",
                    RecordLabel = mastodonEmperorOfSand.RecordLabel,
                    ReleaseYear = mastodonEmperorOfSand.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonEmperorOfSand.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Ancient to the Wise",
                    RecordLabel = mastodonEmperorOfSand.RecordLabel,
                    ReleaseYear = mastodonEmperorOfSand.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonEmperorOfSand.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Ancient Kingdom",
                    RecordLabel = mastodonEmperorOfSand.RecordLabel,
                    ReleaseYear = mastodonEmperorOfSand.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonEmperorOfSand.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Cleandestiny",
                    RecordLabel = mastodonEmperorOfSand.RecordLabel,
                    ReleaseYear = mastodonEmperorOfSand.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonEmperorOfSand.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Andromeda",
                    RecordLabel = mastodonEmperorOfSand.RecordLabel,
                    ReleaseYear = mastodonEmperorOfSand.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonEmperorOfSand.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Scorpion Breath",
                    RecordLabel = mastodonEmperorOfSand.RecordLabel,
                    ReleaseYear = mastodonEmperorOfSand.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonEmperorOfSand.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Jaguar God",
                    RecordLabel = mastodonEmperorOfSand.RecordLabel,
                    ReleaseYear = mastodonEmperorOfSand.ReleaseYear,
                    AuthorId = mastodon.AuthorId,
                    AlbumId = mastodonEmperorOfSand.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Push It",
                    RecordLabel = staticxWisconsinDeathTrip.RecordLabel,
                    ReleaseYear = staticxWisconsinDeathTrip.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxWisconsinDeathTrip.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "I'm with Stupid",
                    RecordLabel = staticxWisconsinDeathTrip.RecordLabel,
                    ReleaseYear = staticxWisconsinDeathTrip.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxWisconsinDeathTrip.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Bled for Days",
                    RecordLabel = staticxWisconsinDeathTrip.RecordLabel,
                    ReleaseYear = staticxWisconsinDeathTrip.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxWisconsinDeathTrip.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Love Dump",
                    RecordLabel = staticxWisconsinDeathTrip.RecordLabel,
                    ReleaseYear = staticxWisconsinDeathTrip.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxWisconsinDeathTrip.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "I Am",
                    RecordLabel = staticxWisconsinDeathTrip.RecordLabel,
                    ReleaseYear = staticxWisconsinDeathTrip.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxWisconsinDeathTrip.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Otsegoldation",
                    RecordLabel = staticxWisconsinDeathTrip.RecordLabel,
                    ReleaseYear = staticxWisconsinDeathTrip.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxWisconsinDeathTrip.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Stem",
                    RecordLabel = staticxWisconsinDeathTrip.RecordLabel,
                    ReleaseYear = staticxWisconsinDeathTrip.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxWisconsinDeathTrip.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Sweat of the Bud",
                    RecordLabel = staticxWisconsinDeathTrip.RecordLabel,
                    ReleaseYear = staticxWisconsinDeathTrip.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxWisconsinDeathTrip.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Fix",
                    RecordLabel = staticxWisconsinDeathTrip.RecordLabel,
                    ReleaseYear = staticxWisconsinDeathTrip.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxWisconsinDeathTrip.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Wisconsin Death Trip",
                    RecordLabel = staticxWisconsinDeathTrip.RecordLabel,
                    ReleaseYear = staticxWisconsinDeathTrip.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxWisconsinDeathTrip.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "December",
                    RecordLabel = staticxWisconsinDeathTrip.RecordLabel,
                    ReleaseYear = staticxWisconsinDeathTrip.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxWisconsinDeathTrip.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Down",
                    RecordLabel = staticxWisconsinDeathTrip.RecordLabel,
                    ReleaseYear = staticxWisconsinDeathTrip.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxWisconsinDeathTrip.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Bien Venidos",
                    RecordLabel = staticxMachine.RecordLabel,
                    ReleaseYear = staticxMachine.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxMachine.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Get to the Gone",
                    RecordLabel = staticxMachine.RecordLabel,
                    ReleaseYear = staticxMachine.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxMachine.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Permance",
                    RecordLabel = staticxMachine.RecordLabel,
                    ReleaseYear = staticxMachine.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxMachine.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Black and White",
                    RecordLabel = staticxMachine.RecordLabel,
                    ReleaseYear = staticxMachine.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxMachine.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "This Is Not",
                    RecordLabel = staticxMachine.RecordLabel,
                    ReleaseYear = staticxMachine.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxMachine.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Otsego Undead",
                    RecordLabel = staticxMachine.RecordLabel,
                    ReleaseYear = staticxMachine.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxMachine.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Cold",
                    RecordLabel = staticxMachine.RecordLabel,
                    ReleaseYear = staticxMachine.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxMachine.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Structural Defect",
                    RecordLabel = staticxMachine.RecordLabel,
                    ReleaseYear = staticxMachine.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxMachine.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "... In a Bag",
                    RecordLabel = staticxMachine.RecordLabel,
                    ReleaseYear = staticxMachine.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxMachine.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Burn to Burn",
                    RecordLabel = staticxMachine.RecordLabel,
                    ReleaseYear = staticxMachine.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxMachine.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Machine",
                    RecordLabel = staticxMachine.RecordLabel,
                    ReleaseYear = staticxMachine.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxMachine.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "A Dios Alma Perdida",
                    RecordLabel = staticxMachine.RecordLabel,
                    ReleaseYear = staticxMachine.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxMachine.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Destroy All",
                    RecordLabel = staticxShadowZone.RecordLabel,
                    ReleaseYear = staticxShadowZone.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxShadowZone.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Control It",
                    RecordLabel = staticxShadowZone.RecordLabel,
                    ReleaseYear = staticxShadowZone.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxShadowZone.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "New Plain",
                    RecordLabel = staticxShadowZone.RecordLabel,
                    ReleaseYear = staticxShadowZone.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxShadowZone.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Shadow Zone",
                    RecordLabel = staticxShadowZone.RecordLabel,
                    ReleaseYear = staticxShadowZone.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxShadowZone.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Dead World",
                    RecordLabel = staticxShadowZone.RecordLabel,
                    ReleaseYear = staticxShadowZone.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxShadowZone.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Monster",
                    RecordLabel = staticxShadowZone.RecordLabel,
                    ReleaseYear = staticxShadowZone.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxShadowZone.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "The Only",
                    RecordLabel = staticxShadowZone.RecordLabel,
                    ReleaseYear = staticxShadowZone.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxShadowZone.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Kill Your Idols",
                    RecordLabel = staticxShadowZone.RecordLabel,
                    ReleaseYear = staticxShadowZone.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxShadowZone.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "All in Wait",
                    RecordLabel = staticxShadowZone.RecordLabel,
                    ReleaseYear = staticxShadowZone.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxShadowZone.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Otsegolectric",
                    RecordLabel = staticxShadowZone.RecordLabel,
                    ReleaseYear = staticxShadowZone.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxShadowZone.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "So",
                    RecordLabel = staticxShadowZone.RecordLabel,
                    ReleaseYear = staticxShadowZone.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxShadowZone.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Transmission",
                    RecordLabel = staticxShadowZone.RecordLabel,
                    ReleaseYear = staticxShadowZone.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxShadowZone.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Invincible",
                    RecordLabel = staticxShadowZone.RecordLabel,
                    ReleaseYear = staticxShadowZone.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxShadowZone.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Gimme Gimme Shock Treatment",
                    RecordLabel = staticxShadowZone.RecordLabel,
                    ReleaseYear = staticxShadowZone.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxShadowZone.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "The Enemy",
                    RecordLabel = staticxStartAWar.RecordLabel,
                    ReleaseYear = staticxStartAWar.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxStartAWar.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "I'm the One",
                    RecordLabel = staticxStartAWar.RecordLabel,
                    ReleaseYear = staticxStartAWar.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxStartAWar.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Start a War",
                    RecordLabel = staticxStartAWar.RecordLabel,
                    ReleaseYear = staticxStartAWar.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxStartAWar.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Pieces",
                    RecordLabel = staticxStartAWar.RecordLabel,
                    ReleaseYear = staticxStartAWar.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxStartAWar.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Dirthouse",
                    RecordLabel = staticxStartAWar.RecordLabel,
                    ReleaseYear = staticxStartAWar.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxStartAWar.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Skinnyman",
                    RecordLabel = staticxStartAWar.RecordLabel,
                    ReleaseYear = staticxStartAWar.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxStartAWar.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Just in Case",
                    RecordLabel = staticxStartAWar.RecordLabel,
                    ReleaseYear = staticxStartAWar.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxStartAWar.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Set It Off",
                    RecordLabel = staticxStartAWar.RecordLabel,
                    ReleaseYear = staticxStartAWar.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxStartAWar.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "I Want to Fucking break It",
                    RecordLabel = staticxStartAWar.RecordLabel,
                    ReleaseYear = staticxStartAWar.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxStartAWar.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Night Terrors",
                    RecordLabel = staticxStartAWar.RecordLabel,
                    ReleaseYear = staticxStartAWar.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxStartAWar.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Otsego Amigo",
                    RecordLabel = staticxStartAWar.RecordLabel,
                    ReleaseYear = staticxStartAWar.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxStartAWar.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "My Damnation",
                    RecordLabel = staticxStartAWar.RecordLabel,
                    ReleaseYear = staticxStartAWar.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxStartAWar.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Brainfog",
                    RecordLabel = staticxStartAWar.RecordLabel,
                    ReleaseYear = staticxStartAWar.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxStartAWar.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Get to the Gone",
                    RecordLabel = staticxStartAWar.RecordLabel,
                    ReleaseYear = staticxStartAWar.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxStartAWar.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Cannibal",
                    RecordLabel = staticxCannibal.RecordLabel,
                    ReleaseYear = staticxCannibal.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxCannibal.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "No Submission",
                    RecordLabel = staticxCannibal.RecordLabel,
                    ReleaseYear = staticxCannibal.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxCannibal.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Behemoth",
                    RecordLabel = staticxCannibal.RecordLabel,
                    ReleaseYear = staticxCannibal.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxCannibal.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Chemical Logic",
                    RecordLabel = staticxCannibal.RecordLabel,
                    ReleaseYear = staticxCannibal.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxCannibal.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Destroyer",
                    RecordLabel = staticxCannibal.RecordLabel,
                    ReleaseYear = staticxCannibal.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxCannibal.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Forty Ways",
                    RecordLabel = staticxCannibal.RecordLabel,
                    ReleaseYear = staticxCannibal.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxCannibal.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Chroma-Matic",
                    RecordLabel = staticxCannibal.RecordLabel,
                    ReleaseYear = staticxCannibal.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxCannibal.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Cuts You Up",
                    RecordLabel = staticxCannibal.RecordLabel,
                    ReleaseYear = staticxCannibal.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxCannibal.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Reptile",
                    RecordLabel = staticxCannibal.RecordLabel,
                    ReleaseYear = staticxCannibal.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxCannibal.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Electric Pulse",
                    RecordLabel = staticxCannibal.RecordLabel,
                    ReleaseYear = staticxCannibal.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxCannibal.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Goat",
                    RecordLabel = staticxCannibal.RecordLabel,
                    ReleaseYear = staticxCannibal.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxCannibal.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Team Hate",
                    RecordLabel = staticxCannibal.RecordLabel,
                    ReleaseYear = staticxCannibal.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxCannibal.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Light It Up",
                    RecordLabel = staticxCannibal.RecordLabel,
                    ReleaseYear = staticxCannibal.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxCannibal.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "I'm the One",
                    RecordLabel = staticxCannibal.RecordLabel,
                    ReleaseYear = staticxCannibal.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxCannibal.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Get Up and Boogie",
                    RecordLabel = staticxCannibal.RecordLabel,
                    ReleaseYear = staticxCannibal.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxCannibal.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Beneath, Between, Beyond",
                    RecordLabel = staticxCannibal.RecordLabel,
                    ReleaseYear = staticxCannibal.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxCannibal.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Lunatic",
                    RecordLabel = staticxCultOfStatic.RecordLabel,
                    ReleaseYear = staticxCultOfStatic.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxCultOfStatic.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Z28",
                    RecordLabel = staticxCultOfStatic.RecordLabel,
                    ReleaseYear = staticxCultOfStatic.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxCultOfStatic.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Terminal",
                    RecordLabel = staticxCultOfStatic.RecordLabel,
                    ReleaseYear = staticxCultOfStatic.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxCultOfStatic.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Hypure",
                    RecordLabel = staticxCultOfStatic.RecordLabel,
                    ReleaseYear = staticxCultOfStatic.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxCultOfStatic.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Tera-Fied",
                    RecordLabel = staticxCultOfStatic.RecordLabel,
                    ReleaseYear = staticxCultOfStatic.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxCultOfStatic.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Stringwray",
                    RecordLabel = staticxCultOfStatic.RecordLabel,
                    ReleaseYear = staticxCultOfStatic.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxCultOfStatic.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "You Am I",
                    RecordLabel = staticxCultOfStatic.RecordLabel,
                    ReleaseYear = staticxCultOfStatic.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxCultOfStatic.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Isolaytore",
                    RecordLabel = staticxCultOfStatic.RecordLabel,
                    ReleaseYear = staticxCultOfStatic.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxCultOfStatic.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Nocturnally",
                    RecordLabel = staticxCultOfStatic.RecordLabel,
                    ReleaseYear = staticxCultOfStatic.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxCultOfStatic.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Skinned",
                    RecordLabel = staticxCultOfStatic.RecordLabel,
                    ReleaseYear = staticxCultOfStatic.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxCultOfStatic.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Grind 2 Halt",
                    RecordLabel = staticxCultOfStatic.RecordLabel,
                    ReleaseYear = staticxCultOfStatic.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxCultOfStatic.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Still of the Night",
                    RecordLabel = staticxCultOfStatic.RecordLabel,
                    ReleaseYear = staticxCultOfStatic.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxCultOfStatic.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "W.F.O",
                    RecordLabel = staticxCultOfStatic.RecordLabel,
                    ReleaseYear = staticxCultOfStatic.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxCultOfStatic.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Looks That Kill",
                    RecordLabel = staticxCultOfStatic.RecordLabel,
                    ReleaseYear = staticxCultOfStatic.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxCultOfStatic.AlbumId
                },
                new Song
                {
                    SongId = Guid.NewGuid(),
                    title = "Talk Dirty to Me",
                    RecordLabel = staticxCultOfStatic.RecordLabel,
                    ReleaseYear = staticxCultOfStatic.ReleaseYear,
                    AuthorId = staticX.AuthorId,
                    AlbumId = staticxCultOfStatic.AlbumId
                }
                );
        }
    }
}
