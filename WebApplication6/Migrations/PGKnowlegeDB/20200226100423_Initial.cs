using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace DIMON_APP.Migrations.PGKnowlegeDB
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "dm_problem",
                columns: table => new
                {
                    pr_id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    pr_cond = table.Column<string>(maxLength: 1, nullable: true),
                    sens_id = table.Column<int>(nullable: false),
                    pr_text = table.Column<string>(maxLength: 200, nullable: true),
                    pr_color = table.Column<string>(maxLength: 1, nullable: true),
                    pr_nn = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dm_problem", x => x.pr_id);
                });

            migrationBuilder.CreateTable(
                name: "dm_reason",
                columns: table => new
                {
                    rs_id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    pr_id = table.Column<int>(nullable: false),
                    rs_text = table.Column<string>(maxLength: 200, nullable: true),
                    rs_cond = table.Column<char>(maxLength: 1, nullable: false),
                    sens_id = table.Column<int>(nullable: false),
                    nn_rs = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dm_reason", x => x.rs_id);
                    table.ForeignKey(
                        name: "FK_dm_reason_dm_problem_pr_id",
                        column: x => x.pr_id,
                        principalTable: "dm_problem",
                        principalColumn: "pr_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "dm_solution",
                columns: table => new
                {
                    sol_id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    rs_id = table.Column<int>(nullable: false),
                    sol_text = table.Column<string>(maxLength: 200, nullable: true),
                    sol_par = table.Column<string>(maxLength: 120, nullable: true),
                    sens_id = table.Column<int>(nullable: false),
                    sol_nn = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dm_solution", x => x.sol_id);
                    table.ForeignKey(
                        name: "FK_dm_solution_dm_reason_rs_id",
                        column: x => x.rs_id,
                        principalTable: "dm_reason",
                        principalColumn: "rs_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_dm_reason_pr_id",
                table: "dm_reason",
                column: "pr_id");

            migrationBuilder.CreateIndex(
                name: "IX_dm_solution_rs_id",
                table: "dm_solution",
                column: "rs_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "dm_solution");

            migrationBuilder.DropTable(
                name: "dm_reason");

            migrationBuilder.DropTable(
                name: "dm_problem");
        }
    }
}
