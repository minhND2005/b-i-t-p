using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace A1.Migrations
{
    /// <inheritdoc />
    public partial class hi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "gioHang",
                columns: table => new
                {
                    IdGH = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<int>(type: "int", nullable: true),
                    SPid = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gioHang", x => x.IdGH);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NgaySinh = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "sanPhams",
                columns: table => new
                {
                    IdSP = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SpName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    price = table.Column<float>(type: "real", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sanPhams", x => x.IdSP);
                    table.ForeignKey(
                        name: "FK_sanPhams_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "GioHangSanPhams",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdGH = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdSP = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Soluong = table.Column<int>(type: "int", nullable: true),
                    TrangThai = table.Column<int>(type: "int", nullable: true),
                    GioHangIdGH = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SanPhamIdSP = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GioHangSanPhams", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GioHangSanPhams_gioHang_GioHangIdGH",
                        column: x => x.GioHangIdGH,
                        principalTable: "gioHang",
                        principalColumn: "IdGH");
                    table.ForeignKey(
                        name: "FK_GioHangSanPhams_sanPhams_SanPhamIdSP",
                        column: x => x.SanPhamIdSP,
                        principalTable: "sanPhams",
                        principalColumn: "IdSP");
                });

            migrationBuilder.CreateIndex(
                name: "IX_GioHangSanPhams_GioHangIdGH",
                table: "GioHangSanPhams",
                column: "GioHangIdGH");

            migrationBuilder.CreateIndex(
                name: "IX_GioHangSanPhams_SanPhamIdSP",
                table: "GioHangSanPhams",
                column: "SanPhamIdSP");

            migrationBuilder.CreateIndex(
                name: "IX_sanPhams_UserId",
                table: "sanPhams",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GioHangSanPhams");

            migrationBuilder.DropTable(
                name: "gioHang");

            migrationBuilder.DropTable(
                name: "sanPhams");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
