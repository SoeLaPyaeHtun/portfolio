using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace pp_backend.Migrations
{
    /// <inheritdoc />
    public partial class fourthCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "VisitMe",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ip = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Device = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Browser = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    recievedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VisitMe", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VisitMe");
        }
    }
}
