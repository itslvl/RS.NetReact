using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class OrgNOrgType : Migration
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
