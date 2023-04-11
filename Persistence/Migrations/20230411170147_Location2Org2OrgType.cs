using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Location2Org2OrgType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "OrgId",
                table: "Location",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Location_OrgId",
                table: "Location",
                column: "OrgId");

            migrationBuilder.AddForeignKey(
                name: "FK_Location_Org_OrgId",
                table: "Location",
                column: "OrgId",
                principalTable: "Org",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Location_Org_OrgId",
                table: "Location");

            migrationBuilder.DropIndex(
                name: "IX_Location_OrgId",
                table: "Location");

            migrationBuilder.DropColumn(
                name: "OrgId",
                table: "Location");
        }
    }
}
