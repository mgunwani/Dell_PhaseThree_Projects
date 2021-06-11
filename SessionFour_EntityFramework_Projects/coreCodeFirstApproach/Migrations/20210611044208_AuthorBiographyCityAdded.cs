using Microsoft.EntityFrameworkCore.Migrations;

namespace coreCodeFirstApproach.Migrations
{
    public partial class AuthorBiographyCityAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CurrentCity",
                table: "AuthorBiographies",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CurrentCity",
                table: "AuthorBiographies");
        }
    }
}
