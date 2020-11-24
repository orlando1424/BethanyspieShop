using Microsoft.EntityFrameworkCore.Migrations;

namespace BethanysPieShop.Migrations
{
    public partial class Addressupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AdressLine1",
                table: "Orders",
                newName: "AddressLine1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AddressLine1",
                table: "Orders",
                newName: "AdressLine1");
        }
    }
}
