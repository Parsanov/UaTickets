using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace UaTicketsAPI.Migrations
{
    /// <inheritdoc />
    public partial class _2342342113 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tickets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AirCompany = table.Column<string>(type: "text", nullable: false),
                    DepartureCity = table.Column<string>(type: "text", nullable: false),
                    ArrivalCity = table.Column<string>(type: "text", nullable: true),
                    DepartureDate = table.Column<string>(type: "text", nullable: false),
                    ArrivalDate = table.Column<string>(type: "text", nullable: false),
                    CostTickets = table.Column<decimal>(type: "numeric", nullable: false),
                    ClassSeat = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tickets", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tickets");
        }
    }
}
