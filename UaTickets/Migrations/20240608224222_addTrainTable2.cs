using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace UaTicketsAPI.Migrations
{
    /// <inheritdoc />
    public partial class addTrainTable2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4251cb3c-b8e2-4a5c-b8a8-2adffc49444e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9725bdfc-401d-49d0-a9d4-e780094dc83c");

            migrationBuilder.RenameColumn(
                name: "AirCompanyUrlLogo",
                table: "TrainTickets",
                newName: "TrainCompanyUrlLogo");

            migrationBuilder.RenameColumn(
                name: "AirCompany",
                table: "TrainTickets",
                newName: "TrainCompany");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "67b4a3e5-d1eb-4443-a354-53b30c66841d", null, "User", "USER" },
                    { "a893da71-b148-468e-8685-22bd17f99d01", null, "Admin", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "67b4a3e5-d1eb-4443-a354-53b30c66841d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a893da71-b148-468e-8685-22bd17f99d01");

            migrationBuilder.RenameColumn(
                name: "TrainCompanyUrlLogo",
                table: "TrainTickets",
                newName: "AirCompanyUrlLogo");

            migrationBuilder.RenameColumn(
                name: "TrainCompany",
                table: "TrainTickets",
                newName: "AirCompany");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4251cb3c-b8e2-4a5c-b8a8-2adffc49444e", null, "Admin", "ADMIN" },
                    { "9725bdfc-401d-49d0-a9d4-e780094dc83c", null, "User", "USER" }
                });
        }
    }
}
