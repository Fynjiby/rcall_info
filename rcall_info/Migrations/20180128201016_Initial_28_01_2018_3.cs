using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace fpv_info.Migrations
{
    public partial class Initial_28_01_2018_3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Inarchive",
                table: "VideoTransmitters",
                newName: "InArchive");

            migrationBuilder.RenameColumn(
                name: "Inarchive",
                table: "VideoReceivers",
                newName: "InArchive");

            migrationBuilder.RenameColumn(
                name: "Inarchive",
                table: "Transmitters",
                newName: "InArchive");

            migrationBuilder.RenameColumn(
                name: "Inarchive",
                table: "Servos",
                newName: "InArchive");

            migrationBuilder.RenameColumn(
                name: "Inarchive",
                table: "Receivers",
                newName: "InArchive");

            migrationBuilder.RenameColumn(
                name: "Inarchive",
                table: "RCOthers",
                newName: "InArchive");

            migrationBuilder.RenameColumn(
                name: "Inarchive",
                table: "Props",
                newName: "InArchive");

            migrationBuilder.RenameColumn(
                name: "Inarchive",
                table: "PDBs",
                newName: "InArchive");

            migrationBuilder.RenameColumn(
                name: "Inarchive",
                table: "Motors",
                newName: "InArchive");

            migrationBuilder.RenameColumn(
                name: "Inarchive",
                table: "Lights",
                newName: "InArchive");

            migrationBuilder.RenameColumn(
                name: "Inarchive",
                table: "Goggles",
                newName: "InArchive");

            migrationBuilder.RenameColumn(
                name: "Inarchive",
                table: "Fuselages",
                newName: "InArchive");

            migrationBuilder.RenameColumn(
                name: "Inarchive",
                table: "Frames",
                newName: "InArchive");

            migrationBuilder.RenameColumn(
                name: "Inarchive",
                table: "FlightControllers",
                newName: "InArchive");

            migrationBuilder.RenameColumn(
                name: "Inarchive",
                table: "ESCs",
                newName: "InArchive");

            migrationBuilder.RenameColumn(
                name: "Inarchive",
                table: "Chargers",
                newName: "InArchive");

            migrationBuilder.RenameColumn(
                name: "Inarchive",
                table: "Cameras",
                newName: "InArchive");

            migrationBuilder.RenameColumn(
                name: "Inarchive",
                table: "Batteries",
                newName: "InArchive");

            migrationBuilder.RenameColumn(
                name: "Inarchive",
                table: "Antennas",
                newName: "InArchive");

            migrationBuilder.RenameColumn(
                name: "Inarchive",
                table: "Accessories",
                newName: "InArchive");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "InArchive",
                table: "VideoTransmitters",
                newName: "Inarchive");

            migrationBuilder.RenameColumn(
                name: "InArchive",
                table: "VideoReceivers",
                newName: "Inarchive");

            migrationBuilder.RenameColumn(
                name: "InArchive",
                table: "Transmitters",
                newName: "Inarchive");

            migrationBuilder.RenameColumn(
                name: "InArchive",
                table: "Servos",
                newName: "Inarchive");

            migrationBuilder.RenameColumn(
                name: "InArchive",
                table: "Receivers",
                newName: "Inarchive");

            migrationBuilder.RenameColumn(
                name: "InArchive",
                table: "RCOthers",
                newName: "Inarchive");

            migrationBuilder.RenameColumn(
                name: "InArchive",
                table: "Props",
                newName: "Inarchive");

            migrationBuilder.RenameColumn(
                name: "InArchive",
                table: "PDBs",
                newName: "Inarchive");

            migrationBuilder.RenameColumn(
                name: "InArchive",
                table: "Motors",
                newName: "Inarchive");

            migrationBuilder.RenameColumn(
                name: "InArchive",
                table: "Lights",
                newName: "Inarchive");

            migrationBuilder.RenameColumn(
                name: "InArchive",
                table: "Goggles",
                newName: "Inarchive");

            migrationBuilder.RenameColumn(
                name: "InArchive",
                table: "Fuselages",
                newName: "Inarchive");

            migrationBuilder.RenameColumn(
                name: "InArchive",
                table: "Frames",
                newName: "Inarchive");

            migrationBuilder.RenameColumn(
                name: "InArchive",
                table: "FlightControllers",
                newName: "Inarchive");

            migrationBuilder.RenameColumn(
                name: "InArchive",
                table: "ESCs",
                newName: "Inarchive");

            migrationBuilder.RenameColumn(
                name: "InArchive",
                table: "Chargers",
                newName: "Inarchive");

            migrationBuilder.RenameColumn(
                name: "InArchive",
                table: "Cameras",
                newName: "Inarchive");

            migrationBuilder.RenameColumn(
                name: "InArchive",
                table: "Batteries",
                newName: "Inarchive");

            migrationBuilder.RenameColumn(
                name: "InArchive",
                table: "Antennas",
                newName: "Inarchive");

            migrationBuilder.RenameColumn(
                name: "InArchive",
                table: "Accessories",
                newName: "Inarchive");
        }
    }
}
