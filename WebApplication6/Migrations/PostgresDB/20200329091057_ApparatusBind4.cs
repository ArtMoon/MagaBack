using Microsoft.EntityFrameworkCore.Migrations;

namespace DIMON_APP.Migrations.PostgresDB
{
    public partial class ApparatusBind4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ap_id",
                table: "dm_alarms",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_dm_alarms_ap_id",
                table: "dm_alarms",
                column: "ap_id");

            migrationBuilder.AddForeignKey(
                name: "FK_dm_alarms_dm_apparatuses_ap_id",
                table: "dm_alarms",
                column: "ap_id",
                principalTable: "dm_apparatuses",
                principalColumn: "ap_id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_dm_alarms_dm_apparatuses_ap_id",
                table: "dm_alarms");

            migrationBuilder.DropIndex(
                name: "IX_dm_alarms_ap_id",
                table: "dm_alarms");

            migrationBuilder.DropColumn(
                name: "ap_id",
                table: "dm_alarms");
        }
    }
}
