using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace fpv_info.Migrations
{
    public partial class Mg200118_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PDBId",
                table: "Files",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "PDBs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description_en = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description_ru = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ManufacturerId = table.Column<int>(type: "int", nullable: true),
                    Name_en = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name_ru = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PDBs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PDBs_Companies_ManufacturerId",
                        column: x => x.ManufacturerId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Files_PDBId",
                table: "Files",
                column: "PDBId");

            migrationBuilder.CreateIndex(
                name: "IX_PDBs_ManufacturerId",
                table: "PDBs",
                column: "ManufacturerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Files_PDBs_PDBId",
                table: "Files",
                column: "PDBId",
                principalTable: "PDBs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Files_PDBs_PDBId",
                table: "Files");

            migrationBuilder.DropTable(
                name: "PDBs");

            migrationBuilder.DropIndex(
                name: "IX_Files_PDBId",
                table: "Files");

            migrationBuilder.DropColumn(
                name: "PDBId",
                table: "Files");
        }
    }
}
