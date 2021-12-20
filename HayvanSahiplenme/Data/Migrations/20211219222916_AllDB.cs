using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HayvanSahiplenme.Data.Migrations
{
    public partial class AllDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Ad",
                table: "AspNetUsers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Adress",
                table: "AspNetUsers",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Soyad",
                table: "AspNetUsers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TcNo",
                table: "AspNetUsers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TelNo",
                table: "AspNetUsers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

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
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ilans", x => x.IlanId);
                    table.ForeignKey(
                        name: "FK_Ilans_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ilans_Cins_CinsId",
                        column: x => x.CinsId,
                        principalTable: "Cins",
                        principalColumn: "CinsId",
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
                name: "IX_Ilans_UserId",
                table: "Ilans",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ilans");

            migrationBuilder.DropTable(
                name: "Cins");

            migrationBuilder.DropTable(
                name: "Tur");

            migrationBuilder.DropColumn(
                name: "Ad",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Adress",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Soyad",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "TcNo",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "TelNo",
                table: "AspNetUsers");
        }
    }
}
