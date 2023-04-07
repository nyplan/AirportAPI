using AirportAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace AirportAPI.CustomMigrations
{
    public static class PilotMigration
    {
        public static void Seed(ModelBuilder builder)
        {
            builder.Entity<Pilot>().HasData(
                new Pilot()
                {
                    Id = 1,
                    Firstname = "Name 1",
                    Lastname = "Surname 1",
                    Phone = 11111,
                    Email = "example1@mail.ru"
                },
                new Pilot()
                {
                    Id = 2,
                    Firstname = "Name 2",
                    Lastname = "Surname 2",
                    Phone = 22222,
                    Email = "example2@mail.ru"
                },
                new Pilot()
                {
                    Id = 3,
                    Firstname = "Name 3",
                    Lastname = "Surname 3",
                    Phone = 33333,
                    Email = "example3@mail.ru"
                });
        }
    }
}
