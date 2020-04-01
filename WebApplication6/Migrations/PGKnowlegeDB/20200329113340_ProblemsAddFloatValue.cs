using Microsoft.EntityFrameworkCore.Migrations;

namespace DIMON_APP.Migrations.PGKnowlegeDB
{
    public partial class ProblemsAddFloatValue : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "rs_value",
                table: "dm_reason",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "pr_value",
                table: "dm_problem",
                nullable: false,
                defaultValue: 0f);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "rs_value",
                table: "dm_reason");

            migrationBuilder.DropColumn(
                name: "pr_value",
                table: "dm_problem");
        }
    }
}
