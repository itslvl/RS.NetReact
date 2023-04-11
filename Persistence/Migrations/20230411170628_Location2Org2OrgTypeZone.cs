using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Location2Org2OrgTypeZone : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "ZoneId",
                table: "Location",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Location_ZoneId",
                table: "Location",
                column: "ZoneId");

            migrationBuilder.AddForeignKey(
                name: "FK_Location_Zone_ZoneId",
                table: "Location",
                column: "ZoneId",
                principalTable: "Zone",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Location_Zone_ZoneId",
                table: "Location");

            migrationBuilder.DropIndex(
                name: "IX_Location_ZoneId",
                table: "Location");

            migrationBuilder.DropColumn(
                name: "ZoneId",
                table: "Location");
        }
    }
}
