using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCinema.Migrations
{
    /// <inheritdoc />
    public partial class NoCountryId2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Film_Countrie_CountryId",
                table: "Film");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateTime",
                table: "Session",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 15, 14, 59, 12, 195, DateTimeKind.Local).AddTicks(6079),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 15, 14, 56, 28, 435, DateTimeKind.Local).AddTicks(2899));

            migrationBuilder.AlterColumn<int>(
                name: "CountryId",
                table: "Film",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Film_Countrie_CountryId",
                table: "Film",
                column: "CountryId",
                principalTable: "Countrie",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Film_Countrie_CountryId",
                table: "Film");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateTime",
                table: "Session",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 15, 14, 56, 28, 435, DateTimeKind.Local).AddTicks(2899),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 15, 14, 59, 12, 195, DateTimeKind.Local).AddTicks(6079));

            migrationBuilder.AlterColumn<int>(
                name: "CountryId",
                table: "Film",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Film_Countrie_CountryId",
                table: "Film",
                column: "CountryId",
                principalTable: "Countrie",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
