using AirportAPI.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System.Diagnostics.Metrics;

namespace AirportAPI.CustomMigrations
{
    public static class CityMigration
    {
        public static void Migrate(MigrationBuilder builder)
        {
            builder.Sql("Insert into \"Cities\" (\"Name\",\"Country\") Values ('Baku', 'Azerbaijan');");
        }
        public static void Seed(ModelBuilder builder)
        {
            builder.Entity<City>().HasData(
            new City()
            {
                Id = 2,
                Name = "Washington DC",
                Country = "USA"
            },
            new City()
            {
                Id = 3,
                Name = "Paris",
                Country = "France"
            }
            );
        }
    }
}
