using Microsoft.EntityFrameworkCore.Migrations;

namespace DIMON_APP.Migrations
{
    public partial class AddSensorInfoTableUpd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ParentId",
                table: "sensorInfo",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ParentId",
                table: "sensorInfo");
        }
    }
}
