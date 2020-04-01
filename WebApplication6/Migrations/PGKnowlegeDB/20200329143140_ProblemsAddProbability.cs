using Microsoft.EntityFrameworkCore.Migrations;

namespace DIMON_APP.Migrations.PGKnowlegeDB
{
    public partial class ProblemsAddProbability : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "rs_probability",
                table: "dm_reason",
                nullable: false,
                defaultValue: 0f);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "rs_probability",
                table: "dm_reason");
        }
    }
}
