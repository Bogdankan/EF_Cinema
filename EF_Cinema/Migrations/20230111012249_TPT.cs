using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCinema.Migrations
{
    /// <inheritdoc />
    public partial class TPT : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Films");

            migrationBuilder.DropColumn(
                name: "EpisodeCount",
                table: "Films");

            migrationBuilder.DropColumn(
                name: "SeasonsCount",
                table: "Films");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateTime",
                table: "Session",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 11, 3, 22, 49, 698, DateTimeKind.Local).AddTicks(5885),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 11, 3, 17, 6, 434, DateTimeKind.Local).AddTicks(9873));

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
                        name: "FK_Series_Films_Id",
                        column: x => x.Id,
                        principalTable: "Films",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Series");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateTime",
                table: "Session",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 11, 3, 17, 6, 434, DateTimeKind.Local).AddTicks(9873),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 11, 3, 22, 49, 698, DateTimeKind.Local).AddTicks(5885));

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Films",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "EpisodeCount",
                table: "Films",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SeasonsCount",
                table: "Films",
                type: "int",
                nullable: true);
        }
    }
}
