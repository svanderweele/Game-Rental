using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GameRental.Data.Migrations
{
    public partial class UpdatedRefGenerationForGame : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
