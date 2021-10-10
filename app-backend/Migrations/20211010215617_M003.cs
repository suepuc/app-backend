using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace app_backend.Migrations
{
    public partial class M003 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "contadorFavoritos",
                table: "Receitas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "dataDeCriacao",
                table: "Receitas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "modoDePreparo",
                table: "Receitas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "tempoDePreparo",
                table: "Receitas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "titulo",
                table: "Receitas",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "contadorFavoritos",
                table: "Receitas");

            migrationBuilder.DropColumn(
                name: "dataDeCriacao",
                table: "Receitas");

            migrationBuilder.DropColumn(
                name: "modoDePreparo",
                table: "Receitas");

            migrationBuilder.DropColumn(
                name: "tempoDePreparo",
                table: "Receitas");

            migrationBuilder.DropColumn(
                name: "titulo",
                table: "Receitas");
        }
    }
}
