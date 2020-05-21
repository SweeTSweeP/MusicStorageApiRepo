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
                    Title = table.Column<string>(nullable: true),
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
                        onDelete: ReferentialAction.Cascade);
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
                values: new object[] { new Guid("f0f4783b-d049-4e5b-8414-049545a002b7"), "Tool" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "AuthorId", "AuthorName" },
                values: new object[] { new Guid("c2a80b80-048a-4e0e-90b9-314b827abb10"), "Mastodon" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "AuthorId", "AuthorName" },
                values: new object[] { new Guid("6c274c28-2413-4d3f-b73d-0dc0b19697ab"), "Static-X" });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "AlbumId", "AuthorId", "Genre", "RecordLabel", "ReleaseYear", "Title" },
                values: new object[,]
                {
                    { new Guid("a93d810e-62cb-40fe-9897-5dcd41861833"), new Guid("f0f4783b-d049-4e5b-8414-049545a002b7"), "Progressive Metal", "Zoo Entertainment", "1993", "Undertow" },
                    { new Guid("9f6aedc7-aeb6-4520-b9e1-d1efbc57e14d"), new Guid("6c274c28-2413-4d3f-b73d-0dc0b19697ab"), "Indastrial/Nu Metal", "Warner Bros Records", "2005", "Start a War" },
                    { new Guid("9ac4c829-f0c6-41ea-95d8-7b7fa2b6ce5d"), new Guid("6c274c28-2413-4d3f-b73d-0dc0b19697ab"), "Indastrial/Nu Metal", "Warner Bros Records", "2003", "Shadow Zone" },
                    { new Guid("6aaf512e-cf70-41cb-b4ef-cc93ded96b50"), new Guid("6c274c28-2413-4d3f-b73d-0dc0b19697ab"), "Indastrial/Nu Metal", "Warner Bros Records", "2001", "Machine" },
                    { new Guid("04289754-30b2-4fec-8393-a3faefcc7192"), new Guid("6c274c28-2413-4d3f-b73d-0dc0b19697ab"), "Indastrial/Nu Metal", "Warner Bros Records", "1999", "Wisconsin Death Trip" },
                    { new Guid("fd66872b-63f9-4caf-a0a5-87eaca1bc065"), new Guid("c2a80b80-048a-4e0e-90b9-314b827abb10"), "Progressive Metal", "Reprise", "2017", "Emperor of Sand" },
                    { new Guid("c532dc2b-d3c5-414f-8d48-825984c28869"), new Guid("c2a80b80-048a-4e0e-90b9-314b827abb10"), "Progressive/Heavy Metal", "Reprise", "2014", "Once More 'Round the Sun" },
                    { new Guid("926976b2-7619-41f8-ba19-f572332f3d4d"), new Guid("c2a80b80-048a-4e0e-90b9-314b827abb10"), "Heavy/Avant-Gard Metal", "Reprise/Roadrunner", "2011", "The Hunter" },
                    { new Guid("efbe4318-e654-420a-bb50-5e04a95c8849"), new Guid("c2a80b80-048a-4e0e-90b9-314b827abb10"), "Alternative/Heavy Metal", "Reprise", "2009", "Crack The Skye" },
                    { new Guid("7051f2a4-7843-49ab-9bb9-80e2e9450095"), new Guid("c2a80b80-048a-4e0e-90b9-314b827abb10"), "Progressive Metal", "Warner Bros./Reprise", "2006", "Blood Mountain" },
                    { new Guid("16b662e3-31b6-47de-b41b-0b79455986b1"), new Guid("c2a80b80-048a-4e0e-90b9-314b827abb10"), "Progressive/Heavy Metal", "Relapse", "2004", "Leviathan" },
                    { new Guid("f5cd1cb4-206d-4761-81ac-7282ddf1f484"), new Guid("c2a80b80-048a-4e0e-90b9-314b827abb10"), "Progressive/Trash Metal", "Relapse", "2002", "Remission" },
                    { new Guid("9c238b0f-8704-443a-9f61-1c158429fb18"), new Guid("f0f4783b-d049-4e5b-8414-049545a002b7"), "Progressive Metal", "Tool Dissectional/Volcano Entertainment", "2019", "Fear Inoculum" },
                    { new Guid("99159799-27e5-4d09-af62-1544427e222f"), new Guid("f0f4783b-d049-4e5b-8414-049545a002b7"), "Progressive Metal", "Tool Dissectional/Volcano Entertainment", "2006", "10,000 Days" },
                    { new Guid("a6cde08f-fefb-40f5-98d0-ed7373e5780c"), new Guid("f0f4783b-d049-4e5b-8414-049545a002b7"), "Progressive Metal", "Volcano Entertainment", "2001", "Lateralus" },
                    { new Guid("0ddbba49-4c9f-4038-805a-df9843171661"), new Guid("f0f4783b-d049-4e5b-8414-049545a002b7"), "Progressive Metal", "Zoo Entertainment", "1996", "AEnima" },
                    { new Guid("a12dffa1-53bb-456c-9ba5-b9413d1cb93e"), new Guid("6c274c28-2413-4d3f-b73d-0dc0b19697ab"), "Indastrial/Nu Metal", "Reprise Records", "2007", "Cannibal" },
                    { new Guid("1fbd29e0-b675-4428-9cb0-358471cce184"), new Guid("6c274c28-2413-4d3f-b73d-0dc0b19697ab"), "Indastrial/Nu Metal", "Reprise Records", "2009", "Cult of Static" }
                });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "SongId", "AlbumId", "AuthorId", "RecordLabel", "ReleaseYear", "Title" },
                values: new object[,]
                {
                    { new Guid("ba9f11a2-edcd-459e-a418-1bfa552729a6"), new Guid("a93d810e-62cb-40fe-9897-5dcd41861833"), new Guid("f0f4783b-d049-4e5b-8414-049545a002b7"), "Zoo Entertainment", "1993", "Intolerance" },
                    { new Guid("75dfe19d-3562-44db-9343-4a1d98189248"), new Guid("04289754-30b2-4fec-8393-a3faefcc7192"), new Guid("6c274c28-2413-4d3f-b73d-0dc0b19697ab"), "Warner Bros Records", "1999", "Bled for Days" },
                    { new Guid("246bb8f0-fc1f-4ef0-86a8-0d6067d77b3d"), new Guid("04289754-30b2-4fec-8393-a3faefcc7192"), new Guid("6c274c28-2413-4d3f-b73d-0dc0b19697ab"), "Warner Bros Records", "1999", "Love Dump" },
                    { new Guid("c0bdf1f3-6285-4d95-aac1-29164c1c5060"), new Guid("04289754-30b2-4fec-8393-a3faefcc7192"), new Guid("6c274c28-2413-4d3f-b73d-0dc0b19697ab"), "Warner Bros Records", "1999", "I Am" },
                    { new Guid("43fac12b-d3c7-4421-8997-09479164908d"), new Guid("04289754-30b2-4fec-8393-a3faefcc7192"), new Guid("6c274c28-2413-4d3f-b73d-0dc0b19697ab"), "Warner Bros Records", "1999", "Otsegoldation" },
                    { new Guid("6cfc1f76-d87f-4b06-9ce3-22d34e61d8e1"), new Guid("04289754-30b2-4fec-8393-a3faefcc7192"), new Guid("6c274c28-2413-4d3f-b73d-0dc0b19697ab"), "Warner Bros Records", "1999", "Stem" },
                    { new Guid("246117d2-8284-4acf-ac8f-7cb6ac08831c"), new Guid("04289754-30b2-4fec-8393-a3faefcc7192"), new Guid("6c274c28-2413-4d3f-b73d-0dc0b19697ab"), "Warner Bros Records", "1999", "Sweat of the Bud" },
                    { new Guid("f7223753-3970-46c5-b9a6-a95f41d72195"), new Guid("04289754-30b2-4fec-8393-a3faefcc7192"), new Guid("6c274c28-2413-4d3f-b73d-0dc0b19697ab"), "Warner Bros Records", "1999", "Fix" },
                    { new Guid("6add2d47-e9f3-4125-b3f9-5808318cecff"), new Guid("04289754-30b2-4fec-8393-a3faefcc7192"), new Guid("6c274c28-2413-4d3f-b73d-0dc0b19697ab"), "Warner Bros Records", "1999", "Wisconsin Death Trip" },
                    { new Guid("b1cba9ae-d04f-4bff-a946-5d9d3e8a38f4"), new Guid("04289754-30b2-4fec-8393-a3faefcc7192"), new Guid("6c274c28-2413-4d3f-b73d-0dc0b19697ab"), "Warner Bros Records", "1999", "December" },
                    { new Guid("0a59bc62-232a-4832-bcdd-a1a86f7e3512"), new Guid("04289754-30b2-4fec-8393-a3faefcc7192"), new Guid("6c274c28-2413-4d3f-b73d-0dc0b19697ab"), "Warner Bros Records", "1999", "Down" },
                    { new Guid("5fa2fc9f-fc8f-438b-a5ee-8c0d0ac809a7"), new Guid("6aaf512e-cf70-41cb-b4ef-cc93ded96b50"), new Guid("6c274c28-2413-4d3f-b73d-0dc0b19697ab"), "Warner Bros Records", "2001", "Bien Venidos" },
                    { new Guid("fd35a106-fe7f-47b7-8fe6-6d61133558c2"), new Guid("6aaf512e-cf70-41cb-b4ef-cc93ded96b50"), new Guid("6c274c28-2413-4d3f-b73d-0dc0b19697ab"), "Warner Bros Records", "2001", "Get to the Gone" },
                    { new Guid("2f0d0286-d95b-46fe-ad17-f10ccc11df26"), new Guid("6aaf512e-cf70-41cb-b4ef-cc93ded96b50"), new Guid("6c274c28-2413-4d3f-b73d-0dc0b19697ab"), "Warner Bros Records", "2001", "Permance" },
                    { new Guid("ce7baa1a-8744-4648-9f13-53b1b49cc339"), new Guid("6aaf512e-cf70-41cb-b4ef-cc93ded96b50"), new Guid("6c274c28-2413-4d3f-b73d-0dc0b19697ab"), "Warner Bros Records", "2001", "Black and White" },
                    { new Guid("1e9a688e-e709-4b4c-9591-be4108c67868"), new Guid("6aaf512e-cf70-41cb-b4ef-cc93ded96b50"), new Guid("6c274c28-2413-4d3f-b73d-0dc0b19697ab"), "Warner Bros Records", "2001", "This Is Not" },
                    { new Guid("4eb0e76c-08d9-49a9-ad6d-f4589282b185"), new Guid("6aaf512e-cf70-41cb-b4ef-cc93ded96b50"), new Guid("6c274c28-2413-4d3f-b73d-0dc0b19697ab"), "Warner Bros Records", "2001", "Otsego Undead" },
                    { new Guid("81d49758-4abe-447b-a61d-1a597d4f8610"), new Guid("6aaf512e-cf70-41cb-b4ef-cc93ded96b50"), new Guid("6c274c28-2413-4d3f-b73d-0dc0b19697ab"), "Warner Bros Records", "2001", "Cold" },
                    { new Guid("ff0fe26a-67eb-4126-a036-277b5374457b"), new Guid("6aaf512e-cf70-41cb-b4ef-cc93ded96b50"), new Guid("6c274c28-2413-4d3f-b73d-0dc0b19697ab"), "Warner Bros Records", "2001", "Structural Defect" },
                    { new Guid("3158b594-244a-4e2b-a54b-45df5759c9e9"), new Guid("6aaf512e-cf70-41cb-b4ef-cc93ded96b50"), new Guid("6c274c28-2413-4d3f-b73d-0dc0b19697ab"), "Warner Bros Records", "2001", "... In a Bag" },
                    { new Guid("f9e46cf8-a217-4710-9800-3f026bc0efd9"), new Guid("6aaf512e-cf70-41cb-b4ef-cc93ded96b50"), new Guid("6c274c28-2413-4d3f-b73d-0dc0b19697ab"), "Warner Bros Records", "2001", "Burn to Burn" },
                    { new Guid("1cc41117-ca4b-40b6-9f9c-823d8f66ed48"), new Guid("6aaf512e-cf70-41cb-b4ef-cc93ded96b50"), new Guid("6c274c28-2413-4d3f-b73d-0dc0b19697ab"), "Warner Bros Records", "2001", "Machine" },
                    { new Guid("8413f2c7-4c8c-4082-8494-7a2de5a7490a"), new Guid("6aaf512e-cf70-41cb-b4ef-cc93ded96b50"), new Guid("6c274c28-2413-4d3f-b73d-0dc0b19697ab"), "Warner Bros Records", "2001", "A Dios Alma Perdida" },
                    { new Guid("50809f5f-eed5-4807-b4ad-65164c5d05dd"), new Guid("9ac4c829-f0c6-41ea-95d8-7b7fa2b6ce5d"), new Guid("6c274c28-2413-4d3f-b73d-0dc0b19697ab"), "Warner Bros Records", "2003", "Destroy All" },
                    { new Guid("7e57b405-5b5b-4cbf-a09a-f4cd9255ecbb"), new Guid("04289754-30b2-4fec-8393-a3faefcc7192"), new Guid("6c274c28-2413-4d3f-b73d-0dc0b19697ab"), "Warner Bros Records", "1999", "I'm with Stupid" },
                    { new Guid("1c0ff811-281f-4934-ab44-e691851aa787"), new Guid("04289754-30b2-4fec-8393-a3faefcc7192"), new Guid("6c274c28-2413-4d3f-b73d-0dc0b19697ab"), "Warner Bros Records", "1999", "Push It" },
                    { new Guid("ca6f26cd-f426-428f-bef5-fbe3224282bc"), new Guid("fd66872b-63f9-4caf-a0a5-87eaca1bc065"), new Guid("c2a80b80-048a-4e0e-90b9-314b827abb10"), "Reprise", "2017", "Jaguar God" },
                    { new Guid("6784b934-48ae-47b6-8cdf-49948e7e31b0"), new Guid("fd66872b-63f9-4caf-a0a5-87eaca1bc065"), new Guid("c2a80b80-048a-4e0e-90b9-314b827abb10"), "Reprise", "2017", "Scorpion Breath" },
                    { new Guid("3938c998-8027-4782-b8e7-9a38fc3f3d60"), new Guid("926976b2-7619-41f8-ba19-f572332f3d4d"), new Guid("c2a80b80-048a-4e0e-90b9-314b827abb10"), "Reprise/Roadrunner", "2011", "The Sparrow" },
                    { new Guid("4783b00c-cdf1-4e59-998b-25b561e658b9"), new Guid("926976b2-7619-41f8-ba19-f572332f3d4d"), new Guid("c2a80b80-048a-4e0e-90b9-314b827abb10"), "Reprise/Roadrunner", "2011", "The Ruiner" },
                    { new Guid("8bfc9c73-49c7-4b5e-9e81-049ee4ee6458"), new Guid("926976b2-7619-41f8-ba19-f572332f3d4d"), new Guid("c2a80b80-048a-4e0e-90b9-314b827abb10"), "Reprise/Roadrunner", "2011", "Deathbound" },
                    { new Guid("0989a63c-fe43-4cdd-b53e-b40bab32547b"), new Guid("c532dc2b-d3c5-414f-8d48-825984c28869"), new Guid("c2a80b80-048a-4e0e-90b9-314b827abb10"), "Reprise", "2014", "Tread Lightly" },
                    { new Guid("e0a6d4dc-0090-4780-bc75-dfd23d837a72"), new Guid("c532dc2b-d3c5-414f-8d48-825984c28869"), new Guid("c2a80b80-048a-4e0e-90b9-314b827abb10"), "Reprise", "2014", "The Motherload" },
                    { new Guid("029a9a96-c954-4507-89ca-33f756a11cfc"), new Guid("c532dc2b-d3c5-414f-8d48-825984c28869"), new Guid("c2a80b80-048a-4e0e-90b9-314b827abb10"), "Reprise", "2014", "High Road" },
                    { new Guid("167ffc3d-836b-4e56-8e47-5817717f6ca3"), new Guid("c532dc2b-d3c5-414f-8d48-825984c28869"), new Guid("c2a80b80-048a-4e0e-90b9-314b827abb10"), "Reprise", "2014", "Once More 'Round the Sun" },
                    { new Guid("c3033da3-3437-4e80-9b8f-0f08cad7204f"), new Guid("c532dc2b-d3c5-414f-8d48-825984c28869"), new Guid("c2a80b80-048a-4e0e-90b9-314b827abb10"), "Reprise", "2014", "Chimes at Midnight" },
                    { new Guid("33600a5e-9c58-4b2a-8e5a-14db5fcf6b73"), new Guid("c532dc2b-d3c5-414f-8d48-825984c28869"), new Guid("c2a80b80-048a-4e0e-90b9-314b827abb10"), "Reprise", "2014", "Asleep in the Deep" },
                    { new Guid("7ae59c3c-9e64-45dc-88fa-839cd5b5e896"), new Guid("c532dc2b-d3c5-414f-8d48-825984c28869"), new Guid("c2a80b80-048a-4e0e-90b9-314b827abb10"), "Reprise", "2014", "Feast Your Eyes" },
                    { new Guid("999ddc54-6083-42b4-b052-a1f4c64bae37"), new Guid("c532dc2b-d3c5-414f-8d48-825984c28869"), new Guid("c2a80b80-048a-4e0e-90b9-314b827abb10"), "Reprise", "2014", "Aunt Lisa" },
                    { new Guid("21d2b535-e57c-4380-943c-7ffcd4b105b1"), new Guid("9ac4c829-f0c6-41ea-95d8-7b7fa2b6ce5d"), new Guid("6c274c28-2413-4d3f-b73d-0dc0b19697ab"), "Warner Bros Records", "2003", "Control It" },
                    { new Guid("097a9551-6a07-43a4-8a9f-dc0d032fc140"), new Guid("c532dc2b-d3c5-414f-8d48-825984c28869"), new Guid("c2a80b80-048a-4e0e-90b9-314b827abb10"), "Reprise", "2014", "Ember City" },
                    { new Guid("693ec66c-06f1-47be-beeb-14ac257996dc"), new Guid("c532dc2b-d3c5-414f-8d48-825984c28869"), new Guid("c2a80b80-048a-4e0e-90b9-314b827abb10"), "Reprise", "2014", "Diamond in the Witch House" },
                    { new Guid("3a471a60-b730-4d76-9532-59ed8190a1f5"), new Guid("fd66872b-63f9-4caf-a0a5-87eaca1bc065"), new Guid("c2a80b80-048a-4e0e-90b9-314b827abb10"), "Reprise", "2017", "Sultan's Curse" },
                    { new Guid("c3a28b2e-76e7-443b-954e-23a217ca636e"), new Guid("fd66872b-63f9-4caf-a0a5-87eaca1bc065"), new Guid("c2a80b80-048a-4e0e-90b9-314b827abb10"), "Reprise", "2017", "Show Yourself" },
                    { new Guid("f99e51ea-68aa-4637-ae95-3da34828a3c9"), new Guid("fd66872b-63f9-4caf-a0a5-87eaca1bc065"), new Guid("c2a80b80-048a-4e0e-90b9-314b827abb10"), "Reprise", "2017", "Precious Stones" },
                    { new Guid("505bc5a2-1fcf-4aa5-afce-c6f6c4205989"), new Guid("fd66872b-63f9-4caf-a0a5-87eaca1bc065"), new Guid("c2a80b80-048a-4e0e-90b9-314b827abb10"), "Reprise", "2017", "Steambreather" },
                    { new Guid("b7919081-a337-42f0-a7f2-229699589f1f"), new Guid("fd66872b-63f9-4caf-a0a5-87eaca1bc065"), new Guid("c2a80b80-048a-4e0e-90b9-314b827abb10"), "Reprise", "2017", "Roots Remain" },
                    { new Guid("de4afc26-937a-43ff-bd60-5def31e58c9c"), new Guid("fd66872b-63f9-4caf-a0a5-87eaca1bc065"), new Guid("c2a80b80-048a-4e0e-90b9-314b827abb10"), "Reprise", "2017", "Word to the Wise" },
                    { new Guid("94c0dae8-6360-4994-9358-fc03449be9ae"), new Guid("fd66872b-63f9-4caf-a0a5-87eaca1bc065"), new Guid("c2a80b80-048a-4e0e-90b9-314b827abb10"), "Reprise", "2017", "Ancient to the Wise" },
                    { new Guid("73379dfe-9bd1-4b1c-9f90-b0dad2318ac6"), new Guid("fd66872b-63f9-4caf-a0a5-87eaca1bc065"), new Guid("c2a80b80-048a-4e0e-90b9-314b827abb10"), "Reprise", "2017", "Ancient Kingdom" },
                    { new Guid("81ad25f7-aa9b-45dd-a74d-558f6d17c3ac"), new Guid("fd66872b-63f9-4caf-a0a5-87eaca1bc065"), new Guid("c2a80b80-048a-4e0e-90b9-314b827abb10"), "Reprise", "2017", "Cleandestiny" },
                    { new Guid("7a7c5027-5bd8-4937-a525-652a5ece218d"), new Guid("fd66872b-63f9-4caf-a0a5-87eaca1bc065"), new Guid("c2a80b80-048a-4e0e-90b9-314b827abb10"), "Reprise", "2017", "Andromeda" },
                    { new Guid("d71ba515-77f2-40a0-a173-464f334dd381"), new Guid("c532dc2b-d3c5-414f-8d48-825984c28869"), new Guid("c2a80b80-048a-4e0e-90b9-314b827abb10"), "Reprise", "2014", "Halloween" },
                    { new Guid("62f61eca-defc-41e5-872e-ded60787f521"), new Guid("9ac4c829-f0c6-41ea-95d8-7b7fa2b6ce5d"), new Guid("6c274c28-2413-4d3f-b73d-0dc0b19697ab"), "Warner Bros Records", "2003", "New Plain" },
                    { new Guid("f1d484ce-5d32-45bc-ae7c-28a846820c13"), new Guid("9ac4c829-f0c6-41ea-95d8-7b7fa2b6ce5d"), new Guid("6c274c28-2413-4d3f-b73d-0dc0b19697ab"), "Warner Bros Records", "2003", "Shadow Zone" },
                    { new Guid("70870980-04e3-467c-a126-9b507bcef307"), new Guid("9ac4c829-f0c6-41ea-95d8-7b7fa2b6ce5d"), new Guid("6c274c28-2413-4d3f-b73d-0dc0b19697ab"), "Warner Bros Records", "2003", "Dead World" },
                    { new Guid("f521d20c-554c-46f2-9378-ca573a3d951a"), new Guid("a12dffa1-53bb-456c-9ba5-b9413d1cb93e"), new Guid("6c274c28-2413-4d3f-b73d-0dc0b19697ab"), "Reprise Records", "2007", "Forty Ways" },
                    { new Guid("585a6de4-9507-407f-8d97-849efcf4a9f4"), new Guid("a12dffa1-53bb-456c-9ba5-b9413d1cb93e"), new Guid("6c274c28-2413-4d3f-b73d-0dc0b19697ab"), "Reprise Records", "2007", "Chroma-Matic" },
                    { new Guid("0f4b7a34-1d6b-4596-a124-444689ff4ed7"), new Guid("a12dffa1-53bb-456c-9ba5-b9413d1cb93e"), new Guid("6c274c28-2413-4d3f-b73d-0dc0b19697ab"), "Reprise Records", "2007", "Cuts You Up" },
                    { new Guid("59d2da9e-5b40-465b-8003-65de548ed3c0"), new Guid("a12dffa1-53bb-456c-9ba5-b9413d1cb93e"), new Guid("6c274c28-2413-4d3f-b73d-0dc0b19697ab"), "Reprise Records", "2007", "Reptile" },
                    { new Guid("63e6ff8e-1d19-4fc9-8be7-b49b28aa36cd"), new Guid("a12dffa1-53bb-456c-9ba5-b9413d1cb93e"), new Guid("6c274c28-2413-4d3f-b73d-0dc0b19697ab"), "Reprise Records", "2007", "Electric Pulse" },
                    { new Guid("9e3856bf-a689-40c2-ab26-355fd7e6c482"), new Guid("a12dffa1-53bb-456c-9ba5-b9413d1cb93e"), new Guid("6c274c28-2413-4d3f-b73d-0dc0b19697ab"), "Reprise Records", "2007", "Goat" },
                    { new Guid("7f18ae94-c39a-4edf-ba69-78f38ebe6bfd"), new Guid("a12dffa1-53bb-456c-9ba5-b9413d1cb93e"), new Guid("6c274c28-2413-4d3f-b73d-0dc0b19697ab"), "Reprise Records", "2007", "Team Hate" },
                    { new Guid("7805779e-de48-46b4-aaef-c913ccd6949d"), new Guid("a12dffa1-53bb-456c-9ba5-b9413d1cb93e"), new Guid("6c274c28-2413-4d3f-b73d-0dc0b19697ab"), "Reprise Records", "2007", "Light It Up" },
                    { new Guid("03523435-ba47-446b-b003-bba37df62229"), new Guid("a12dffa1-53bb-456c-9ba5-b9413d1cb93e"), new Guid("6c274c28-2413-4d3f-b73d-0dc0b19697ab"), "Reprise Records", "2007", "I'm the One" },
                    { new Guid("49f8722d-aaac-433a-a3f5-13f760153b9e"), new Guid("a12dffa1-53bb-456c-9ba5-b9413d1cb93e"), new Guid("6c274c28-2413-4d3f-b73d-0dc0b19697ab"), "Reprise Records", "2007", "Get Up and Boogie" },
                    { new Guid("023f76dc-786a-42d7-8ff7-fd82001ffdf6"), new Guid("a12dffa1-53bb-456c-9ba5-b9413d1cb93e"), new Guid("6c274c28-2413-4d3f-b73d-0dc0b19697ab"), "Reprise Records", "2007", "Beneath, Between, Beyond" },
                    { new Guid("e54d00d2-168c-4886-987b-1ca5b670d46b"), new Guid("a12dffa1-53bb-456c-9ba5-b9413d1cb93e"), new Guid("6c274c28-2413-4d3f-b73d-0dc0b19697ab"), "Reprise Records", "2007", "Destroyer" },
                    { new Guid("b125e138-bd9c-42e9-86a1-6c1027aed5b6"), new Guid("1fbd29e0-b675-4428-9cb0-358471cce184"), new Guid("6c274c28-2413-4d3f-b73d-0dc0b19697ab"), "Reprise Records", "2009", "Lunatic" },
                    { new Guid("0ffba7c9-2016-468c-a5c8-74ec0f76d0cf"), new Guid("1fbd29e0-b675-4428-9cb0-358471cce184"), new Guid("6c274c28-2413-4d3f-b73d-0dc0b19697ab"), "Reprise Records", "2009", "Terminal" },
                    { new Guid("2cce8273-aeec-45af-849c-f11f885de937"), new Guid("1fbd29e0-b675-4428-9cb0-358471cce184"), new Guid("6c274c28-2413-4d3f-b73d-0dc0b19697ab"), "Reprise Records", "2009", "Hypure" },
                    { new Guid("8c82f5b2-26fa-4d6f-83cd-43195249378d"), new Guid("1fbd29e0-b675-4428-9cb0-358471cce184"), new Guid("6c274c28-2413-4d3f-b73d-0dc0b19697ab"), "Reprise Records", "2009", "Tera-Fied" },
                    { new Guid("b4280a45-7aff-42e7-8425-360fa2485126"), new Guid("1fbd29e0-b675-4428-9cb0-358471cce184"), new Guid("6c274c28-2413-4d3f-b73d-0dc0b19697ab"), "Reprise Records", "2009", "Stringwray" },
                    { new Guid("1909c215-67c4-474e-9c8a-7780cf9cfe6b"), new Guid("1fbd29e0-b675-4428-9cb0-358471cce184"), new Guid("6c274c28-2413-4d3f-b73d-0dc0b19697ab"), "Reprise Records", "2009", "You Am I" },
                    { new Guid("78132b76-fac7-4fd4-a754-fe6d5aef6f61"), new Guid("1fbd29e0-b675-4428-9cb0-358471cce184"), new Guid("6c274c28-2413-4d3f-b73d-0dc0b19697ab"), "Reprise Records", "2009", "Isolaytore" },
                    { new Guid("8c0b5a96-bff9-4821-862e-e0a4d223f58d"), new Guid("1fbd29e0-b675-4428-9cb0-358471cce184"), new Guid("6c274c28-2413-4d3f-b73d-0dc0b19697ab"), "Reprise Records", "2009", "Nocturnally" },
                    { new Guid("b0c6e500-d75a-4c9f-a9db-40597da6c41b"), new Guid("1fbd29e0-b675-4428-9cb0-358471cce184"), new Guid("6c274c28-2413-4d3f-b73d-0dc0b19697ab"), "Reprise Records", "2009", "Skinned" },
                    { new Guid("018c158c-5882-41e3-9452-4bc3f6ce7ac4"), new Guid("1fbd29e0-b675-4428-9cb0-358471cce184"), new Guid("6c274c28-2413-4d3f-b73d-0dc0b19697ab"), "Reprise Records", "2009", "Grind 2 Halt" },
                    { new Guid("7012dda2-9ce9-4fb2-8462-d5f29fb58ef5"), new Guid("1fbd29e0-b675-4428-9cb0-358471cce184"), new Guid("6c274c28-2413-4d3f-b73d-0dc0b19697ab"), "Reprise Records", "2009", "Still of the Night" },
                    { new Guid("08d5dc66-4009-494d-97e3-c97b337d964e"), new Guid("1fbd29e0-b675-4428-9cb0-358471cce184"), new Guid("6c274c28-2413-4d3f-b73d-0dc0b19697ab"), "Reprise Records", "2009", "W.F.O" },
                    { new Guid("4ac355ce-49ae-4041-bf5b-cae58eccfb00"), new Guid("1fbd29e0-b675-4428-9cb0-358471cce184"), new Guid("6c274c28-2413-4d3f-b73d-0dc0b19697ab"), "Reprise Records", "2009", "Z28" },
                    { new Guid("61d6f6e4-65f1-4347-bc0b-1a072a79beba"), new Guid("926976b2-7619-41f8-ba19-f572332f3d4d"), new Guid("c2a80b80-048a-4e0e-90b9-314b827abb10"), "Reprise/Roadrunner", "2011", "Bedazzled Fingernails" },
                    { new Guid("fe788fb1-9104-41f3-a11b-4d4dde164329"), new Guid("a12dffa1-53bb-456c-9ba5-b9413d1cb93e"), new Guid("6c274c28-2413-4d3f-b73d-0dc0b19697ab"), "Reprise Records", "2007", "Chemical Logic" },
                    { new Guid("2b04c6c5-a077-462f-a786-d8050df6c43a"), new Guid("a12dffa1-53bb-456c-9ba5-b9413d1cb93e"), new Guid("6c274c28-2413-4d3f-b73d-0dc0b19697ab"), "Reprise Records", "2007", "No Submission" },
                    { new Guid("188b5028-874f-4b13-931a-ccdd960a7400"), new Guid("9ac4c829-f0c6-41ea-95d8-7b7fa2b6ce5d"), new Guid("6c274c28-2413-4d3f-b73d-0dc0b19697ab"), "Warner Bros Records", "2003", "Monster" },
                    { new Guid("ab18441a-29b2-4df6-8c5a-e394d206a7e4"), new Guid("9ac4c829-f0c6-41ea-95d8-7b7fa2b6ce5d"), new Guid("6c274c28-2413-4d3f-b73d-0dc0b19697ab"), "Warner Bros Records", "2003", "The Only" },
                    { new Guid("b1c5a8bd-bd5e-4061-8091-412773119a60"), new Guid("9ac4c829-f0c6-41ea-95d8-7b7fa2b6ce5d"), new Guid("6c274c28-2413-4d3f-b73d-0dc0b19697ab"), "Warner Bros Records", "2003", "Kill Your Idols" },
                    { new Guid("a18cd51d-c19a-4a09-a2ee-1200aa3022bd"), new Guid("9ac4c829-f0c6-41ea-95d8-7b7fa2b6ce5d"), new Guid("6c274c28-2413-4d3f-b73d-0dc0b19697ab"), "Warner Bros Records", "2003", "All in Wait" },
                    { new Guid("61491691-e857-48ba-9787-4c7f04fb1dce"), new Guid("9ac4c829-f0c6-41ea-95d8-7b7fa2b6ce5d"), new Guid("6c274c28-2413-4d3f-b73d-0dc0b19697ab"), "Warner Bros Records", "2003", "Otsegolectric" },
                    { new Guid("38c12043-53b8-4705-8b75-30d7ccdcfe30"), new Guid("9ac4c829-f0c6-41ea-95d8-7b7fa2b6ce5d"), new Guid("6c274c28-2413-4d3f-b73d-0dc0b19697ab"), "Warner Bros Records", "2003", "So" },
                    { new Guid("bd5e5f60-93ed-45d8-95da-0ed31b219217"), new Guid("9ac4c829-f0c6-41ea-95d8-7b7fa2b6ce5d"), new Guid("6c274c28-2413-4d3f-b73d-0dc0b19697ab"), "Warner Bros Records", "2003", "Transmission" },
                    { new Guid("b865e61e-9250-48ae-bd22-7b53920cfd5b"), new Guid("9ac4c829-f0c6-41ea-95d8-7b7fa2b6ce5d"), new Guid("6c274c28-2413-4d3f-b73d-0dc0b19697ab"), "Warner Bros Records", "2003", "Invincible" },
                    { new Guid("c75eb5f7-ddbf-4e63-ad0f-13ca2629ae2a"), new Guid("9ac4c829-f0c6-41ea-95d8-7b7fa2b6ce5d"), new Guid("6c274c28-2413-4d3f-b73d-0dc0b19697ab"), "Warner Bros Records", "2003", "Gimme Gimme Shock Treatment" },
                    { new Guid("f8c07ed6-47e7-4210-8f76-1778a85526e3"), new Guid("9f6aedc7-aeb6-4520-b9e1-d1efbc57e14d"), new Guid("6c274c28-2413-4d3f-b73d-0dc0b19697ab"), "Warner Bros Records", "2005", "The Enemy" },
                    { new Guid("a899b0fd-2827-40c6-80df-ab66b3d26bc0"), new Guid("9f6aedc7-aeb6-4520-b9e1-d1efbc57e14d"), new Guid("6c274c28-2413-4d3f-b73d-0dc0b19697ab"), "Warner Bros Records", "2005", "I'm the One" },
                    { new Guid("06f49e7a-0233-43c7-b595-4c6c9036e6b3"), new Guid("a12dffa1-53bb-456c-9ba5-b9413d1cb93e"), new Guid("6c274c28-2413-4d3f-b73d-0dc0b19697ab"), "Reprise Records", "2007", "Behemoth" },
                    { new Guid("79db9d3c-878c-4069-acdf-6b6bceb3f250"), new Guid("9f6aedc7-aeb6-4520-b9e1-d1efbc57e14d"), new Guid("6c274c28-2413-4d3f-b73d-0dc0b19697ab"), "Warner Bros Records", "2005", "Start a War" },
                    { new Guid("b9a2e236-6c08-4cd1-af5f-65e2e13a3186"), new Guid("9f6aedc7-aeb6-4520-b9e1-d1efbc57e14d"), new Guid("6c274c28-2413-4d3f-b73d-0dc0b19697ab"), "Warner Bros Records", "2005", "Dirthouse" },
                    { new Guid("0536caa9-77a0-42b2-ae8a-e593dbe47a1e"), new Guid("9f6aedc7-aeb6-4520-b9e1-d1efbc57e14d"), new Guid("6c274c28-2413-4d3f-b73d-0dc0b19697ab"), "Warner Bros Records", "2005", "Skinnyman" },
                    { new Guid("2c29a91f-4db2-4dd6-8793-a5e27276edab"), new Guid("9f6aedc7-aeb6-4520-b9e1-d1efbc57e14d"), new Guid("6c274c28-2413-4d3f-b73d-0dc0b19697ab"), "Warner Bros Records", "2005", "Just in Case" },
                    { new Guid("57d5a09e-0803-4fad-afaf-7283d50668f6"), new Guid("9f6aedc7-aeb6-4520-b9e1-d1efbc57e14d"), new Guid("6c274c28-2413-4d3f-b73d-0dc0b19697ab"), "Warner Bros Records", "2005", "Set It Off" },
                    { new Guid("8ed14f75-1469-4412-81cf-3285ab13d202"), new Guid("9f6aedc7-aeb6-4520-b9e1-d1efbc57e14d"), new Guid("6c274c28-2413-4d3f-b73d-0dc0b19697ab"), "Warner Bros Records", "2005", "I Want to Fucking break It" },
                    { new Guid("5dd92cf3-12db-4719-b4aa-2b29b92432c5"), new Guid("9f6aedc7-aeb6-4520-b9e1-d1efbc57e14d"), new Guid("6c274c28-2413-4d3f-b73d-0dc0b19697ab"), "Warner Bros Records", "2005", "Night Terrors" },
                    { new Guid("79fbb3da-eef6-440c-ad23-9ca5b47704d6"), new Guid("9f6aedc7-aeb6-4520-b9e1-d1efbc57e14d"), new Guid("6c274c28-2413-4d3f-b73d-0dc0b19697ab"), "Warner Bros Records", "2005", "Otsego Amigo" },
                    { new Guid("2370480c-0e4d-4a45-99f4-9abcb0233edb"), new Guid("9f6aedc7-aeb6-4520-b9e1-d1efbc57e14d"), new Guid("6c274c28-2413-4d3f-b73d-0dc0b19697ab"), "Warner Bros Records", "2005", "My Damnation" },
                    { new Guid("b27f669b-614e-4158-8f86-ef7c8c738b9d"), new Guid("9f6aedc7-aeb6-4520-b9e1-d1efbc57e14d"), new Guid("6c274c28-2413-4d3f-b73d-0dc0b19697ab"), "Warner Bros Records", "2005", "Brainfog" },
                    { new Guid("5534eb02-a7cc-4dff-854d-a77edd1a293c"), new Guid("9f6aedc7-aeb6-4520-b9e1-d1efbc57e14d"), new Guid("6c274c28-2413-4d3f-b73d-0dc0b19697ab"), "Warner Bros Records", "2005", "Get to the Gone" },
                    { new Guid("50885555-5642-45d8-9855-c58e69b92672"), new Guid("a12dffa1-53bb-456c-9ba5-b9413d1cb93e"), new Guid("6c274c28-2413-4d3f-b73d-0dc0b19697ab"), "Reprise Records", "2007", "Cannibal" },
                    { new Guid("fe176dd3-ff74-47e0-9f2e-14bab57bff15"), new Guid("9f6aedc7-aeb6-4520-b9e1-d1efbc57e14d"), new Guid("6c274c28-2413-4d3f-b73d-0dc0b19697ab"), "Warner Bros Records", "2005", "Pieces" },
                    { new Guid("785f4ab4-c442-4b05-b572-fb76bee9a406"), new Guid("1fbd29e0-b675-4428-9cb0-358471cce184"), new Guid("6c274c28-2413-4d3f-b73d-0dc0b19697ab"), "Reprise Records", "2009", "Looks That Kill" },
                    { new Guid("f54d11f0-a0f7-49fa-869a-c736447b0c24"), new Guid("926976b2-7619-41f8-ba19-f572332f3d4d"), new Guid("c2a80b80-048a-4e0e-90b9-314b827abb10"), "Reprise/Roadrunner", "2011", "Spectrelight" },
                    { new Guid("4f5ee77c-248f-4654-b84d-78e28f1e7e2d"), new Guid("926976b2-7619-41f8-ba19-f572332f3d4d"), new Guid("c2a80b80-048a-4e0e-90b9-314b827abb10"), "Reprise/Roadrunner", "2011", "Thickening" },
                    { new Guid("6f57fb53-739f-4528-b69e-f69177cd4d90"), new Guid("a6cde08f-fefb-40f5-98d0-ed7373e5780c"), new Guid("f0f4783b-d049-4e5b-8414-049545a002b7"), "Volcano Entertainment", "2001", "Mantra" },
                    { new Guid("92fa9e2a-734b-4cb2-9c2a-54b63e2147a0"), new Guid("a6cde08f-fefb-40f5-98d0-ed7373e5780c"), new Guid("f0f4783b-d049-4e5b-8414-049545a002b7"), "Volcano Entertainment", "2001", "Schism" },
                    { new Guid("67aeeb8d-b369-47ff-9726-c95171e819c9"), new Guid("a6cde08f-fefb-40f5-98d0-ed7373e5780c"), new Guid("f0f4783b-d049-4e5b-8414-049545a002b7"), "Volcano Entertainment", "2001", "Parabol" },
                    { new Guid("08e88865-4923-4685-9638-3a7dace0c85d"), new Guid("a6cde08f-fefb-40f5-98d0-ed7373e5780c"), new Guid("f0f4783b-d049-4e5b-8414-049545a002b7"), "Volcano Entertainment", "2001", "Parabola" },
                    { new Guid("a2398f05-bf9a-4c24-ab74-ef6bf92c1760"), new Guid("a6cde08f-fefb-40f5-98d0-ed7373e5780c"), new Guid("f0f4783b-d049-4e5b-8414-049545a002b7"), "Volcano Entertainment", "2001", "Ticks & Leeches" },
                    { new Guid("0ef2e4f5-c3d5-4ff9-a198-e951e8438d36"), new Guid("a6cde08f-fefb-40f5-98d0-ed7373e5780c"), new Guid("f0f4783b-d049-4e5b-8414-049545a002b7"), "Volcano Entertainment", "2001", "Lateralus" },
                    { new Guid("93898a23-861e-4cdb-a388-3e1cfeb10ab0"), new Guid("a6cde08f-fefb-40f5-98d0-ed7373e5780c"), new Guid("f0f4783b-d049-4e5b-8414-049545a002b7"), "Volcano Entertainment", "2001", "Disposition" },
                    { new Guid("a1f26b19-11fa-479b-9947-44532789ff1c"), new Guid("a6cde08f-fefb-40f5-98d0-ed7373e5780c"), new Guid("f0f4783b-d049-4e5b-8414-049545a002b7"), "Volcano Entertainment", "2001", "Reflection" },
                    { new Guid("02e37589-f643-4e96-9214-d1e30e71b8df"), new Guid("a6cde08f-fefb-40f5-98d0-ed7373e5780c"), new Guid("f0f4783b-d049-4e5b-8414-049545a002b7"), "Volcano Entertainment", "2001", "Triad" },
                    { new Guid("3ca77752-cff1-4061-8431-c59c5f640d43"), new Guid("a6cde08f-fefb-40f5-98d0-ed7373e5780c"), new Guid("f0f4783b-d049-4e5b-8414-049545a002b7"), "Volcano Entertainment", "2001", "Faaip de Oiad" },
                    { new Guid("996c1ffe-f6d8-4c57-b124-ae45f48ff784"), new Guid("99159799-27e5-4d09-af62-1544427e222f"), new Guid("f0f4783b-d049-4e5b-8414-049545a002b7"), "Tool Dissectional/Volcano Entertainment", "2006", "Vicarious" },
                    { new Guid("91f5360b-c586-4fb7-9e30-2f79c11c0226"), new Guid("99159799-27e5-4d09-af62-1544427e222f"), new Guid("f0f4783b-d049-4e5b-8414-049545a002b7"), "Tool Dissectional/Volcano Entertainment", "2006", "Jambi" },
                    { new Guid("8440970b-361c-49a1-b32b-f49c8b7e5473"), new Guid("99159799-27e5-4d09-af62-1544427e222f"), new Guid("f0f4783b-d049-4e5b-8414-049545a002b7"), "Tool Dissectional/Volcano Entertainment", "2006", "Wings for Marie" },
                    { new Guid("39f331df-4a2c-44ba-89bf-b4c5de49b5e0"), new Guid("99159799-27e5-4d09-af62-1544427e222f"), new Guid("f0f4783b-d049-4e5b-8414-049545a002b7"), "Tool Dissectional/Volcano Entertainment", "2006", "10,000 Days" },
                    { new Guid("0352179c-b1ae-4853-93a0-1cd1b6f833cc"), new Guid("99159799-27e5-4d09-af62-1544427e222f"), new Guid("f0f4783b-d049-4e5b-8414-049545a002b7"), "Tool Dissectional/Volcano Entertainment", "2006", "The Pot" },
                    { new Guid("2cd45d97-7de1-41f9-8668-bfea41f3d97a"), new Guid("99159799-27e5-4d09-af62-1544427e222f"), new Guid("f0f4783b-d049-4e5b-8414-049545a002b7"), "Tool Dissectional/Volcano Entertainment", "2006", "Lipan Conjuring" },
                    { new Guid("4ff93993-5ae6-49dd-a5bc-aebcce2a35ad"), new Guid("99159799-27e5-4d09-af62-1544427e222f"), new Guid("f0f4783b-d049-4e5b-8414-049545a002b7"), "Tool Dissectional/Volcano Entertainment", "2006", "Lost Keys" },
                    { new Guid("e647164c-46ce-4d3d-a906-ab484d47178b"), new Guid("99159799-27e5-4d09-af62-1544427e222f"), new Guid("f0f4783b-d049-4e5b-8414-049545a002b7"), "Tool Dissectional/Volcano Entertainment", "2006", "Rosetta Stoned" },
                    { new Guid("55ba305d-37af-4661-8558-f1abc4f29d82"), new Guid("99159799-27e5-4d09-af62-1544427e222f"), new Guid("f0f4783b-d049-4e5b-8414-049545a002b7"), "Tool Dissectional/Volcano Entertainment", "2006", "Intension" },
                    { new Guid("08738c04-153e-452c-a5de-bb1861754d69"), new Guid("99159799-27e5-4d09-af62-1544427e222f"), new Guid("f0f4783b-d049-4e5b-8414-049545a002b7"), "Tool Dissectional/Volcano Entertainment", "2006", "Right in Two" },
                    { new Guid("026811f2-b4c5-4cb2-821c-513f0da8b537"), new Guid("99159799-27e5-4d09-af62-1544427e222f"), new Guid("f0f4783b-d049-4e5b-8414-049545a002b7"), "Tool Dissectional/Volcano Entertainment", "2006", "Viginti Tres" },
                    { new Guid("e5d37828-ecf1-416e-a909-3da6f0e6f384"), new Guid("9c238b0f-8704-443a-9f61-1c158429fb18"), new Guid("f0f4783b-d049-4e5b-8414-049545a002b7"), "Tool Dissectional/Volcano Entertainment", "2019", "Fear Inoculum" },
                    { new Guid("44c458c1-04a0-4e9d-abfe-9f0c2fa3f193"), new Guid("9c238b0f-8704-443a-9f61-1c158429fb18"), new Guid("f0f4783b-d049-4e5b-8414-049545a002b7"), "Tool Dissectional/Volcano Entertainment", "2019", "Pneuma" },
                    { new Guid("ea46e763-390b-41f2-ba7d-bf90f3aa3fe9"), new Guid("a6cde08f-fefb-40f5-98d0-ed7373e5780c"), new Guid("f0f4783b-d049-4e5b-8414-049545a002b7"), "Volcano Entertainment", "2001", "The Patient" },
                    { new Guid("cae95ea3-b056-462b-8721-79fb30aa617a"), new Guid("a6cde08f-fefb-40f5-98d0-ed7373e5780c"), new Guid("f0f4783b-d049-4e5b-8414-049545a002b7"), "Volcano Entertainment", "2001", "Eon Blue Apocalypse" },
                    { new Guid("370ed5ee-233b-47c7-9181-2891d43c11ea"), new Guid("a6cde08f-fefb-40f5-98d0-ed7373e5780c"), new Guid("f0f4783b-d049-4e5b-8414-049545a002b7"), "Volcano Entertainment", "2001", "The Grudge" },
                    { new Guid("71463e33-da13-4929-b8fe-fcdec174f238"), new Guid("0ddbba49-4c9f-4038-805a-df9843171661"), new Guid("f0f4783b-d049-4e5b-8414-049545a002b7"), "Zoo Entertainment", "1996", "Eulogy" },
                    { new Guid("5a7d5796-cec5-4a97-b8f1-49a0d5e0fc36"), new Guid("a93d810e-62cb-40fe-9897-5dcd41861833"), new Guid("f0f4783b-d049-4e5b-8414-049545a002b7"), "Zoo Entertainment", "1993", "Prison Sex" },
                    { new Guid("0723c808-749e-496e-8590-02811795d11e"), new Guid("a93d810e-62cb-40fe-9897-5dcd41861833"), new Guid("f0f4783b-d049-4e5b-8414-049545a002b7"), "Zoo Entertainment", "1993", "Sober" },
                    { new Guid("cb8e15fc-6797-4eb9-95d6-f54419417ff3"), new Guid("a93d810e-62cb-40fe-9897-5dcd41861833"), new Guid("f0f4783b-d049-4e5b-8414-049545a002b7"), "Zoo Entertainment", "1993", "Bottom" },
                    { new Guid("5af5c8e6-c57a-4fc5-99f1-3340dd82c22e"), new Guid("a93d810e-62cb-40fe-9897-5dcd41861833"), new Guid("f0f4783b-d049-4e5b-8414-049545a002b7"), "Zoo Entertainment", "1993", "Crawl Away" },
                    { new Guid("f7c9b532-cee3-4ac4-af68-0c3babca0762"), new Guid("a93d810e-62cb-40fe-9897-5dcd41861833"), new Guid("f0f4783b-d049-4e5b-8414-049545a002b7"), "Zoo Entertainment", "1993", "Swamp Song" },
                    { new Guid("dd4d82ae-4edc-4854-ba3c-d72563c2ff36"), new Guid("a93d810e-62cb-40fe-9897-5dcd41861833"), new Guid("f0f4783b-d049-4e5b-8414-049545a002b7"), "Zoo Entertainment", "1993", "Undertow" },
                    { new Guid("d896e02d-43c4-4fe1-87fb-59099ad2d07e"), new Guid("a93d810e-62cb-40fe-9897-5dcd41861833"), new Guid("f0f4783b-d049-4e5b-8414-049545a002b7"), "Zoo Entertainment", "1993", "4degree" },
                    { new Guid("70507184-177f-40fd-a7ee-86bd396e448a"), new Guid("a93d810e-62cb-40fe-9897-5dcd41861833"), new Guid("f0f4783b-d049-4e5b-8414-049545a002b7"), "Zoo Entertainment", "1993", "Flood" },
                    { new Guid("040397f3-8413-4e0f-a2c5-10d5369dac5e"), new Guid("a93d810e-62cb-40fe-9897-5dcd41861833"), new Guid("f0f4783b-d049-4e5b-8414-049545a002b7"), "Zoo Entertainment", "1993", "Disgustipated" },
                    { new Guid("a015969b-d986-4e2a-945b-69c28347b63f"), new Guid("0ddbba49-4c9f-4038-805a-df9843171661"), new Guid("f0f4783b-d049-4e5b-8414-049545a002b7"), "Zoo Entertainment", "1996", "Stinkfist" },
                    { new Guid("9d817204-37f2-4a87-933c-a08d2188959a"), new Guid("0ddbba49-4c9f-4038-805a-df9843171661"), new Guid("f0f4783b-d049-4e5b-8414-049545a002b7"), "Zoo Entertainment", "1996", "Eulogy" },
                    { new Guid("5e095c9d-f9ac-4038-8fcb-946011cc602c"), new Guid("9c238b0f-8704-443a-9f61-1c158429fb18"), new Guid("f0f4783b-d049-4e5b-8414-049545a002b7"), "Tool Dissectional/Volcano Entertainment", "2019", "Litanie contre la peur" },
                    { new Guid("94a33573-5378-4615-8289-7c8844c51002"), new Guid("0ddbba49-4c9f-4038-805a-df9843171661"), new Guid("f0f4783b-d049-4e5b-8414-049545a002b7"), "Zoo Entertainment", "1996", "H." },
                    { new Guid("01d1c661-e25a-4be1-a826-27ccec7db895"), new Guid("0ddbba49-4c9f-4038-805a-df9843171661"), new Guid("f0f4783b-d049-4e5b-8414-049545a002b7"), "Zoo Entertainment", "1996", "Forty Six & 2" },
                    { new Guid("2829a688-a19e-42eb-81da-3e52e6e54c7f"), new Guid("0ddbba49-4c9f-4038-805a-df9843171661"), new Guid("f0f4783b-d049-4e5b-8414-049545a002b7"), "Zoo Entertainment", "1996", "Message to Harry Manback" },
                    { new Guid("0cd03ff2-29b1-4add-a226-22c4712db915"), new Guid("0ddbba49-4c9f-4038-805a-df9843171661"), new Guid("f0f4783b-d049-4e5b-8414-049545a002b7"), "Zoo Entertainment", "1996", "Hooker with a Denis" },
                    { new Guid("2f59fb70-5fb8-4529-be18-bb871b723414"), new Guid("0ddbba49-4c9f-4038-805a-df9843171661"), new Guid("f0f4783b-d049-4e5b-8414-049545a002b7"), "Zoo Entertainment", "1996", "Intermission" },
                    { new Guid("40fd23c6-f1fa-4ecb-b7b4-0d975dc55955"), new Guid("0ddbba49-4c9f-4038-805a-df9843171661"), new Guid("f0f4783b-d049-4e5b-8414-049545a002b7"), "Zoo Entertainment", "1996", "jimmy" },
                    { new Guid("f1f0627a-f244-4259-83c2-282fb9b5232f"), new Guid("0ddbba49-4c9f-4038-805a-df9843171661"), new Guid("f0f4783b-d049-4e5b-8414-049545a002b7"), "Zoo Entertainment", "1996", "Die Eier von Satan" },
                    { new Guid("5e37574c-219b-4b80-8480-4eefa797a685"), new Guid("0ddbba49-4c9f-4038-805a-df9843171661"), new Guid("f0f4783b-d049-4e5b-8414-049545a002b7"), "Zoo Entertainment", "1996", "Pushit" },
                    { new Guid("d0dfdfb0-e913-4aa5-be4b-032f83195e57"), new Guid("0ddbba49-4c9f-4038-805a-df9843171661"), new Guid("f0f4783b-d049-4e5b-8414-049545a002b7"), "Zoo Entertainment", "1996", "Cesaro Summability" },
                    { new Guid("f21e41ed-52d3-4ff9-875c-943b4317bf64"), new Guid("0ddbba49-4c9f-4038-805a-df9843171661"), new Guid("f0f4783b-d049-4e5b-8414-049545a002b7"), "Zoo Entertainment", "1996", "AEnema" },
                    { new Guid("6a421403-3c7a-44f1-8957-0a1398a00206"), new Guid("0ddbba49-4c9f-4038-805a-df9843171661"), new Guid("f0f4783b-d049-4e5b-8414-049545a002b7"), "Zoo Entertainment", "1996", "(-) Ions" },
                    { new Guid("1c9b7479-a23b-4683-998f-fbcf27a30ef5"), new Guid("0ddbba49-4c9f-4038-805a-df9843171661"), new Guid("f0f4783b-d049-4e5b-8414-049545a002b7"), "Zoo Entertainment", "1996", "Third Eye" },
                    { new Guid("51c91bd3-caf7-4bf2-99f6-ad4ca48a1645"), new Guid("0ddbba49-4c9f-4038-805a-df9843171661"), new Guid("f0f4783b-d049-4e5b-8414-049545a002b7"), "Zoo Entertainment", "1996", "Useful Idiot" },
                    { new Guid("80cef70d-7202-4c42-8bab-c0cb7742406a"), new Guid("9c238b0f-8704-443a-9f61-1c158429fb18"), new Guid("f0f4783b-d049-4e5b-8414-049545a002b7"), "Tool Dissectional/Volcano Entertainment", "2019", "Invincible" },
                    { new Guid("aeee221a-b043-4f00-8ea4-9272b20442b8"), new Guid("9c238b0f-8704-443a-9f61-1c158429fb18"), new Guid("f0f4783b-d049-4e5b-8414-049545a002b7"), "Tool Dissectional/Volcano Entertainment", "2019", "Legion Inoculant" },
                    { new Guid("bd334bb6-50f6-4b87-af82-4401992755fa"), new Guid("9c238b0f-8704-443a-9f61-1c158429fb18"), new Guid("f0f4783b-d049-4e5b-8414-049545a002b7"), "Tool Dissectional/Volcano Entertainment", "2019", "Descending" },
                    { new Guid("01ade126-19f3-4929-bad7-48f07f60e8af"), new Guid("7051f2a4-7843-49ab-9bb9-80e2e9450095"), new Guid("c2a80b80-048a-4e0e-90b9-314b827abb10"), "Warner Bros./Reprise", "2006", "Capillarian Crest" },
                    { new Guid("73440091-3e77-4bcb-b081-649af54f0319"), new Guid("7051f2a4-7843-49ab-9bb9-80e2e9450095"), new Guid("c2a80b80-048a-4e0e-90b9-314b827abb10"), "Warner Bros./Reprise", "2006", "Circle of Cysquatch" },
                    { new Guid("514f9274-fe1c-40d1-a01f-13650ec5e1e6"), new Guid("7051f2a4-7843-49ab-9bb9-80e2e9450095"), new Guid("c2a80b80-048a-4e0e-90b9-314b827abb10"), "Warner Bros./Reprise", "2006", "Bladecatcher" },
                    { new Guid("cdf4b37f-4665-4c57-9e24-e52c62f06ce1"), new Guid("7051f2a4-7843-49ab-9bb9-80e2e9450095"), new Guid("c2a80b80-048a-4e0e-90b9-314b827abb10"), "Warner Bros./Reprise", "2006", "Colony of Birchmen" },
                    { new Guid("d73eaae4-8f6c-47dc-ac4c-3ca64a09fe9c"), new Guid("7051f2a4-7843-49ab-9bb9-80e2e9450095"), new Guid("c2a80b80-048a-4e0e-90b9-314b827abb10"), "Warner Bros./Reprise", "2006", "Hunters of the Sky" },
                    { new Guid("48b4e71e-ac32-418a-9bd7-093651b1617c"), new Guid("7051f2a4-7843-49ab-9bb9-80e2e9450095"), new Guid("c2a80b80-048a-4e0e-90b9-314b827abb10"), "Warner Bros./Reprise", "2006", "Hand of Stone" },
                    { new Guid("0f30eb3a-4590-49ed-ba15-8c92da7e5aaa"), new Guid("7051f2a4-7843-49ab-9bb9-80e2e9450095"), new Guid("c2a80b80-048a-4e0e-90b9-314b827abb10"), "Warner Bros./Reprise", "2006", "This Mortal Soil" },
                    { new Guid("80af4498-fb5e-44b9-a2b3-0f13b17ff6be"), new Guid("7051f2a4-7843-49ab-9bb9-80e2e9450095"), new Guid("c2a80b80-048a-4e0e-90b9-314b827abb10"), "Warner Bros./Reprise", "2006", "Siberian Divide" },
                    { new Guid("7097b7b5-1408-4bc3-9f3a-bfdefc4d172d"), new Guid("7051f2a4-7843-49ab-9bb9-80e2e9450095"), new Guid("c2a80b80-048a-4e0e-90b9-314b827abb10"), "Warner Bros./Reprise", "2006", "Pendulous Skin" },
                    { new Guid("45974e71-5803-4149-aaee-feb188c1cd3d"), new Guid("efbe4318-e654-420a-bb50-5e04a95c8849"), new Guid("c2a80b80-048a-4e0e-90b9-314b827abb10"), "Reprise", "2009", "Oblivion" },
                    { new Guid("b6547812-3645-423e-954a-0f82d07fc09b"), new Guid("efbe4318-e654-420a-bb50-5e04a95c8849"), new Guid("c2a80b80-048a-4e0e-90b9-314b827abb10"), "Reprise", "2009", "Divinations" },
                    { new Guid("fe70b2c2-d889-4a3b-9585-55df241339fe"), new Guid("7051f2a4-7843-49ab-9bb9-80e2e9450095"), new Guid("c2a80b80-048a-4e0e-90b9-314b827abb10"), "Warner Bros./Reprise", "2006", "Sleeping Giant" },
                    { new Guid("25995275-7ef6-405a-ac06-85081408bbc4"), new Guid("efbe4318-e654-420a-bb50-5e04a95c8849"), new Guid("c2a80b80-048a-4e0e-90b9-314b827abb10"), "Reprise", "2009", "Quintessence" },
                    { new Guid("e5e5b45d-1cfe-43ae-b6e3-2cf124516f0d"), new Guid("efbe4318-e654-420a-bb50-5e04a95c8849"), new Guid("c2a80b80-048a-4e0e-90b9-314b827abb10"), "Reprise", "2009", "Ghost of Karelia" },
                    { new Guid("a7628c43-1139-4a9c-82d8-19fa860de69f"), new Guid("efbe4318-e654-420a-bb50-5e04a95c8849"), new Guid("c2a80b80-048a-4e0e-90b9-314b827abb10"), "Reprise", "2009", "Crack the Skye" },
                    { new Guid("aba83dc4-be2a-458e-ab77-d2560a81cf05"), new Guid("efbe4318-e654-420a-bb50-5e04a95c8849"), new Guid("c2a80b80-048a-4e0e-90b9-314b827abb10"), "Reprise", "2009", "The Last Baron" },
                    { new Guid("d291d8af-3be7-4299-afb4-9ff726cf6ab8"), new Guid("926976b2-7619-41f8-ba19-f572332f3d4d"), new Guid("c2a80b80-048a-4e0e-90b9-314b827abb10"), "Reprise/Roadrunner", "2011", "Black Tongue" },
                    { new Guid("7511fee4-f922-4f0d-8804-515b28b82311"), new Guid("926976b2-7619-41f8-ba19-f572332f3d4d"), new Guid("c2a80b80-048a-4e0e-90b9-314b827abb10"), "Reprise/Roadrunner", "2011", "Curl of the Buri" },
                    { new Guid("4e6b882f-0809-4314-9654-54fb7acb7c5c"), new Guid("926976b2-7619-41f8-ba19-f572332f3d4d"), new Guid("c2a80b80-048a-4e0e-90b9-314b827abb10"), "Reprise/Roadrunner", "2011", "Blasteroid" },
                    { new Guid("c7a32a73-00f0-4e3d-8ee5-d91262192b73"), new Guid("926976b2-7619-41f8-ba19-f572332f3d4d"), new Guid("c2a80b80-048a-4e0e-90b9-314b827abb10"), "Reprise/Roadrunner", "2011", "Stargasm" },
                    { new Guid("c79f39df-0384-4e6d-b3d3-893e661e20e0"), new Guid("926976b2-7619-41f8-ba19-f572332f3d4d"), new Guid("c2a80b80-048a-4e0e-90b9-314b827abb10"), "Reprise/Roadrunner", "2011", "Octupus Has No Friends" },
                    { new Guid("16eb25d3-9375-4ef9-8d32-d9351be91c63"), new Guid("926976b2-7619-41f8-ba19-f572332f3d4d"), new Guid("c2a80b80-048a-4e0e-90b9-314b827abb10"), "Reprise/Roadrunner", "2011", "All the Heavy Lifting" },
                    { new Guid("c1d90d79-6d80-41be-851d-4705f398caad"), new Guid("926976b2-7619-41f8-ba19-f572332f3d4d"), new Guid("c2a80b80-048a-4e0e-90b9-314b827abb10"), "Reprise/Roadrunner", "2011", "The Hunter" },
                    { new Guid("490ccf11-26b0-4f63-8f57-b3d94367bbfc"), new Guid("926976b2-7619-41f8-ba19-f572332f3d4d"), new Guid("c2a80b80-048a-4e0e-90b9-314b827abb10"), "Reprise/Roadrunner", "2011", "Dry Bone Valley" },
                    { new Guid("e08191b3-d89d-4752-9c4d-ba6925a72f92"), new Guid("efbe4318-e654-420a-bb50-5e04a95c8849"), new Guid("c2a80b80-048a-4e0e-90b9-314b827abb10"), "Reprise", "2009", "The Czar" },
                    { new Guid("1835695a-8c3d-42d4-895b-5fa3861aac79"), new Guid("926976b2-7619-41f8-ba19-f572332f3d4d"), new Guid("c2a80b80-048a-4e0e-90b9-314b827abb10"), "Reprise/Roadrunner", "2011", "Creature Lives" },
                    { new Guid("1ada24bd-2a0a-40c3-83a5-27457b833ff3"), new Guid("7051f2a4-7843-49ab-9bb9-80e2e9450095"), new Guid("c2a80b80-048a-4e0e-90b9-314b827abb10"), "Warner Bros./Reprise", "2006", "Crystal Skull" },
                    { new Guid("1a5295cf-f7b2-47a1-a80e-c9f57dcd0416"), new Guid("16b662e3-31b6-47de-b41b-0b79455986b1"), new Guid("c2a80b80-048a-4e0e-90b9-314b827abb10"), "Relapse", "2004", "Joseph Merrick" },
                    { new Guid("7c9c9e88-a7c6-492a-9231-66c20147f76a"), new Guid("9c238b0f-8704-443a-9f61-1c158429fb18"), new Guid("f0f4783b-d049-4e5b-8414-049545a002b7"), "Tool Dissectional/Volcano Entertainment", "2019", "Culling Voices" },
                    { new Guid("4bf33e28-c7a4-47fc-9028-471555f5ad72"), new Guid("9c238b0f-8704-443a-9f61-1c158429fb18"), new Guid("f0f4783b-d049-4e5b-8414-049545a002b7"), "Tool Dissectional/Volcano Entertainment", "2019", "Chocolate Chip Trip" },
                    { new Guid("1515b194-17c2-4fcb-baec-0e634064dbc7"), new Guid("9c238b0f-8704-443a-9f61-1c158429fb18"), new Guid("f0f4783b-d049-4e5b-8414-049545a002b7"), "Tool Dissectional/Volcano Entertainment", "2019", "7empest" },
                    { new Guid("0d4ae076-afda-4456-b888-b5b5d4823903"), new Guid("9c238b0f-8704-443a-9f61-1c158429fb18"), new Guid("f0f4783b-d049-4e5b-8414-049545a002b7"), "Tool Dissectional/Volcano Entertainment", "2019", "Mockingbeat" },
                    { new Guid("ce630cd8-3e44-49f1-9bb3-86767fa6cb90"), new Guid("f5cd1cb4-206d-4761-81ac-7282ddf1f484"), new Guid("c2a80b80-048a-4e0e-90b9-314b827abb10"), "Relapse", "2002", "Crusher Destroyer" },
                    { new Guid("3ced91be-c2eb-4a2f-a8e2-172d794a14d8"), new Guid("f5cd1cb4-206d-4761-81ac-7282ddf1f484"), new Guid("c2a80b80-048a-4e0e-90b9-314b827abb10"), "Relapse", "2002", "March of the Fire Ants" },
                    { new Guid("1cec86bc-4a0e-471f-963d-f266f26a9460"), new Guid("f5cd1cb4-206d-4761-81ac-7282ddf1f484"), new Guid("c2a80b80-048a-4e0e-90b9-314b827abb10"), "Relapse", "2002", "Where Strides the Behemoth" },
                    { new Guid("8128b230-e043-48c5-823b-826e402347e5"), new Guid("f5cd1cb4-206d-4761-81ac-7282ddf1f484"), new Guid("c2a80b80-048a-4e0e-90b9-314b827abb10"), "Relapse", "2002", "Workhorse" },
                    { new Guid("78bbc53d-cbd8-4541-9e9b-dd405a0e1ff0"), new Guid("f5cd1cb4-206d-4761-81ac-7282ddf1f484"), new Guid("c2a80b80-048a-4e0e-90b9-314b827abb10"), "Relapse", "2002", "Ol'e Nessie" },
                    { new Guid("f8d290d3-1a01-49f6-b9c2-a89fcdb302bb"), new Guid("f5cd1cb4-206d-4761-81ac-7282ddf1f484"), new Guid("c2a80b80-048a-4e0e-90b9-314b827abb10"), "Relapse", "2002", "Burning Man" },
                    { new Guid("e0787084-89c6-4690-b197-d9a125254ec9"), new Guid("f5cd1cb4-206d-4761-81ac-7282ddf1f484"), new Guid("c2a80b80-048a-4e0e-90b9-314b827abb10"), "Relapse", "2002", "Trainwreck" },
                    { new Guid("1561fd39-2088-410d-9e84-9c8eafaabf5b"), new Guid("7051f2a4-7843-49ab-9bb9-80e2e9450095"), new Guid("c2a80b80-048a-4e0e-90b9-314b827abb10"), "Warner Bros./Reprise", "2006", "The Wolf Is Loose" },
                    { new Guid("e5d48d5d-9df1-49c5-91b8-f6d32e1957d4"), new Guid("f5cd1cb4-206d-4761-81ac-7282ddf1f484"), new Guid("c2a80b80-048a-4e0e-90b9-314b827abb10"), "Relapse", "2002", "Trempled Under Hoof" },
                    { new Guid("41a48803-f34b-47b4-b8f4-94bdaac5bfd7"), new Guid("f5cd1cb4-206d-4761-81ac-7282ddf1f484"), new Guid("c2a80b80-048a-4e0e-90b9-314b827abb10"), "Relapse", "2002", "Mother Puncher" },
                    { new Guid("ea296eb2-7b85-4046-baa3-7d8f1dde9fae"), new Guid("f5cd1cb4-206d-4761-81ac-7282ddf1f484"), new Guid("c2a80b80-048a-4e0e-90b9-314b827abb10"), "Relapse", "2002", "Elephant Man" },
                    { new Guid("88b675f2-251c-45a3-a2cd-79bdb7b419ad"), new Guid("16b662e3-31b6-47de-b41b-0b79455986b1"), new Guid("c2a80b80-048a-4e0e-90b9-314b827abb10"), "Relapse", "2004", "Blood and Thunder" },
                    { new Guid("9e882f7e-732a-4fcf-81d2-d95b7d1e3aa9"), new Guid("16b662e3-31b6-47de-b41b-0b79455986b1"), new Guid("c2a80b80-048a-4e0e-90b9-314b827abb10"), "Relapse", "2004", "I Am Ahab" },
                    { new Guid("a57d3de5-9873-48f2-8491-b622afcbe94c"), new Guid("16b662e3-31b6-47de-b41b-0b79455986b1"), new Guid("c2a80b80-048a-4e0e-90b9-314b827abb10"), "Relapse", "2004", "Seabeast" },
                    { new Guid("573aee72-5095-4ada-a1e4-264bb42a936a"), new Guid("16b662e3-31b6-47de-b41b-0b79455986b1"), new Guid("c2a80b80-048a-4e0e-90b9-314b827abb10"), "Relapse", "2004", "Island" },
                    { new Guid("ce28bc8d-6338-4122-a62d-7098e5c9b121"), new Guid("16b662e3-31b6-47de-b41b-0b79455986b1"), new Guid("c2a80b80-048a-4e0e-90b9-314b827abb10"), "Relapse", "2004", "Iron Tusk" },
                    { new Guid("98b88a44-1d21-4ef4-97c2-284a182e8579"), new Guid("16b662e3-31b6-47de-b41b-0b79455986b1"), new Guid("c2a80b80-048a-4e0e-90b9-314b827abb10"), "Relapse", "2004", "Megalodon" },
                    { new Guid("9e91d04c-6d52-4f07-923e-f8980523cb3d"), new Guid("16b662e3-31b6-47de-b41b-0b79455986b1"), new Guid("c2a80b80-048a-4e0e-90b9-314b827abb10"), "Relapse", "2004", "Naked Burn" },
                    { new Guid("41360939-755a-423d-93ef-b2285a231731"), new Guid("16b662e3-31b6-47de-b41b-0b79455986b1"), new Guid("c2a80b80-048a-4e0e-90b9-314b827abb10"), "Relapse", "2004", "Aqua Dementia" },
                    { new Guid("bb9552ac-9f52-4499-8e45-9ed021e2bbb0"), new Guid("16b662e3-31b6-47de-b41b-0b79455986b1"), new Guid("c2a80b80-048a-4e0e-90b9-314b827abb10"), "Relapse", "2004", "Hearts Alive" },
                    { new Guid("6edbaeca-8a90-4f02-ad3a-1a6a9c6a363d"), new Guid("f5cd1cb4-206d-4761-81ac-7282ddf1f484"), new Guid("c2a80b80-048a-4e0e-90b9-314b827abb10"), "Relapse", "2002", "Triobite" },
                    { new Guid("dc2672d0-5ef9-475d-b29d-55ff7904e5e6"), new Guid("1fbd29e0-b675-4428-9cb0-358471cce184"), new Guid("6c274c28-2413-4d3f-b73d-0dc0b19697ab"), "Reprise Records", "2009", "Talk Dirty to Me" }
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
