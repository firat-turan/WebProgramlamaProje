using Microsoft.EntityFrameworkCore.Migrations;

namespace HayvanSahiplenme.Migrations
{
    public partial class TurDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tur",
                columns: table => new
                {
                    TurId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TurAd = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TurAdIng = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tur", x => x.TurId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tur");
        }
    }
}
