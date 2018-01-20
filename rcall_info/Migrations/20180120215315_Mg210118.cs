using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace fpv_info.Migrations
{
    public partial class Mg210118 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FlightControllers_Companies_ManufacturerId",
                table: "FlightControllers");

            migrationBuilder.DropForeignKey(
                name: "FK_Motors_Companies_ManufacturerId",
                table: "Motors");

            migrationBuilder.DropForeignKey(
                name: "FK_PDBs_Companies_ManufacturerId",
                table: "PDBs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Companies",
                table: "Companies");

            migrationBuilder.RenameTable(
                name: "Companies",
                newName: "Company");

            migrationBuilder.AddColumn<int>(
                name: "ProcessorId",
                table: "FlightControllers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AccessoryModelId",
                table: "Files",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AntennaId",
                table: "Files",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BatteryId",
                table: "Files",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CameraId",
                table: "Files",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ChargerId",
                table: "Files",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ESCId",
                table: "Files",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FrameId",
                table: "Files",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FuselageId",
                table: "Files",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GoggleId",
                table: "Files",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LightId",
                table: "Files",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PropId",
                table: "Files",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RCOtherId",
                table: "Files",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ReceiverId",
                table: "Files",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ServoId",
                table: "Files",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TransmitterId",
                table: "Files",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VideoReceiverId",
                table: "Files",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VideoTransmitterId",
                table: "Files",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Company",
                table: "Company",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Accessories",
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
                    table.PrimaryKey("PK_Accessories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Accessories_Company_ManufacturerId",
                        column: x => x.ManufacturerId,
                        principalTable: "Company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Antennas",
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
                    table.PrimaryKey("PK_Antennas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Antennas_Company_ManufacturerId",
                        column: x => x.ManufacturerId,
                        principalTable: "Company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Batteries",
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
                    table.PrimaryKey("PK_Batteries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Batteries_Company_ManufacturerId",
                        column: x => x.ManufacturerId,
                        principalTable: "Company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Cameras",
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
                    table.PrimaryKey("PK_Cameras", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cameras_Company_ManufacturerId",
                        column: x => x.ManufacturerId,
                        principalTable: "Company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Chargers",
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
                    table.PrimaryKey("PK_Chargers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Chargers_Company_ManufacturerId",
                        column: x => x.ManufacturerId,
                        principalTable: "Company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ESCs",
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
                    table.PrimaryKey("PK_ESCs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ESCs_Company_ManufacturerId",
                        column: x => x.ManufacturerId,
                        principalTable: "Company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FrameTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FrameTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FuselageTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FuselageTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Goggles",
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
                    table.PrimaryKey("PK_Goggles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Goggles_Company_ManufacturerId",
                        column: x => x.ManufacturerId,
                        principalTable: "Company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Lights",
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
                    table.PrimaryKey("PK_Lights", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Lights_Company_ManufacturerId",
                        column: x => x.ManufacturerId,
                        principalTable: "Company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Processors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description_en = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description_ru = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Processors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Props",
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
                    table.PrimaryKey("PK_Props", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Props_Company_ManufacturerId",
                        column: x => x.ManufacturerId,
                        principalTable: "Company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RCOthers",
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
                    table.PrimaryKey("PK_RCOthers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RCOthers_Company_ManufacturerId",
                        column: x => x.ManufacturerId,
                        principalTable: "Company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Receivers",
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
                    table.PrimaryKey("PK_Receivers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Receivers_Company_ManufacturerId",
                        column: x => x.ManufacturerId,
                        principalTable: "Company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Servos",
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
                    table.PrimaryKey("PK_Servos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Servos_Company_ManufacturerId",
                        column: x => x.ManufacturerId,
                        principalTable: "Company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Stores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description_en = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description_ru = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Transmitters",
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
                    table.PrimaryKey("PK_Transmitters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Transmitters_Company_ManufacturerId",
                        column: x => x.ManufacturerId,
                        principalTable: "Company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "VideoReceivers",
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
                    table.PrimaryKey("PK_VideoReceivers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VideoReceivers_Company_ManufacturerId",
                        column: x => x.ManufacturerId,
                        principalTable: "Company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "VideoTransmitters",
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
                    table.PrimaryKey("PK_VideoTransmitters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VideoTransmitters_Company_ManufacturerId",
                        column: x => x.ManufacturerId,
                        principalTable: "Company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Frames",
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
                    TypeId = table.Column<int>(type: "int", nullable: true),
                    Weight = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Frames", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Frames_Company_ManufacturerId",
                        column: x => x.ManufacturerId,
                        principalTable: "Company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Frames_FrameTypes_TypeId",
                        column: x => x.TypeId,
                        principalTable: "FrameTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Fuselages",
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
                    TypeId = table.Column<int>(type: "int", nullable: true),
                    Weight = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fuselages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Fuselages_Company_ManufacturerId",
                        column: x => x.ManufacturerId,
                        principalTable: "Company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Fuselages_FuselageTypes_TypeId",
                        column: x => x.TypeId,
                        principalTable: "FuselageTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Links",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Path = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StoreId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Links", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Links_Stores_StoreId",
                        column: x => x.StoreId,
                        principalTable: "Stores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FlightControllers_ProcessorId",
                table: "FlightControllers",
                column: "ProcessorId");

            migrationBuilder.CreateIndex(
                name: "IX_Files_AccessoryModelId",
                table: "Files",
                column: "AccessoryModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Files_AntennaId",
                table: "Files",
                column: "AntennaId");

            migrationBuilder.CreateIndex(
                name: "IX_Files_BatteryId",
                table: "Files",
                column: "BatteryId");

            migrationBuilder.CreateIndex(
                name: "IX_Files_CameraId",
                table: "Files",
                column: "CameraId");

            migrationBuilder.CreateIndex(
                name: "IX_Files_ChargerId",
                table: "Files",
                column: "ChargerId");

            migrationBuilder.CreateIndex(
                name: "IX_Files_ESCId",
                table: "Files",
                column: "ESCId");

            migrationBuilder.CreateIndex(
                name: "IX_Files_FrameId",
                table: "Files",
                column: "FrameId");

            migrationBuilder.CreateIndex(
                name: "IX_Files_FuselageId",
                table: "Files",
                column: "FuselageId");

            migrationBuilder.CreateIndex(
                name: "IX_Files_GoggleId",
                table: "Files",
                column: "GoggleId");

            migrationBuilder.CreateIndex(
                name: "IX_Files_LightId",
                table: "Files",
                column: "LightId");

            migrationBuilder.CreateIndex(
                name: "IX_Files_PropId",
                table: "Files",
                column: "PropId");

            migrationBuilder.CreateIndex(
                name: "IX_Files_RCOtherId",
                table: "Files",
                column: "RCOtherId");

            migrationBuilder.CreateIndex(
                name: "IX_Files_ReceiverId",
                table: "Files",
                column: "ReceiverId");

            migrationBuilder.CreateIndex(
                name: "IX_Files_ServoId",
                table: "Files",
                column: "ServoId");

            migrationBuilder.CreateIndex(
                name: "IX_Files_TransmitterId",
                table: "Files",
                column: "TransmitterId");

            migrationBuilder.CreateIndex(
                name: "IX_Files_VideoReceiverId",
                table: "Files",
                column: "VideoReceiverId");

            migrationBuilder.CreateIndex(
                name: "IX_Files_VideoTransmitterId",
                table: "Files",
                column: "VideoTransmitterId");

            migrationBuilder.CreateIndex(
                name: "IX_Accessories_ManufacturerId",
                table: "Accessories",
                column: "ManufacturerId");

            migrationBuilder.CreateIndex(
                name: "IX_Antennas_ManufacturerId",
                table: "Antennas",
                column: "ManufacturerId");

            migrationBuilder.CreateIndex(
                name: "IX_Batteries_ManufacturerId",
                table: "Batteries",
                column: "ManufacturerId");

            migrationBuilder.CreateIndex(
                name: "IX_Cameras_ManufacturerId",
                table: "Cameras",
                column: "ManufacturerId");

            migrationBuilder.CreateIndex(
                name: "IX_Chargers_ManufacturerId",
                table: "Chargers",
                column: "ManufacturerId");

            migrationBuilder.CreateIndex(
                name: "IX_ESCs_ManufacturerId",
                table: "ESCs",
                column: "ManufacturerId");

            migrationBuilder.CreateIndex(
                name: "IX_Frames_ManufacturerId",
                table: "Frames",
                column: "ManufacturerId");

            migrationBuilder.CreateIndex(
                name: "IX_Frames_TypeId",
                table: "Frames",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Fuselages_ManufacturerId",
                table: "Fuselages",
                column: "ManufacturerId");

            migrationBuilder.CreateIndex(
                name: "IX_Fuselages_TypeId",
                table: "Fuselages",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Goggles_ManufacturerId",
                table: "Goggles",
                column: "ManufacturerId");

            migrationBuilder.CreateIndex(
                name: "IX_Lights_ManufacturerId",
                table: "Lights",
                column: "ManufacturerId");

            migrationBuilder.CreateIndex(
                name: "IX_Links_StoreId",
                table: "Links",
                column: "StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_Props_ManufacturerId",
                table: "Props",
                column: "ManufacturerId");

            migrationBuilder.CreateIndex(
                name: "IX_RCOthers_ManufacturerId",
                table: "RCOthers",
                column: "ManufacturerId");

            migrationBuilder.CreateIndex(
                name: "IX_Receivers_ManufacturerId",
                table: "Receivers",
                column: "ManufacturerId");

            migrationBuilder.CreateIndex(
                name: "IX_Servos_ManufacturerId",
                table: "Servos",
                column: "ManufacturerId");

            migrationBuilder.CreateIndex(
                name: "IX_Transmitters_ManufacturerId",
                table: "Transmitters",
                column: "ManufacturerId");

            migrationBuilder.CreateIndex(
                name: "IX_VideoReceivers_ManufacturerId",
                table: "VideoReceivers",
                column: "ManufacturerId");

            migrationBuilder.CreateIndex(
                name: "IX_VideoTransmitters_ManufacturerId",
                table: "VideoTransmitters",
                column: "ManufacturerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Files_Accessories_AccessoryModelId",
                table: "Files",
                column: "AccessoryModelId",
                principalTable: "Accessories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Files_Antennas_AntennaId",
                table: "Files",
                column: "AntennaId",
                principalTable: "Antennas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Files_Batteries_BatteryId",
                table: "Files",
                column: "BatteryId",
                principalTable: "Batteries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Files_Cameras_CameraId",
                table: "Files",
                column: "CameraId",
                principalTable: "Cameras",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Files_Chargers_ChargerId",
                table: "Files",
                column: "ChargerId",
                principalTable: "Chargers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Files_ESCs_ESCId",
                table: "Files",
                column: "ESCId",
                principalTable: "ESCs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Files_Frames_FrameId",
                table: "Files",
                column: "FrameId",
                principalTable: "Frames",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Files_Fuselages_FuselageId",
                table: "Files",
                column: "FuselageId",
                principalTable: "Fuselages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Files_Goggles_GoggleId",
                table: "Files",
                column: "GoggleId",
                principalTable: "Goggles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Files_Lights_LightId",
                table: "Files",
                column: "LightId",
                principalTable: "Lights",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Files_Props_PropId",
                table: "Files",
                column: "PropId",
                principalTable: "Props",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Files_RCOthers_RCOtherId",
                table: "Files",
                column: "RCOtherId",
                principalTable: "RCOthers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Files_Receivers_ReceiverId",
                table: "Files",
                column: "ReceiverId",
                principalTable: "Receivers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Files_Servos_ServoId",
                table: "Files",
                column: "ServoId",
                principalTable: "Servos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Files_Transmitters_TransmitterId",
                table: "Files",
                column: "TransmitterId",
                principalTable: "Transmitters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Files_VideoReceivers_VideoReceiverId",
                table: "Files",
                column: "VideoReceiverId",
                principalTable: "VideoReceivers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Files_VideoTransmitters_VideoTransmitterId",
                table: "Files",
                column: "VideoTransmitterId",
                principalTable: "VideoTransmitters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FlightControllers_Company_ManufacturerId",
                table: "FlightControllers",
                column: "ManufacturerId",
                principalTable: "Company",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FlightControllers_Processors_ProcessorId",
                table: "FlightControllers",
                column: "ProcessorId",
                principalTable: "Processors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Motors_Company_ManufacturerId",
                table: "Motors",
                column: "ManufacturerId",
                principalTable: "Company",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PDBs_Company_ManufacturerId",
                table: "PDBs",
                column: "ManufacturerId",
                principalTable: "Company",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Files_Accessories_AccessoryModelId",
                table: "Files");

            migrationBuilder.DropForeignKey(
                name: "FK_Files_Antennas_AntennaId",
                table: "Files");

            migrationBuilder.DropForeignKey(
                name: "FK_Files_Batteries_BatteryId",
                table: "Files");

            migrationBuilder.DropForeignKey(
                name: "FK_Files_Cameras_CameraId",
                table: "Files");

            migrationBuilder.DropForeignKey(
                name: "FK_Files_Chargers_ChargerId",
                table: "Files");

            migrationBuilder.DropForeignKey(
                name: "FK_Files_ESCs_ESCId",
                table: "Files");

            migrationBuilder.DropForeignKey(
                name: "FK_Files_Frames_FrameId",
                table: "Files");

            migrationBuilder.DropForeignKey(
                name: "FK_Files_Fuselages_FuselageId",
                table: "Files");

            migrationBuilder.DropForeignKey(
                name: "FK_Files_Goggles_GoggleId",
                table: "Files");

            migrationBuilder.DropForeignKey(
                name: "FK_Files_Lights_LightId",
                table: "Files");

            migrationBuilder.DropForeignKey(
                name: "FK_Files_Props_PropId",
                table: "Files");

            migrationBuilder.DropForeignKey(
                name: "FK_Files_RCOthers_RCOtherId",
                table: "Files");

            migrationBuilder.DropForeignKey(
                name: "FK_Files_Receivers_ReceiverId",
                table: "Files");

            migrationBuilder.DropForeignKey(
                name: "FK_Files_Servos_ServoId",
                table: "Files");

            migrationBuilder.DropForeignKey(
                name: "FK_Files_Transmitters_TransmitterId",
                table: "Files");

            migrationBuilder.DropForeignKey(
                name: "FK_Files_VideoReceivers_VideoReceiverId",
                table: "Files");

            migrationBuilder.DropForeignKey(
                name: "FK_Files_VideoTransmitters_VideoTransmitterId",
                table: "Files");

            migrationBuilder.DropForeignKey(
                name: "FK_FlightControllers_Company_ManufacturerId",
                table: "FlightControllers");

            migrationBuilder.DropForeignKey(
                name: "FK_FlightControllers_Processors_ProcessorId",
                table: "FlightControllers");

            migrationBuilder.DropForeignKey(
                name: "FK_Motors_Company_ManufacturerId",
                table: "Motors");

            migrationBuilder.DropForeignKey(
                name: "FK_PDBs_Company_ManufacturerId",
                table: "PDBs");

            migrationBuilder.DropTable(
                name: "Accessories");

            migrationBuilder.DropTable(
                name: "Antennas");

            migrationBuilder.DropTable(
                name: "Batteries");

            migrationBuilder.DropTable(
                name: "Cameras");

            migrationBuilder.DropTable(
                name: "Chargers");

            migrationBuilder.DropTable(
                name: "ESCs");

            migrationBuilder.DropTable(
                name: "Frames");

            migrationBuilder.DropTable(
                name: "Fuselages");

            migrationBuilder.DropTable(
                name: "Goggles");

            migrationBuilder.DropTable(
                name: "Lights");

            migrationBuilder.DropTable(
                name: "Links");

            migrationBuilder.DropTable(
                name: "Processors");

            migrationBuilder.DropTable(
                name: "Props");

            migrationBuilder.DropTable(
                name: "RCOthers");

            migrationBuilder.DropTable(
                name: "Receivers");

            migrationBuilder.DropTable(
                name: "Servos");

            migrationBuilder.DropTable(
                name: "Transmitters");

            migrationBuilder.DropTable(
                name: "VideoReceivers");

            migrationBuilder.DropTable(
                name: "VideoTransmitters");

            migrationBuilder.DropTable(
                name: "FrameTypes");

            migrationBuilder.DropTable(
                name: "FuselageTypes");

            migrationBuilder.DropTable(
                name: "Stores");

            migrationBuilder.DropIndex(
                name: "IX_FlightControllers_ProcessorId",
                table: "FlightControllers");

            migrationBuilder.DropIndex(
                name: "IX_Files_AccessoryModelId",
                table: "Files");

            migrationBuilder.DropIndex(
                name: "IX_Files_AntennaId",
                table: "Files");

            migrationBuilder.DropIndex(
                name: "IX_Files_BatteryId",
                table: "Files");

            migrationBuilder.DropIndex(
                name: "IX_Files_CameraId",
                table: "Files");

            migrationBuilder.DropIndex(
                name: "IX_Files_ChargerId",
                table: "Files");

            migrationBuilder.DropIndex(
                name: "IX_Files_ESCId",
                table: "Files");

            migrationBuilder.DropIndex(
                name: "IX_Files_FrameId",
                table: "Files");

            migrationBuilder.DropIndex(
                name: "IX_Files_FuselageId",
                table: "Files");

            migrationBuilder.DropIndex(
                name: "IX_Files_GoggleId",
                table: "Files");

            migrationBuilder.DropIndex(
                name: "IX_Files_LightId",
                table: "Files");

            migrationBuilder.DropIndex(
                name: "IX_Files_PropId",
                table: "Files");

            migrationBuilder.DropIndex(
                name: "IX_Files_RCOtherId",
                table: "Files");

            migrationBuilder.DropIndex(
                name: "IX_Files_ReceiverId",
                table: "Files");

            migrationBuilder.DropIndex(
                name: "IX_Files_ServoId",
                table: "Files");

            migrationBuilder.DropIndex(
                name: "IX_Files_TransmitterId",
                table: "Files");

            migrationBuilder.DropIndex(
                name: "IX_Files_VideoReceiverId",
                table: "Files");

            migrationBuilder.DropIndex(
                name: "IX_Files_VideoTransmitterId",
                table: "Files");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Company",
                table: "Company");

            migrationBuilder.DropColumn(
                name: "ProcessorId",
                table: "FlightControllers");

            migrationBuilder.DropColumn(
                name: "AccessoryModelId",
                table: "Files");

            migrationBuilder.DropColumn(
                name: "AntennaId",
                table: "Files");

            migrationBuilder.DropColumn(
                name: "BatteryId",
                table: "Files");

            migrationBuilder.DropColumn(
                name: "CameraId",
                table: "Files");

            migrationBuilder.DropColumn(
                name: "ChargerId",
                table: "Files");

            migrationBuilder.DropColumn(
                name: "ESCId",
                table: "Files");

            migrationBuilder.DropColumn(
                name: "FrameId",
                table: "Files");

            migrationBuilder.DropColumn(
                name: "FuselageId",
                table: "Files");

            migrationBuilder.DropColumn(
                name: "GoggleId",
                table: "Files");

            migrationBuilder.DropColumn(
                name: "LightId",
                table: "Files");

            migrationBuilder.DropColumn(
                name: "PropId",
                table: "Files");

            migrationBuilder.DropColumn(
                name: "RCOtherId",
                table: "Files");

            migrationBuilder.DropColumn(
                name: "ReceiverId",
                table: "Files");

            migrationBuilder.DropColumn(
                name: "ServoId",
                table: "Files");

            migrationBuilder.DropColumn(
                name: "TransmitterId",
                table: "Files");

            migrationBuilder.DropColumn(
                name: "VideoReceiverId",
                table: "Files");

            migrationBuilder.DropColumn(
                name: "VideoTransmitterId",
                table: "Files");

            migrationBuilder.RenameTable(
                name: "Company",
                newName: "Companies");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Companies",
                table: "Companies",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_FlightControllers_Companies_ManufacturerId",
                table: "FlightControllers",
                column: "ManufacturerId",
                principalTable: "Companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Motors_Companies_ManufacturerId",
                table: "Motors",
                column: "ManufacturerId",
                principalTable: "Companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PDBs_Companies_ManufacturerId",
                table: "PDBs",
                column: "ManufacturerId",
                principalTable: "Companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
