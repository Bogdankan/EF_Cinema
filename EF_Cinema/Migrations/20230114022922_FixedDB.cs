using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCinema.Migrations
{
    /// <inheritdoc />
    public partial class FixedDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FilmId",
                table: "Countrie");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateTime",
                table: "Session",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 14, 4, 29, 22, 372, DateTimeKind.Local).AddTicks(7144),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 13, 7, 46, 2, 427, DateTimeKind.Local).AddTicks(2298));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateTime",
                table: "Session",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 13, 7, 46, 2, 427, DateTimeKind.Local).AddTicks(2298),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 14, 4, 29, 22, 372, DateTimeKind.Local).AddTicks(7144));

            migrationBuilder.AddColumn<int>(
                name: "FilmId",
                table: "Countrie",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Countrie",
                keyColumn: "Id",
                keyValue: 1,
                column: "FilmId",
                value: null);
        }
    }
}
