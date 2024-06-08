using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace UaTicketsAPI.Migrations
{
    /// <inheritdoc />
    public partial class asfdsafjkkлщь : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d935ce32-b83b-4be8-b459-39a4f67c763a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dd6a8b95-d6c9-44c0-ba3a-622788c47b23");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "7477810f-86e0-4ece-9d60-3d03bc73fb8e", null, "User", "USER" },
                    { "c886ca6c-b29b-470a-9c1d-fb6f4eaaaa47", null, "Admin", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7477810f-86e0-4ece-9d60-3d03bc73fb8e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c886ca6c-b29b-470a-9c1d-fb6f4eaaaa47");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "d935ce32-b83b-4be8-b459-39a4f67c763a", null, "Admin", "ADMIN" },
                    { "dd6a8b95-d6c9-44c0-ba3a-622788c47b23", null, "User", "USER" }
                });
        }
    }
}
