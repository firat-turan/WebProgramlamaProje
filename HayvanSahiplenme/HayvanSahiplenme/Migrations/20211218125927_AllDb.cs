using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HayvanSahiplenme.Migrations
{
    public partial class AllDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kullanici",
                columns: table => new
                {
                    KullaniciId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Soyad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TcNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TelNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Adress = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kullanici", x => x.KullaniciId);
                });

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

            migrationBuilder.CreateTable(
                name: "Cins",
                columns: table => new
                {
                    CinsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CinsAd = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CinsAdIng = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TurId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cins", x => x.CinsId);
                    table.ForeignKey(
                        name: "FK_Cins_Tur_TurId",
                        column: x => x.TurId,
                        principalTable: "Tur",
                        principalColumn: "TurId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ilans",
                columns: table => new
                {
                    IlanId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    İlanBaslik = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    İlanBaslikIng = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    HayvanAd = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CinsId = table.Column<int>(type: "int", nullable: false),
                    Cinsiyet = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CinsiyetIng = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Yas = table.Column<int>(type: "int", nullable: false),
                    AsiDurumu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AsiDurumuIng = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Aciklama = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    AciklamaIng = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Fotograf = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    KullaniciId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ilans", x => x.IlanId);
                    table.ForeignKey(
                        name: "FK_Ilans_Cins_CinsId",
                        column: x => x.CinsId,
                        principalTable: "Cins",
                        principalColumn: "CinsId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ilans_Kullanici_KullaniciId",
                        column: x => x.KullaniciId,
                        principalTable: "Kullanici",
                        principalColumn: "KullaniciId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cins_TurId",
                table: "Cins",
                column: "TurId");

            migrationBuilder.CreateIndex(
                name: "IX_Ilans_CinsId",
                table: "Ilans",
                column: "CinsId");

            migrationBuilder.CreateIndex(
                name: "IX_Ilans_KullaniciId",
                table: "Ilans",
                column: "KullaniciId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ilans");

            migrationBuilder.DropTable(
                name: "Cins");

            migrationBuilder.DropTable(
                name: "Kullanici");

            migrationBuilder.DropTable(
                name: "Tur");
        }
    }
}
