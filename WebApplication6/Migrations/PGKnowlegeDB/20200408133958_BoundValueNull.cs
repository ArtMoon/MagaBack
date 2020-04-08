using Microsoft.EntityFrameworkCore.Migrations;

namespace DIMON_APP.Migrations.PGKnowlegeDB
{
    public partial class BoundValueNull : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "pr_bound_value",
                table: "dm_problem",
                nullable: true,
                oldClrType: typeof(float),
                oldType: "real");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "pr_bound_value",
                table: "dm_problem",
                type: "real",
                nullable: false,
                oldClrType: typeof(float),
                oldNullable: true);
        }
    }
}
