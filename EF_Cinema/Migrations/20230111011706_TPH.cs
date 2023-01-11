using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCinema.Migrations
{
    /// <inheritdoc />
    public partial class TPH : Migration
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
                name: "FK_FilmGenre_Film_FilmId",
                table: "FilmGenre");

            migrationBuilder.DropForeignKey(
                name: "FK_Hall_Cinemas_CinemaId",
                table: "Hall");

            migrationBuilder.DropForeignKey(
                name: "FK_Session_Film_FilmId",
                table: "Session");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_Country_FilmId",
                table: "Country");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Film",
                table: "Film");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CinemasNetworks",
                table: "CinemasNetworks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cinemas",
                table: "Cinemas");

            migrationBuilder.RenameTable(
                name: "Film",
                newName: "Films");

            migrationBuilder.RenameTable(
                name: "CinemasNetworks",
                newName: "CinemasNetwork");

            migrationBuilder.RenameTable(
                name: "Cinemas",
                newName: "Cinema");

            migrationBuilder.RenameIndex(
                name: "IX_Film_CountryId",
                table: "Films",
                newName: "IX_Films_CountryId");

            migrationBuilder.RenameIndex(
                name: "IX_Cinemas_CinemasNetworkId",
                table: "Cinema",
                newName: "IX_Cinema_CinemasNetworkId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateTime",
                table: "Session",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 11, 3, 17, 6, 434, DateTimeKind.Local).AddTicks(9873),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 10, 23, 24, 51, 635, DateTimeKind.Local).AddTicks(3782));

            migrationBuilder.AlterColumn<int>(
                name: "FilmId",
                table: "Country",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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

            migrationBuilder.AddPrimaryKey(
                name: "PK_Films",
                table: "Films",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CinemasNetwork",
                table: "CinemasNetwork",
                column: "cinemasnetwork_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cinema",
                table: "Cinema",
                column: "cinema_id");

            migrationBuilder.InsertData(
                table: "Country",
                columns: new[] { "Id", "FilmId", "Name" },
                values: new object[] { 1, null, "USA" });

            migrationBuilder.AddForeignKey(
                name: "FK_Cinema_CinemasNetwork_CinemasNetworkId",
                table: "Cinema",
                column: "CinemasNetworkId",
                principalTable: "CinemasNetwork",
                principalColumn: "cinemasnetwork_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FilmGenre_Films_FilmId",
                table: "FilmGenre",
                column: "FilmId",
                principalTable: "Films",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Films_Country_CountryId",
                table: "Films",
                column: "CountryId",
                principalTable: "Country",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Hall_Cinema_CinemaId",
                table: "Hall",
                column: "CinemaId",
                principalTable: "Cinema",
                principalColumn: "cinema_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Session_Films_FilmId",
                table: "Session",
                column: "FilmId",
                principalTable: "Films",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cinema_CinemasNetwork_CinemasNetworkId",
                table: "Cinema");

            migrationBuilder.DropForeignKey(
                name: "FK_FilmGenre_Films_FilmId",
                table: "FilmGenre");

            migrationBuilder.DropForeignKey(
                name: "FK_Films_Country_CountryId",
                table: "Films");

            migrationBuilder.DropForeignKey(
                name: "FK_Hall_Cinema_CinemaId",
                table: "Hall");

            migrationBuilder.DropForeignKey(
                name: "FK_Session_Films_FilmId",
                table: "Session");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Films",
                table: "Films");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CinemasNetwork",
                table: "CinemasNetwork");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cinema",
                table: "Cinema");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Films");

            migrationBuilder.DropColumn(
                name: "EpisodeCount",
                table: "Films");

            migrationBuilder.DropColumn(
                name: "SeasonsCount",
                table: "Films");

            migrationBuilder.RenameTable(
                name: "Films",
                newName: "Film");

            migrationBuilder.RenameTable(
                name: "CinemasNetwork",
                newName: "CinemasNetworks");

            migrationBuilder.RenameTable(
                name: "Cinema",
                newName: "Cinemas");

            migrationBuilder.RenameIndex(
                name: "IX_Films_CountryId",
                table: "Film",
                newName: "IX_Film_CountryId");

            migrationBuilder.RenameIndex(
                name: "IX_Cinema_CinemasNetworkId",
                table: "Cinemas",
                newName: "IX_Cinemas_CinemasNetworkId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateTime",
                table: "Session",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 10, 23, 24, 51, 635, DateTimeKind.Local).AddTicks(3782),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 11, 3, 17, 6, 434, DateTimeKind.Local).AddTicks(9873));

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

            migrationBuilder.AddPrimaryKey(
                name: "PK_Film",
                table: "Film",
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
                name: "FK_FilmGenre_Film_FilmId",
                table: "FilmGenre",
                column: "FilmId",
                principalTable: "Film",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Hall_Cinemas_CinemaId",
                table: "Hall",
                column: "CinemaId",
                principalTable: "Cinemas",
                principalColumn: "cinema_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Session_Film_FilmId",
                table: "Session",
                column: "FilmId",
                principalTable: "Film",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
