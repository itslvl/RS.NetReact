using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OrgType",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Deleted = table.Column<int>(type: "int", nullable: false),
                    SaveDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Display = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Definition = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrgType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Org",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Deleted = table.Column<int>(type: "int", nullable: false),
                    SaveDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SSOrganizationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SSClientID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SSClientSecret = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrgName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrgTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Org", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Org_OrgType_OrgTypeId",
                        column: x => x.OrgTypeId,
                        principalTable: "OrgType",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Org_OrgTypeId",
                table: "Org",
                column: "OrgTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Org");

            migrationBuilder.DropTable(
                name: "OrgType");
        }
    }
}
