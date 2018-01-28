using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace fpv_info.Migrations
{
    public partial class Initial_28_01_2018_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Inarchive",
                table: "VideoTransmitters",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Inarchive",
                table: "VideoReceivers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Inarchive",
                table: "Transmitters",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Inarchive",
                table: "Servos",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Inarchive",
                table: "Receivers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Inarchive",
                table: "RCOthers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Inarchive",
                table: "Props",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Inarchive",
                table: "PDBs",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Inarchive",
                table: "Motors",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Inarchive",
                table: "Lights",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Inarchive",
                table: "Goggles",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Inarchive",
                table: "Fuselages",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Inarchive",
                table: "Frames",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Inarchive",
                table: "FlightControllers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Inarchive",
                table: "ESCs",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Inarchive",
                table: "Chargers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Inarchive",
                table: "Cameras",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Inarchive",
                table: "Batteries",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Inarchive",
                table: "Antennas",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Inarchive",
                table: "Accessories",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Inarchive",
                table: "VideoTransmitters");

            migrationBuilder.DropColumn(
                name: "Inarchive",
                table: "VideoReceivers");

            migrationBuilder.DropColumn(
                name: "Inarchive",
                table: "Transmitters");

            migrationBuilder.DropColumn(
                name: "Inarchive",
                table: "Servos");

            migrationBuilder.DropColumn(
                name: "Inarchive",
                table: "Receivers");

            migrationBuilder.DropColumn(
                name: "Inarchive",
                table: "RCOthers");

            migrationBuilder.DropColumn(
                name: "Inarchive",
                table: "Props");

            migrationBuilder.DropColumn(
                name: "Inarchive",
                table: "PDBs");

            migrationBuilder.DropColumn(
                name: "Inarchive",
                table: "Motors");

            migrationBuilder.DropColumn(
                name: "Inarchive",
                table: "Lights");

            migrationBuilder.DropColumn(
                name: "Inarchive",
                table: "Goggles");

            migrationBuilder.DropColumn(
                name: "Inarchive",
                table: "Fuselages");

            migrationBuilder.DropColumn(
                name: "Inarchive",
                table: "Frames");

            migrationBuilder.DropColumn(
                name: "Inarchive",
                table: "FlightControllers");

            migrationBuilder.DropColumn(
                name: "Inarchive",
                table: "ESCs");

            migrationBuilder.DropColumn(
                name: "Inarchive",
                table: "Chargers");

            migrationBuilder.DropColumn(
                name: "Inarchive",
                table: "Cameras");

            migrationBuilder.DropColumn(
                name: "Inarchive",
                table: "Batteries");

            migrationBuilder.DropColumn(
                name: "Inarchive",
                table: "Antennas");

            migrationBuilder.DropColumn(
                name: "Inarchive",
                table: "Accessories");
        }
    }
}
