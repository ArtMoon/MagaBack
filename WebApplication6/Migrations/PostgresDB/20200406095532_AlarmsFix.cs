using Microsoft.EntityFrameworkCore.Migrations;

namespace DIMON_APP.Migrations.PostgresDB
{
    public partial class AlarmsFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "sens_name",
                table: "dm_alarms",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "sens_name",
                table: "dm_alarms",
                type: "integer",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 200,
                oldNullable: true);
        }
    }
}
