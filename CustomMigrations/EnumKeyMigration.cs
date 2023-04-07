using AirportAPI.Entities;
using AirportAPI.Migrations;
using Microsoft.EntityFrameworkCore;

namespace AirportAPI.CustomMigrations
{
    public static class EnumKeyMigration
    {
        public static void Seed(ModelBuilder builder)
        {
            builder.Entity<EnumKey>().HasData(
            new EnumKey()
            {
                Id = 1,
                Key = "FlightStatus"
            },
            new EnumKey()
            {
                Id = 2,
                Key = "TicketType"
            },
            new EnumKey()
            {
                Id = 3,
                Key = "Rating"
            });
        }
    }
}
