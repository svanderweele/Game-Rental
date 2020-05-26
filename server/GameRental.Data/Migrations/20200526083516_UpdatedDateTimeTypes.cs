using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GameRental.Data.Migrations
{
    public partial class UpdatedDateTimeTypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Publishers",
                type: "datetime(0)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldMaxLength: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeletedAt",
                table: "Publishers",
                type: "datetime(0)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldMaxLength: 0,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Publishers",
                type: "datetime(0)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldMaxLength: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Games",
                type: "datetime(0)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldMaxLength: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeletedAt",
                table: "Games",
                type: "datetime(0)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldMaxLength: 0,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Games",
                type: "datetime(0)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldMaxLength: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Publishers",
                type: "datetime(6)",
                maxLength: 0,
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime(0)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeletedAt",
                table: "Publishers",
                type: "datetime(6)",
                maxLength: 0,
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime(0)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Publishers",
                type: "datetime(6)",
                maxLength: 0,
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime(0)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Games",
                type: "datetime(6)",
                maxLength: 0,
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime(0)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeletedAt",
                table: "Games",
                type: "datetime(6)",
                maxLength: 0,
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime(0)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Games",
                type: "datetime(6)",
                maxLength: 0,
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime(0)");
        }
    }
}
