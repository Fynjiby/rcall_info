using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace fpv_info.Migrations
{
    public partial class Mg200118_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsCompared",
                table: "PDBs",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<float>(
                name: "Weight",
                table: "PDBs",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<bool>(
                name: "IsCompared",
                table: "FlightControllers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<float>(
                name: "Weight",
                table: "FlightControllers",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<int>(
                name: "MotorId",
                table: "Files",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Motors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description_en = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description_ru = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsCompared = table.Column<bool>(type: "bit", nullable: false),
                    ManufacturerId = table.Column<int>(type: "int", nullable: true),
                    Name_en = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name_ru = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Weight = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Motors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Motors_Companies_ManufacturerId",
                        column: x => x.ManufacturerId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Files_MotorId",
                table: "Files",
                column: "MotorId");

            migrationBuilder.CreateIndex(
                name: "IX_Motors_ManufacturerId",
                table: "Motors",
                column: "ManufacturerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Files_Motors_MotorId",
                table: "Files",
                column: "MotorId",
                principalTable: "Motors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Files_Motors_MotorId",
                table: "Files");

            migrationBuilder.DropTable(
                name: "Motors");

            migrationBuilder.DropIndex(
                name: "IX_Files_MotorId",
                table: "Files");

            migrationBuilder.DropColumn(
                name: "IsCompared",
                table: "PDBs");

            migrationBuilder.DropColumn(
                name: "Weight",
                table: "PDBs");

            migrationBuilder.DropColumn(
                name: "IsCompared",
                table: "FlightControllers");

            migrationBuilder.DropColumn(
                name: "Weight",
                table: "FlightControllers");

            migrationBuilder.DropColumn(
                name: "MotorId",
                table: "Files");
        }
    }
}
