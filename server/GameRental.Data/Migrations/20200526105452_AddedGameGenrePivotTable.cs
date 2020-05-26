using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GameRental.Data.Migrations
{
    public partial class AddedGameGenrePivotTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GameGenres",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameGenres", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GameGenresPivot",
                columns: table => new
                {
                    GameId = table.Column<int>(nullable: false),
                    GenreId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameGenresPivot", x => new { x.GameId, x.GenreId });
                    table.ForeignKey(
                        name: "FK_GameGenresPivot_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GameGenresPivot_GameGenres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "GameGenres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "GameGenres",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Action" },
                    { 2, "Third Person Shooter" },
                    { 3, "Platformer" },
                    { 4, "Survival" },
                    { 5, "Horror" }
                });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Ref", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 26, 12, 54, 51, 969, DateTimeKind.Local).AddTicks(1720), new Guid("849cf2e9-748d-461d-a8da-0875faff61b3"), new DateTime(2020, 5, 26, 12, 54, 51, 969, DateTimeKind.Local).AddTicks(2150) });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "CoverArtUrl", "CreatedAt", "DeletedAt", "Description", "Name", "PublisherId", "Ref", "ReleaseDate", "UpdatedAt" },
                values: new object[] { 2, "https://upload.wikimedia.org/wikipedia/en/4/44/Crash_Bandicoot_Cover.png", new DateTime(2020, 5, 26, 12, 54, 51, 969, DateTimeKind.Local).AddTicks(3240), null, "Crash Bandicoot is a platform video game developed by Naughty Dog and published by Sony Computer Entertainment for the PlayStation. The game was released in North America in September 1996, and in Europe in November 1996.", "Crash Bandicoot", 1, new Guid("6072c524-8ad1-468f-869c-82c42d03cbea"), new DateTime(1996, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 26, 12, 54, 51, 969, DateTimeKind.Local).AddTicks(3260) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 26, 12, 54, 51, 958, DateTimeKind.Local).AddTicks(2510), new DateTime(2020, 5, 26, 12, 54, 51, 968, DateTimeKind.Local).AddTicks(6460) });

            migrationBuilder.InsertData(
                table: "GameGenresPivot",
                columns: new[] { "GameId", "GenreId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 3 },
                    { 2, 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_GameGenresPivot_GenreId",
                table: "GameGenresPivot",
                column: "GenreId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GameGenresPivot");

            migrationBuilder.DropTable(
                name: "GameGenres");

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Ref", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 26, 12, 26, 36, 130, DateTimeKind.Local).AddTicks(860), new Guid("2f0e5116-58b8-4076-8083-e99994960164"), new DateTime(2020, 5, 26, 12, 26, 36, 130, DateTimeKind.Local).AddTicks(1300) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 26, 12, 26, 36, 119, DateTimeKind.Local).AddTicks(3140), new DateTime(2020, 5, 26, 12, 26, 36, 129, DateTimeKind.Local).AddTicks(7050) });
        }
    }
}
