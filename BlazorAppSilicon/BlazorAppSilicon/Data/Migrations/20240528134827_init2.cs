using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorAppSilicon.Migrations
{
    /// <inheritdoc />
    public partial class init2 : Migration
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
                newName: "addresses");

            migrationBuilder.AddPrimaryKey(
                name: "PK_addresses",
                table: "addresses",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_addresses_AddressId",
                table: "AspNetUsers",
                column: "AddressId",
                principalTable: "addresses",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_addresses_AddressId",
                table: "AspNetUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_addresses",
                table: "addresses");

            migrationBuilder.RenameTable(
                name: "addresses",
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
