using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UaTicketsAPI.Migrations
{
    /// <inheritdoc />
    public partial class UrlLogo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AirCompanyUrlLogo",
                table: "tickets",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AirCompanyUrlLogo",
                table: "tickets");
        }
    }
}
