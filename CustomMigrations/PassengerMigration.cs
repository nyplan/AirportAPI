using AirportAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace AirportAPI.CustomMigrations
{
    public static class PassengerMigration
    {
        public static void Seed(ModelBuilder builder)
        {
            builder.Entity<Passenger>().HasData(
            new Passenger()
            {
                Id = 1,
                Fullname = "Nurlan",
                Username= "username",
                Password= "password",
                Email= "email",
                Phone = 15115,
                IsDeleted = false,
            },
            new Passenger()
            {
                Id = 2,
                Fullname = "Teymur",
                Username = "teymur",
                Password = "teymur123",
                Email = "email teymur",
                Phone = 151148485,
                IsDeleted = true,
            }
            );
        }
    }
}
