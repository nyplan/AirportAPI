using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AirportAPI.Migrations
{
    /// <inheritdoc />
    public partial class dataSeedEnumValue : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "EnumValues",
                columns: new[] { "Id", "KeyId", "Value" },
                values: new object[,]
                {
                    { 1, 2, "Economy class" },
                    { 2, 2, "Premium economy class" },
                    { 3, 2, "Business class" },
                    { 4, 2, "First class" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EnumValues",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "EnumValues",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "EnumValues",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "EnumValues",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
