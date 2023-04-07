using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AirportAPI.Migrations
{
    /// <inheritdoc />
    public partial class dataSeedEnumKey1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "EnumKeys",
                columns: new[] { "Id", "Key" },
                values: new object[] { 3, "Rating" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EnumKeys",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
