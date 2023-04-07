using AirportAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace AirportAPI.CustomMigrations
{
    public static class PlaneMigration
    {
        public static void Seed(ModelBuilder builder)
        {
            builder.Entity<Plane>().HasData(
                new Plane()
                {
                    Id = 1,
                    Model = "Model 1",
                    NumberOfSeats = 500
                },
                new Plane()
                {
                    Id = 2,
                    Model = "Model 2",
                    NumberOfSeats = 750
                },
                new Plane()
                {
                    Id = 3,
                    Model = "Model 3",
                    NumberOfSeats = 1000
                });
        }
    }
}
