using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GameRental.Data.Migrations
{
    public partial class UpdatedGameReleaseDateFormat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ReleaseDate",
                table: "Games",
                type: "datetime(0)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 26, 11, 0, 34, 292, DateTimeKind.Local).AddTicks(7990), new DateTime(2020, 5, 26, 11, 0, 34, 292, DateTimeKind.Local).AddTicks(8410) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 26, 11, 0, 34, 282, DateTimeKind.Local).AddTicks(3370), new DateTime(2020, 5, 26, 11, 0, 34, 292, DateTimeKind.Local).AddTicks(4740) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ReleaseDate",
                table: "Games",
                type: "datetime(6)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime(0)");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 26, 10, 57, 55, 635, DateTimeKind.Local).AddTicks(6020), new DateTime(2020, 5, 26, 10, 57, 55, 635, DateTimeKind.Local).AddTicks(6450) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 26, 10, 57, 55, 625, DateTimeKind.Local).AddTicks(750), new DateTime(2020, 5, 26, 10, 57, 55, 635, DateTimeKind.Local).AddTicks(2720) });
        }
    }
}
