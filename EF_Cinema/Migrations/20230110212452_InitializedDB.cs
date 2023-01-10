using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCinema.Migrations
{
    /// <inheritdoc />
    public partial class InitializedDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateTime",
                table: "Session",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 10, 23, 24, 51, 635, DateTimeKind.Local).AddTicks(3782),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 10, 22, 59, 46, 86, DateTimeKind.Local).AddTicks(2338));

            migrationBuilder.InsertData(
                table: "Genre",
                columns: new[] { "Id", "FilmId", "Name" },
                values: new object[] { 1, null, "Fantasy" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateTime",
                table: "Session",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 10, 22, 59, 46, 86, DateTimeKind.Local).AddTicks(2338),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 10, 23, 24, 51, 635, DateTimeKind.Local).AddTicks(3782));
        }
    }
}
