using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GameRental.Data.Migrations
{
    public partial class AddedGameGenreRelationshipToGameGenrePivotTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Ref", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 26, 14, 5, 9, 379, DateTimeKind.Local).AddTicks(650), new Guid("0a811243-c7a4-4a72-aff7-a42c84255cd2"), new DateTime(2020, 5, 26, 14, 5, 9, 379, DateTimeKind.Local).AddTicks(1090) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Ref", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 26, 14, 5, 9, 379, DateTimeKind.Local).AddTicks(2050), new Guid("c3016508-09af-4921-82c9-fd9c81cfec49"), new DateTime(2020, 5, 26, 14, 5, 9, 379, DateTimeKind.Local).AddTicks(2070) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 26, 14, 5, 9, 368, DateTimeKind.Local).AddTicks(2050), new DateTime(2020, 5, 26, 14, 5, 9, 378, DateTimeKind.Local).AddTicks(5370) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Ref", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 26, 12, 54, 51, 969, DateTimeKind.Local).AddTicks(1720), new Guid("849cf2e9-748d-461d-a8da-0875faff61b3"), new DateTime(2020, 5, 26, 12, 54, 51, 969, DateTimeKind.Local).AddTicks(2150) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Ref", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 26, 12, 54, 51, 969, DateTimeKind.Local).AddTicks(3240), new Guid("6072c524-8ad1-468f-869c-82c42d03cbea"), new DateTime(2020, 5, 26, 12, 54, 51, 969, DateTimeKind.Local).AddTicks(3260) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 26, 12, 54, 51, 958, DateTimeKind.Local).AddTicks(2510), new DateTime(2020, 5, 26, 12, 54, 51, 968, DateTimeKind.Local).AddTicks(6460) });
        }
    }
}
