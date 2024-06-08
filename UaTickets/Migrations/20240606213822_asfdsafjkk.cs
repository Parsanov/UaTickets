using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace UaTicketsAPI.Migrations
{
    /// <inheritdoc />
    public partial class asfdsafjkk : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00a4b907-a1da-4bb9-9013-22452fa0b23e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "75abc864-d982-474b-b6a5-5fa96b1999ef");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "d935ce32-b83b-4be8-b459-39a4f67c763a", null, "Admin", "ADMIN" },
                    { "dd6a8b95-d6c9-44c0-ba3a-622788c47b23", null, "User", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "00a4b907-a1da-4bb9-9013-22452fa0b23e", null, "User", "USER" },
                    { "75abc864-d982-474b-b6a5-5fa96b1999ef", null, "Admin", "ADMIN" }
                });
        }
    }
}
