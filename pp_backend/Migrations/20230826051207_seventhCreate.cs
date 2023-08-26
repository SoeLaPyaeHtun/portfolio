using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace pp_backend.Migrations
{
    /// <inheritdoc />
    public partial class seventhCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Browser",
                table: "HireMe");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "HireMe");

            migrationBuilder.DropColumn(
                name: "Device",
                table: "HireMe");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Browser",
                table: "HireMe",
                type: "nvarchar(50)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "HireMe",
                type: "nvarchar(50)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Device",
                table: "HireMe",
                type: "nvarchar(50)",
                nullable: false,
                defaultValue: "");
        }
    }
}
