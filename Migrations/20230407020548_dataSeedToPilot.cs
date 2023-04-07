using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AirportAPI.Migrations
{
    /// <inheritdoc />
    public partial class dataSeedToPilot : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Pilots",
                columns: new[] { "Id", "Email", "Firstname", "Lastname", "Phone" },
                values: new object[,]
                {
                    { 1, "example1@mail.ru", "Name 1", "Surname 1", 11111 },
                    { 2, "example2@mail.ru", "Name 2", "Surname 2", 22222 },
                    { 3, "example3@mail.ru", "Name 3", "Surname 3", 33333 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Pilots",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Pilots",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Pilots",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
