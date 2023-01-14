using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCinema.Migrations
{
    /// <inheritdoc />
    public partial class Lab4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cinemas_CinemasNetworks_CinemasNetworkId",
                table: "Cinemas");

            migrationBuilder.DropForeignKey(
                name: "FK_Film_Country_CountryId",
                table: "Film");

            migrationBuilder.DropForeignKey(
                name: "FK_Hall_Cinemas_CinemaId",
                table: "Hall");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_Country_FilmId",
                table: "Country");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_Country_Name",
                table: "Country");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Country",
                table: "Country");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CinemasNetworks",
                table: "CinemasNetworks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cinemas",
                table: "Cinemas");

            migrationBuilder.RenameTable(
                name: "Country",
                newName: "Countrie");

            migrationBuilder.RenameTable(
                name: "CinemasNetworks",
                newName: "CinemasNetwork");

            migrationBuilder.RenameTable(
                name: "Cinemas",
                newName: "Cinema");

            migrationBuilder.RenameIndex(
                name: "IX_Cinemas_CinemasNetworkId",
                table: "Cinema",
                newName: "IX_Cinema_CinemasNetworkId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateTime",
                table: "Session",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 14, 14, 17, 19, 706, DateTimeKind.Local).AddTicks(1262),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 10, 22, 59, 46, 86, DateTimeKind.Local).AddTicks(2338));

            migrationBuilder.AlterColumn<int>(
                name: "FilmId",
                table: "Countrie",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_Countrie_Name",
                table: "Countrie",
                column: "Name");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Countrie",
                table: "Countrie",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CinemasNetwork",
                table: "CinemasNetwork",
                column: "cinemasnetwork_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cinema",
                table: "Cinema",
                column: "cinema_id");

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

            migrationBuilder.InsertData(
                table: "Countrie",
                columns: new[] { "Id", "FilmId", "Name" },
                values: new object[] { 1, null, "USA" });

            migrationBuilder.InsertData(
                table: "Genre",
                columns: new[] { "Id", "FilmId", "Name" },
                values: new object[] { 1, null, "Fantasy" });

            migrationBuilder.AddForeignKey(
                name: "FK_Cinema_CinemasNetwork_CinemasNetworkId",
                table: "Cinema",
                column: "CinemasNetworkId",
                principalTable: "CinemasNetwork",
                principalColumn: "cinemasnetwork_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Film_Countrie_CountryId",
                table: "Film",
                column: "CountryId",
                principalTable: "Countrie",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Hall_Cinema_CinemaId",
                table: "Hall",
                column: "CinemaId",
                principalTable: "Cinema",
                principalColumn: "cinema_id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cinema_CinemasNetwork_CinemasNetworkId",
                table: "Cinema");

            migrationBuilder.DropForeignKey(
                name: "FK_Film_Countrie_CountryId",
                table: "Film");

            migrationBuilder.DropForeignKey(
                name: "FK_Hall_Cinema_CinemaId",
                table: "Hall");

            migrationBuilder.DropTable(
                name: "Series");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_Countrie_Name",
                table: "Countrie");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Countrie",
                table: "Countrie");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CinemasNetwork",
                table: "CinemasNetwork");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cinema",
                table: "Cinema");

            migrationBuilder.DeleteData(
                table: "Countrie",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.RenameTable(
                name: "Countrie",
                newName: "Country");

            migrationBuilder.RenameTable(
                name: "CinemasNetwork",
                newName: "CinemasNetworks");

            migrationBuilder.RenameTable(
                name: "Cinema",
                newName: "Cinemas");

            migrationBuilder.RenameIndex(
                name: "IX_Cinema_CinemasNetworkId",
                table: "Cinemas",
                newName: "IX_Cinemas_CinemasNetworkId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateTime",
                table: "Session",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 10, 22, 59, 46, 86, DateTimeKind.Local).AddTicks(2338),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 14, 14, 17, 19, 706, DateTimeKind.Local).AddTicks(1262));

            migrationBuilder.AlterColumn<int>(
                name: "FilmId",
                table: "Country",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddUniqueConstraint(
                name: "AK_Country_FilmId",
                table: "Country",
                column: "FilmId");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_Country_Name",
                table: "Country",
                column: "Name");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Country",
                table: "Country",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CinemasNetworks",
                table: "CinemasNetworks",
                column: "cinemasnetwork_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cinemas",
                table: "Cinemas",
                column: "cinema_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Cinemas_CinemasNetworks_CinemasNetworkId",
                table: "Cinemas",
                column: "CinemasNetworkId",
                principalTable: "CinemasNetworks",
                principalColumn: "cinemasnetwork_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Film_Country_CountryId",
                table: "Film",
                column: "CountryId",
                principalTable: "Country",
                principalColumn: "FilmId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Hall_Cinemas_CinemaId",
                table: "Hall",
                column: "CinemaId",
                principalTable: "Cinemas",
                principalColumn: "cinema_id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
