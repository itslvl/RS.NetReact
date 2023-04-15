using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class modelNSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Org_OrgType_OrgTypeId",
                table: "Org");

            migrationBuilder.RenameColumn(
                name: "OrgTypeId",
                table: "Org",
                newName: "OrgTypeID");

            migrationBuilder.RenameIndex(
                name: "IX_Org_OrgTypeId",
                table: "Org",
                newName: "IX_Org_OrgTypeID");

            migrationBuilder.AlterColumn<Guid>(
                name: "OrgTypeID",
                table: "Org",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "Parent",
                table: "Org",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

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
                name: "LocationType",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Display = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Definition = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocationType", x => x.Id);
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
                name: "Zone",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProvinceId = table.Column<int>(type: "int", nullable: false),
                    CityId = table.Column<int>(type: "int", nullable: false),
                    DistrictId = table.Column<int>(type: "int", nullable: false),
                    VillageId = table.Column<int>(type: "int", nullable: false),
                    Definition = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zone", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pendidikan2",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Deleted = table.Column<int>(type: "int", nullable: false),
                    Uraian = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ParentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pendidikan2", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pendidikan2_Pendidikan1_ParentId",
                        column: x => x.ParentId,
                        principalTable: "Pendidikan1",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Location",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Deleted = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrgId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LocationTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ZoneId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Location", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Location_LocationType_LocationTypeId",
                        column: x => x.LocationTypeId,
                        principalTable: "LocationType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Location_Org_OrgId",
                        column: x => x.OrgId,
                        principalTable: "Org",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Location_Zone_ZoneId",
                        column: x => x.ZoneId,
                        principalTable: "Zone",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pendidikan3",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Deleted = table.Column<int>(type: "int", nullable: false),
                    Uraian = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ParentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pendidikan3", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pendidikan3_Pendidikan2_ParentId",
                        column: x => x.ParentId,
                        principalTable: "Pendidikan2",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pegawai",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Deleted = table.Column<int>(type: "int", nullable: false),
                    NIP = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Nama = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    TmpLahir = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    TglLahir = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Alamat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tlp = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TlgMasuk = table.Column<DateTime>(type: "datetime2", nullable: false),
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
                    SukuId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ZoneId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pegawai", x => x.Id);
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
                name: "IX_Location_LocationTypeId",
                table: "Location",
                column: "LocationTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Location_OrgId",
                table: "Location",
                column: "OrgId");

            migrationBuilder.CreateIndex(
                name: "IX_Location_ZoneId",
                table: "Location",
                column: "ZoneId");

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
                name: "IX_Pendidikan2_ParentId",
                table: "Pendidikan2",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_Pendidikan3_ParentId",
                table: "Pendidikan3",
                column: "ParentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Org_OrgType_OrgTypeID",
                table: "Org",
                column: "OrgTypeID",
                principalTable: "OrgType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Org_OrgType_OrgTypeID",
                table: "Org");

            migrationBuilder.DropTable(
                name: "Location");

            migrationBuilder.DropTable(
                name: "Pegawai");

            migrationBuilder.DropTable(
                name: "LocationType");

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
                name: "Zone");

            migrationBuilder.DropTable(
                name: "Pendidikan2");

            migrationBuilder.DropTable(
                name: "Pendidikan1");

            migrationBuilder.DropColumn(
                name: "Parent",
                table: "Org");

            migrationBuilder.RenameColumn(
                name: "OrgTypeID",
                table: "Org",
                newName: "OrgTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Org_OrgTypeID",
                table: "Org",
                newName: "IX_Org_OrgTypeId");

            migrationBuilder.AlterColumn<Guid>(
                name: "OrgTypeId",
                table: "Org",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddForeignKey(
                name: "FK_Org_OrgType_OrgTypeId",
                table: "Org",
                column: "OrgTypeId",
                principalTable: "OrgType",
                principalColumn: "Id");
        }
    }
}
