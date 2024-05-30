using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace progpoe.Data.Migrations
{
    /// <inheritdoc />
    public partial class famerUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FarmerAge",
                table: "Farmer");

            migrationBuilder.DropColumn(
                name: "FarmerCellNo",
                table: "Farmer");

            migrationBuilder.DropColumn(
                name: "FarmerName",
                table: "Farmer");

            migrationBuilder.DropColumn(
                name: "FarmerSurname",
                table: "Farmer");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FarmerAge",
                table: "Farmer",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FarmerCellNo",
                table: "Farmer",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "FarmerName",
                table: "Farmer",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FarmerSurname",
                table: "Farmer",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
