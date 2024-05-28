using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazerWebApp.Migrations
{
    /// <inheritdoc />
    public partial class test3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_AddressEntity_AddressId",
                table: "AspNetUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AddressEntity",
                table: "AddressEntity");

            migrationBuilder.RenameTable(
                name: "AddressEntity",
                newName: "AddressesEntities");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AddressesEntities",
                table: "AddressesEntities",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_AddressesEntities_AddressId",
                table: "AspNetUsers",
                column: "AddressId",
                principalTable: "AddressesEntities",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_AddressesEntities_AddressId",
                table: "AspNetUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AddressesEntities",
                table: "AddressesEntities");

            migrationBuilder.RenameTable(
                name: "AddressesEntities",
                newName: "AddressEntity");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AddressEntity",
                table: "AddressEntity",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_AddressEntity_AddressId",
                table: "AspNetUsers",
                column: "AddressId",
                principalTable: "AddressEntity",
                principalColumn: "Id");
        }
    }
}
