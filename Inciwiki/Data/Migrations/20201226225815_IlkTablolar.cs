using Microsoft.EntityFrameworkCore.Migrations;

namespace Inciwiki.Data.Migrations
{
    public partial class IlkTablolar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Icerik",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IcerikAdi = table.Column<string>(nullable: true),
                    Aciklamasi = table.Column<string>(nullable: true),
                    IcerikResmi = table.Column<string>(nullable: true),
                    Puani = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Icerik", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ihtiyac",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IhtiyacAdi = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ihtiyac", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IhtiyacIcerik",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IcerikId = table.Column<int>(nullable: false),
                    IhtiyacId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IhtiyacIcerik", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IhtiyacIcerik_Icerik_IcerikId",
                        column: x => x.IcerikId,
                        principalTable: "Icerik",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IhtiyacIcerik_Ihtiyac_IhtiyacId",
                        column: x => x.IhtiyacId,
                        principalTable: "Ihtiyac",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_IhtiyacIcerik_IcerikId",
                table: "IhtiyacIcerik",
                column: "IcerikId");

            migrationBuilder.CreateIndex(
                name: "IX_IhtiyacIcerik_IhtiyacId",
                table: "IhtiyacIcerik",
                column: "IhtiyacId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IhtiyacIcerik");

            migrationBuilder.DropTable(
                name: "Icerik");

            migrationBuilder.DropTable(
                name: "Ihtiyac");
        }
    }
}
