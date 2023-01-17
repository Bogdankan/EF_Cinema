using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCinema.Migrations
{
    /// <inheritdoc />
    public partial class nocountryid : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Series");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateTime",
                table: "Session",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 17, 21, 13, 30, 363, DateTimeKind.Local).AddTicks(2725),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 14, 14, 17, 19, 706, DateTimeKind.Local).AddTicks(1262));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateTime",
                table: "Session",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 14, 14, 17, 19, 706, DateTimeKind.Local).AddTicks(1262),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 17, 21, 13, 30, 363, DateTimeKind.Local).AddTicks(2725));

            migrationBuilder.CreateTable(
                name: "Series",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    EpisodeCount = table.Column<int>(type: "int", nullable: false),
                    SeasonsCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Series", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Series_Film_Id",
                        column: x => x.Id,
                        principalTable: "Film",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
        }
    }
}
