using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace fpv_info.Migrations
{
    public partial class Initial_28_01_2018 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AntennaConnectorId",
                table: "VideoTransmitters",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BEC",
                table: "VideoTransmitters",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Dimension",
                table: "VideoTransmitters",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FrequencyId",
                table: "VideoTransmitters",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "LowBand",
                table: "VideoTransmitters",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Mic",
                table: "VideoTransmitters",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "N_Channels",
                table: "VideoTransmitters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "PitMode",
                table: "VideoTransmitters",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "RaceBand",
                table: "VideoTransmitters",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "VTXControl",
                table: "VideoTransmitters",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "VoltageId",
                table: "VideoTransmitters",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Сomment",
                table: "VideoTransmitters",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AntennaConnectorId",
                table: "VideoReceivers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "AntennaGain",
                table: "VideoReceivers",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<string>(
                name: "Dimension",
                table: "VideoReceivers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FrequencyId",
                table: "VideoReceivers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "LowBand",
                table: "VideoReceivers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "N_Channels",
                table: "VideoReceivers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "RaceBand",
                table: "VideoReceivers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "VoltageId",
                table: "VideoReceivers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Сomment",
                table: "VideoReceivers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Сomment",
                table: "Transmitters",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Dimension",
                table: "Servos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OperatingSpeed",
                table: "Servos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StallTorque",
                table: "Servos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VoltageId",
                table: "Servos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Сomment",
                table: "Servos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Dimension",
                table: "Receivers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FrequencyId",
                table: "Receivers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OutputId",
                table: "Receivers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "SPort",
                table: "Receivers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "VoltageId",
                table: "Receivers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Сomment",
                table: "Receivers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TypeId",
                table: "RCOthers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Сomment",
                table: "RCOthers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "MountingHole",
                table: "Props",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<string>(
                name: "Сomment",
                table: "Props",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "CurrentSensor",
                table: "PDBs",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Dimensions",
                table: "PDBs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "InputVoltageId",
                table: "PDBs",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "InstallDimensionId",
                table: "PDBs",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PDBTypeId",
                table: "PDBs",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Сomment",
                table: "PDBs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "Height",
                table: "Motors",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<int>(
                name: "InstallDimensionId",
                table: "Motors",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "KVId",
                table: "Motors",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "MotorMountHoleSize",
                table: "Motors",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "ShaftDiameter",
                table: "Motors",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<int>(
                name: "VoltageId",
                table: "Motors",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "Width",
                table: "Motors",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<string>(
                name: "Сomment",
                table: "Motors",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AccessoryModelId",
                table: "Links",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AccessoryModelId1",
                table: "Links",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AccessoryModelId2",
                table: "Links",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AntennaId",
                table: "Links",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AntennaId1",
                table: "Links",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AntennaId2",
                table: "Links",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BatteryId",
                table: "Links",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BatteryId1",
                table: "Links",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BatteryId2",
                table: "Links",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CameraId",
                table: "Links",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CameraId1",
                table: "Links",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CameraId2",
                table: "Links",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ChargerId",
                table: "Links",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ChargerId1",
                table: "Links",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ChargerId2",
                table: "Links",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ESCId",
                table: "Links",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ESCId1",
                table: "Links",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ESCId2",
                table: "Links",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FlightControllerId",
                table: "Links",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FlightControllerId1",
                table: "Links",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FlightControllerId2",
                table: "Links",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FrameId",
                table: "Links",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FrameId1",
                table: "Links",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FrameId2",
                table: "Links",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FuselageId",
                table: "Links",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FuselageId1",
                table: "Links",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FuselageId2",
                table: "Links",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GoggleId",
                table: "Links",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GoggleId1",
                table: "Links",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GoggleId2",
                table: "Links",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LightId",
                table: "Links",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LightId1",
                table: "Links",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LightId2",
                table: "Links",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LinkTypeId",
                table: "Links",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MotorId",
                table: "Links",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MotorId1",
                table: "Links",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MotorId2",
                table: "Links",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Links",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PDBId",
                table: "Links",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PDBId1",
                table: "Links",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PDBId2",
                table: "Links",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PropId",
                table: "Links",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PropId1",
                table: "Links",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PropId2",
                table: "Links",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RCOtherId",
                table: "Links",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RCOtherId1",
                table: "Links",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RCOtherId2",
                table: "Links",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ReceiverId",
                table: "Links",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ReceiverId1",
                table: "Links",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ReceiverId2",
                table: "Links",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ServoId",
                table: "Links",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ServoId1",
                table: "Links",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ServoId2",
                table: "Links",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TransmitterId",
                table: "Links",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TransmitterId1",
                table: "Links",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TransmitterId2",
                table: "Links",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VideoReceiverId",
                table: "Links",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VideoReceiverId1",
                table: "Links",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VideoReceiverId2",
                table: "Links",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VideoTransmitterId",
                table: "Links",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VideoTransmitterId1",
                table: "Links",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VideoTransmitterId2",
                table: "Links",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Сomment",
                table: "Lights",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AspectRatioId",
                table: "Goggles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "DVR",
                table: "Goggles",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "DisplayId",
                table: "Goggles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FOVId",
                table: "Goggles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IPD",
                table: "Goggles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Сomment",
                table: "Goggles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MaterialId",
                table: "Fuselages",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Wingspan",
                table: "Fuselages",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Сomment",
                table: "Fuselages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "InstallDimensionMotorId",
                table: "Frames",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "InstallDimensionProcId",
                table: "Frames",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MaterialId",
                table: "Frames",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Wheelbase",
                table: "Frames",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Сomment",
                table: "Frames",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Dimensions",
                table: "FlightControllers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FirmwareId",
                table: "FlightControllers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GyroId",
                table: "FlightControllers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "InstallDimensionId",
                table: "FlightControllers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "N_PWMOut",
                table: "FlightControllers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "N_UART",
                table: "FlightControllers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "OSD",
                table: "FlightControllers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "PDB",
                table: "FlightControllers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "SlotSD",
                table: "FlightControllers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "VoltageId",
                table: "FlightControllers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Сomment",
                table: "FlightControllers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "BEC",
                table: "ESCs",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "CurrentId",
                table: "ESCs",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "DShot1200",
                table: "ESCs",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "DShot150",
                table: "ESCs",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "DShot300",
                table: "ESCs",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "DShot600",
                table: "ESCs",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Dimensions",
                table: "ESCs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FirmwareId",
                table: "ESCs",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "InstallDimensionId",
                table: "ESCs",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Multishot",
                table: "ESCs",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Oneshot125",
                table: "ESCs",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Oneshot42",
                table: "ESCs",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "PeakCurrentId",
                table: "ESCs",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProcessorId",
                table: "ESCs",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VoltageId",
                table: "ESCs",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Сomment",
                table: "ESCs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ChargeCurrentRange",
                table: "Chargers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CurrentDrainBalancing",
                table: "Chargers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Dimension",
                table: "Chargers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DischargeCurrentRange",
                table: "Chargers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LiPoCellCount",
                table: "Chargers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NiCd_NiMHCellCount",
                table: "Chargers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PbBatteryVoltageId",
                table: "Chargers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PowerChargeId",
                table: "Chargers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PowerDischargeId",
                table: "Chargers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VoltageId",
                table: "Chargers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Сomment",
                table: "Chargers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AspectRatioId",
                table: "Cameras",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "DVR",
                table: "Cameras",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Dimension",
                table: "Cameras",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FOVId",
                table: "Cameras",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HorizontalResolutionId",
                table: "Cameras",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "ImageFlip",
                table: "Cameras",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "ImageSensorId",
                table: "Cameras",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Mic",
                table: "Cameras",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "OSD",
                table: "Cameras",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "VoltageId",
                table: "Cameras",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Сomment",
                table: "Cameras",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BattaryTypeId",
                table: "Batteries",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CapacityId",
                table: "Batteries",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Dimension",
                table: "Batteries",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DischargeRateId",
                table: "Batteries",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VoltageId",
                table: "Batteries",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Сomment",
                table: "Batteries",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AntennaConnectorId",
                table: "Antennas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FrequencyId",
                table: "Antennas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "Gain",
                table: "Antennas",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<string>(
                name: "Сomment",
                table: "Antennas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TypeId",
                table: "Accessories",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Сomment",
                table: "Accessories",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "AccessoryTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccessoryTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AntennaConnector",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AntennaConnector", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspectsRatio",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspectsRatio", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BattaryTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BattaryTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BECs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PDBId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BECs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BECs_PDBs_PDBId",
                        column: x => x.PDBId,
                        principalTable: "PDBs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Capacity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Capacity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Currents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Currents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DischargeRates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DischargeRates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Displays",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Displays", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Firmware",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Firmware", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FOVs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FOVs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Frequency",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Frequency", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Gyros",
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
                    table.PrimaryKey("PK_Gyros", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HorizontalResolutions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HorizontalResolutions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ImageSensors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImageSensors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InstallDimensions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InstallDimensions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InstallMotorDimensions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InstallMotorDimensions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LinkTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LinkTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Materials",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materials", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MotorKVs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MotorKVs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PDBTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PDBTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Powers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VideoTransmitterId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Powers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Powers_VideoTransmitters_VideoTransmitterId",
                        column: x => x.VideoTransmitterId,
                        principalTable: "VideoTransmitters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PropTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RCOtherTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RCOtherTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RCProtocols",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RCProtocols", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Voltages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Voltages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TransmitterTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FrequencyId = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PowerId = table.Column<int>(type: "int", nullable: true),
                    TypeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransmitterTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TransmitterTypes_Frequency_FrequencyId",
                        column: x => x.FrequencyId,
                        principalTable: "Frequency",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TransmitterTypes_Powers_PowerId",
                        column: x => x.PowerId,
                        principalTable: "Powers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TransmitterTypes_TransmitterTypes_TypeId",
                        column: x => x.TypeId,
                        principalTable: "TransmitterTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Measurements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Efficiency = table.Column<int>(type: "int", nullable: false),
                    LoadCurrent = table.Column<float>(type: "real", nullable: false),
                    MotorId = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Power = table.Column<int>(type: "int", nullable: false),
                    PropTypeId = table.Column<int>(type: "int", nullable: true),
                    Pull = table.Column<int>(type: "int", nullable: false),
                    SourceId = table.Column<int>(type: "int", nullable: true),
                    VoltageId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Measurements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Measurements_Motors_MotorId",
                        column: x => x.MotorId,
                        principalTable: "Motors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Measurements_PropTypes_PropTypeId",
                        column: x => x.PropTypeId,
                        principalTable: "PropTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Measurements_Links_SourceId",
                        column: x => x.SourceId,
                        principalTable: "Links",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Measurements_Voltages_VoltageId",
                        column: x => x.VoltageId,
                        principalTable: "Voltages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_VideoTransmitters_AntennaConnectorId",
                table: "VideoTransmitters",
                column: "AntennaConnectorId");

            migrationBuilder.CreateIndex(
                name: "IX_VideoTransmitters_FrequencyId",
                table: "VideoTransmitters",
                column: "FrequencyId");

            migrationBuilder.CreateIndex(
                name: "IX_VideoTransmitters_VoltageId",
                table: "VideoTransmitters",
                column: "VoltageId");

            migrationBuilder.CreateIndex(
                name: "IX_VideoReceivers_AntennaConnectorId",
                table: "VideoReceivers",
                column: "AntennaConnectorId");

            migrationBuilder.CreateIndex(
                name: "IX_VideoReceivers_FrequencyId",
                table: "VideoReceivers",
                column: "FrequencyId");

            migrationBuilder.CreateIndex(
                name: "IX_VideoReceivers_VoltageId",
                table: "VideoReceivers",
                column: "VoltageId");

            migrationBuilder.CreateIndex(
                name: "IX_Servos_VoltageId",
                table: "Servos",
                column: "VoltageId");

            migrationBuilder.CreateIndex(
                name: "IX_Receivers_FrequencyId",
                table: "Receivers",
                column: "FrequencyId");

            migrationBuilder.CreateIndex(
                name: "IX_Receivers_OutputId",
                table: "Receivers",
                column: "OutputId");

            migrationBuilder.CreateIndex(
                name: "IX_Receivers_VoltageId",
                table: "Receivers",
                column: "VoltageId");

            migrationBuilder.CreateIndex(
                name: "IX_RCOthers_TypeId",
                table: "RCOthers",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PDBs_InputVoltageId",
                table: "PDBs",
                column: "InputVoltageId");

            migrationBuilder.CreateIndex(
                name: "IX_PDBs_InstallDimensionId",
                table: "PDBs",
                column: "InstallDimensionId");

            migrationBuilder.CreateIndex(
                name: "IX_PDBs_PDBTypeId",
                table: "PDBs",
                column: "PDBTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Motors_InstallDimensionId",
                table: "Motors",
                column: "InstallDimensionId");

            migrationBuilder.CreateIndex(
                name: "IX_Motors_KVId",
                table: "Motors",
                column: "KVId");

            migrationBuilder.CreateIndex(
                name: "IX_Motors_VoltageId",
                table: "Motors",
                column: "VoltageId");

            migrationBuilder.CreateIndex(
                name: "IX_Links_AccessoryModelId",
                table: "Links",
                column: "AccessoryModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Links_AccessoryModelId1",
                table: "Links",
                column: "AccessoryModelId1");

            migrationBuilder.CreateIndex(
                name: "IX_Links_AccessoryModelId2",
                table: "Links",
                column: "AccessoryModelId2");

            migrationBuilder.CreateIndex(
                name: "IX_Links_AntennaId",
                table: "Links",
                column: "AntennaId");

            migrationBuilder.CreateIndex(
                name: "IX_Links_AntennaId1",
                table: "Links",
                column: "AntennaId1");

            migrationBuilder.CreateIndex(
                name: "IX_Links_AntennaId2",
                table: "Links",
                column: "AntennaId2");

            migrationBuilder.CreateIndex(
                name: "IX_Links_BatteryId",
                table: "Links",
                column: "BatteryId");

            migrationBuilder.CreateIndex(
                name: "IX_Links_BatteryId1",
                table: "Links",
                column: "BatteryId1");

            migrationBuilder.CreateIndex(
                name: "IX_Links_BatteryId2",
                table: "Links",
                column: "BatteryId2");

            migrationBuilder.CreateIndex(
                name: "IX_Links_CameraId",
                table: "Links",
                column: "CameraId");

            migrationBuilder.CreateIndex(
                name: "IX_Links_CameraId1",
                table: "Links",
                column: "CameraId1");

            migrationBuilder.CreateIndex(
                name: "IX_Links_CameraId2",
                table: "Links",
                column: "CameraId2");

            migrationBuilder.CreateIndex(
                name: "IX_Links_ChargerId",
                table: "Links",
                column: "ChargerId");

            migrationBuilder.CreateIndex(
                name: "IX_Links_ChargerId1",
                table: "Links",
                column: "ChargerId1");

            migrationBuilder.CreateIndex(
                name: "IX_Links_ChargerId2",
                table: "Links",
                column: "ChargerId2");

            migrationBuilder.CreateIndex(
                name: "IX_Links_ESCId",
                table: "Links",
                column: "ESCId");

            migrationBuilder.CreateIndex(
                name: "IX_Links_ESCId1",
                table: "Links",
                column: "ESCId1");

            migrationBuilder.CreateIndex(
                name: "IX_Links_ESCId2",
                table: "Links",
                column: "ESCId2");

            migrationBuilder.CreateIndex(
                name: "IX_Links_FlightControllerId",
                table: "Links",
                column: "FlightControllerId");

            migrationBuilder.CreateIndex(
                name: "IX_Links_FlightControllerId1",
                table: "Links",
                column: "FlightControllerId1");

            migrationBuilder.CreateIndex(
                name: "IX_Links_FlightControllerId2",
                table: "Links",
                column: "FlightControllerId2");

            migrationBuilder.CreateIndex(
                name: "IX_Links_FrameId",
                table: "Links",
                column: "FrameId");

            migrationBuilder.CreateIndex(
                name: "IX_Links_FrameId1",
                table: "Links",
                column: "FrameId1");

            migrationBuilder.CreateIndex(
                name: "IX_Links_FrameId2",
                table: "Links",
                column: "FrameId2");

            migrationBuilder.CreateIndex(
                name: "IX_Links_FuselageId",
                table: "Links",
                column: "FuselageId");

            migrationBuilder.CreateIndex(
                name: "IX_Links_FuselageId1",
                table: "Links",
                column: "FuselageId1");

            migrationBuilder.CreateIndex(
                name: "IX_Links_FuselageId2",
                table: "Links",
                column: "FuselageId2");

            migrationBuilder.CreateIndex(
                name: "IX_Links_GoggleId",
                table: "Links",
                column: "GoggleId");

            migrationBuilder.CreateIndex(
                name: "IX_Links_GoggleId1",
                table: "Links",
                column: "GoggleId1");

            migrationBuilder.CreateIndex(
                name: "IX_Links_GoggleId2",
                table: "Links",
                column: "GoggleId2");

            migrationBuilder.CreateIndex(
                name: "IX_Links_LightId",
                table: "Links",
                column: "LightId");

            migrationBuilder.CreateIndex(
                name: "IX_Links_LightId1",
                table: "Links",
                column: "LightId1");

            migrationBuilder.CreateIndex(
                name: "IX_Links_LightId2",
                table: "Links",
                column: "LightId2");

            migrationBuilder.CreateIndex(
                name: "IX_Links_LinkTypeId",
                table: "Links",
                column: "LinkTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Links_MotorId",
                table: "Links",
                column: "MotorId");

            migrationBuilder.CreateIndex(
                name: "IX_Links_MotorId1",
                table: "Links",
                column: "MotorId1");

            migrationBuilder.CreateIndex(
                name: "IX_Links_MotorId2",
                table: "Links",
                column: "MotorId2");

            migrationBuilder.CreateIndex(
                name: "IX_Links_PDBId",
                table: "Links",
                column: "PDBId");

            migrationBuilder.CreateIndex(
                name: "IX_Links_PDBId1",
                table: "Links",
                column: "PDBId1");

            migrationBuilder.CreateIndex(
                name: "IX_Links_PDBId2",
                table: "Links",
                column: "PDBId2");

            migrationBuilder.CreateIndex(
                name: "IX_Links_PropId",
                table: "Links",
                column: "PropId");

            migrationBuilder.CreateIndex(
                name: "IX_Links_PropId1",
                table: "Links",
                column: "PropId1");

            migrationBuilder.CreateIndex(
                name: "IX_Links_PropId2",
                table: "Links",
                column: "PropId2");

            migrationBuilder.CreateIndex(
                name: "IX_Links_RCOtherId",
                table: "Links",
                column: "RCOtherId");

            migrationBuilder.CreateIndex(
                name: "IX_Links_RCOtherId1",
                table: "Links",
                column: "RCOtherId1");

            migrationBuilder.CreateIndex(
                name: "IX_Links_RCOtherId2",
                table: "Links",
                column: "RCOtherId2");

            migrationBuilder.CreateIndex(
                name: "IX_Links_ReceiverId",
                table: "Links",
                column: "ReceiverId");

            migrationBuilder.CreateIndex(
                name: "IX_Links_ReceiverId1",
                table: "Links",
                column: "ReceiverId1");

            migrationBuilder.CreateIndex(
                name: "IX_Links_ReceiverId2",
                table: "Links",
                column: "ReceiverId2");

            migrationBuilder.CreateIndex(
                name: "IX_Links_ServoId",
                table: "Links",
                column: "ServoId");

            migrationBuilder.CreateIndex(
                name: "IX_Links_ServoId1",
                table: "Links",
                column: "ServoId1");

            migrationBuilder.CreateIndex(
                name: "IX_Links_ServoId2",
                table: "Links",
                column: "ServoId2");

            migrationBuilder.CreateIndex(
                name: "IX_Links_TransmitterId",
                table: "Links",
                column: "TransmitterId");

            migrationBuilder.CreateIndex(
                name: "IX_Links_TransmitterId1",
                table: "Links",
                column: "TransmitterId1");

            migrationBuilder.CreateIndex(
                name: "IX_Links_TransmitterId2",
                table: "Links",
                column: "TransmitterId2");

            migrationBuilder.CreateIndex(
                name: "IX_Links_VideoReceiverId",
                table: "Links",
                column: "VideoReceiverId");

            migrationBuilder.CreateIndex(
                name: "IX_Links_VideoReceiverId1",
                table: "Links",
                column: "VideoReceiverId1");

            migrationBuilder.CreateIndex(
                name: "IX_Links_VideoReceiverId2",
                table: "Links",
                column: "VideoReceiverId2");

            migrationBuilder.CreateIndex(
                name: "IX_Links_VideoTransmitterId",
                table: "Links",
                column: "VideoTransmitterId");

            migrationBuilder.CreateIndex(
                name: "IX_Links_VideoTransmitterId1",
                table: "Links",
                column: "VideoTransmitterId1");

            migrationBuilder.CreateIndex(
                name: "IX_Links_VideoTransmitterId2",
                table: "Links",
                column: "VideoTransmitterId2");

            migrationBuilder.CreateIndex(
                name: "IX_Goggles_AspectRatioId",
                table: "Goggles",
                column: "AspectRatioId");

            migrationBuilder.CreateIndex(
                name: "IX_Goggles_DisplayId",
                table: "Goggles",
                column: "DisplayId");

            migrationBuilder.CreateIndex(
                name: "IX_Goggles_FOVId",
                table: "Goggles",
                column: "FOVId");

            migrationBuilder.CreateIndex(
                name: "IX_Fuselages_MaterialId",
                table: "Fuselages",
                column: "MaterialId");

            migrationBuilder.CreateIndex(
                name: "IX_Frames_InstallDimensionMotorId",
                table: "Frames",
                column: "InstallDimensionMotorId");

            migrationBuilder.CreateIndex(
                name: "IX_Frames_InstallDimensionProcId",
                table: "Frames",
                column: "InstallDimensionProcId");

            migrationBuilder.CreateIndex(
                name: "IX_Frames_MaterialId",
                table: "Frames",
                column: "MaterialId");

            migrationBuilder.CreateIndex(
                name: "IX_FlightControllers_FirmwareId",
                table: "FlightControllers",
                column: "FirmwareId");

            migrationBuilder.CreateIndex(
                name: "IX_FlightControllers_GyroId",
                table: "FlightControllers",
                column: "GyroId");

            migrationBuilder.CreateIndex(
                name: "IX_FlightControllers_InstallDimensionId",
                table: "FlightControllers",
                column: "InstallDimensionId");

            migrationBuilder.CreateIndex(
                name: "IX_FlightControllers_VoltageId",
                table: "FlightControllers",
                column: "VoltageId");

            migrationBuilder.CreateIndex(
                name: "IX_ESCs_CurrentId",
                table: "ESCs",
                column: "CurrentId");

            migrationBuilder.CreateIndex(
                name: "IX_ESCs_FirmwareId",
                table: "ESCs",
                column: "FirmwareId");

            migrationBuilder.CreateIndex(
                name: "IX_ESCs_InstallDimensionId",
                table: "ESCs",
                column: "InstallDimensionId");

            migrationBuilder.CreateIndex(
                name: "IX_ESCs_PeakCurrentId",
                table: "ESCs",
                column: "PeakCurrentId");

            migrationBuilder.CreateIndex(
                name: "IX_ESCs_ProcessorId",
                table: "ESCs",
                column: "ProcessorId");

            migrationBuilder.CreateIndex(
                name: "IX_ESCs_VoltageId",
                table: "ESCs",
                column: "VoltageId");

            migrationBuilder.CreateIndex(
                name: "IX_Chargers_PbBatteryVoltageId",
                table: "Chargers",
                column: "PbBatteryVoltageId");

            migrationBuilder.CreateIndex(
                name: "IX_Chargers_PowerChargeId",
                table: "Chargers",
                column: "PowerChargeId");

            migrationBuilder.CreateIndex(
                name: "IX_Chargers_PowerDischargeId",
                table: "Chargers",
                column: "PowerDischargeId");

            migrationBuilder.CreateIndex(
                name: "IX_Chargers_VoltageId",
                table: "Chargers",
                column: "VoltageId");

            migrationBuilder.CreateIndex(
                name: "IX_Cameras_AspectRatioId",
                table: "Cameras",
                column: "AspectRatioId");

            migrationBuilder.CreateIndex(
                name: "IX_Cameras_FOVId",
                table: "Cameras",
                column: "FOVId");

            migrationBuilder.CreateIndex(
                name: "IX_Cameras_HorizontalResolutionId",
                table: "Cameras",
                column: "HorizontalResolutionId");

            migrationBuilder.CreateIndex(
                name: "IX_Cameras_ImageSensorId",
                table: "Cameras",
                column: "ImageSensorId");

            migrationBuilder.CreateIndex(
                name: "IX_Cameras_VoltageId",
                table: "Cameras",
                column: "VoltageId");

            migrationBuilder.CreateIndex(
                name: "IX_Batteries_BattaryTypeId",
                table: "Batteries",
                column: "BattaryTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Batteries_CapacityId",
                table: "Batteries",
                column: "CapacityId");

            migrationBuilder.CreateIndex(
                name: "IX_Batteries_DischargeRateId",
                table: "Batteries",
                column: "DischargeRateId");

            migrationBuilder.CreateIndex(
                name: "IX_Batteries_VoltageId",
                table: "Batteries",
                column: "VoltageId");

            migrationBuilder.CreateIndex(
                name: "IX_Antennas_AntennaConnectorId",
                table: "Antennas",
                column: "AntennaConnectorId");

            migrationBuilder.CreateIndex(
                name: "IX_Antennas_FrequencyId",
                table: "Antennas",
                column: "FrequencyId");

            migrationBuilder.CreateIndex(
                name: "IX_Accessories_TypeId",
                table: "Accessories",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_BECs_PDBId",
                table: "BECs",
                column: "PDBId");

            migrationBuilder.CreateIndex(
                name: "IX_Measurements_MotorId",
                table: "Measurements",
                column: "MotorId");

            migrationBuilder.CreateIndex(
                name: "IX_Measurements_PropTypeId",
                table: "Measurements",
                column: "PropTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Measurements_SourceId",
                table: "Measurements",
                column: "SourceId");

            migrationBuilder.CreateIndex(
                name: "IX_Measurements_VoltageId",
                table: "Measurements",
                column: "VoltageId");

            migrationBuilder.CreateIndex(
                name: "IX_Powers_VideoTransmitterId",
                table: "Powers",
                column: "VideoTransmitterId");

            migrationBuilder.CreateIndex(
                name: "IX_TransmitterTypes_FrequencyId",
                table: "TransmitterTypes",
                column: "FrequencyId");

            migrationBuilder.CreateIndex(
                name: "IX_TransmitterTypes_PowerId",
                table: "TransmitterTypes",
                column: "PowerId");

            migrationBuilder.CreateIndex(
                name: "IX_TransmitterTypes_TypeId",
                table: "TransmitterTypes",
                column: "TypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Accessories_AccessoryTypes_TypeId",
                table: "Accessories",
                column: "TypeId",
                principalTable: "AccessoryTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Antennas_AntennaConnector_AntennaConnectorId",
                table: "Antennas",
                column: "AntennaConnectorId",
                principalTable: "AntennaConnector",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Antennas_Frequency_FrequencyId",
                table: "Antennas",
                column: "FrequencyId",
                principalTable: "Frequency",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Batteries_BattaryTypes_BattaryTypeId",
                table: "Batteries",
                column: "BattaryTypeId",
                principalTable: "BattaryTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Batteries_Capacity_CapacityId",
                table: "Batteries",
                column: "CapacityId",
                principalTable: "Capacity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Batteries_DischargeRates_DischargeRateId",
                table: "Batteries",
                column: "DischargeRateId",
                principalTable: "DischargeRates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Batteries_Voltages_VoltageId",
                table: "Batteries",
                column: "VoltageId",
                principalTable: "Voltages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Cameras_AspectsRatio_AspectRatioId",
                table: "Cameras",
                column: "AspectRatioId",
                principalTable: "AspectsRatio",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Cameras_FOVs_FOVId",
                table: "Cameras",
                column: "FOVId",
                principalTable: "FOVs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Cameras_HorizontalResolutions_HorizontalResolutionId",
                table: "Cameras",
                column: "HorizontalResolutionId",
                principalTable: "HorizontalResolutions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Cameras_ImageSensors_ImageSensorId",
                table: "Cameras",
                column: "ImageSensorId",
                principalTable: "ImageSensors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Cameras_Voltages_VoltageId",
                table: "Cameras",
                column: "VoltageId",
                principalTable: "Voltages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Chargers_Voltages_PbBatteryVoltageId",
                table: "Chargers",
                column: "PbBatteryVoltageId",
                principalTable: "Voltages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Chargers_Powers_PowerChargeId",
                table: "Chargers",
                column: "PowerChargeId",
                principalTable: "Powers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Chargers_Powers_PowerDischargeId",
                table: "Chargers",
                column: "PowerDischargeId",
                principalTable: "Powers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Chargers_Voltages_VoltageId",
                table: "Chargers",
                column: "VoltageId",
                principalTable: "Voltages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ESCs_Currents_CurrentId",
                table: "ESCs",
                column: "CurrentId",
                principalTable: "Currents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ESCs_Firmware_FirmwareId",
                table: "ESCs",
                column: "FirmwareId",
                principalTable: "Firmware",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ESCs_InstallDimensions_InstallDimensionId",
                table: "ESCs",
                column: "InstallDimensionId",
                principalTable: "InstallDimensions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ESCs_Currents_PeakCurrentId",
                table: "ESCs",
                column: "PeakCurrentId",
                principalTable: "Currents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ESCs_Processors_ProcessorId",
                table: "ESCs",
                column: "ProcessorId",
                principalTable: "Processors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ESCs_Voltages_VoltageId",
                table: "ESCs",
                column: "VoltageId",
                principalTable: "Voltages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FlightControllers_Firmware_FirmwareId",
                table: "FlightControllers",
                column: "FirmwareId",
                principalTable: "Firmware",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FlightControllers_Gyros_GyroId",
                table: "FlightControllers",
                column: "GyroId",
                principalTable: "Gyros",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FlightControllers_InstallDimensions_InstallDimensionId",
                table: "FlightControllers",
                column: "InstallDimensionId",
                principalTable: "InstallDimensions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FlightControllers_Voltages_VoltageId",
                table: "FlightControllers",
                column: "VoltageId",
                principalTable: "Voltages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Frames_InstallMotorDimensions_InstallDimensionMotorId",
                table: "Frames",
                column: "InstallDimensionMotorId",
                principalTable: "InstallMotorDimensions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Frames_InstallDimensions_InstallDimensionProcId",
                table: "Frames",
                column: "InstallDimensionProcId",
                principalTable: "InstallDimensions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Frames_Materials_MaterialId",
                table: "Frames",
                column: "MaterialId",
                principalTable: "Materials",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Fuselages_Materials_MaterialId",
                table: "Fuselages",
                column: "MaterialId",
                principalTable: "Materials",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Goggles_AspectsRatio_AspectRatioId",
                table: "Goggles",
                column: "AspectRatioId",
                principalTable: "AspectsRatio",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Goggles_Displays_DisplayId",
                table: "Goggles",
                column: "DisplayId",
                principalTable: "Displays",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Goggles_FOVs_FOVId",
                table: "Goggles",
                column: "FOVId",
                principalTable: "FOVs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Links_Accessories_AccessoryModelId",
                table: "Links",
                column: "AccessoryModelId",
                principalTable: "Accessories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Links_Accessories_AccessoryModelId1",
                table: "Links",
                column: "AccessoryModelId1",
                principalTable: "Accessories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Links_Accessories_AccessoryModelId2",
                table: "Links",
                column: "AccessoryModelId2",
                principalTable: "Accessories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Links_Antennas_AntennaId",
                table: "Links",
                column: "AntennaId",
                principalTable: "Antennas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Links_Antennas_AntennaId1",
                table: "Links",
                column: "AntennaId1",
                principalTable: "Antennas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Links_Antennas_AntennaId2",
                table: "Links",
                column: "AntennaId2",
                principalTable: "Antennas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Links_Batteries_BatteryId",
                table: "Links",
                column: "BatteryId",
                principalTable: "Batteries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Links_Batteries_BatteryId1",
                table: "Links",
                column: "BatteryId1",
                principalTable: "Batteries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Links_Batteries_BatteryId2",
                table: "Links",
                column: "BatteryId2",
                principalTable: "Batteries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Links_Cameras_CameraId",
                table: "Links",
                column: "CameraId",
                principalTable: "Cameras",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Links_Cameras_CameraId1",
                table: "Links",
                column: "CameraId1",
                principalTable: "Cameras",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Links_Cameras_CameraId2",
                table: "Links",
                column: "CameraId2",
                principalTable: "Cameras",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Links_Chargers_ChargerId",
                table: "Links",
                column: "ChargerId",
                principalTable: "Chargers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Links_Chargers_ChargerId1",
                table: "Links",
                column: "ChargerId1",
                principalTable: "Chargers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Links_Chargers_ChargerId2",
                table: "Links",
                column: "ChargerId2",
                principalTable: "Chargers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Links_ESCs_ESCId",
                table: "Links",
                column: "ESCId",
                principalTable: "ESCs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Links_ESCs_ESCId1",
                table: "Links",
                column: "ESCId1",
                principalTable: "ESCs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Links_ESCs_ESCId2",
                table: "Links",
                column: "ESCId2",
                principalTable: "ESCs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Links_FlightControllers_FlightControllerId",
                table: "Links",
                column: "FlightControllerId",
                principalTable: "FlightControllers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Links_FlightControllers_FlightControllerId1",
                table: "Links",
                column: "FlightControllerId1",
                principalTable: "FlightControllers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Links_FlightControllers_FlightControllerId2",
                table: "Links",
                column: "FlightControllerId2",
                principalTable: "FlightControllers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Links_Frames_FrameId",
                table: "Links",
                column: "FrameId",
                principalTable: "Frames",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Links_Frames_FrameId1",
                table: "Links",
                column: "FrameId1",
                principalTable: "Frames",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Links_Frames_FrameId2",
                table: "Links",
                column: "FrameId2",
                principalTable: "Frames",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Links_Fuselages_FuselageId",
                table: "Links",
                column: "FuselageId",
                principalTable: "Fuselages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Links_Fuselages_FuselageId1",
                table: "Links",
                column: "FuselageId1",
                principalTable: "Fuselages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Links_Fuselages_FuselageId2",
                table: "Links",
                column: "FuselageId2",
                principalTable: "Fuselages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Links_Goggles_GoggleId",
                table: "Links",
                column: "GoggleId",
                principalTable: "Goggles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Links_Goggles_GoggleId1",
                table: "Links",
                column: "GoggleId1",
                principalTable: "Goggles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Links_Goggles_GoggleId2",
                table: "Links",
                column: "GoggleId2",
                principalTable: "Goggles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Links_Lights_LightId",
                table: "Links",
                column: "LightId",
                principalTable: "Lights",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Links_Lights_LightId1",
                table: "Links",
                column: "LightId1",
                principalTable: "Lights",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Links_Lights_LightId2",
                table: "Links",
                column: "LightId2",
                principalTable: "Lights",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Links_LinkTypes_LinkTypeId",
                table: "Links",
                column: "LinkTypeId",
                principalTable: "LinkTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Links_Motors_MotorId",
                table: "Links",
                column: "MotorId",
                principalTable: "Motors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Links_Motors_MotorId1",
                table: "Links",
                column: "MotorId1",
                principalTable: "Motors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Links_Motors_MotorId2",
                table: "Links",
                column: "MotorId2",
                principalTable: "Motors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Links_PDBs_PDBId",
                table: "Links",
                column: "PDBId",
                principalTable: "PDBs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Links_PDBs_PDBId1",
                table: "Links",
                column: "PDBId1",
                principalTable: "PDBs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Links_PDBs_PDBId2",
                table: "Links",
                column: "PDBId2",
                principalTable: "PDBs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Links_Props_PropId",
                table: "Links",
                column: "PropId",
                principalTable: "Props",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Links_Props_PropId1",
                table: "Links",
                column: "PropId1",
                principalTable: "Props",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Links_Props_PropId2",
                table: "Links",
                column: "PropId2",
                principalTable: "Props",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Links_RCOthers_RCOtherId",
                table: "Links",
                column: "RCOtherId",
                principalTable: "RCOthers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Links_RCOthers_RCOtherId1",
                table: "Links",
                column: "RCOtherId1",
                principalTable: "RCOthers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Links_RCOthers_RCOtherId2",
                table: "Links",
                column: "RCOtherId2",
                principalTable: "RCOthers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Links_Receivers_ReceiverId",
                table: "Links",
                column: "ReceiverId",
                principalTable: "Receivers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Links_Receivers_ReceiverId1",
                table: "Links",
                column: "ReceiverId1",
                principalTable: "Receivers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Links_Receivers_ReceiverId2",
                table: "Links",
                column: "ReceiverId2",
                principalTable: "Receivers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Links_Servos_ServoId",
                table: "Links",
                column: "ServoId",
                principalTable: "Servos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Links_Servos_ServoId1",
                table: "Links",
                column: "ServoId1",
                principalTable: "Servos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Links_Servos_ServoId2",
                table: "Links",
                column: "ServoId2",
                principalTable: "Servos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Links_Transmitters_TransmitterId",
                table: "Links",
                column: "TransmitterId",
                principalTable: "Transmitters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Links_Transmitters_TransmitterId1",
                table: "Links",
                column: "TransmitterId1",
                principalTable: "Transmitters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Links_Transmitters_TransmitterId2",
                table: "Links",
                column: "TransmitterId2",
                principalTable: "Transmitters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Links_VideoReceivers_VideoReceiverId",
                table: "Links",
                column: "VideoReceiverId",
                principalTable: "VideoReceivers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Links_VideoReceivers_VideoReceiverId1",
                table: "Links",
                column: "VideoReceiverId1",
                principalTable: "VideoReceivers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Links_VideoReceivers_VideoReceiverId2",
                table: "Links",
                column: "VideoReceiverId2",
                principalTable: "VideoReceivers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Links_VideoTransmitters_VideoTransmitterId",
                table: "Links",
                column: "VideoTransmitterId",
                principalTable: "VideoTransmitters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Links_VideoTransmitters_VideoTransmitterId1",
                table: "Links",
                column: "VideoTransmitterId1",
                principalTable: "VideoTransmitters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Links_VideoTransmitters_VideoTransmitterId2",
                table: "Links",
                column: "VideoTransmitterId2",
                principalTable: "VideoTransmitters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Motors_InstallMotorDimensions_InstallDimensionId",
                table: "Motors",
                column: "InstallDimensionId",
                principalTable: "InstallMotorDimensions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Motors_MotorKVs_KVId",
                table: "Motors",
                column: "KVId",
                principalTable: "MotorKVs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Motors_Voltages_VoltageId",
                table: "Motors",
                column: "VoltageId",
                principalTable: "Voltages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PDBs_Voltages_InputVoltageId",
                table: "PDBs",
                column: "InputVoltageId",
                principalTable: "Voltages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PDBs_InstallDimensions_InstallDimensionId",
                table: "PDBs",
                column: "InstallDimensionId",
                principalTable: "InstallDimensions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PDBs_PDBTypes_PDBTypeId",
                table: "PDBs",
                column: "PDBTypeId",
                principalTable: "PDBTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RCOthers_RCOtherTypes_TypeId",
                table: "RCOthers",
                column: "TypeId",
                principalTable: "RCOtherTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Receivers_Frequency_FrequencyId",
                table: "Receivers",
                column: "FrequencyId",
                principalTable: "Frequency",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Receivers_RCProtocols_OutputId",
                table: "Receivers",
                column: "OutputId",
                principalTable: "RCProtocols",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Receivers_Voltages_VoltageId",
                table: "Receivers",
                column: "VoltageId",
                principalTable: "Voltages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Servos_Voltages_VoltageId",
                table: "Servos",
                column: "VoltageId",
                principalTable: "Voltages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_VideoReceivers_AntennaConnector_AntennaConnectorId",
                table: "VideoReceivers",
                column: "AntennaConnectorId",
                principalTable: "AntennaConnector",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_VideoReceivers_Frequency_FrequencyId",
                table: "VideoReceivers",
                column: "FrequencyId",
                principalTable: "Frequency",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_VideoReceivers_Voltages_VoltageId",
                table: "VideoReceivers",
                column: "VoltageId",
                principalTable: "Voltages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_VideoTransmitters_AntennaConnector_AntennaConnectorId",
                table: "VideoTransmitters",
                column: "AntennaConnectorId",
                principalTable: "AntennaConnector",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_VideoTransmitters_Frequency_FrequencyId",
                table: "VideoTransmitters",
                column: "FrequencyId",
                principalTable: "Frequency",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_VideoTransmitters_Voltages_VoltageId",
                table: "VideoTransmitters",
                column: "VoltageId",
                principalTable: "Voltages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Accessories_AccessoryTypes_TypeId",
                table: "Accessories");

            migrationBuilder.DropForeignKey(
                name: "FK_Antennas_AntennaConnector_AntennaConnectorId",
                table: "Antennas");

            migrationBuilder.DropForeignKey(
                name: "FK_Antennas_Frequency_FrequencyId",
                table: "Antennas");

            migrationBuilder.DropForeignKey(
                name: "FK_Batteries_BattaryTypes_BattaryTypeId",
                table: "Batteries");

            migrationBuilder.DropForeignKey(
                name: "FK_Batteries_Capacity_CapacityId",
                table: "Batteries");

            migrationBuilder.DropForeignKey(
                name: "FK_Batteries_DischargeRates_DischargeRateId",
                table: "Batteries");

            migrationBuilder.DropForeignKey(
                name: "FK_Batteries_Voltages_VoltageId",
                table: "Batteries");

            migrationBuilder.DropForeignKey(
                name: "FK_Cameras_AspectsRatio_AspectRatioId",
                table: "Cameras");

            migrationBuilder.DropForeignKey(
                name: "FK_Cameras_FOVs_FOVId",
                table: "Cameras");

            migrationBuilder.DropForeignKey(
                name: "FK_Cameras_HorizontalResolutions_HorizontalResolutionId",
                table: "Cameras");

            migrationBuilder.DropForeignKey(
                name: "FK_Cameras_ImageSensors_ImageSensorId",
                table: "Cameras");

            migrationBuilder.DropForeignKey(
                name: "FK_Cameras_Voltages_VoltageId",
                table: "Cameras");

            migrationBuilder.DropForeignKey(
                name: "FK_Chargers_Voltages_PbBatteryVoltageId",
                table: "Chargers");

            migrationBuilder.DropForeignKey(
                name: "FK_Chargers_Powers_PowerChargeId",
                table: "Chargers");

            migrationBuilder.DropForeignKey(
                name: "FK_Chargers_Powers_PowerDischargeId",
                table: "Chargers");

            migrationBuilder.DropForeignKey(
                name: "FK_Chargers_Voltages_VoltageId",
                table: "Chargers");

            migrationBuilder.DropForeignKey(
                name: "FK_ESCs_Currents_CurrentId",
                table: "ESCs");

            migrationBuilder.DropForeignKey(
                name: "FK_ESCs_Firmware_FirmwareId",
                table: "ESCs");

            migrationBuilder.DropForeignKey(
                name: "FK_ESCs_InstallDimensions_InstallDimensionId",
                table: "ESCs");

            migrationBuilder.DropForeignKey(
                name: "FK_ESCs_Currents_PeakCurrentId",
                table: "ESCs");

            migrationBuilder.DropForeignKey(
                name: "FK_ESCs_Processors_ProcessorId",
                table: "ESCs");

            migrationBuilder.DropForeignKey(
                name: "FK_ESCs_Voltages_VoltageId",
                table: "ESCs");

            migrationBuilder.DropForeignKey(
                name: "FK_FlightControllers_Firmware_FirmwareId",
                table: "FlightControllers");

            migrationBuilder.DropForeignKey(
                name: "FK_FlightControllers_Gyros_GyroId",
                table: "FlightControllers");

            migrationBuilder.DropForeignKey(
                name: "FK_FlightControllers_InstallDimensions_InstallDimensionId",
                table: "FlightControllers");

            migrationBuilder.DropForeignKey(
                name: "FK_FlightControllers_Voltages_VoltageId",
                table: "FlightControllers");

            migrationBuilder.DropForeignKey(
                name: "FK_Frames_InstallMotorDimensions_InstallDimensionMotorId",
                table: "Frames");

            migrationBuilder.DropForeignKey(
                name: "FK_Frames_InstallDimensions_InstallDimensionProcId",
                table: "Frames");

            migrationBuilder.DropForeignKey(
                name: "FK_Frames_Materials_MaterialId",
                table: "Frames");

            migrationBuilder.DropForeignKey(
                name: "FK_Fuselages_Materials_MaterialId",
                table: "Fuselages");

            migrationBuilder.DropForeignKey(
                name: "FK_Goggles_AspectsRatio_AspectRatioId",
                table: "Goggles");

            migrationBuilder.DropForeignKey(
                name: "FK_Goggles_Displays_DisplayId",
                table: "Goggles");

            migrationBuilder.DropForeignKey(
                name: "FK_Goggles_FOVs_FOVId",
                table: "Goggles");

            migrationBuilder.DropForeignKey(
                name: "FK_Links_Accessories_AccessoryModelId",
                table: "Links");

            migrationBuilder.DropForeignKey(
                name: "FK_Links_Accessories_AccessoryModelId1",
                table: "Links");

            migrationBuilder.DropForeignKey(
                name: "FK_Links_Accessories_AccessoryModelId2",
                table: "Links");

            migrationBuilder.DropForeignKey(
                name: "FK_Links_Antennas_AntennaId",
                table: "Links");

            migrationBuilder.DropForeignKey(
                name: "FK_Links_Antennas_AntennaId1",
                table: "Links");

            migrationBuilder.DropForeignKey(
                name: "FK_Links_Antennas_AntennaId2",
                table: "Links");

            migrationBuilder.DropForeignKey(
                name: "FK_Links_Batteries_BatteryId",
                table: "Links");

            migrationBuilder.DropForeignKey(
                name: "FK_Links_Batteries_BatteryId1",
                table: "Links");

            migrationBuilder.DropForeignKey(
                name: "FK_Links_Batteries_BatteryId2",
                table: "Links");

            migrationBuilder.DropForeignKey(
                name: "FK_Links_Cameras_CameraId",
                table: "Links");

            migrationBuilder.DropForeignKey(
                name: "FK_Links_Cameras_CameraId1",
                table: "Links");

            migrationBuilder.DropForeignKey(
                name: "FK_Links_Cameras_CameraId2",
                table: "Links");

            migrationBuilder.DropForeignKey(
                name: "FK_Links_Chargers_ChargerId",
                table: "Links");

            migrationBuilder.DropForeignKey(
                name: "FK_Links_Chargers_ChargerId1",
                table: "Links");

            migrationBuilder.DropForeignKey(
                name: "FK_Links_Chargers_ChargerId2",
                table: "Links");

            migrationBuilder.DropForeignKey(
                name: "FK_Links_ESCs_ESCId",
                table: "Links");

            migrationBuilder.DropForeignKey(
                name: "FK_Links_ESCs_ESCId1",
                table: "Links");

            migrationBuilder.DropForeignKey(
                name: "FK_Links_ESCs_ESCId2",
                table: "Links");

            migrationBuilder.DropForeignKey(
                name: "FK_Links_FlightControllers_FlightControllerId",
                table: "Links");

            migrationBuilder.DropForeignKey(
                name: "FK_Links_FlightControllers_FlightControllerId1",
                table: "Links");

            migrationBuilder.DropForeignKey(
                name: "FK_Links_FlightControllers_FlightControllerId2",
                table: "Links");

            migrationBuilder.DropForeignKey(
                name: "FK_Links_Frames_FrameId",
                table: "Links");

            migrationBuilder.DropForeignKey(
                name: "FK_Links_Frames_FrameId1",
                table: "Links");

            migrationBuilder.DropForeignKey(
                name: "FK_Links_Frames_FrameId2",
                table: "Links");

            migrationBuilder.DropForeignKey(
                name: "FK_Links_Fuselages_FuselageId",
                table: "Links");

            migrationBuilder.DropForeignKey(
                name: "FK_Links_Fuselages_FuselageId1",
                table: "Links");

            migrationBuilder.DropForeignKey(
                name: "FK_Links_Fuselages_FuselageId2",
                table: "Links");

            migrationBuilder.DropForeignKey(
                name: "FK_Links_Goggles_GoggleId",
                table: "Links");

            migrationBuilder.DropForeignKey(
                name: "FK_Links_Goggles_GoggleId1",
                table: "Links");

            migrationBuilder.DropForeignKey(
                name: "FK_Links_Goggles_GoggleId2",
                table: "Links");

            migrationBuilder.DropForeignKey(
                name: "FK_Links_Lights_LightId",
                table: "Links");

            migrationBuilder.DropForeignKey(
                name: "FK_Links_Lights_LightId1",
                table: "Links");

            migrationBuilder.DropForeignKey(
                name: "FK_Links_Lights_LightId2",
                table: "Links");

            migrationBuilder.DropForeignKey(
                name: "FK_Links_LinkTypes_LinkTypeId",
                table: "Links");

            migrationBuilder.DropForeignKey(
                name: "FK_Links_Motors_MotorId",
                table: "Links");

            migrationBuilder.DropForeignKey(
                name: "FK_Links_Motors_MotorId1",
                table: "Links");

            migrationBuilder.DropForeignKey(
                name: "FK_Links_Motors_MotorId2",
                table: "Links");

            migrationBuilder.DropForeignKey(
                name: "FK_Links_PDBs_PDBId",
                table: "Links");

            migrationBuilder.DropForeignKey(
                name: "FK_Links_PDBs_PDBId1",
                table: "Links");

            migrationBuilder.DropForeignKey(
                name: "FK_Links_PDBs_PDBId2",
                table: "Links");

            migrationBuilder.DropForeignKey(
                name: "FK_Links_Props_PropId",
                table: "Links");

            migrationBuilder.DropForeignKey(
                name: "FK_Links_Props_PropId1",
                table: "Links");

            migrationBuilder.DropForeignKey(
                name: "FK_Links_Props_PropId2",
                table: "Links");

            migrationBuilder.DropForeignKey(
                name: "FK_Links_RCOthers_RCOtherId",
                table: "Links");

            migrationBuilder.DropForeignKey(
                name: "FK_Links_RCOthers_RCOtherId1",
                table: "Links");

            migrationBuilder.DropForeignKey(
                name: "FK_Links_RCOthers_RCOtherId2",
                table: "Links");

            migrationBuilder.DropForeignKey(
                name: "FK_Links_Receivers_ReceiverId",
                table: "Links");

            migrationBuilder.DropForeignKey(
                name: "FK_Links_Receivers_ReceiverId1",
                table: "Links");

            migrationBuilder.DropForeignKey(
                name: "FK_Links_Receivers_ReceiverId2",
                table: "Links");

            migrationBuilder.DropForeignKey(
                name: "FK_Links_Servos_ServoId",
                table: "Links");

            migrationBuilder.DropForeignKey(
                name: "FK_Links_Servos_ServoId1",
                table: "Links");

            migrationBuilder.DropForeignKey(
                name: "FK_Links_Servos_ServoId2",
                table: "Links");

            migrationBuilder.DropForeignKey(
                name: "FK_Links_Transmitters_TransmitterId",
                table: "Links");

            migrationBuilder.DropForeignKey(
                name: "FK_Links_Transmitters_TransmitterId1",
                table: "Links");

            migrationBuilder.DropForeignKey(
                name: "FK_Links_Transmitters_TransmitterId2",
                table: "Links");

            migrationBuilder.DropForeignKey(
                name: "FK_Links_VideoReceivers_VideoReceiverId",
                table: "Links");

            migrationBuilder.DropForeignKey(
                name: "FK_Links_VideoReceivers_VideoReceiverId1",
                table: "Links");

            migrationBuilder.DropForeignKey(
                name: "FK_Links_VideoReceivers_VideoReceiverId2",
                table: "Links");

            migrationBuilder.DropForeignKey(
                name: "FK_Links_VideoTransmitters_VideoTransmitterId",
                table: "Links");

            migrationBuilder.DropForeignKey(
                name: "FK_Links_VideoTransmitters_VideoTransmitterId1",
                table: "Links");

            migrationBuilder.DropForeignKey(
                name: "FK_Links_VideoTransmitters_VideoTransmitterId2",
                table: "Links");

            migrationBuilder.DropForeignKey(
                name: "FK_Motors_InstallMotorDimensions_InstallDimensionId",
                table: "Motors");

            migrationBuilder.DropForeignKey(
                name: "FK_Motors_MotorKVs_KVId",
                table: "Motors");

            migrationBuilder.DropForeignKey(
                name: "FK_Motors_Voltages_VoltageId",
                table: "Motors");

            migrationBuilder.DropForeignKey(
                name: "FK_PDBs_Voltages_InputVoltageId",
                table: "PDBs");

            migrationBuilder.DropForeignKey(
                name: "FK_PDBs_InstallDimensions_InstallDimensionId",
                table: "PDBs");

            migrationBuilder.DropForeignKey(
                name: "FK_PDBs_PDBTypes_PDBTypeId",
                table: "PDBs");

            migrationBuilder.DropForeignKey(
                name: "FK_RCOthers_RCOtherTypes_TypeId",
                table: "RCOthers");

            migrationBuilder.DropForeignKey(
                name: "FK_Receivers_Frequency_FrequencyId",
                table: "Receivers");

            migrationBuilder.DropForeignKey(
                name: "FK_Receivers_RCProtocols_OutputId",
                table: "Receivers");

            migrationBuilder.DropForeignKey(
                name: "FK_Receivers_Voltages_VoltageId",
                table: "Receivers");

            migrationBuilder.DropForeignKey(
                name: "FK_Servos_Voltages_VoltageId",
                table: "Servos");

            migrationBuilder.DropForeignKey(
                name: "FK_VideoReceivers_AntennaConnector_AntennaConnectorId",
                table: "VideoReceivers");

            migrationBuilder.DropForeignKey(
                name: "FK_VideoReceivers_Frequency_FrequencyId",
                table: "VideoReceivers");

            migrationBuilder.DropForeignKey(
                name: "FK_VideoReceivers_Voltages_VoltageId",
                table: "VideoReceivers");

            migrationBuilder.DropForeignKey(
                name: "FK_VideoTransmitters_AntennaConnector_AntennaConnectorId",
                table: "VideoTransmitters");

            migrationBuilder.DropForeignKey(
                name: "FK_VideoTransmitters_Frequency_FrequencyId",
                table: "VideoTransmitters");

            migrationBuilder.DropForeignKey(
                name: "FK_VideoTransmitters_Voltages_VoltageId",
                table: "VideoTransmitters");

            migrationBuilder.DropTable(
                name: "AccessoryTypes");

            migrationBuilder.DropTable(
                name: "AntennaConnector");

            migrationBuilder.DropTable(
                name: "AspectsRatio");

            migrationBuilder.DropTable(
                name: "BattaryTypes");

            migrationBuilder.DropTable(
                name: "BECs");

            migrationBuilder.DropTable(
                name: "Capacity");

            migrationBuilder.DropTable(
                name: "Currents");

            migrationBuilder.DropTable(
                name: "DischargeRates");

            migrationBuilder.DropTable(
                name: "Displays");

            migrationBuilder.DropTable(
                name: "Firmware");

            migrationBuilder.DropTable(
                name: "FOVs");

            migrationBuilder.DropTable(
                name: "Gyros");

            migrationBuilder.DropTable(
                name: "HorizontalResolutions");

            migrationBuilder.DropTable(
                name: "ImageSensors");

            migrationBuilder.DropTable(
                name: "InstallDimensions");

            migrationBuilder.DropTable(
                name: "InstallMotorDimensions");

            migrationBuilder.DropTable(
                name: "LinkTypes");

            migrationBuilder.DropTable(
                name: "Materials");

            migrationBuilder.DropTable(
                name: "Measurements");

            migrationBuilder.DropTable(
                name: "MotorKVs");

            migrationBuilder.DropTable(
                name: "PDBTypes");

            migrationBuilder.DropTable(
                name: "RCOtherTypes");

            migrationBuilder.DropTable(
                name: "RCProtocols");

            migrationBuilder.DropTable(
                name: "TransmitterTypes");

            migrationBuilder.DropTable(
                name: "PropTypes");

            migrationBuilder.DropTable(
                name: "Voltages");

            migrationBuilder.DropTable(
                name: "Frequency");

            migrationBuilder.DropTable(
                name: "Powers");

            migrationBuilder.DropIndex(
                name: "IX_VideoTransmitters_AntennaConnectorId",
                table: "VideoTransmitters");

            migrationBuilder.DropIndex(
                name: "IX_VideoTransmitters_FrequencyId",
                table: "VideoTransmitters");

            migrationBuilder.DropIndex(
                name: "IX_VideoTransmitters_VoltageId",
                table: "VideoTransmitters");

            migrationBuilder.DropIndex(
                name: "IX_VideoReceivers_AntennaConnectorId",
                table: "VideoReceivers");

            migrationBuilder.DropIndex(
                name: "IX_VideoReceivers_FrequencyId",
                table: "VideoReceivers");

            migrationBuilder.DropIndex(
                name: "IX_VideoReceivers_VoltageId",
                table: "VideoReceivers");

            migrationBuilder.DropIndex(
                name: "IX_Servos_VoltageId",
                table: "Servos");

            migrationBuilder.DropIndex(
                name: "IX_Receivers_FrequencyId",
                table: "Receivers");

            migrationBuilder.DropIndex(
                name: "IX_Receivers_OutputId",
                table: "Receivers");

            migrationBuilder.DropIndex(
                name: "IX_Receivers_VoltageId",
                table: "Receivers");

            migrationBuilder.DropIndex(
                name: "IX_RCOthers_TypeId",
                table: "RCOthers");

            migrationBuilder.DropIndex(
                name: "IX_PDBs_InputVoltageId",
                table: "PDBs");

            migrationBuilder.DropIndex(
                name: "IX_PDBs_InstallDimensionId",
                table: "PDBs");

            migrationBuilder.DropIndex(
                name: "IX_PDBs_PDBTypeId",
                table: "PDBs");

            migrationBuilder.DropIndex(
                name: "IX_Motors_InstallDimensionId",
                table: "Motors");

            migrationBuilder.DropIndex(
                name: "IX_Motors_KVId",
                table: "Motors");

            migrationBuilder.DropIndex(
                name: "IX_Motors_VoltageId",
                table: "Motors");

            migrationBuilder.DropIndex(
                name: "IX_Links_AccessoryModelId",
                table: "Links");

            migrationBuilder.DropIndex(
                name: "IX_Links_AccessoryModelId1",
                table: "Links");

            migrationBuilder.DropIndex(
                name: "IX_Links_AccessoryModelId2",
                table: "Links");

            migrationBuilder.DropIndex(
                name: "IX_Links_AntennaId",
                table: "Links");

            migrationBuilder.DropIndex(
                name: "IX_Links_AntennaId1",
                table: "Links");

            migrationBuilder.DropIndex(
                name: "IX_Links_AntennaId2",
                table: "Links");

            migrationBuilder.DropIndex(
                name: "IX_Links_BatteryId",
                table: "Links");

            migrationBuilder.DropIndex(
                name: "IX_Links_BatteryId1",
                table: "Links");

            migrationBuilder.DropIndex(
                name: "IX_Links_BatteryId2",
                table: "Links");

            migrationBuilder.DropIndex(
                name: "IX_Links_CameraId",
                table: "Links");

            migrationBuilder.DropIndex(
                name: "IX_Links_CameraId1",
                table: "Links");

            migrationBuilder.DropIndex(
                name: "IX_Links_CameraId2",
                table: "Links");

            migrationBuilder.DropIndex(
                name: "IX_Links_ChargerId",
                table: "Links");

            migrationBuilder.DropIndex(
                name: "IX_Links_ChargerId1",
                table: "Links");

            migrationBuilder.DropIndex(
                name: "IX_Links_ChargerId2",
                table: "Links");

            migrationBuilder.DropIndex(
                name: "IX_Links_ESCId",
                table: "Links");

            migrationBuilder.DropIndex(
                name: "IX_Links_ESCId1",
                table: "Links");

            migrationBuilder.DropIndex(
                name: "IX_Links_ESCId2",
                table: "Links");

            migrationBuilder.DropIndex(
                name: "IX_Links_FlightControllerId",
                table: "Links");

            migrationBuilder.DropIndex(
                name: "IX_Links_FlightControllerId1",
                table: "Links");

            migrationBuilder.DropIndex(
                name: "IX_Links_FlightControllerId2",
                table: "Links");

            migrationBuilder.DropIndex(
                name: "IX_Links_FrameId",
                table: "Links");

            migrationBuilder.DropIndex(
                name: "IX_Links_FrameId1",
                table: "Links");

            migrationBuilder.DropIndex(
                name: "IX_Links_FrameId2",
                table: "Links");

            migrationBuilder.DropIndex(
                name: "IX_Links_FuselageId",
                table: "Links");

            migrationBuilder.DropIndex(
                name: "IX_Links_FuselageId1",
                table: "Links");

            migrationBuilder.DropIndex(
                name: "IX_Links_FuselageId2",
                table: "Links");

            migrationBuilder.DropIndex(
                name: "IX_Links_GoggleId",
                table: "Links");

            migrationBuilder.DropIndex(
                name: "IX_Links_GoggleId1",
                table: "Links");

            migrationBuilder.DropIndex(
                name: "IX_Links_GoggleId2",
                table: "Links");

            migrationBuilder.DropIndex(
                name: "IX_Links_LightId",
                table: "Links");

            migrationBuilder.DropIndex(
                name: "IX_Links_LightId1",
                table: "Links");

            migrationBuilder.DropIndex(
                name: "IX_Links_LightId2",
                table: "Links");

            migrationBuilder.DropIndex(
                name: "IX_Links_LinkTypeId",
                table: "Links");

            migrationBuilder.DropIndex(
                name: "IX_Links_MotorId",
                table: "Links");

            migrationBuilder.DropIndex(
                name: "IX_Links_MotorId1",
                table: "Links");

            migrationBuilder.DropIndex(
                name: "IX_Links_MotorId2",
                table: "Links");

            migrationBuilder.DropIndex(
                name: "IX_Links_PDBId",
                table: "Links");

            migrationBuilder.DropIndex(
                name: "IX_Links_PDBId1",
                table: "Links");

            migrationBuilder.DropIndex(
                name: "IX_Links_PDBId2",
                table: "Links");

            migrationBuilder.DropIndex(
                name: "IX_Links_PropId",
                table: "Links");

            migrationBuilder.DropIndex(
                name: "IX_Links_PropId1",
                table: "Links");

            migrationBuilder.DropIndex(
                name: "IX_Links_PropId2",
                table: "Links");

            migrationBuilder.DropIndex(
                name: "IX_Links_RCOtherId",
                table: "Links");

            migrationBuilder.DropIndex(
                name: "IX_Links_RCOtherId1",
                table: "Links");

            migrationBuilder.DropIndex(
                name: "IX_Links_RCOtherId2",
                table: "Links");

            migrationBuilder.DropIndex(
                name: "IX_Links_ReceiverId",
                table: "Links");

            migrationBuilder.DropIndex(
                name: "IX_Links_ReceiverId1",
                table: "Links");

            migrationBuilder.DropIndex(
                name: "IX_Links_ReceiverId2",
                table: "Links");

            migrationBuilder.DropIndex(
                name: "IX_Links_ServoId",
                table: "Links");

            migrationBuilder.DropIndex(
                name: "IX_Links_ServoId1",
                table: "Links");

            migrationBuilder.DropIndex(
                name: "IX_Links_ServoId2",
                table: "Links");

            migrationBuilder.DropIndex(
                name: "IX_Links_TransmitterId",
                table: "Links");

            migrationBuilder.DropIndex(
                name: "IX_Links_TransmitterId1",
                table: "Links");

            migrationBuilder.DropIndex(
                name: "IX_Links_TransmitterId2",
                table: "Links");

            migrationBuilder.DropIndex(
                name: "IX_Links_VideoReceiverId",
                table: "Links");

            migrationBuilder.DropIndex(
                name: "IX_Links_VideoReceiverId1",
                table: "Links");

            migrationBuilder.DropIndex(
                name: "IX_Links_VideoReceiverId2",
                table: "Links");

            migrationBuilder.DropIndex(
                name: "IX_Links_VideoTransmitterId",
                table: "Links");

            migrationBuilder.DropIndex(
                name: "IX_Links_VideoTransmitterId1",
                table: "Links");

            migrationBuilder.DropIndex(
                name: "IX_Links_VideoTransmitterId2",
                table: "Links");

            migrationBuilder.DropIndex(
                name: "IX_Goggles_AspectRatioId",
                table: "Goggles");

            migrationBuilder.DropIndex(
                name: "IX_Goggles_DisplayId",
                table: "Goggles");

            migrationBuilder.DropIndex(
                name: "IX_Goggles_FOVId",
                table: "Goggles");

            migrationBuilder.DropIndex(
                name: "IX_Fuselages_MaterialId",
                table: "Fuselages");

            migrationBuilder.DropIndex(
                name: "IX_Frames_InstallDimensionMotorId",
                table: "Frames");

            migrationBuilder.DropIndex(
                name: "IX_Frames_InstallDimensionProcId",
                table: "Frames");

            migrationBuilder.DropIndex(
                name: "IX_Frames_MaterialId",
                table: "Frames");

            migrationBuilder.DropIndex(
                name: "IX_FlightControllers_FirmwareId",
                table: "FlightControllers");

            migrationBuilder.DropIndex(
                name: "IX_FlightControllers_GyroId",
                table: "FlightControllers");

            migrationBuilder.DropIndex(
                name: "IX_FlightControllers_InstallDimensionId",
                table: "FlightControllers");

            migrationBuilder.DropIndex(
                name: "IX_FlightControllers_VoltageId",
                table: "FlightControllers");

            migrationBuilder.DropIndex(
                name: "IX_ESCs_CurrentId",
                table: "ESCs");

            migrationBuilder.DropIndex(
                name: "IX_ESCs_FirmwareId",
                table: "ESCs");

            migrationBuilder.DropIndex(
                name: "IX_ESCs_InstallDimensionId",
                table: "ESCs");

            migrationBuilder.DropIndex(
                name: "IX_ESCs_PeakCurrentId",
                table: "ESCs");

            migrationBuilder.DropIndex(
                name: "IX_ESCs_ProcessorId",
                table: "ESCs");

            migrationBuilder.DropIndex(
                name: "IX_ESCs_VoltageId",
                table: "ESCs");

            migrationBuilder.DropIndex(
                name: "IX_Chargers_PbBatteryVoltageId",
                table: "Chargers");

            migrationBuilder.DropIndex(
                name: "IX_Chargers_PowerChargeId",
                table: "Chargers");

            migrationBuilder.DropIndex(
                name: "IX_Chargers_PowerDischargeId",
                table: "Chargers");

            migrationBuilder.DropIndex(
                name: "IX_Chargers_VoltageId",
                table: "Chargers");

            migrationBuilder.DropIndex(
                name: "IX_Cameras_AspectRatioId",
                table: "Cameras");

            migrationBuilder.DropIndex(
                name: "IX_Cameras_FOVId",
                table: "Cameras");

            migrationBuilder.DropIndex(
                name: "IX_Cameras_HorizontalResolutionId",
                table: "Cameras");

            migrationBuilder.DropIndex(
                name: "IX_Cameras_ImageSensorId",
                table: "Cameras");

            migrationBuilder.DropIndex(
                name: "IX_Cameras_VoltageId",
                table: "Cameras");

            migrationBuilder.DropIndex(
                name: "IX_Batteries_BattaryTypeId",
                table: "Batteries");

            migrationBuilder.DropIndex(
                name: "IX_Batteries_CapacityId",
                table: "Batteries");

            migrationBuilder.DropIndex(
                name: "IX_Batteries_DischargeRateId",
                table: "Batteries");

            migrationBuilder.DropIndex(
                name: "IX_Batteries_VoltageId",
                table: "Batteries");

            migrationBuilder.DropIndex(
                name: "IX_Antennas_AntennaConnectorId",
                table: "Antennas");

            migrationBuilder.DropIndex(
                name: "IX_Antennas_FrequencyId",
                table: "Antennas");

            migrationBuilder.DropIndex(
                name: "IX_Accessories_TypeId",
                table: "Accessories");

            migrationBuilder.DropColumn(
                name: "AntennaConnectorId",
                table: "VideoTransmitters");

            migrationBuilder.DropColumn(
                name: "BEC",
                table: "VideoTransmitters");

            migrationBuilder.DropColumn(
                name: "Dimension",
                table: "VideoTransmitters");

            migrationBuilder.DropColumn(
                name: "FrequencyId",
                table: "VideoTransmitters");

            migrationBuilder.DropColumn(
                name: "LowBand",
                table: "VideoTransmitters");

            migrationBuilder.DropColumn(
                name: "Mic",
                table: "VideoTransmitters");

            migrationBuilder.DropColumn(
                name: "N_Channels",
                table: "VideoTransmitters");

            migrationBuilder.DropColumn(
                name: "PitMode",
                table: "VideoTransmitters");

            migrationBuilder.DropColumn(
                name: "RaceBand",
                table: "VideoTransmitters");

            migrationBuilder.DropColumn(
                name: "VTXControl",
                table: "VideoTransmitters");

            migrationBuilder.DropColumn(
                name: "VoltageId",
                table: "VideoTransmitters");

            migrationBuilder.DropColumn(
                name: "Сomment",
                table: "VideoTransmitters");

            migrationBuilder.DropColumn(
                name: "AntennaConnectorId",
                table: "VideoReceivers");

            migrationBuilder.DropColumn(
                name: "AntennaGain",
                table: "VideoReceivers");

            migrationBuilder.DropColumn(
                name: "Dimension",
                table: "VideoReceivers");

            migrationBuilder.DropColumn(
                name: "FrequencyId",
                table: "VideoReceivers");

            migrationBuilder.DropColumn(
                name: "LowBand",
                table: "VideoReceivers");

            migrationBuilder.DropColumn(
                name: "N_Channels",
                table: "VideoReceivers");

            migrationBuilder.DropColumn(
                name: "RaceBand",
                table: "VideoReceivers");

            migrationBuilder.DropColumn(
                name: "VoltageId",
                table: "VideoReceivers");

            migrationBuilder.DropColumn(
                name: "Сomment",
                table: "VideoReceivers");

            migrationBuilder.DropColumn(
                name: "Сomment",
                table: "Transmitters");

            migrationBuilder.DropColumn(
                name: "Dimension",
                table: "Servos");

            migrationBuilder.DropColumn(
                name: "OperatingSpeed",
                table: "Servos");

            migrationBuilder.DropColumn(
                name: "StallTorque",
                table: "Servos");

            migrationBuilder.DropColumn(
                name: "VoltageId",
                table: "Servos");

            migrationBuilder.DropColumn(
                name: "Сomment",
                table: "Servos");

            migrationBuilder.DropColumn(
                name: "Dimension",
                table: "Receivers");

            migrationBuilder.DropColumn(
                name: "FrequencyId",
                table: "Receivers");

            migrationBuilder.DropColumn(
                name: "OutputId",
                table: "Receivers");

            migrationBuilder.DropColumn(
                name: "SPort",
                table: "Receivers");

            migrationBuilder.DropColumn(
                name: "VoltageId",
                table: "Receivers");

            migrationBuilder.DropColumn(
                name: "Сomment",
                table: "Receivers");

            migrationBuilder.DropColumn(
                name: "TypeId",
                table: "RCOthers");

            migrationBuilder.DropColumn(
                name: "Сomment",
                table: "RCOthers");

            migrationBuilder.DropColumn(
                name: "MountingHole",
                table: "Props");

            migrationBuilder.DropColumn(
                name: "Сomment",
                table: "Props");

            migrationBuilder.DropColumn(
                name: "CurrentSensor",
                table: "PDBs");

            migrationBuilder.DropColumn(
                name: "Dimensions",
                table: "PDBs");

            migrationBuilder.DropColumn(
                name: "InputVoltageId",
                table: "PDBs");

            migrationBuilder.DropColumn(
                name: "InstallDimensionId",
                table: "PDBs");

            migrationBuilder.DropColumn(
                name: "PDBTypeId",
                table: "PDBs");

            migrationBuilder.DropColumn(
                name: "Сomment",
                table: "PDBs");

            migrationBuilder.DropColumn(
                name: "Height",
                table: "Motors");

            migrationBuilder.DropColumn(
                name: "InstallDimensionId",
                table: "Motors");

            migrationBuilder.DropColumn(
                name: "KVId",
                table: "Motors");

            migrationBuilder.DropColumn(
                name: "MotorMountHoleSize",
                table: "Motors");

            migrationBuilder.DropColumn(
                name: "ShaftDiameter",
                table: "Motors");

            migrationBuilder.DropColumn(
                name: "VoltageId",
                table: "Motors");

            migrationBuilder.DropColumn(
                name: "Width",
                table: "Motors");

            migrationBuilder.DropColumn(
                name: "Сomment",
                table: "Motors");

            migrationBuilder.DropColumn(
                name: "AccessoryModelId",
                table: "Links");

            migrationBuilder.DropColumn(
                name: "AccessoryModelId1",
                table: "Links");

            migrationBuilder.DropColumn(
                name: "AccessoryModelId2",
                table: "Links");

            migrationBuilder.DropColumn(
                name: "AntennaId",
                table: "Links");

            migrationBuilder.DropColumn(
                name: "AntennaId1",
                table: "Links");

            migrationBuilder.DropColumn(
                name: "AntennaId2",
                table: "Links");

            migrationBuilder.DropColumn(
                name: "BatteryId",
                table: "Links");

            migrationBuilder.DropColumn(
                name: "BatteryId1",
                table: "Links");

            migrationBuilder.DropColumn(
                name: "BatteryId2",
                table: "Links");

            migrationBuilder.DropColumn(
                name: "CameraId",
                table: "Links");

            migrationBuilder.DropColumn(
                name: "CameraId1",
                table: "Links");

            migrationBuilder.DropColumn(
                name: "CameraId2",
                table: "Links");

            migrationBuilder.DropColumn(
                name: "ChargerId",
                table: "Links");

            migrationBuilder.DropColumn(
                name: "ChargerId1",
                table: "Links");

            migrationBuilder.DropColumn(
                name: "ChargerId2",
                table: "Links");

            migrationBuilder.DropColumn(
                name: "ESCId",
                table: "Links");

            migrationBuilder.DropColumn(
                name: "ESCId1",
                table: "Links");

            migrationBuilder.DropColumn(
                name: "ESCId2",
                table: "Links");

            migrationBuilder.DropColumn(
                name: "FlightControllerId",
                table: "Links");

            migrationBuilder.DropColumn(
                name: "FlightControllerId1",
                table: "Links");

            migrationBuilder.DropColumn(
                name: "FlightControllerId2",
                table: "Links");

            migrationBuilder.DropColumn(
                name: "FrameId",
                table: "Links");

            migrationBuilder.DropColumn(
                name: "FrameId1",
                table: "Links");

            migrationBuilder.DropColumn(
                name: "FrameId2",
                table: "Links");

            migrationBuilder.DropColumn(
                name: "FuselageId",
                table: "Links");

            migrationBuilder.DropColumn(
                name: "FuselageId1",
                table: "Links");

            migrationBuilder.DropColumn(
                name: "FuselageId2",
                table: "Links");

            migrationBuilder.DropColumn(
                name: "GoggleId",
                table: "Links");

            migrationBuilder.DropColumn(
                name: "GoggleId1",
                table: "Links");

            migrationBuilder.DropColumn(
                name: "GoggleId2",
                table: "Links");

            migrationBuilder.DropColumn(
                name: "LightId",
                table: "Links");

            migrationBuilder.DropColumn(
                name: "LightId1",
                table: "Links");

            migrationBuilder.DropColumn(
                name: "LightId2",
                table: "Links");

            migrationBuilder.DropColumn(
                name: "LinkTypeId",
                table: "Links");

            migrationBuilder.DropColumn(
                name: "MotorId",
                table: "Links");

            migrationBuilder.DropColumn(
                name: "MotorId1",
                table: "Links");

            migrationBuilder.DropColumn(
                name: "MotorId2",
                table: "Links");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Links");

            migrationBuilder.DropColumn(
                name: "PDBId",
                table: "Links");

            migrationBuilder.DropColumn(
                name: "PDBId1",
                table: "Links");

            migrationBuilder.DropColumn(
                name: "PDBId2",
                table: "Links");

            migrationBuilder.DropColumn(
                name: "PropId",
                table: "Links");

            migrationBuilder.DropColumn(
                name: "PropId1",
                table: "Links");

            migrationBuilder.DropColumn(
                name: "PropId2",
                table: "Links");

            migrationBuilder.DropColumn(
                name: "RCOtherId",
                table: "Links");

            migrationBuilder.DropColumn(
                name: "RCOtherId1",
                table: "Links");

            migrationBuilder.DropColumn(
                name: "RCOtherId2",
                table: "Links");

            migrationBuilder.DropColumn(
                name: "ReceiverId",
                table: "Links");

            migrationBuilder.DropColumn(
                name: "ReceiverId1",
                table: "Links");

            migrationBuilder.DropColumn(
                name: "ReceiverId2",
                table: "Links");

            migrationBuilder.DropColumn(
                name: "ServoId",
                table: "Links");

            migrationBuilder.DropColumn(
                name: "ServoId1",
                table: "Links");

            migrationBuilder.DropColumn(
                name: "ServoId2",
                table: "Links");

            migrationBuilder.DropColumn(
                name: "TransmitterId",
                table: "Links");

            migrationBuilder.DropColumn(
                name: "TransmitterId1",
                table: "Links");

            migrationBuilder.DropColumn(
                name: "TransmitterId2",
                table: "Links");

            migrationBuilder.DropColumn(
                name: "VideoReceiverId",
                table: "Links");

            migrationBuilder.DropColumn(
                name: "VideoReceiverId1",
                table: "Links");

            migrationBuilder.DropColumn(
                name: "VideoReceiverId2",
                table: "Links");

            migrationBuilder.DropColumn(
                name: "VideoTransmitterId",
                table: "Links");

            migrationBuilder.DropColumn(
                name: "VideoTransmitterId1",
                table: "Links");

            migrationBuilder.DropColumn(
                name: "VideoTransmitterId2",
                table: "Links");

            migrationBuilder.DropColumn(
                name: "Сomment",
                table: "Lights");

            migrationBuilder.DropColumn(
                name: "AspectRatioId",
                table: "Goggles");

            migrationBuilder.DropColumn(
                name: "DVR",
                table: "Goggles");

            migrationBuilder.DropColumn(
                name: "DisplayId",
                table: "Goggles");

            migrationBuilder.DropColumn(
                name: "FOVId",
                table: "Goggles");

            migrationBuilder.DropColumn(
                name: "IPD",
                table: "Goggles");

            migrationBuilder.DropColumn(
                name: "Сomment",
                table: "Goggles");

            migrationBuilder.DropColumn(
                name: "MaterialId",
                table: "Fuselages");

            migrationBuilder.DropColumn(
                name: "Wingspan",
                table: "Fuselages");

            migrationBuilder.DropColumn(
                name: "Сomment",
                table: "Fuselages");

            migrationBuilder.DropColumn(
                name: "InstallDimensionMotorId",
                table: "Frames");

            migrationBuilder.DropColumn(
                name: "InstallDimensionProcId",
                table: "Frames");

            migrationBuilder.DropColumn(
                name: "MaterialId",
                table: "Frames");

            migrationBuilder.DropColumn(
                name: "Wheelbase",
                table: "Frames");

            migrationBuilder.DropColumn(
                name: "Сomment",
                table: "Frames");

            migrationBuilder.DropColumn(
                name: "Dimensions",
                table: "FlightControllers");

            migrationBuilder.DropColumn(
                name: "FirmwareId",
                table: "FlightControllers");

            migrationBuilder.DropColumn(
                name: "GyroId",
                table: "FlightControllers");

            migrationBuilder.DropColumn(
                name: "InstallDimensionId",
                table: "FlightControllers");

            migrationBuilder.DropColumn(
                name: "N_PWMOut",
                table: "FlightControllers");

            migrationBuilder.DropColumn(
                name: "N_UART",
                table: "FlightControllers");

            migrationBuilder.DropColumn(
                name: "OSD",
                table: "FlightControllers");

            migrationBuilder.DropColumn(
                name: "PDB",
                table: "FlightControllers");

            migrationBuilder.DropColumn(
                name: "SlotSD",
                table: "FlightControllers");

            migrationBuilder.DropColumn(
                name: "VoltageId",
                table: "FlightControllers");

            migrationBuilder.DropColumn(
                name: "Сomment",
                table: "FlightControllers");

            migrationBuilder.DropColumn(
                name: "BEC",
                table: "ESCs");

            migrationBuilder.DropColumn(
                name: "CurrentId",
                table: "ESCs");

            migrationBuilder.DropColumn(
                name: "DShot1200",
                table: "ESCs");

            migrationBuilder.DropColumn(
                name: "DShot150",
                table: "ESCs");

            migrationBuilder.DropColumn(
                name: "DShot300",
                table: "ESCs");

            migrationBuilder.DropColumn(
                name: "DShot600",
                table: "ESCs");

            migrationBuilder.DropColumn(
                name: "Dimensions",
                table: "ESCs");

            migrationBuilder.DropColumn(
                name: "FirmwareId",
                table: "ESCs");

            migrationBuilder.DropColumn(
                name: "InstallDimensionId",
                table: "ESCs");

            migrationBuilder.DropColumn(
                name: "Multishot",
                table: "ESCs");

            migrationBuilder.DropColumn(
                name: "Oneshot125",
                table: "ESCs");

            migrationBuilder.DropColumn(
                name: "Oneshot42",
                table: "ESCs");

            migrationBuilder.DropColumn(
                name: "PeakCurrentId",
                table: "ESCs");

            migrationBuilder.DropColumn(
                name: "ProcessorId",
                table: "ESCs");

            migrationBuilder.DropColumn(
                name: "VoltageId",
                table: "ESCs");

            migrationBuilder.DropColumn(
                name: "Сomment",
                table: "ESCs");

            migrationBuilder.DropColumn(
                name: "ChargeCurrentRange",
                table: "Chargers");

            migrationBuilder.DropColumn(
                name: "CurrentDrainBalancing",
                table: "Chargers");

            migrationBuilder.DropColumn(
                name: "Dimension",
                table: "Chargers");

            migrationBuilder.DropColumn(
                name: "DischargeCurrentRange",
                table: "Chargers");

            migrationBuilder.DropColumn(
                name: "LiPoCellCount",
                table: "Chargers");

            migrationBuilder.DropColumn(
                name: "NiCd_NiMHCellCount",
                table: "Chargers");

            migrationBuilder.DropColumn(
                name: "PbBatteryVoltageId",
                table: "Chargers");

            migrationBuilder.DropColumn(
                name: "PowerChargeId",
                table: "Chargers");

            migrationBuilder.DropColumn(
                name: "PowerDischargeId",
                table: "Chargers");

            migrationBuilder.DropColumn(
                name: "VoltageId",
                table: "Chargers");

            migrationBuilder.DropColumn(
                name: "Сomment",
                table: "Chargers");

            migrationBuilder.DropColumn(
                name: "AspectRatioId",
                table: "Cameras");

            migrationBuilder.DropColumn(
                name: "DVR",
                table: "Cameras");

            migrationBuilder.DropColumn(
                name: "Dimension",
                table: "Cameras");

            migrationBuilder.DropColumn(
                name: "FOVId",
                table: "Cameras");

            migrationBuilder.DropColumn(
                name: "HorizontalResolutionId",
                table: "Cameras");

            migrationBuilder.DropColumn(
                name: "ImageFlip",
                table: "Cameras");

            migrationBuilder.DropColumn(
                name: "ImageSensorId",
                table: "Cameras");

            migrationBuilder.DropColumn(
                name: "Mic",
                table: "Cameras");

            migrationBuilder.DropColumn(
                name: "OSD",
                table: "Cameras");

            migrationBuilder.DropColumn(
                name: "VoltageId",
                table: "Cameras");

            migrationBuilder.DropColumn(
                name: "Сomment",
                table: "Cameras");

            migrationBuilder.DropColumn(
                name: "BattaryTypeId",
                table: "Batteries");

            migrationBuilder.DropColumn(
                name: "CapacityId",
                table: "Batteries");

            migrationBuilder.DropColumn(
                name: "Dimension",
                table: "Batteries");

            migrationBuilder.DropColumn(
                name: "DischargeRateId",
                table: "Batteries");

            migrationBuilder.DropColumn(
                name: "VoltageId",
                table: "Batteries");

            migrationBuilder.DropColumn(
                name: "Сomment",
                table: "Batteries");

            migrationBuilder.DropColumn(
                name: "AntennaConnectorId",
                table: "Antennas");

            migrationBuilder.DropColumn(
                name: "FrequencyId",
                table: "Antennas");

            migrationBuilder.DropColumn(
                name: "Gain",
                table: "Antennas");

            migrationBuilder.DropColumn(
                name: "Сomment",
                table: "Antennas");

            migrationBuilder.DropColumn(
                name: "TypeId",
                table: "Accessories");

            migrationBuilder.DropColumn(
                name: "Сomment",
                table: "Accessories");
        }
    }
}
