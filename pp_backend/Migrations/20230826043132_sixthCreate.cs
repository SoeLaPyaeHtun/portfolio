using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace pp_backend.Migrations
{
    /// <inheritdoc />
    public partial class sixthCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "OS",
                table: "VisitMe",
                type: "nvarchar(50)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OS",
                table: "VisitMe");
        }
    }
}
