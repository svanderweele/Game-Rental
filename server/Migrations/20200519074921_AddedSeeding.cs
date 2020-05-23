using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace server.Migrations
{
    public partial class AddedSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Publishers",
                columns: new[] { "Id", "Name", "Ref" },
                values: new object[] { 1, "Sony Interactive Entertainment", new Guid("7320e219-b461-4f9d-a793-341cd1763198") });

            migrationBuilder.InsertData(
                table: "Publishers",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Capcom" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
