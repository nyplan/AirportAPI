using AirportAPI.CustomMigrations;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AirportAPI.Migrations
{
    /// <inheritdoc />
    public partial class CustomDataSeedToCity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            CityMigration.Migrate(migrationBuilder);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
