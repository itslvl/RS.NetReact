using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Pegawaidll : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Agama",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Deleted = table.Column<int>(type: "int", nullable: false),
                    Uraian = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agama", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Bahasa",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Deleted = table.Column<int>(type: "int", nullable: false),
                    Uraian = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bahasa", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Gender",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Deleted = table.Column<int>(type: "int", nullable: false),
                    Uraian = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gender", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Golongan",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Deleted = table.Column<int>(type: "int", nullable: false),
                    UraianGolongan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UraianPangkat = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Golongan", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Jabatan",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Deleted = table.Column<int>(type: "int", nullable: false),
                    Uraian = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jabatan", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Negara",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Deleted = table.Column<int>(type: "int", nullable: false),
                    Uraian = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Negara", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pendidikan",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Deleted = table.Column<int>(type: "int", nullable: false),
                    Uraian = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pendidikan", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pendidikan1",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Deleted = table.Column<int>(type: "int", nullable: false),
                    Uraian = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pendidikan1", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Perkawinan",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Deleted = table.Column<int>(type: "int", nullable: false),
                    Uraian = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Perkawinan", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Suku",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Deleted = table.Column<int>(type: "int", nullable: false),
                    Uraian = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suku", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pendidikan2",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Deleted = table.Column<int>(type: "int", nullable: false),
                    Uraian = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ParentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Pendidikan2Ke1Id = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pendidikan2", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pendidikan2_Pendidikan1_Pendidikan2Ke1Id",
                        column: x => x.Pendidikan2Ke1Id,
                        principalTable: "Pendidikan1",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Pendidikan3",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Deleted = table.Column<int>(type: "int", nullable: false),
                    Uraian = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ParentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Pendidikan3Ke2Id = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pendidikan3", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pendidikan3_Pendidikan2_Pendidikan3Ke2Id",
                        column: x => x.Pendidikan3Ke2Id,
                        principalTable: "Pendidikan2",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Pegawai",
                columns: table => new
                {
                    Kode = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Deleted = table.Column<int>(type: "int", nullable: false),
                    NIP = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    PlaceOfBirth = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    TglLahir = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Alamat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ZoneId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    EntryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PictFile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsFakasi = table.Column<int>(type: "int", nullable: false),
                    LeaderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AgamaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BahasaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GenderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GolonganId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    JabatanId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NegaraId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PendidikanId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Pendidikan3Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PerkawinanId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SukuId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pegawai", x => x.Kode);
                    table.ForeignKey(
                        name: "FK_Pegawai_Agama_AgamaId",
                        column: x => x.AgamaId,
                        principalTable: "Agama",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pegawai_Bahasa_BahasaId",
                        column: x => x.BahasaId,
                        principalTable: "Bahasa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pegawai_Gender_GenderId",
                        column: x => x.GenderId,
                        principalTable: "Gender",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pegawai_Golongan_GolonganId",
                        column: x => x.GolonganId,
                        principalTable: "Golongan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pegawai_Jabatan_JabatanId",
                        column: x => x.JabatanId,
                        principalTable: "Jabatan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pegawai_Negara_NegaraId",
                        column: x => x.NegaraId,
                        principalTable: "Negara",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pegawai_Pendidikan3_Pendidikan3Id",
                        column: x => x.Pendidikan3Id,
                        principalTable: "Pendidikan3",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pegawai_Pendidikan_PendidikanId",
                        column: x => x.PendidikanId,
                        principalTable: "Pendidikan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pegawai_Perkawinan_PerkawinanId",
                        column: x => x.PerkawinanId,
                        principalTable: "Perkawinan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pegawai_Suku_SukuId",
                        column: x => x.SukuId,
                        principalTable: "Suku",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pegawai_Zone_ZoneId",
                        column: x => x.ZoneId,
                        principalTable: "Zone",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pegawai_AgamaId",
                table: "Pegawai",
                column: "AgamaId");

            migrationBuilder.CreateIndex(
                name: "IX_Pegawai_BahasaId",
                table: "Pegawai",
                column: "BahasaId");

            migrationBuilder.CreateIndex(
                name: "IX_Pegawai_GenderId",
                table: "Pegawai",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_Pegawai_GolonganId",
                table: "Pegawai",
                column: "GolonganId");

            migrationBuilder.CreateIndex(
                name: "IX_Pegawai_JabatanId",
                table: "Pegawai",
                column: "JabatanId");

            migrationBuilder.CreateIndex(
                name: "IX_Pegawai_NegaraId",
                table: "Pegawai",
                column: "NegaraId");

            migrationBuilder.CreateIndex(
                name: "IX_Pegawai_Pendidikan3Id",
                table: "Pegawai",
                column: "Pendidikan3Id");

            migrationBuilder.CreateIndex(
                name: "IX_Pegawai_PendidikanId",
                table: "Pegawai",
                column: "PendidikanId");

            migrationBuilder.CreateIndex(
                name: "IX_Pegawai_PerkawinanId",
                table: "Pegawai",
                column: "PerkawinanId");

            migrationBuilder.CreateIndex(
                name: "IX_Pegawai_SukuId",
                table: "Pegawai",
                column: "SukuId");

            migrationBuilder.CreateIndex(
                name: "IX_Pegawai_ZoneId",
                table: "Pegawai",
                column: "ZoneId");

            migrationBuilder.CreateIndex(
                name: "IX_Pendidikan2_Pendidikan2Ke1Id",
                table: "Pendidikan2",
                column: "Pendidikan2Ke1Id");

            migrationBuilder.CreateIndex(
                name: "IX_Pendidikan3_Pendidikan3Ke2Id",
                table: "Pendidikan3",
                column: "Pendidikan3Ke2Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pegawai");

            migrationBuilder.DropTable(
                name: "Agama");

            migrationBuilder.DropTable(
                name: "Bahasa");

            migrationBuilder.DropTable(
                name: "Gender");

            migrationBuilder.DropTable(
                name: "Golongan");

            migrationBuilder.DropTable(
                name: "Jabatan");

            migrationBuilder.DropTable(
                name: "Negara");

            migrationBuilder.DropTable(
                name: "Pendidikan3");

            migrationBuilder.DropTable(
                name: "Pendidikan");

            migrationBuilder.DropTable(
                name: "Perkawinan");

            migrationBuilder.DropTable(
                name: "Suku");

            migrationBuilder.DropTable(
                name: "Pendidikan2");

            migrationBuilder.DropTable(
                name: "Pendidikan1");
        }
    }
}
