using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HayvanSahiplenmeSitesi.Migrations
{
    public partial class baslangic : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hayvan",
                columns: table => new
                {
                    HayvanID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tur = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hayvan", x => x.HayvanID);
                });

            migrationBuilder.CreateTable(
                name: "IlanSahibi",
                columns: table => new
                {
                    IlanSahibiID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Soyad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TelNo = table.Column<int>(type: "int", nullable: false),
                    Adres = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IlanSahibi", x => x.IlanSahibiID);
                });

            migrationBuilder.CreateTable(
                name: "Cins",
                columns: table => new
                {
                    CinsID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CinsAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HayvanID1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cins", x => x.CinsID);
                    table.ForeignKey(
                        name: "FK_Cins_Hayvan_HayvanID1",
                        column: x => x.HayvanID1,
                        principalTable: "Hayvan",
                        principalColumn: "HayvanID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Ilan",
                columns: table => new
                {
                    IlanID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Yas = table.Column<int>(type: "int", nullable: false),
                    AsiDurumu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Cinsiyet = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Fotograf = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    HayvanID1 = table.Column<int>(type: "int", nullable: true),
                    CinsID1 = table.Column<int>(type: "int", nullable: true),
                    IlanSahibiID1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ilan", x => x.IlanID);
                    table.ForeignKey(
                        name: "FK_Ilan_Cins_CinsID1",
                        column: x => x.CinsID1,
                        principalTable: "Cins",
                        principalColumn: "CinsID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ilan_Hayvan_HayvanID1",
                        column: x => x.HayvanID1,
                        principalTable: "Hayvan",
                        principalColumn: "HayvanID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ilan_IlanSahibi_IlanSahibiID1",
                        column: x => x.IlanSahibiID1,
                        principalTable: "IlanSahibi",
                        principalColumn: "IlanSahibiID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cins_HayvanID1",
                table: "Cins",
                column: "HayvanID1");

            migrationBuilder.CreateIndex(
                name: "IX_Ilan_CinsID1",
                table: "Ilan",
                column: "CinsID1");

            migrationBuilder.CreateIndex(
                name: "IX_Ilan_HayvanID1",
                table: "Ilan",
                column: "HayvanID1");

            migrationBuilder.CreateIndex(
                name: "IX_Ilan_IlanSahibiID1",
                table: "Ilan",
                column: "IlanSahibiID1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ilan");

            migrationBuilder.DropTable(
                name: "Cins");

            migrationBuilder.DropTable(
                name: "IlanSahibi");

            migrationBuilder.DropTable(
                name: "Hayvan");
        }
    }
}
