using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DIMON_APP.Migrations.PostgresDB
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "dm_apparatus_info",
                columns: table => new
                {
                    ap_id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    description = table.Column<string>(nullable: true),
                    launch_date = table.Column<DateTime>(nullable: false),
                    power = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dm_apparatus_info", x => x.ap_id);
                });

            migrationBuilder.CreateTable(
                name: "dm_apparatuses",
                columns: table => new
                {
                    ap_id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    parent_ap_id = table.Column<int>(nullable: false),
                    short_name = table.Column<string>(nullable: true),
                    full_name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dm_apparatuses", x => x.ap_id);
                });

            migrationBuilder.CreateTable(
                name: "dm_sensor_vals",
                columns: table => new
                {
                    val_id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    sens_id = table.Column<int>(nullable: false),
                    val_date = table.Column<DateTime>(nullable: false),
                    val = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dm_sensor_vals", x => x.val_id);
                });

            migrationBuilder.CreateTable(
                name: "dm_sensors",
                columns: table => new
                {
                    sens_id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    sens_name = table.Column<string>(nullable: true),
                    description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dm_sensors", x => x.sens_id);
                });

            migrationBuilder.CreateTable(
                name: "dm_users",
                columns: table => new
                {
                    user_id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(nullable: true),
                    last_name = table.Column<string>(nullable: true),
                    password = table.Column<string>(nullable: true),
                    email = table.Column<string>(nullable: true),
                    table_num = table.Column<int>(nullable: false),
                    photo_url = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dm_users", x => x.user_id);
                });

            migrationBuilder.CreateTable(
                name: "dm_apparatus_2_sens_link",
                columns: table => new
                {
                    rec_id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    sens_id = table.Column<int>(nullable: false),
                    ap_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dm_apparatus_2_sens_link", x => x.rec_id);
                    table.ForeignKey(
                        name: "FK_dm_apparatus_2_sens_link_dm_apparatuses_ap_id",
                        column: x => x.ap_id,
                        principalTable: "dm_apparatuses",
                        principalColumn: "ap_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_dm_apparatus_2_sens_link_dm_sensors_sens_id",
                        column: x => x.sens_id,
                        principalTable: "dm_sensors",
                        principalColumn: "sens_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_dm_apparatus_2_sens_link_ap_id",
                table: "dm_apparatus_2_sens_link",
                column: "ap_id");

            migrationBuilder.CreateIndex(
                name: "IX_dm_apparatus_2_sens_link_sens_id",
                table: "dm_apparatus_2_sens_link",
                column: "sens_id",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "dm_apparatus_2_sens_link");

            migrationBuilder.DropTable(
                name: "dm_apparatus_info");

            migrationBuilder.DropTable(
                name: "dm_sensor_vals");

            migrationBuilder.DropTable(
                name: "dm_users");

            migrationBuilder.DropTable(
                name: "dm_apparatuses");

            migrationBuilder.DropTable(
                name: "dm_sensors");
        }
    }
}
