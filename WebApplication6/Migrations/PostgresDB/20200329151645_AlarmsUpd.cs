﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace DIMON_APP.Migrations.PostgresDB
{
    public partial class AlarmsUpd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_dm_alarms_dm_apparatuses_ap_id",
                table: "dm_alarms");

            migrationBuilder.DropForeignKey(
                name: "FK_dm_alarms_dm_sensors_sens_id",
                table: "dm_alarms");

            migrationBuilder.DropIndex(
                name: "IX_dm_alarms_ap_id",
                table: "dm_alarms");

            migrationBuilder.DropIndex(
                name: "IX_dm_alarms_sens_id",
                table: "dm_alarms");

            migrationBuilder.AddColumn<int>(
                name: "apparatusap_id",
                table: "dm_alarms",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "sensorsens_id",
                table: "dm_alarms",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "sol_text",
                table: "dm_alarms",
                maxLength: 200,
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_dm_alarms_apparatusap_id",
                table: "dm_alarms",
                column: "apparatusap_id");

            migrationBuilder.CreateIndex(
                name: "IX_dm_alarms_sensorsens_id",
                table: "dm_alarms",
                column: "sensorsens_id");

            migrationBuilder.AddForeignKey(
                name: "FK_dm_alarms_dm_apparatuses_apparatusap_id",
                table: "dm_alarms",
                column: "apparatusap_id",
                principalTable: "dm_apparatuses",
                principalColumn: "ap_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_dm_alarms_dm_sensors_sensorsens_id",
                table: "dm_alarms",
                column: "sensorsens_id",
                principalTable: "dm_sensors",
                principalColumn: "sens_id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_dm_alarms_dm_apparatuses_apparatusap_id",
                table: "dm_alarms");

            migrationBuilder.DropForeignKey(
                name: "FK_dm_alarms_dm_sensors_sensorsens_id",
                table: "dm_alarms");

            migrationBuilder.DropIndex(
                name: "IX_dm_alarms_apparatusap_id",
                table: "dm_alarms");

            migrationBuilder.DropIndex(
                name: "IX_dm_alarms_sensorsens_id",
                table: "dm_alarms");

            migrationBuilder.DropColumn(
                name: "apparatusap_id",
                table: "dm_alarms");

            migrationBuilder.DropColumn(
                name: "sensorsens_id",
                table: "dm_alarms");

            migrationBuilder.DropColumn(
                name: "sol_text",
                table: "dm_alarms");

            migrationBuilder.CreateIndex(
                name: "IX_dm_alarms_ap_id",
                table: "dm_alarms",
                column: "ap_id");

            migrationBuilder.CreateIndex(
                name: "IX_dm_alarms_sens_id",
                table: "dm_alarms",
                column: "sens_id");

            migrationBuilder.AddForeignKey(
                name: "FK_dm_alarms_dm_apparatuses_ap_id",
                table: "dm_alarms",
                column: "ap_id",
                principalTable: "dm_apparatuses",
                principalColumn: "ap_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_dm_alarms_dm_sensors_sens_id",
                table: "dm_alarms",
                column: "sens_id",
                principalTable: "dm_sensors",
                principalColumn: "sens_id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
