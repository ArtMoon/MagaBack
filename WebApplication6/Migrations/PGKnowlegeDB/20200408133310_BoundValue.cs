using Microsoft.EntityFrameworkCore.Migrations;

namespace DIMON_APP.Migrations.PGKnowlegeDB
{
    public partial class BoundValue : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "rs_cond",
                table: "dm_reason",
                maxLength: 1,
                nullable: true,
                oldClrType: typeof(char),
                oldType: "character(1)",
                oldMaxLength: 1);

            migrationBuilder.AlterColumn<string>(
                name: "pr_cond",
                table: "dm_problem",
                maxLength: 2,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(1)",
                oldMaxLength: 1,
                oldNullable: true);

            migrationBuilder.AddColumn<float>(
                name: "pr_bound_value",
                table: "dm_problem",
                nullable: false,
                defaultValue: 0f);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "pr_bound_value",
                table: "dm_problem");

            migrationBuilder.AlterColumn<char>(
                name: "rs_cond",
                table: "dm_reason",
                type: "character(1)",
                maxLength: 1,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 1,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "pr_cond",
                table: "dm_problem",
                type: "character varying(1)",
                maxLength: 1,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 2,
                oldNullable: true);
        }
    }
}
