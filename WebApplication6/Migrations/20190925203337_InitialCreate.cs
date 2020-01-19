using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DIMON_APP.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Apparatus",
                columns: table => new
                {
                    Id_Ap = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    App_name = table.Column<string>(nullable: true),
                    Parent_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Apparatus", x => x.Id_Ap);
                });

            migrationBuilder.CreateTable(
                name: "Sensor_Val",
                columns: table => new
                {
                    Value_id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Sensor_name = table.Column<string>(nullable: true),
                    Sensor_value = table.Column<float>(nullable: false),
                    Parent_id = table.Column<int>(nullable: false),
                    Date_time = table.Column<DateTime>(nullable: true),
                    Id_sensor = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sensor_Val", x => x.Value_id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    Last_name = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Apparatus");

            migrationBuilder.DropTable(
                name: "Sensor_Val");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
