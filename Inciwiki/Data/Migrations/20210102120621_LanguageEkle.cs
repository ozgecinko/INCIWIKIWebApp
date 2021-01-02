using Microsoft.EntityFrameworkCore.Migrations;

namespace Inciwiki.Data.Migrations
{
    public partial class LanguageEkle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Language",
                table: "Icerik",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Language",
                table: "Icerik");
        }
    }
}
