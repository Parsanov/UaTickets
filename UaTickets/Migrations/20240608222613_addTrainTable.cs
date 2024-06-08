using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace UaTicketsAPI.Migrations
{
    /// <inheritdoc />
    public partial class addTrainTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tickets");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7477810f-86e0-4ece-9d60-3d03bc73fb8e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c886ca6c-b29b-470a-9c1d-fb6f4eaaaa47");

            migrationBuilder.CreateTable(
                name: "AirTickets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AirCompany = table.Column<string>(type: "text", nullable: false),
                    DepartureCity = table.Column<string>(type: "text", nullable: false),
                    ArrivalCity = table.Column<string>(type: "text", nullable: false),
                    DepartureDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ArrivalDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CostTickets = table.Column<decimal>(type: "numeric", nullable: false),
                    ClassSeat = table.Column<string>(type: "text", nullable: false),
                    AirCompanyUrlLogo = table.Column<string>(type: "text", nullable: false),
                    UserId = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AirTickets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TrainTickets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AirCompany = table.Column<string>(type: "text", nullable: false),
                    DepartureCity = table.Column<string>(type: "text", nullable: false),
                    ArrivalCity = table.Column<string>(type: "text", nullable: false),
                    DepartureDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ArrivalDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CostTickets = table.Column<decimal>(type: "numeric", nullable: false),
                    ClassSeat = table.Column<string>(type: "text", nullable: false),
                    AirCompanyUrlLogo = table.Column<string>(type: "text", nullable: false),
                    UserId = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainTickets", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4251cb3c-b8e2-4a5c-b8a8-2adffc49444e", null, "Admin", "ADMIN" },
                    { "9725bdfc-401d-49d0-a9d4-e780094dc83c", null, "User", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AirTickets");

            migrationBuilder.DropTable(
                name: "TrainTickets");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4251cb3c-b8e2-4a5c-b8a8-2adffc49444e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9725bdfc-401d-49d0-a9d4-e780094dc83c");

            migrationBuilder.CreateTable(
                name: "tickets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AirCompany = table.Column<string>(type: "text", nullable: false),
                    AirCompanyUrlLogo = table.Column<string>(type: "text", nullable: false),
                    ArrivalCity = table.Column<string>(type: "text", nullable: false),
                    ArrivalDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    ClassSeat = table.Column<string>(type: "text", nullable: false),
                    CostTickets = table.Column<decimal>(type: "numeric", nullable: false),
                    DepartureCity = table.Column<string>(type: "text", nullable: false),
                    DepartureDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UserId = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tickets", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "7477810f-86e0-4ece-9d60-3d03bc73fb8e", null, "User", "USER" },
                    { "c886ca6c-b29b-470a-9c1d-fb6f4eaaaa47", null, "Admin", "ADMIN" }
                });
        }
    }
}
