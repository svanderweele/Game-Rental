using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GameRental.Data.Migrations
{
    public partial class UpdatedGameModelAndAddedSeedingForGamesPublishersTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CoverArtUrl",
                table: "Games",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ReleaseDate",
                table: "Games",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "Publishers",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Name", "UpdatedAt" },
                values: new object[] { 1, new DateTime(2020, 5, 26, 10, 57, 55, 625, DateTimeKind.Local).AddTicks(750), null, "Sony Interactive Entertainment", new DateTime(2020, 5, 26, 10, 57, 55, 635, DateTimeKind.Local).AddTicks(2720) });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "CoverArtUrl", "CreatedAt", "DeletedAt", "Description", "Name", "PublisherId", "ReleaseDate", "UpdatedAt" },
                values: new object[] { 1, "https://en.wikipedia.org/wiki/Uncharted:_Drake%27s_Fortune#/media/File:Uncharted_Drake's_Fortune.jpg", new DateTime(2020, 5, 26, 10, 57, 55, 635, DateTimeKind.Local).AddTicks(6020), null, "Uncharted: Drake's Fortune is a 2007 action-adventure game developed by Naughty Dog and published by Sony Computer Entertainment. It is the first game in the Uncharted series, and was released in November 2007 for PlayStation 3. Combining action-adventure and platforming elements with a third-person perspective, the game follows Nathan Drake, the supposed descendant of the explorer Sir Francis Drake, as he seeks the lost treasure of El Dorado, with the help of journalist Elena Fisher and mentor Victor Sullivan.[1]", "Uncharted: Drake's Fortune", 1, new DateTime(2007, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 26, 10, 57, 55, 635, DateTimeKind.Local).AddTicks(6450) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "CoverArtUrl",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "ReleaseDate",
                table: "Games");
        }
    }
}
