using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityFrameworkCoreGuideProject.Migrations
{
    public partial class StudentModelAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Academic");

            migrationBuilder.CreateTable(
                name: "StudentMaster",
                schema: "Academic",
                columns: table => new
                {
                    StudentKey = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DoB = table.Column<DateTime>(type: "DateTime2", nullable: false),
                    StudentAge = table.Column<int>(type: "int", nullable: false),
                    CurrentCity = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentMaster", x => x.StudentKey);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentMaster",
                schema: "Academic");
        }
    }
}
