using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MusicStorageApi.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    AuthorId = table.Column<Guid>(nullable: false),
                    AuthorName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.AuthorId);
                });

            migrationBuilder.CreateTable(
                name: "Albums",
                columns: table => new
                {
                    AlbumId = table.Column<Guid>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    ReleaseYear = table.Column<string>(nullable: true),
                    RecordLabel = table.Column<string>(nullable: true),
                    Genre = table.Column<string>(nullable: true),
                    AuthorId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Albums", x => x.AlbumId);
                    table.ForeignKey(
                        name: "FK_Albums_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "AuthorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Songs",
                columns: table => new
                {
                    SongId = table.Column<Guid>(nullable: false),
                    title = table.Column<string>(nullable: true),
                    ReleaseYear = table.Column<string>(nullable: true),
                    RecordLabel = table.Column<string>(nullable: true),
                    AlbumId = table.Column<Guid>(nullable: true),
                    AuthorId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Songs", x => x.SongId);
                    table.ForeignKey(
                        name: "FK_Songs_Albums_AlbumId",
                        column: x => x.AlbumId,
                        principalTable: "Albums",
                        principalColumn: "AlbumId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Songs_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "AuthorId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "AuthorId", "AuthorName" },
                values: new object[] { new Guid("f7cf1610-6f8d-49c8-bfdf-17f69f75a133"), "Tool" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "AuthorId", "AuthorName" },
                values: new object[] { new Guid("06a9c3ac-d18e-42f3-8f9e-702c6c3778bb"), "Mastodon" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "AuthorId", "AuthorName" },
                values: new object[] { new Guid("705ec861-6190-49e8-b17d-1403bc222a5f"), "Static-X" });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "AlbumId", "AuthorId", "Genre", "RecordLabel", "ReleaseYear", "Title" },
                values: new object[,]
                {
                    { new Guid("dbab1a59-fd05-493c-92ec-22254ef64384"), new Guid("f7cf1610-6f8d-49c8-bfdf-17f69f75a133"), "Progressive Metal", "Zoo Entertainment", "1993", "Undertow" },
                    { new Guid("0b2f66ec-fb2e-4f5d-96cf-95d211908148"), new Guid("705ec861-6190-49e8-b17d-1403bc222a5f"), "Indastrial/Nu Metal", "Warner Bros Records", "2005", "Start a War" },
                    { new Guid("7c9c5fad-d074-4f02-9ff2-d1ca98d86d5d"), new Guid("705ec861-6190-49e8-b17d-1403bc222a5f"), "Indastrial/Nu Metal", "Warner Bros Records", "2003", "Shadow Zone" },
                    { new Guid("34b09efd-0e70-443b-a36a-1e9d07d92251"), new Guid("705ec861-6190-49e8-b17d-1403bc222a5f"), "Indastrial/Nu Metal", "Warner Bros Records", "2001", "Machine" },
                    { new Guid("89dd9054-b458-438e-8de5-eedd55145f9f"), new Guid("705ec861-6190-49e8-b17d-1403bc222a5f"), "Indastrial/Nu Metal", "Warner Bros Records", "1999", "Wisconsin Death Trip" },
                    { new Guid("2cf436d6-11bc-4cd6-9a8c-35eb937bc50a"), new Guid("06a9c3ac-d18e-42f3-8f9e-702c6c3778bb"), "Progressive Metal", "Reprise", "2017", "Emperor of Sand" },
                    { new Guid("94632667-4f79-4e1c-a74c-5a3a03ecb5fb"), new Guid("06a9c3ac-d18e-42f3-8f9e-702c6c3778bb"), "Progressive/Heavy Metal", "Reprise", "2014", "Once More 'Round the Sun" },
                    { new Guid("647438ca-14c7-48bf-b18d-38208bf00aa9"), new Guid("06a9c3ac-d18e-42f3-8f9e-702c6c3778bb"), "Heavy/Avant-Gard Metal", "Reprise/Roadrunner", "2011", "The Hunter" },
                    { new Guid("bfcf92c1-4279-434f-ad93-772c154d4e52"), new Guid("06a9c3ac-d18e-42f3-8f9e-702c6c3778bb"), "Alternative/Heavy Metal", "Reprise", "2009", "Crack The Skye" },
                    { new Guid("3a91e53f-6c21-4b74-8a5a-a40e3d8e4503"), new Guid("06a9c3ac-d18e-42f3-8f9e-702c6c3778bb"), "Progressive Metal", "Warner Bros./Reprise", "2006", "Blood Mountain" },
                    { new Guid("6158209a-772f-4a59-85b4-001db2cb31c3"), new Guid("06a9c3ac-d18e-42f3-8f9e-702c6c3778bb"), "Progressive/Heavy Metal", "Relapse", "2004", "Leviathan" },
                    { new Guid("737be9b4-abf9-4549-9b4c-67e33cb3d3a1"), new Guid("06a9c3ac-d18e-42f3-8f9e-702c6c3778bb"), "Progressive/Trash Metal", "Relapse", "2002", "Remission" },
                    { new Guid("3a2866c3-b880-4a09-80fb-672c99f4c64d"), new Guid("f7cf1610-6f8d-49c8-bfdf-17f69f75a133"), "Progressive Metal", "Tool Dissectional/Volcano Entertainment", "2019", "Fear Inoculum" },
                    { new Guid("9e335d61-e9d1-4fc5-b351-f72fc931836f"), new Guid("f7cf1610-6f8d-49c8-bfdf-17f69f75a133"), "Progressive Metal", "Tool Dissectional/Volcano Entertainment", "2006", "10,000 Days" },
                    { new Guid("d8897f73-d9bc-40dc-9331-80a7c892d88e"), new Guid("f7cf1610-6f8d-49c8-bfdf-17f69f75a133"), "Progressive Metal", "Volcano Entertainment", "2001", "Lateralus" },
                    { new Guid("08234bf9-73dd-4a82-a5e0-900d0eb7ee55"), new Guid("f7cf1610-6f8d-49c8-bfdf-17f69f75a133"), "Progressive Metal", "Zoo Entertainment", "1996", "AEnima" },
                    { new Guid("0b8b7c69-5e79-4212-bb95-d9278e646763"), new Guid("705ec861-6190-49e8-b17d-1403bc222a5f"), "Indastrial/Nu Metal", "Reprise Records", "2007", "Cannibal" },
                    { new Guid("3020bc0e-9c86-43be-ac4d-6e942509a8b7"), new Guid("705ec861-6190-49e8-b17d-1403bc222a5f"), "Indastrial/Nu Metal", "Reprise Records", "2009", "Cult of Static" }
                });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "SongId", "AlbumId", "AuthorId", "RecordLabel", "ReleaseYear", "title" },
                values: new object[,]
                {
                    { new Guid("8618f12e-2550-4bbe-b1a5-ecb1df27cd10"), new Guid("dbab1a59-fd05-493c-92ec-22254ef64384"), new Guid("f7cf1610-6f8d-49c8-bfdf-17f69f75a133"), "Zoo Entertainment", "1993", "Intolerance" },
                    { new Guid("1deb050c-be74-45f5-bbdb-62a64d808e54"), new Guid("89dd9054-b458-438e-8de5-eedd55145f9f"), new Guid("705ec861-6190-49e8-b17d-1403bc222a5f"), "Warner Bros Records", "1999", "Bled for Days" },
                    { new Guid("977b6754-b3d5-4320-8727-c957a37c2e60"), new Guid("89dd9054-b458-438e-8de5-eedd55145f9f"), new Guid("705ec861-6190-49e8-b17d-1403bc222a5f"), "Warner Bros Records", "1999", "Love Dump" },
                    { new Guid("a2e1ebf5-d188-40a7-a89e-39eed1905773"), new Guid("89dd9054-b458-438e-8de5-eedd55145f9f"), new Guid("705ec861-6190-49e8-b17d-1403bc222a5f"), "Warner Bros Records", "1999", "I Am" },
                    { new Guid("3c24feed-4a12-4be2-9c60-0673433b1f60"), new Guid("89dd9054-b458-438e-8de5-eedd55145f9f"), new Guid("705ec861-6190-49e8-b17d-1403bc222a5f"), "Warner Bros Records", "1999", "Otsegoldation" },
                    { new Guid("97880093-682d-4ca9-9391-0112ed67fa73"), new Guid("89dd9054-b458-438e-8de5-eedd55145f9f"), new Guid("705ec861-6190-49e8-b17d-1403bc222a5f"), "Warner Bros Records", "1999", "Stem" },
                    { new Guid("df0a4214-b285-4908-8d15-cbbe0a9a8b7a"), new Guid("89dd9054-b458-438e-8de5-eedd55145f9f"), new Guid("705ec861-6190-49e8-b17d-1403bc222a5f"), "Warner Bros Records", "1999", "Sweat of the Bud" },
                    { new Guid("7a89b516-7317-4059-b72f-ddfeeac989a9"), new Guid("89dd9054-b458-438e-8de5-eedd55145f9f"), new Guid("705ec861-6190-49e8-b17d-1403bc222a5f"), "Warner Bros Records", "1999", "Fix" },
                    { new Guid("6cb781cd-ae47-4a7c-9eff-367258670dea"), new Guid("89dd9054-b458-438e-8de5-eedd55145f9f"), new Guid("705ec861-6190-49e8-b17d-1403bc222a5f"), "Warner Bros Records", "1999", "Wisconsin Death Trip" },
                    { new Guid("cadedce4-57d4-4c31-9bfc-ea09853b4f85"), new Guid("89dd9054-b458-438e-8de5-eedd55145f9f"), new Guid("705ec861-6190-49e8-b17d-1403bc222a5f"), "Warner Bros Records", "1999", "December" },
                    { new Guid("de9ad262-bb48-48ce-88af-63a90e89e20b"), new Guid("89dd9054-b458-438e-8de5-eedd55145f9f"), new Guid("705ec861-6190-49e8-b17d-1403bc222a5f"), "Warner Bros Records", "1999", "Down" },
                    { new Guid("90395372-ffb5-4f6c-98fe-3118e238f5bc"), new Guid("34b09efd-0e70-443b-a36a-1e9d07d92251"), new Guid("705ec861-6190-49e8-b17d-1403bc222a5f"), "Warner Bros Records", "2001", "Bien Venidos" },
                    { new Guid("33f47430-1858-41e7-89d4-9ed925e8f509"), new Guid("34b09efd-0e70-443b-a36a-1e9d07d92251"), new Guid("705ec861-6190-49e8-b17d-1403bc222a5f"), "Warner Bros Records", "2001", "Get to the Gone" },
                    { new Guid("ba356c04-12d2-4262-a5b7-cea0dd859d08"), new Guid("34b09efd-0e70-443b-a36a-1e9d07d92251"), new Guid("705ec861-6190-49e8-b17d-1403bc222a5f"), "Warner Bros Records", "2001", "Permance" },
                    { new Guid("4a21d92e-7d05-4624-a52d-78822e296029"), new Guid("34b09efd-0e70-443b-a36a-1e9d07d92251"), new Guid("705ec861-6190-49e8-b17d-1403bc222a5f"), "Warner Bros Records", "2001", "Black and White" },
                    { new Guid("b8460df2-d24e-44e2-9d38-4ab48f8ae6a3"), new Guid("34b09efd-0e70-443b-a36a-1e9d07d92251"), new Guid("705ec861-6190-49e8-b17d-1403bc222a5f"), "Warner Bros Records", "2001", "This Is Not" },
                    { new Guid("582c4ff9-1e90-4553-81f0-865170941c59"), new Guid("34b09efd-0e70-443b-a36a-1e9d07d92251"), new Guid("705ec861-6190-49e8-b17d-1403bc222a5f"), "Warner Bros Records", "2001", "Otsego Undead" },
                    { new Guid("0372b81f-40b8-4c89-aca2-846690fa080b"), new Guid("34b09efd-0e70-443b-a36a-1e9d07d92251"), new Guid("705ec861-6190-49e8-b17d-1403bc222a5f"), "Warner Bros Records", "2001", "Cold" },
                    { new Guid("f09040e9-a86d-4fb9-a521-ab9128cb2349"), new Guid("34b09efd-0e70-443b-a36a-1e9d07d92251"), new Guid("705ec861-6190-49e8-b17d-1403bc222a5f"), "Warner Bros Records", "2001", "Structural Defect" },
                    { new Guid("aab169b4-717f-40f1-9902-9c2f9eb1ebf9"), new Guid("34b09efd-0e70-443b-a36a-1e9d07d92251"), new Guid("705ec861-6190-49e8-b17d-1403bc222a5f"), "Warner Bros Records", "2001", "... In a Bag" },
                    { new Guid("95d6e986-97f2-4923-baf0-924c588a2031"), new Guid("34b09efd-0e70-443b-a36a-1e9d07d92251"), new Guid("705ec861-6190-49e8-b17d-1403bc222a5f"), "Warner Bros Records", "2001", "Burn to Burn" },
                    { new Guid("a84b5bc8-ec3d-421b-96f7-9855701134ce"), new Guid("34b09efd-0e70-443b-a36a-1e9d07d92251"), new Guid("705ec861-6190-49e8-b17d-1403bc222a5f"), "Warner Bros Records", "2001", "Machine" },
                    { new Guid("636c5b9b-fe44-4b99-be4e-f58b78f0b2a0"), new Guid("34b09efd-0e70-443b-a36a-1e9d07d92251"), new Guid("705ec861-6190-49e8-b17d-1403bc222a5f"), "Warner Bros Records", "2001", "A Dios Alma Perdida" },
                    { new Guid("9a705670-596e-4a0b-ad34-5ac613450fe0"), new Guid("7c9c5fad-d074-4f02-9ff2-d1ca98d86d5d"), new Guid("705ec861-6190-49e8-b17d-1403bc222a5f"), "Warner Bros Records", "2003", "Destroy All" },
                    { new Guid("e28145d3-2259-440b-bd0f-49d87c1ab512"), new Guid("89dd9054-b458-438e-8de5-eedd55145f9f"), new Guid("705ec861-6190-49e8-b17d-1403bc222a5f"), "Warner Bros Records", "1999", "I'm with Stupid" },
                    { new Guid("78dddadf-296b-47ea-a000-0f409658d61e"), new Guid("89dd9054-b458-438e-8de5-eedd55145f9f"), new Guid("705ec861-6190-49e8-b17d-1403bc222a5f"), "Warner Bros Records", "1999", "Push It" },
                    { new Guid("96e9b160-9366-4a1c-803d-02ab23a26a4b"), new Guid("2cf436d6-11bc-4cd6-9a8c-35eb937bc50a"), new Guid("06a9c3ac-d18e-42f3-8f9e-702c6c3778bb"), "Reprise", "2017", "Jaguar God" },
                    { new Guid("b39c9a30-9755-4402-a0a2-3f71ac27b131"), new Guid("2cf436d6-11bc-4cd6-9a8c-35eb937bc50a"), new Guid("06a9c3ac-d18e-42f3-8f9e-702c6c3778bb"), "Reprise", "2017", "Scorpion Breath" },
                    { new Guid("782f81a1-cd7e-4412-95a7-59535f65ff85"), new Guid("647438ca-14c7-48bf-b18d-38208bf00aa9"), new Guid("06a9c3ac-d18e-42f3-8f9e-702c6c3778bb"), "Reprise/Roadrunner", "2011", "The Sparrow" },
                    { new Guid("d83cf672-c827-4a16-b0d3-d6ee9a0327f1"), new Guid("647438ca-14c7-48bf-b18d-38208bf00aa9"), new Guid("06a9c3ac-d18e-42f3-8f9e-702c6c3778bb"), "Reprise/Roadrunner", "2011", "The Ruiner" },
                    { new Guid("4c993cf0-d9c0-4e0e-8a7c-cee3c0158327"), new Guid("647438ca-14c7-48bf-b18d-38208bf00aa9"), new Guid("06a9c3ac-d18e-42f3-8f9e-702c6c3778bb"), "Reprise/Roadrunner", "2011", "Deathbound" },
                    { new Guid("fe8799c5-660c-4802-aab4-a33d79e7bed7"), new Guid("94632667-4f79-4e1c-a74c-5a3a03ecb5fb"), new Guid("06a9c3ac-d18e-42f3-8f9e-702c6c3778bb"), "Reprise", "2014", "Tread Lightly" },
                    { new Guid("df104ecb-2e0b-4852-9d79-f9b1106689cc"), new Guid("94632667-4f79-4e1c-a74c-5a3a03ecb5fb"), new Guid("06a9c3ac-d18e-42f3-8f9e-702c6c3778bb"), "Reprise", "2014", "The Motherload" },
                    { new Guid("47799697-8b37-46d7-9ca2-6bc76edcf873"), new Guid("94632667-4f79-4e1c-a74c-5a3a03ecb5fb"), new Guid("06a9c3ac-d18e-42f3-8f9e-702c6c3778bb"), "Reprise", "2014", "High Road" },
                    { new Guid("edaea173-db40-4e14-90b8-bf29b988dd44"), new Guid("94632667-4f79-4e1c-a74c-5a3a03ecb5fb"), new Guid("06a9c3ac-d18e-42f3-8f9e-702c6c3778bb"), "Reprise", "2014", "Once More 'Round the Sun" },
                    { new Guid("564f3a62-4c79-4235-8acf-f390ceacea80"), new Guid("94632667-4f79-4e1c-a74c-5a3a03ecb5fb"), new Guid("06a9c3ac-d18e-42f3-8f9e-702c6c3778bb"), "Reprise", "2014", "Chimes at Midnight" },
                    { new Guid("553bd8b3-8599-4a5c-9d83-c3c41b19719d"), new Guid("94632667-4f79-4e1c-a74c-5a3a03ecb5fb"), new Guid("06a9c3ac-d18e-42f3-8f9e-702c6c3778bb"), "Reprise", "2014", "Asleep in the Deep" },
                    { new Guid("f780187c-38c0-498f-b77e-a447626ceb9f"), new Guid("94632667-4f79-4e1c-a74c-5a3a03ecb5fb"), new Guid("06a9c3ac-d18e-42f3-8f9e-702c6c3778bb"), "Reprise", "2014", "Feast Your Eyes" },
                    { new Guid("2ec32955-79e2-4c52-a954-8892dad6ae32"), new Guid("94632667-4f79-4e1c-a74c-5a3a03ecb5fb"), new Guid("06a9c3ac-d18e-42f3-8f9e-702c6c3778bb"), "Reprise", "2014", "Aunt Lisa" },
                    { new Guid("195027b2-0ad2-489a-850a-82f05df648a4"), new Guid("7c9c5fad-d074-4f02-9ff2-d1ca98d86d5d"), new Guid("705ec861-6190-49e8-b17d-1403bc222a5f"), "Warner Bros Records", "2003", "Control It" },
                    { new Guid("46b2d522-68f0-42b8-a67b-cc35b6a66e0b"), new Guid("94632667-4f79-4e1c-a74c-5a3a03ecb5fb"), new Guid("06a9c3ac-d18e-42f3-8f9e-702c6c3778bb"), "Reprise", "2014", "Ember City" },
                    { new Guid("0202eba8-fe98-4d51-b6ad-5e99577bc2f2"), new Guid("94632667-4f79-4e1c-a74c-5a3a03ecb5fb"), new Guid("06a9c3ac-d18e-42f3-8f9e-702c6c3778bb"), "Reprise", "2014", "Diamond in the Witch House" },
                    { new Guid("f7d81470-ec09-4d8e-bd0d-0b3243454a98"), new Guid("2cf436d6-11bc-4cd6-9a8c-35eb937bc50a"), new Guid("06a9c3ac-d18e-42f3-8f9e-702c6c3778bb"), "Reprise", "2017", "Sultan's Curse" },
                    { new Guid("1f160bfd-c028-4d73-811d-d8f985354748"), new Guid("2cf436d6-11bc-4cd6-9a8c-35eb937bc50a"), new Guid("06a9c3ac-d18e-42f3-8f9e-702c6c3778bb"), "Reprise", "2017", "Show Yourself" },
                    { new Guid("2dae5502-3c7e-4a96-b98e-cc419a40d78a"), new Guid("2cf436d6-11bc-4cd6-9a8c-35eb937bc50a"), new Guid("06a9c3ac-d18e-42f3-8f9e-702c6c3778bb"), "Reprise", "2017", "Precious Stones" },
                    { new Guid("1f7a949b-f2f5-4f86-b445-36c47836e818"), new Guid("2cf436d6-11bc-4cd6-9a8c-35eb937bc50a"), new Guid("06a9c3ac-d18e-42f3-8f9e-702c6c3778bb"), "Reprise", "2017", "Steambreather" },
                    { new Guid("c25cfe72-186c-4218-a584-438d8f1c959b"), new Guid("2cf436d6-11bc-4cd6-9a8c-35eb937bc50a"), new Guid("06a9c3ac-d18e-42f3-8f9e-702c6c3778bb"), "Reprise", "2017", "Roots Remain" },
                    { new Guid("e47a74c6-1fd8-49c4-8968-70aa1606b7fa"), new Guid("2cf436d6-11bc-4cd6-9a8c-35eb937bc50a"), new Guid("06a9c3ac-d18e-42f3-8f9e-702c6c3778bb"), "Reprise", "2017", "Word to the Wise" },
                    { new Guid("e94a0f53-356c-40ce-91c4-f13327c2162f"), new Guid("2cf436d6-11bc-4cd6-9a8c-35eb937bc50a"), new Guid("06a9c3ac-d18e-42f3-8f9e-702c6c3778bb"), "Reprise", "2017", "Ancient to the Wise" },
                    { new Guid("381f1fba-206e-4f93-8b25-6f0a4066cc7e"), new Guid("2cf436d6-11bc-4cd6-9a8c-35eb937bc50a"), new Guid("06a9c3ac-d18e-42f3-8f9e-702c6c3778bb"), "Reprise", "2017", "Ancient Kingdom" },
                    { new Guid("461010e3-e0da-468f-b359-40f7eb313241"), new Guid("2cf436d6-11bc-4cd6-9a8c-35eb937bc50a"), new Guid("06a9c3ac-d18e-42f3-8f9e-702c6c3778bb"), "Reprise", "2017", "Cleandestiny" },
                    { new Guid("921de763-00a1-4a58-8982-624ff2e996a2"), new Guid("2cf436d6-11bc-4cd6-9a8c-35eb937bc50a"), new Guid("06a9c3ac-d18e-42f3-8f9e-702c6c3778bb"), "Reprise", "2017", "Andromeda" },
                    { new Guid("199dc05a-3b5a-4d36-a4c4-b96088adbb53"), new Guid("94632667-4f79-4e1c-a74c-5a3a03ecb5fb"), new Guid("06a9c3ac-d18e-42f3-8f9e-702c6c3778bb"), "Reprise", "2014", "Halloween" },
                    { new Guid("57467bc4-2897-49ed-9baf-23117c3efab9"), new Guid("7c9c5fad-d074-4f02-9ff2-d1ca98d86d5d"), new Guid("705ec861-6190-49e8-b17d-1403bc222a5f"), "Warner Bros Records", "2003", "New Plain" },
                    { new Guid("b3d8881f-507e-48a0-8f9f-c3e2a18ff3cc"), new Guid("7c9c5fad-d074-4f02-9ff2-d1ca98d86d5d"), new Guid("705ec861-6190-49e8-b17d-1403bc222a5f"), "Warner Bros Records", "2003", "Shadow Zone" },
                    { new Guid("7ab0cfbb-f6a1-4859-9425-39c51d0ae291"), new Guid("7c9c5fad-d074-4f02-9ff2-d1ca98d86d5d"), new Guid("705ec861-6190-49e8-b17d-1403bc222a5f"), "Warner Bros Records", "2003", "Dead World" },
                    { new Guid("fae8a937-973a-4e6f-b293-c4102030ae3c"), new Guid("0b8b7c69-5e79-4212-bb95-d9278e646763"), new Guid("705ec861-6190-49e8-b17d-1403bc222a5f"), "Reprise Records", "2007", "Forty Ways" },
                    { new Guid("2e9bb877-bac4-4499-a022-bd197846997d"), new Guid("0b8b7c69-5e79-4212-bb95-d9278e646763"), new Guid("705ec861-6190-49e8-b17d-1403bc222a5f"), "Reprise Records", "2007", "Chroma-Matic" },
                    { new Guid("7f502635-c7c0-4705-b8f6-2cdcccf82504"), new Guid("0b8b7c69-5e79-4212-bb95-d9278e646763"), new Guid("705ec861-6190-49e8-b17d-1403bc222a5f"), "Reprise Records", "2007", "Cuts You Up" },
                    { new Guid("68bd8c80-e67d-4d1c-8956-14409d238398"), new Guid("0b8b7c69-5e79-4212-bb95-d9278e646763"), new Guid("705ec861-6190-49e8-b17d-1403bc222a5f"), "Reprise Records", "2007", "Reptile" },
                    { new Guid("fb0cdb47-100d-4916-b5a4-5a3f89f61ac0"), new Guid("0b8b7c69-5e79-4212-bb95-d9278e646763"), new Guid("705ec861-6190-49e8-b17d-1403bc222a5f"), "Reprise Records", "2007", "Electric Pulse" },
                    { new Guid("0eb2d776-e07d-4b9f-9602-5d5846b985c1"), new Guid("0b8b7c69-5e79-4212-bb95-d9278e646763"), new Guid("705ec861-6190-49e8-b17d-1403bc222a5f"), "Reprise Records", "2007", "Goat" },
                    { new Guid("f8a8a70e-b720-4dc6-b295-94f73a4c7d50"), new Guid("0b8b7c69-5e79-4212-bb95-d9278e646763"), new Guid("705ec861-6190-49e8-b17d-1403bc222a5f"), "Reprise Records", "2007", "Team Hate" },
                    { new Guid("30191b31-df6a-4f37-9d5f-bf1fb8abb0f3"), new Guid("0b8b7c69-5e79-4212-bb95-d9278e646763"), new Guid("705ec861-6190-49e8-b17d-1403bc222a5f"), "Reprise Records", "2007", "Light It Up" },
                    { new Guid("f8229470-6cad-4b18-a0dc-8f03e7e459a0"), new Guid("0b8b7c69-5e79-4212-bb95-d9278e646763"), new Guid("705ec861-6190-49e8-b17d-1403bc222a5f"), "Reprise Records", "2007", "I'm the One" },
                    { new Guid("6b1c21d3-d772-47fc-85ac-2c00df286781"), new Guid("0b8b7c69-5e79-4212-bb95-d9278e646763"), new Guid("705ec861-6190-49e8-b17d-1403bc222a5f"), "Reprise Records", "2007", "Get Up and Boogie" },
                    { new Guid("a85cfd31-3115-4d1e-9587-e6ed033ad1cd"), new Guid("0b8b7c69-5e79-4212-bb95-d9278e646763"), new Guid("705ec861-6190-49e8-b17d-1403bc222a5f"), "Reprise Records", "2007", "Beneath, Between, Beyond" },
                    { new Guid("fc148398-c14e-4e34-bde4-e9d9cad6b1cd"), new Guid("0b8b7c69-5e79-4212-bb95-d9278e646763"), new Guid("705ec861-6190-49e8-b17d-1403bc222a5f"), "Reprise Records", "2007", "Destroyer" },
                    { new Guid("78b1ff47-4ca4-4377-9470-ff0da06367a1"), new Guid("3020bc0e-9c86-43be-ac4d-6e942509a8b7"), new Guid("705ec861-6190-49e8-b17d-1403bc222a5f"), "Reprise Records", "2009", "Lunatic" },
                    { new Guid("711b8505-8ebc-4bc8-b28a-0a26f93e29a6"), new Guid("3020bc0e-9c86-43be-ac4d-6e942509a8b7"), new Guid("705ec861-6190-49e8-b17d-1403bc222a5f"), "Reprise Records", "2009", "Terminal" },
                    { new Guid("0c5ac3f7-dfb2-4e01-83ec-93e721b0818a"), new Guid("3020bc0e-9c86-43be-ac4d-6e942509a8b7"), new Guid("705ec861-6190-49e8-b17d-1403bc222a5f"), "Reprise Records", "2009", "Hypure" },
                    { new Guid("d3db0669-5dab-41d0-bd2b-e17ae9b39a7c"), new Guid("3020bc0e-9c86-43be-ac4d-6e942509a8b7"), new Guid("705ec861-6190-49e8-b17d-1403bc222a5f"), "Reprise Records", "2009", "Tera-Fied" },
                    { new Guid("d3339c72-aed4-4f01-b4f5-ed6515fa5012"), new Guid("3020bc0e-9c86-43be-ac4d-6e942509a8b7"), new Guid("705ec861-6190-49e8-b17d-1403bc222a5f"), "Reprise Records", "2009", "Stringwray" },
                    { new Guid("2c0be969-2d2c-4ce4-a16f-9b693dba3f22"), new Guid("3020bc0e-9c86-43be-ac4d-6e942509a8b7"), new Guid("705ec861-6190-49e8-b17d-1403bc222a5f"), "Reprise Records", "2009", "You Am I" },
                    { new Guid("d51fae8d-25a9-4888-a8a3-322380c7adf4"), new Guid("3020bc0e-9c86-43be-ac4d-6e942509a8b7"), new Guid("705ec861-6190-49e8-b17d-1403bc222a5f"), "Reprise Records", "2009", "Isolaytore" },
                    { new Guid("9c12dd37-1e74-48b5-9683-d401fe4d7555"), new Guid("3020bc0e-9c86-43be-ac4d-6e942509a8b7"), new Guid("705ec861-6190-49e8-b17d-1403bc222a5f"), "Reprise Records", "2009", "Nocturnally" },
                    { new Guid("6c8fee1a-8951-40e7-b1f2-de0ff3896975"), new Guid("3020bc0e-9c86-43be-ac4d-6e942509a8b7"), new Guid("705ec861-6190-49e8-b17d-1403bc222a5f"), "Reprise Records", "2009", "Skinned" },
                    { new Guid("1d5d0ce5-6750-46c7-a55e-cb13c4aa2dbf"), new Guid("3020bc0e-9c86-43be-ac4d-6e942509a8b7"), new Guid("705ec861-6190-49e8-b17d-1403bc222a5f"), "Reprise Records", "2009", "Grind 2 Halt" },
                    { new Guid("07afadbe-5575-4065-9e87-83ed49e4463a"), new Guid("3020bc0e-9c86-43be-ac4d-6e942509a8b7"), new Guid("705ec861-6190-49e8-b17d-1403bc222a5f"), "Reprise Records", "2009", "Still of the Night" },
                    { new Guid("73d1a264-dee1-4c51-b8fa-859d4090a25c"), new Guid("3020bc0e-9c86-43be-ac4d-6e942509a8b7"), new Guid("705ec861-6190-49e8-b17d-1403bc222a5f"), "Reprise Records", "2009", "W.F.O" },
                    { new Guid("615cb7f0-0819-4ca3-8212-498a766ee3df"), new Guid("3020bc0e-9c86-43be-ac4d-6e942509a8b7"), new Guid("705ec861-6190-49e8-b17d-1403bc222a5f"), "Reprise Records", "2009", "Z28" },
                    { new Guid("d62d1b69-275f-4134-92d5-d8ef5757423c"), new Guid("647438ca-14c7-48bf-b18d-38208bf00aa9"), new Guid("06a9c3ac-d18e-42f3-8f9e-702c6c3778bb"), "Reprise/Roadrunner", "2011", "Bedazzled Fingernails" },
                    { new Guid("ed5608bd-533c-47fa-ad4a-11c2dca21494"), new Guid("0b8b7c69-5e79-4212-bb95-d9278e646763"), new Guid("705ec861-6190-49e8-b17d-1403bc222a5f"), "Reprise Records", "2007", "Chemical Logic" },
                    { new Guid("19d456ad-9429-483d-9998-b60476f11051"), new Guid("0b8b7c69-5e79-4212-bb95-d9278e646763"), new Guid("705ec861-6190-49e8-b17d-1403bc222a5f"), "Reprise Records", "2007", "No Submission" },
                    { new Guid("a16a5f03-2fa5-44c3-af31-21db77bde416"), new Guid("7c9c5fad-d074-4f02-9ff2-d1ca98d86d5d"), new Guid("705ec861-6190-49e8-b17d-1403bc222a5f"), "Warner Bros Records", "2003", "Monster" },
                    { new Guid("ed4b6a77-f03f-46a3-801c-f43d08ac8666"), new Guid("7c9c5fad-d074-4f02-9ff2-d1ca98d86d5d"), new Guid("705ec861-6190-49e8-b17d-1403bc222a5f"), "Warner Bros Records", "2003", "The Only" },
                    { new Guid("1e198efd-9fb6-4abb-a7ae-267331030add"), new Guid("7c9c5fad-d074-4f02-9ff2-d1ca98d86d5d"), new Guid("705ec861-6190-49e8-b17d-1403bc222a5f"), "Warner Bros Records", "2003", "Kill Your Idols" },
                    { new Guid("e517db70-dea3-4fa8-9cb7-3c1160464afe"), new Guid("7c9c5fad-d074-4f02-9ff2-d1ca98d86d5d"), new Guid("705ec861-6190-49e8-b17d-1403bc222a5f"), "Warner Bros Records", "2003", "All in Wait" },
                    { new Guid("87cb4f0f-613b-4e18-8b6b-ec48d5af9219"), new Guid("7c9c5fad-d074-4f02-9ff2-d1ca98d86d5d"), new Guid("705ec861-6190-49e8-b17d-1403bc222a5f"), "Warner Bros Records", "2003", "Otsegolectric" },
                    { new Guid("8f1a43f5-5bea-45d1-ba87-43df56e9f276"), new Guid("7c9c5fad-d074-4f02-9ff2-d1ca98d86d5d"), new Guid("705ec861-6190-49e8-b17d-1403bc222a5f"), "Warner Bros Records", "2003", "So" },
                    { new Guid("6ee8a528-f698-41b3-b9ae-4f3bf6a1287c"), new Guid("7c9c5fad-d074-4f02-9ff2-d1ca98d86d5d"), new Guid("705ec861-6190-49e8-b17d-1403bc222a5f"), "Warner Bros Records", "2003", "Transmission" },
                    { new Guid("34e9f3ec-41a5-4c1e-82a9-aeb9c5594b6b"), new Guid("7c9c5fad-d074-4f02-9ff2-d1ca98d86d5d"), new Guid("705ec861-6190-49e8-b17d-1403bc222a5f"), "Warner Bros Records", "2003", "Invincible" },
                    { new Guid("1deeb51c-f435-44d3-810e-c4a3b87b7a42"), new Guid("7c9c5fad-d074-4f02-9ff2-d1ca98d86d5d"), new Guid("705ec861-6190-49e8-b17d-1403bc222a5f"), "Warner Bros Records", "2003", "Gimme Gimme Shock Treatment" },
                    { new Guid("8a1f304f-3c1e-4971-958b-f7fa062f5058"), new Guid("0b2f66ec-fb2e-4f5d-96cf-95d211908148"), new Guid("705ec861-6190-49e8-b17d-1403bc222a5f"), "Warner Bros Records", "2005", "The Enemy" },
                    { new Guid("8fde39b0-8f38-44c7-b169-8e8f59d5aebe"), new Guid("0b2f66ec-fb2e-4f5d-96cf-95d211908148"), new Guid("705ec861-6190-49e8-b17d-1403bc222a5f"), "Warner Bros Records", "2005", "I'm the One" },
                    { new Guid("0c60ac04-8e97-4616-bc63-23b46e22b79c"), new Guid("0b8b7c69-5e79-4212-bb95-d9278e646763"), new Guid("705ec861-6190-49e8-b17d-1403bc222a5f"), "Reprise Records", "2007", "Behemoth" },
                    { new Guid("e514f40b-6959-4640-9a00-36a864cc493b"), new Guid("0b2f66ec-fb2e-4f5d-96cf-95d211908148"), new Guid("705ec861-6190-49e8-b17d-1403bc222a5f"), "Warner Bros Records", "2005", "Start a War" },
                    { new Guid("0623d7d4-8f13-4a67-b59a-9a1fc8f43f87"), new Guid("0b2f66ec-fb2e-4f5d-96cf-95d211908148"), new Guid("705ec861-6190-49e8-b17d-1403bc222a5f"), "Warner Bros Records", "2005", "Dirthouse" },
                    { new Guid("fd220627-e05a-4c50-bbdf-1aef5e040823"), new Guid("0b2f66ec-fb2e-4f5d-96cf-95d211908148"), new Guid("705ec861-6190-49e8-b17d-1403bc222a5f"), "Warner Bros Records", "2005", "Skinnyman" },
                    { new Guid("cb3502c9-7d78-442d-a7d7-6412ab4636d2"), new Guid("0b2f66ec-fb2e-4f5d-96cf-95d211908148"), new Guid("705ec861-6190-49e8-b17d-1403bc222a5f"), "Warner Bros Records", "2005", "Just in Case" },
                    { new Guid("c1b00850-1651-4a0f-aa99-2c7c77bd4931"), new Guid("0b2f66ec-fb2e-4f5d-96cf-95d211908148"), new Guid("705ec861-6190-49e8-b17d-1403bc222a5f"), "Warner Bros Records", "2005", "Set It Off" },
                    { new Guid("be2bb476-e308-4474-8838-3bb6f892e8eb"), new Guid("0b2f66ec-fb2e-4f5d-96cf-95d211908148"), new Guid("705ec861-6190-49e8-b17d-1403bc222a5f"), "Warner Bros Records", "2005", "I Want to Fucking break It" },
                    { new Guid("8c55622c-a274-426d-b965-8d251c6933b7"), new Guid("0b2f66ec-fb2e-4f5d-96cf-95d211908148"), new Guid("705ec861-6190-49e8-b17d-1403bc222a5f"), "Warner Bros Records", "2005", "Night Terrors" },
                    { new Guid("31290b21-629d-4001-96b0-cfe6f7e99908"), new Guid("0b2f66ec-fb2e-4f5d-96cf-95d211908148"), new Guid("705ec861-6190-49e8-b17d-1403bc222a5f"), "Warner Bros Records", "2005", "Otsego Amigo" },
                    { new Guid("bb782b07-2363-401b-b080-2b22d5ac7582"), new Guid("0b2f66ec-fb2e-4f5d-96cf-95d211908148"), new Guid("705ec861-6190-49e8-b17d-1403bc222a5f"), "Warner Bros Records", "2005", "My Damnation" },
                    { new Guid("6f3aaead-5709-4886-9a29-76dc34f97e27"), new Guid("0b2f66ec-fb2e-4f5d-96cf-95d211908148"), new Guid("705ec861-6190-49e8-b17d-1403bc222a5f"), "Warner Bros Records", "2005", "Brainfog" },
                    { new Guid("8d3488c8-6d5f-40f1-9994-2f9d520e21e7"), new Guid("0b2f66ec-fb2e-4f5d-96cf-95d211908148"), new Guid("705ec861-6190-49e8-b17d-1403bc222a5f"), "Warner Bros Records", "2005", "Get to the Gone" },
                    { new Guid("eef5365f-d472-4cd3-872c-777893ed08f7"), new Guid("0b8b7c69-5e79-4212-bb95-d9278e646763"), new Guid("705ec861-6190-49e8-b17d-1403bc222a5f"), "Reprise Records", "2007", "Cannibal" },
                    { new Guid("4f5d1a7e-9f49-4612-975c-bc068488f9bd"), new Guid("0b2f66ec-fb2e-4f5d-96cf-95d211908148"), new Guid("705ec861-6190-49e8-b17d-1403bc222a5f"), "Warner Bros Records", "2005", "Pieces" },
                    { new Guid("895aabb3-7c28-41c8-af8a-fe210fa61348"), new Guid("3020bc0e-9c86-43be-ac4d-6e942509a8b7"), new Guid("705ec861-6190-49e8-b17d-1403bc222a5f"), "Reprise Records", "2009", "Looks That Kill" },
                    { new Guid("20260f6e-2c30-4df3-b1de-104316c8548f"), new Guid("647438ca-14c7-48bf-b18d-38208bf00aa9"), new Guid("06a9c3ac-d18e-42f3-8f9e-702c6c3778bb"), "Reprise/Roadrunner", "2011", "Spectrelight" },
                    { new Guid("0ecda95c-8edc-4169-940a-9266e1062c9b"), new Guid("647438ca-14c7-48bf-b18d-38208bf00aa9"), new Guid("06a9c3ac-d18e-42f3-8f9e-702c6c3778bb"), "Reprise/Roadrunner", "2011", "Thickening" },
                    { new Guid("a184ca58-1d81-488b-bc58-4039ce032aac"), new Guid("d8897f73-d9bc-40dc-9331-80a7c892d88e"), new Guid("f7cf1610-6f8d-49c8-bfdf-17f69f75a133"), "Volcano Entertainment", "2001", "Mantra" },
                    { new Guid("f3678313-7636-49c3-876e-f44fa2952c34"), new Guid("d8897f73-d9bc-40dc-9331-80a7c892d88e"), new Guid("f7cf1610-6f8d-49c8-bfdf-17f69f75a133"), "Volcano Entertainment", "2001", "Schism" },
                    { new Guid("b3727929-7774-43af-a9c1-cceab3f12225"), new Guid("d8897f73-d9bc-40dc-9331-80a7c892d88e"), new Guid("f7cf1610-6f8d-49c8-bfdf-17f69f75a133"), "Volcano Entertainment", "2001", "Parabol" },
                    { new Guid("58895ebf-fc10-433a-a341-90fa36035ea2"), new Guid("d8897f73-d9bc-40dc-9331-80a7c892d88e"), new Guid("f7cf1610-6f8d-49c8-bfdf-17f69f75a133"), "Volcano Entertainment", "2001", "Parabola" },
                    { new Guid("798557df-e2f9-45a3-83e8-28781f12dc19"), new Guid("d8897f73-d9bc-40dc-9331-80a7c892d88e"), new Guid("f7cf1610-6f8d-49c8-bfdf-17f69f75a133"), "Volcano Entertainment", "2001", "Ticks & Leeches" },
                    { new Guid("77f62cf5-61a6-4c9c-aeeb-f2b389436538"), new Guid("d8897f73-d9bc-40dc-9331-80a7c892d88e"), new Guid("f7cf1610-6f8d-49c8-bfdf-17f69f75a133"), "Volcano Entertainment", "2001", "Lateralus" },
                    { new Guid("6fe6fe77-4735-4175-9ebd-b9533302d532"), new Guid("d8897f73-d9bc-40dc-9331-80a7c892d88e"), new Guid("f7cf1610-6f8d-49c8-bfdf-17f69f75a133"), "Volcano Entertainment", "2001", "Disposition" },
                    { new Guid("5a0186fa-d487-458a-a87b-c8989c669bf1"), new Guid("d8897f73-d9bc-40dc-9331-80a7c892d88e"), new Guid("f7cf1610-6f8d-49c8-bfdf-17f69f75a133"), "Volcano Entertainment", "2001", "Reflection" },
                    { new Guid("7ad44f66-1e92-4e1d-bd6d-ab855a3a9280"), new Guid("d8897f73-d9bc-40dc-9331-80a7c892d88e"), new Guid("f7cf1610-6f8d-49c8-bfdf-17f69f75a133"), "Volcano Entertainment", "2001", "Triad" },
                    { new Guid("1a375a1a-34e1-47fb-aa36-dfec0cadc23c"), new Guid("d8897f73-d9bc-40dc-9331-80a7c892d88e"), new Guid("f7cf1610-6f8d-49c8-bfdf-17f69f75a133"), "Volcano Entertainment", "2001", "Faaip de Oiad" },
                    { new Guid("6360f52a-8e68-4deb-9269-b65d1a2ad83a"), new Guid("9e335d61-e9d1-4fc5-b351-f72fc931836f"), new Guid("f7cf1610-6f8d-49c8-bfdf-17f69f75a133"), "Tool Dissectional/Volcano Entertainment", "2006", "Vicarious" },
                    { new Guid("14c90084-2d21-48fb-96ce-0d87991f30c8"), new Guid("9e335d61-e9d1-4fc5-b351-f72fc931836f"), new Guid("f7cf1610-6f8d-49c8-bfdf-17f69f75a133"), "Tool Dissectional/Volcano Entertainment", "2006", "Jambi" },
                    { new Guid("d40a1f46-f252-4ad6-bfb9-4280ca4f69b2"), new Guid("9e335d61-e9d1-4fc5-b351-f72fc931836f"), new Guid("f7cf1610-6f8d-49c8-bfdf-17f69f75a133"), "Tool Dissectional/Volcano Entertainment", "2006", "Wings for Marie" },
                    { new Guid("bffa022c-0c08-4fc3-89b7-8856b9b2dc5f"), new Guid("9e335d61-e9d1-4fc5-b351-f72fc931836f"), new Guid("f7cf1610-6f8d-49c8-bfdf-17f69f75a133"), "Tool Dissectional/Volcano Entertainment", "2006", "10,000 Days" },
                    { new Guid("27cb9520-6ae4-4f65-84b7-2c5f9d385dcd"), new Guid("9e335d61-e9d1-4fc5-b351-f72fc931836f"), new Guid("f7cf1610-6f8d-49c8-bfdf-17f69f75a133"), "Tool Dissectional/Volcano Entertainment", "2006", "The Pot" },
                    { new Guid("9669596e-5612-4732-9249-43879ce7bf43"), new Guid("9e335d61-e9d1-4fc5-b351-f72fc931836f"), new Guid("f7cf1610-6f8d-49c8-bfdf-17f69f75a133"), "Tool Dissectional/Volcano Entertainment", "2006", "Lipan Conjuring" },
                    { new Guid("83cfb3db-9d54-4532-974d-dcc22efdac2a"), new Guid("9e335d61-e9d1-4fc5-b351-f72fc931836f"), new Guid("f7cf1610-6f8d-49c8-bfdf-17f69f75a133"), "Tool Dissectional/Volcano Entertainment", "2006", "Lost Keys" },
                    { new Guid("4ebcc2a5-125c-49bd-a7ff-cd2827d1fe1c"), new Guid("9e335d61-e9d1-4fc5-b351-f72fc931836f"), new Guid("f7cf1610-6f8d-49c8-bfdf-17f69f75a133"), "Tool Dissectional/Volcano Entertainment", "2006", "Rosetta Stoned" },
                    { new Guid("6f0fc2c1-db4e-4e18-abe7-f0f991a1eae2"), new Guid("9e335d61-e9d1-4fc5-b351-f72fc931836f"), new Guid("f7cf1610-6f8d-49c8-bfdf-17f69f75a133"), "Tool Dissectional/Volcano Entertainment", "2006", "Intension" },
                    { new Guid("b35d37af-9dc5-4a54-8678-003db352af60"), new Guid("9e335d61-e9d1-4fc5-b351-f72fc931836f"), new Guid("f7cf1610-6f8d-49c8-bfdf-17f69f75a133"), "Tool Dissectional/Volcano Entertainment", "2006", "Right in Two" },
                    { new Guid("e69b6aa2-41d7-4e4b-b28e-fbee836f873a"), new Guid("9e335d61-e9d1-4fc5-b351-f72fc931836f"), new Guid("f7cf1610-6f8d-49c8-bfdf-17f69f75a133"), "Tool Dissectional/Volcano Entertainment", "2006", "Viginti Tres" },
                    { new Guid("1b7e7748-f117-413a-9f6e-b06123044ab2"), new Guid("3a2866c3-b880-4a09-80fb-672c99f4c64d"), new Guid("f7cf1610-6f8d-49c8-bfdf-17f69f75a133"), "Tool Dissectional/Volcano Entertainment", "2019", "Fear Inoculum" },
                    { new Guid("b0f278d0-302c-451c-8b63-a64a8669c79b"), new Guid("3a2866c3-b880-4a09-80fb-672c99f4c64d"), new Guid("f7cf1610-6f8d-49c8-bfdf-17f69f75a133"), "Tool Dissectional/Volcano Entertainment", "2019", "Pneuma" },
                    { new Guid("e094a1b2-0ed7-4824-9388-234043f692f2"), new Guid("d8897f73-d9bc-40dc-9331-80a7c892d88e"), new Guid("f7cf1610-6f8d-49c8-bfdf-17f69f75a133"), "Volcano Entertainment", "2001", "The Patient" },
                    { new Guid("8a8a4f5c-6593-4fe5-802a-fa8a8cda91e0"), new Guid("d8897f73-d9bc-40dc-9331-80a7c892d88e"), new Guid("f7cf1610-6f8d-49c8-bfdf-17f69f75a133"), "Volcano Entertainment", "2001", "Eon Blue Apocalypse" },
                    { new Guid("a3abed91-7fa3-4ebc-b799-c1864439806c"), new Guid("d8897f73-d9bc-40dc-9331-80a7c892d88e"), new Guid("f7cf1610-6f8d-49c8-bfdf-17f69f75a133"), "Volcano Entertainment", "2001", "The Grudge" },
                    { new Guid("6d3cad0d-f8a1-4fe7-b75c-bb1f01ce74f6"), new Guid("08234bf9-73dd-4a82-a5e0-900d0eb7ee55"), new Guid("f7cf1610-6f8d-49c8-bfdf-17f69f75a133"), "Zoo Entertainment", "1996", "Eulogy" },
                    { new Guid("8ab95bb1-c806-4b33-8135-aa613f259c9c"), new Guid("dbab1a59-fd05-493c-92ec-22254ef64384"), new Guid("f7cf1610-6f8d-49c8-bfdf-17f69f75a133"), "Zoo Entertainment", "1993", "Prison Sex" },
                    { new Guid("414c1061-4f77-4b3d-ac2a-11dbbacb9a63"), new Guid("dbab1a59-fd05-493c-92ec-22254ef64384"), new Guid("f7cf1610-6f8d-49c8-bfdf-17f69f75a133"), "Zoo Entertainment", "1993", "Sober" },
                    { new Guid("89b1a131-0247-4449-b53c-0cd85a3e0b5f"), new Guid("dbab1a59-fd05-493c-92ec-22254ef64384"), new Guid("f7cf1610-6f8d-49c8-bfdf-17f69f75a133"), "Zoo Entertainment", "1993", "Bottom" },
                    { new Guid("4d3a7104-a564-426e-bd28-b2447e922251"), new Guid("dbab1a59-fd05-493c-92ec-22254ef64384"), new Guid("f7cf1610-6f8d-49c8-bfdf-17f69f75a133"), "Zoo Entertainment", "1993", "Crawl Away" },
                    { new Guid("06565dd0-92b6-4de8-b138-2b13577b4e32"), new Guid("dbab1a59-fd05-493c-92ec-22254ef64384"), new Guid("f7cf1610-6f8d-49c8-bfdf-17f69f75a133"), "Zoo Entertainment", "1993", "Swamp Song" },
                    { new Guid("47f96f0b-68f1-449f-8fff-1adaa32ff3bf"), new Guid("dbab1a59-fd05-493c-92ec-22254ef64384"), new Guid("f7cf1610-6f8d-49c8-bfdf-17f69f75a133"), "Zoo Entertainment", "1993", "Undertow" },
                    { new Guid("92e5c253-4b94-402c-ab7f-7c542b80df1c"), new Guid("dbab1a59-fd05-493c-92ec-22254ef64384"), new Guid("f7cf1610-6f8d-49c8-bfdf-17f69f75a133"), "Zoo Entertainment", "1993", "4degree" },
                    { new Guid("33090bde-dc8b-4447-aa72-512bcffb7a26"), new Guid("dbab1a59-fd05-493c-92ec-22254ef64384"), new Guid("f7cf1610-6f8d-49c8-bfdf-17f69f75a133"), "Zoo Entertainment", "1993", "Flood" },
                    { new Guid("c6db84ba-14c9-4fea-b2ef-62874671be8e"), new Guid("dbab1a59-fd05-493c-92ec-22254ef64384"), new Guid("f7cf1610-6f8d-49c8-bfdf-17f69f75a133"), "Zoo Entertainment", "1993", "Disgustipated" },
                    { new Guid("a4118b7e-bb29-4881-b024-f8161bbe04a9"), new Guid("08234bf9-73dd-4a82-a5e0-900d0eb7ee55"), new Guid("f7cf1610-6f8d-49c8-bfdf-17f69f75a133"), "Zoo Entertainment", "1996", "Stinkfist" },
                    { new Guid("ef8e5513-0def-4cb7-befa-380a26c57d71"), new Guid("08234bf9-73dd-4a82-a5e0-900d0eb7ee55"), new Guid("f7cf1610-6f8d-49c8-bfdf-17f69f75a133"), "Zoo Entertainment", "1996", "Eulogy" },
                    { new Guid("14d75eeb-596b-4a7e-8b30-d6ea1d6aa98a"), new Guid("3a2866c3-b880-4a09-80fb-672c99f4c64d"), new Guid("f7cf1610-6f8d-49c8-bfdf-17f69f75a133"), "Tool Dissectional/Volcano Entertainment", "2019", "Litanie contre la peur" },
                    { new Guid("2c484d6b-bdf4-4234-bfe1-bbaddac7eaa2"), new Guid("08234bf9-73dd-4a82-a5e0-900d0eb7ee55"), new Guid("f7cf1610-6f8d-49c8-bfdf-17f69f75a133"), "Zoo Entertainment", "1996", "H." },
                    { new Guid("ee50be2c-237c-4894-a95a-85c4326d4f8b"), new Guid("08234bf9-73dd-4a82-a5e0-900d0eb7ee55"), new Guid("f7cf1610-6f8d-49c8-bfdf-17f69f75a133"), "Zoo Entertainment", "1996", "Forty Six & 2" },
                    { new Guid("7309a18b-504d-4940-9097-22751639e073"), new Guid("08234bf9-73dd-4a82-a5e0-900d0eb7ee55"), new Guid("f7cf1610-6f8d-49c8-bfdf-17f69f75a133"), "Zoo Entertainment", "1996", "Message to Harry Manback" },
                    { new Guid("bd69742a-2664-4f42-8c3b-8422a9e4f42d"), new Guid("08234bf9-73dd-4a82-a5e0-900d0eb7ee55"), new Guid("f7cf1610-6f8d-49c8-bfdf-17f69f75a133"), "Zoo Entertainment", "1996", "Hooker with a Denis" },
                    { new Guid("76ed54a2-3658-47b3-b4df-9bf3da945880"), new Guid("08234bf9-73dd-4a82-a5e0-900d0eb7ee55"), new Guid("f7cf1610-6f8d-49c8-bfdf-17f69f75a133"), "Zoo Entertainment", "1996", "Intermission" },
                    { new Guid("a83826f4-4b54-40b8-bfbf-c64c51cfc748"), new Guid("08234bf9-73dd-4a82-a5e0-900d0eb7ee55"), new Guid("f7cf1610-6f8d-49c8-bfdf-17f69f75a133"), "Zoo Entertainment", "1996", "jimmy" },
                    { new Guid("a349836c-afcb-4347-af31-8531f88c836f"), new Guid("08234bf9-73dd-4a82-a5e0-900d0eb7ee55"), new Guid("f7cf1610-6f8d-49c8-bfdf-17f69f75a133"), "Zoo Entertainment", "1996", "Die Eier von Satan" },
                    { new Guid("5cf7f7b3-8101-472e-ac1e-9a3576f8195d"), new Guid("08234bf9-73dd-4a82-a5e0-900d0eb7ee55"), new Guid("f7cf1610-6f8d-49c8-bfdf-17f69f75a133"), "Zoo Entertainment", "1996", "Pushit" },
                    { new Guid("6819f0ed-c89e-4ecb-911d-4ed72672ecb3"), new Guid("08234bf9-73dd-4a82-a5e0-900d0eb7ee55"), new Guid("f7cf1610-6f8d-49c8-bfdf-17f69f75a133"), "Zoo Entertainment", "1996", "Cesaro Summability" },
                    { new Guid("85c1b774-049d-4f59-9898-664790d49cfe"), new Guid("08234bf9-73dd-4a82-a5e0-900d0eb7ee55"), new Guid("f7cf1610-6f8d-49c8-bfdf-17f69f75a133"), "Zoo Entertainment", "1996", "AEnema" },
                    { new Guid("f9b1550c-c8e0-4115-8d24-811e069c39d2"), new Guid("08234bf9-73dd-4a82-a5e0-900d0eb7ee55"), new Guid("f7cf1610-6f8d-49c8-bfdf-17f69f75a133"), "Zoo Entertainment", "1996", "(-) Ions" },
                    { new Guid("c9e92768-5fbf-49f7-85d9-34496f8207d3"), new Guid("08234bf9-73dd-4a82-a5e0-900d0eb7ee55"), new Guid("f7cf1610-6f8d-49c8-bfdf-17f69f75a133"), "Zoo Entertainment", "1996", "Third Eye" },
                    { new Guid("a88e62d2-9095-4008-977d-a554839c01a4"), new Guid("08234bf9-73dd-4a82-a5e0-900d0eb7ee55"), new Guid("f7cf1610-6f8d-49c8-bfdf-17f69f75a133"), "Zoo Entertainment", "1996", "Useful Idiot" },
                    { new Guid("7bfba345-c671-4dc5-8030-346294185594"), new Guid("3a2866c3-b880-4a09-80fb-672c99f4c64d"), new Guid("f7cf1610-6f8d-49c8-bfdf-17f69f75a133"), "Tool Dissectional/Volcano Entertainment", "2019", "Invincible" },
                    { new Guid("2936e152-c61d-475e-b310-85d80f67c271"), new Guid("3a2866c3-b880-4a09-80fb-672c99f4c64d"), new Guid("f7cf1610-6f8d-49c8-bfdf-17f69f75a133"), "Tool Dissectional/Volcano Entertainment", "2019", "Legion Inoculant" },
                    { new Guid("c173cfa2-5977-4dfc-9704-9080bd1419c8"), new Guid("3a2866c3-b880-4a09-80fb-672c99f4c64d"), new Guid("f7cf1610-6f8d-49c8-bfdf-17f69f75a133"), "Tool Dissectional/Volcano Entertainment", "2019", "Descending" },
                    { new Guid("91815817-85c3-48be-9234-6b913ac3ffea"), new Guid("3a91e53f-6c21-4b74-8a5a-a40e3d8e4503"), new Guid("06a9c3ac-d18e-42f3-8f9e-702c6c3778bb"), "Warner Bros./Reprise", "2006", "Capillarian Crest" },
                    { new Guid("71007f95-569a-4857-a651-de17906a360d"), new Guid("3a91e53f-6c21-4b74-8a5a-a40e3d8e4503"), new Guid("06a9c3ac-d18e-42f3-8f9e-702c6c3778bb"), "Warner Bros./Reprise", "2006", "Circle of Cysquatch" },
                    { new Guid("4fca321d-5e72-47f1-aee1-534fd923221d"), new Guid("3a91e53f-6c21-4b74-8a5a-a40e3d8e4503"), new Guid("06a9c3ac-d18e-42f3-8f9e-702c6c3778bb"), "Warner Bros./Reprise", "2006", "Bladecatcher" },
                    { new Guid("9f227659-1d27-40ab-b4d5-44e5dacc30ae"), new Guid("3a91e53f-6c21-4b74-8a5a-a40e3d8e4503"), new Guid("06a9c3ac-d18e-42f3-8f9e-702c6c3778bb"), "Warner Bros./Reprise", "2006", "Colony of Birchmen" },
                    { new Guid("3bd45a9d-6243-4958-a0bd-4650ccb65734"), new Guid("3a91e53f-6c21-4b74-8a5a-a40e3d8e4503"), new Guid("06a9c3ac-d18e-42f3-8f9e-702c6c3778bb"), "Warner Bros./Reprise", "2006", "Hunters of the Sky" },
                    { new Guid("231cdfd7-3c9d-48fe-af7b-d616d0dcdc22"), new Guid("3a91e53f-6c21-4b74-8a5a-a40e3d8e4503"), new Guid("06a9c3ac-d18e-42f3-8f9e-702c6c3778bb"), "Warner Bros./Reprise", "2006", "Hand of Stone" },
                    { new Guid("3c26e577-c31d-4c4e-9947-2a47184c11ec"), new Guid("3a91e53f-6c21-4b74-8a5a-a40e3d8e4503"), new Guid("06a9c3ac-d18e-42f3-8f9e-702c6c3778bb"), "Warner Bros./Reprise", "2006", "This Mortal Soil" },
                    { new Guid("336fc79f-f240-4b2f-897a-221959dbca05"), new Guid("3a91e53f-6c21-4b74-8a5a-a40e3d8e4503"), new Guid("06a9c3ac-d18e-42f3-8f9e-702c6c3778bb"), "Warner Bros./Reprise", "2006", "Siberian Divide" },
                    { new Guid("b298e04e-e182-4749-ab5c-60b4f0333964"), new Guid("3a91e53f-6c21-4b74-8a5a-a40e3d8e4503"), new Guid("06a9c3ac-d18e-42f3-8f9e-702c6c3778bb"), "Warner Bros./Reprise", "2006", "Pendulous Skin" },
                    { new Guid("8dc59afd-aab1-4981-9ef8-926763684ed0"), new Guid("bfcf92c1-4279-434f-ad93-772c154d4e52"), new Guid("06a9c3ac-d18e-42f3-8f9e-702c6c3778bb"), "Reprise", "2009", "Oblivion" },
                    { new Guid("b83cf277-2761-4aaf-8320-52c5526f28c1"), new Guid("bfcf92c1-4279-434f-ad93-772c154d4e52"), new Guid("06a9c3ac-d18e-42f3-8f9e-702c6c3778bb"), "Reprise", "2009", "Divinations" },
                    { new Guid("d2f86f4d-5f39-4f9d-92c3-d6165cd67c34"), new Guid("3a91e53f-6c21-4b74-8a5a-a40e3d8e4503"), new Guid("06a9c3ac-d18e-42f3-8f9e-702c6c3778bb"), "Warner Bros./Reprise", "2006", "Sleeping Giant" },
                    { new Guid("779f7060-5c83-421c-93c6-2d14034c0627"), new Guid("bfcf92c1-4279-434f-ad93-772c154d4e52"), new Guid("06a9c3ac-d18e-42f3-8f9e-702c6c3778bb"), "Reprise", "2009", "Quintessence" },
                    { new Guid("5961ea37-1bae-45e7-bffb-1823609ae9ea"), new Guid("bfcf92c1-4279-434f-ad93-772c154d4e52"), new Guid("06a9c3ac-d18e-42f3-8f9e-702c6c3778bb"), "Reprise", "2009", "Ghost of Karelia" },
                    { new Guid("eb795c83-906e-49c0-a53f-02f51cefb3dd"), new Guid("bfcf92c1-4279-434f-ad93-772c154d4e52"), new Guid("06a9c3ac-d18e-42f3-8f9e-702c6c3778bb"), "Reprise", "2009", "Crack the Skye" },
                    { new Guid("dda3887a-acd6-4c91-9a00-677b905cf5df"), new Guid("bfcf92c1-4279-434f-ad93-772c154d4e52"), new Guid("06a9c3ac-d18e-42f3-8f9e-702c6c3778bb"), "Reprise", "2009", "The Last Baron" },
                    { new Guid("13979b20-5560-4a2d-95d4-bf7f729a7f9d"), new Guid("647438ca-14c7-48bf-b18d-38208bf00aa9"), new Guid("06a9c3ac-d18e-42f3-8f9e-702c6c3778bb"), "Reprise/Roadrunner", "2011", "Black Tongue" },
                    { new Guid("1a239a4d-f3a9-481f-8c58-a8224cded543"), new Guid("647438ca-14c7-48bf-b18d-38208bf00aa9"), new Guid("06a9c3ac-d18e-42f3-8f9e-702c6c3778bb"), "Reprise/Roadrunner", "2011", "Curl of the Buri" },
                    { new Guid("001d8ea5-352a-4503-b1dc-79376bc619f1"), new Guid("647438ca-14c7-48bf-b18d-38208bf00aa9"), new Guid("06a9c3ac-d18e-42f3-8f9e-702c6c3778bb"), "Reprise/Roadrunner", "2011", "Blasteroid" },
                    { new Guid("e6b6022b-11f6-4ce8-b4c7-6dc59bedc3f4"), new Guid("647438ca-14c7-48bf-b18d-38208bf00aa9"), new Guid("06a9c3ac-d18e-42f3-8f9e-702c6c3778bb"), "Reprise/Roadrunner", "2011", "Stargasm" },
                    { new Guid("0e18909d-33f1-47ec-b4fb-a0fcbb3f79f5"), new Guid("647438ca-14c7-48bf-b18d-38208bf00aa9"), new Guid("06a9c3ac-d18e-42f3-8f9e-702c6c3778bb"), "Reprise/Roadrunner", "2011", "Octupus Has No Friends" },
                    { new Guid("50178b15-5667-494a-b629-212ce5cf4c3c"), new Guid("647438ca-14c7-48bf-b18d-38208bf00aa9"), new Guid("06a9c3ac-d18e-42f3-8f9e-702c6c3778bb"), "Reprise/Roadrunner", "2011", "All the Heavy Lifting" },
                    { new Guid("324a8f3f-7ef7-40bb-9ade-75bf2198bf45"), new Guid("647438ca-14c7-48bf-b18d-38208bf00aa9"), new Guid("06a9c3ac-d18e-42f3-8f9e-702c6c3778bb"), "Reprise/Roadrunner", "2011", "The Hunter" },
                    { new Guid("89268adc-334c-4762-a124-e6f86c9afd62"), new Guid("647438ca-14c7-48bf-b18d-38208bf00aa9"), new Guid("06a9c3ac-d18e-42f3-8f9e-702c6c3778bb"), "Reprise/Roadrunner", "2011", "Dry Bone Valley" },
                    { new Guid("e6d76e30-b076-48fa-85db-ac31bdcc84a2"), new Guid("bfcf92c1-4279-434f-ad93-772c154d4e52"), new Guid("06a9c3ac-d18e-42f3-8f9e-702c6c3778bb"), "Reprise", "2009", "The Czar" },
                    { new Guid("360a6e68-bcd6-47b4-add5-88271025571f"), new Guid("647438ca-14c7-48bf-b18d-38208bf00aa9"), new Guid("06a9c3ac-d18e-42f3-8f9e-702c6c3778bb"), "Reprise/Roadrunner", "2011", "Creature Lives" },
                    { new Guid("f40390f3-42a4-48f1-9387-1b2b8c313994"), new Guid("3a91e53f-6c21-4b74-8a5a-a40e3d8e4503"), new Guid("06a9c3ac-d18e-42f3-8f9e-702c6c3778bb"), "Warner Bros./Reprise", "2006", "Crystal Skull" },
                    { new Guid("216a57a0-ea42-4990-94c5-50a404c8cb3c"), new Guid("6158209a-772f-4a59-85b4-001db2cb31c3"), new Guid("06a9c3ac-d18e-42f3-8f9e-702c6c3778bb"), "Relapse", "2004", "Joseph Merrick" },
                    { new Guid("a450a54c-ec78-4747-aa9c-278936f161c8"), new Guid("3a2866c3-b880-4a09-80fb-672c99f4c64d"), new Guid("f7cf1610-6f8d-49c8-bfdf-17f69f75a133"), "Tool Dissectional/Volcano Entertainment", "2019", "Culling Voices" },
                    { new Guid("167b67de-ecfc-4d13-9b43-e7d9712c7607"), new Guid("3a2866c3-b880-4a09-80fb-672c99f4c64d"), new Guid("f7cf1610-6f8d-49c8-bfdf-17f69f75a133"), "Tool Dissectional/Volcano Entertainment", "2019", "Chocolate Chip Trip" },
                    { new Guid("2b438cf7-3a88-4e48-a5bd-a25c60633119"), new Guid("3a2866c3-b880-4a09-80fb-672c99f4c64d"), new Guid("f7cf1610-6f8d-49c8-bfdf-17f69f75a133"), "Tool Dissectional/Volcano Entertainment", "2019", "7empest" },
                    { new Guid("687874d3-5c72-4e0a-b653-7ff45e0e3756"), new Guid("3a2866c3-b880-4a09-80fb-672c99f4c64d"), new Guid("f7cf1610-6f8d-49c8-bfdf-17f69f75a133"), "Tool Dissectional/Volcano Entertainment", "2019", "Mockingbeat" },
                    { new Guid("439eb316-5c3d-4528-b0d2-b6b15d67f186"), new Guid("737be9b4-abf9-4549-9b4c-67e33cb3d3a1"), new Guid("06a9c3ac-d18e-42f3-8f9e-702c6c3778bb"), "Relapse", "2002", "Crusher Destroyer" },
                    { new Guid("5c85301f-0d6f-4d97-ac0f-4fe9e1879f1a"), new Guid("737be9b4-abf9-4549-9b4c-67e33cb3d3a1"), new Guid("06a9c3ac-d18e-42f3-8f9e-702c6c3778bb"), "Relapse", "2002", "March of the Fire Ants" },
                    { new Guid("0972e056-9280-4732-9b07-e4a093abb6ea"), new Guid("737be9b4-abf9-4549-9b4c-67e33cb3d3a1"), new Guid("06a9c3ac-d18e-42f3-8f9e-702c6c3778bb"), "Relapse", "2002", "Where Strides the Behemoth" },
                    { new Guid("747d1a90-eea9-4bfc-ae41-16ab28a18d36"), new Guid("737be9b4-abf9-4549-9b4c-67e33cb3d3a1"), new Guid("06a9c3ac-d18e-42f3-8f9e-702c6c3778bb"), "Relapse", "2002", "Workhorse" },
                    { new Guid("655de9a2-6ea8-4650-9e51-4cb0e1b7c092"), new Guid("737be9b4-abf9-4549-9b4c-67e33cb3d3a1"), new Guid("06a9c3ac-d18e-42f3-8f9e-702c6c3778bb"), "Relapse", "2002", "Ol'e Nessie" },
                    { new Guid("af483cdf-86c1-4845-80f1-4dc0a1fa9c79"), new Guid("737be9b4-abf9-4549-9b4c-67e33cb3d3a1"), new Guid("06a9c3ac-d18e-42f3-8f9e-702c6c3778bb"), "Relapse", "2002", "Burning Man" },
                    { new Guid("3a3a97fe-4006-4fa7-b336-9ba933a88fd0"), new Guid("737be9b4-abf9-4549-9b4c-67e33cb3d3a1"), new Guid("06a9c3ac-d18e-42f3-8f9e-702c6c3778bb"), "Relapse", "2002", "Trainwreck" },
                    { new Guid("c929cfd1-eb4a-4afc-acc7-16ed0a19346b"), new Guid("3a91e53f-6c21-4b74-8a5a-a40e3d8e4503"), new Guid("06a9c3ac-d18e-42f3-8f9e-702c6c3778bb"), "Warner Bros./Reprise", "2006", "The Wolf Is Loose" },
                    { new Guid("eab139d1-d4c7-42e4-b0d4-8485da869b53"), new Guid("737be9b4-abf9-4549-9b4c-67e33cb3d3a1"), new Guid("06a9c3ac-d18e-42f3-8f9e-702c6c3778bb"), "Relapse", "2002", "Trempled Under Hoof" },
                    { new Guid("fdcc7e33-e8c1-4fc5-b7ae-49d2ce6086d6"), new Guid("737be9b4-abf9-4549-9b4c-67e33cb3d3a1"), new Guid("06a9c3ac-d18e-42f3-8f9e-702c6c3778bb"), "Relapse", "2002", "Mother Puncher" },
                    { new Guid("c970d720-ef07-4695-8825-09604070ac00"), new Guid("737be9b4-abf9-4549-9b4c-67e33cb3d3a1"), new Guid("06a9c3ac-d18e-42f3-8f9e-702c6c3778bb"), "Relapse", "2002", "Elephant Man" },
                    { new Guid("f0baa546-a00f-4f8e-a74d-8bb6450ab289"), new Guid("6158209a-772f-4a59-85b4-001db2cb31c3"), new Guid("06a9c3ac-d18e-42f3-8f9e-702c6c3778bb"), "Relapse", "2004", "Blood and Thunder" },
                    { new Guid("c6c3b6bd-4940-44cd-b0c4-dbd61a73231f"), new Guid("6158209a-772f-4a59-85b4-001db2cb31c3"), new Guid("06a9c3ac-d18e-42f3-8f9e-702c6c3778bb"), "Relapse", "2004", "I Am Ahab" },
                    { new Guid("659958e3-ac92-42d7-b8a4-dbf757b471a6"), new Guid("6158209a-772f-4a59-85b4-001db2cb31c3"), new Guid("06a9c3ac-d18e-42f3-8f9e-702c6c3778bb"), "Relapse", "2004", "Seabeast" },
                    { new Guid("b1401a4c-82eb-4dce-86ad-3f00456d3743"), new Guid("6158209a-772f-4a59-85b4-001db2cb31c3"), new Guid("06a9c3ac-d18e-42f3-8f9e-702c6c3778bb"), "Relapse", "2004", "Island" },
                    { new Guid("5576b582-48f9-4bbb-a67b-7c98a42ea431"), new Guid("6158209a-772f-4a59-85b4-001db2cb31c3"), new Guid("06a9c3ac-d18e-42f3-8f9e-702c6c3778bb"), "Relapse", "2004", "Iron Tusk" },
                    { new Guid("7aa76b04-bbbf-42b8-a546-9121a663ff7f"), new Guid("6158209a-772f-4a59-85b4-001db2cb31c3"), new Guid("06a9c3ac-d18e-42f3-8f9e-702c6c3778bb"), "Relapse", "2004", "Megalodon" },
                    { new Guid("d632426b-7357-4144-822b-664d5915b82d"), new Guid("6158209a-772f-4a59-85b4-001db2cb31c3"), new Guid("06a9c3ac-d18e-42f3-8f9e-702c6c3778bb"), "Relapse", "2004", "Naked Burn" },
                    { new Guid("79689381-0732-4a86-b4d5-a4a2bf7a298f"), new Guid("6158209a-772f-4a59-85b4-001db2cb31c3"), new Guid("06a9c3ac-d18e-42f3-8f9e-702c6c3778bb"), "Relapse", "2004", "Aqua Dementia" },
                    { new Guid("d1fe3353-591f-4a16-9a3e-8bd727876192"), new Guid("6158209a-772f-4a59-85b4-001db2cb31c3"), new Guid("06a9c3ac-d18e-42f3-8f9e-702c6c3778bb"), "Relapse", "2004", "Hearts Alive" },
                    { new Guid("24170980-24e8-40e5-b2d3-e63b5286b6f6"), new Guid("737be9b4-abf9-4549-9b4c-67e33cb3d3a1"), new Guid("06a9c3ac-d18e-42f3-8f9e-702c6c3778bb"), "Relapse", "2002", "Triobite" },
                    { new Guid("66a19f2d-6b54-4488-a321-c39729e63d81"), new Guid("3020bc0e-9c86-43be-ac4d-6e942509a8b7"), new Guid("705ec861-6190-49e8-b17d-1403bc222a5f"), "Reprise Records", "2009", "Talk Dirty to Me" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Albums_AuthorId",
                table: "Albums",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Songs_AlbumId",
                table: "Songs",
                column: "AlbumId");

            migrationBuilder.CreateIndex(
                name: "IX_Songs_AuthorId",
                table: "Songs",
                column: "AuthorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Songs");

            migrationBuilder.DropTable(
                name: "Albums");

            migrationBuilder.DropTable(
                name: "Authors");
        }
    }
}
