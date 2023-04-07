using AirportAPI.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AirportAPI.CustomMigrations
{
    public static class EnumValueMigration
    {
        public static void Seed(ModelBuilder builder)
        {
            builder.Entity<EnumValue>().HasData(
                new EnumValue()
                {
                    Id = 1,
                    KeyId = 2,
                    Value = "Economy class"
                },
                new EnumValue()
                {
                    Id = 2,
                    KeyId = 2,
                    Value = "Premium economy class"
                },
                new EnumValue()
                {
                    Id = 3,
                    KeyId = 2,
                    Value = "Business class"
                },
                new EnumValue()
                {
                    Id = 4,
                    KeyId = 2,
                    Value = "First class"
                },
                new EnumValue()
                {
                    Id = 5,
                    KeyId = 1,
                    Value = "On-time"
                },
                new EnumValue()
                {
                    Id = 6,
                    KeyId = 1,
                    Value = "Delayed"
                },
                new EnumValue()
                {
                    Id = 7,
                    KeyId = 1,
                    Value = "Cancelled"
                },
                new EnumValue()
                {
                    Id = 8,
                    KeyId = 1,
                    Value = "Diverted"
                },
                new EnumValue()
                {
                    Id = 9,
                    KeyId = 1,
                    Value = "Boarding"
                },
                new EnumValue()
                {
                    Id = 10,
                    KeyId = 1,
                    Value = "In-flight"
                },
                new EnumValue()
                {
                    Id = 11,
                    KeyId = 1,
                    Value = "Landed"
                },
                new EnumValue()
                {
                    Id = 12,
                    KeyId = 1,
                    Value = "Arrived"
                },
                new EnumValue()
                {
                    Id = 13,
                    KeyId = 1,
                    Value = "Missed"
                },
                new EnumValue()
                {
                     Id = 14,
                     KeyId = 3,
                     Value = "1 star"
                },
                new EnumValue()
                {
                    Id = 15,
                    KeyId = 3,
                    Value = "2 star"
                },
                new EnumValue()
                {
                    Id = 16,
                    KeyId = 3,
                    Value = "3 star"
                },
                new EnumValue()
                {
                    Id = 17,
                    KeyId = 3,
                    Value = "4 star"
                },
                new EnumValue()
                {
                    Id = 18,
                    KeyId = 3,
                    Value = "5 star"
                });
        }
    }
}
