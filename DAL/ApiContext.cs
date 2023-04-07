using AirportAPI.Controllers;
using AirportAPI.CustomMigrations;
using AirportAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace AirportAPI.DAL
{
    public class ApiContext : DbContext
    {
        public ApiContext(DbContextOptions<ApiContext> options) : base(options) { }
        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries()
                                               .Where(e => e.State == EntityState.Deleted && 
                                                e.Entity.GetType().GetProperty("IsDeleted") != null))
            {
                entry.State = EntityState.Modified;
                entry.CurrentValues["IsDeleted"] = true;
            }
            return base.SaveChanges();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            CityMigration.Seed(modelBuilder);
            EnumKeyMigration.Seed(modelBuilder);
            EnumValueMigration.Seed(modelBuilder);
            PlaneMigration.Seed(modelBuilder);
            PilotMigration.Seed(modelBuilder);

            modelBuilder.Entity<Passenger>().HasQueryFilter(p => !p.IsDeleted);

            base.OnModelCreating(modelBuilder);
        }
        public DbSet<City> Cities { get; set; }
        public DbSet<Airport> Airports { get; set; }
        public DbSet<EnumKey> EnumKeys { get; set; }
        public DbSet<EnumValue> EnumValues { get; set; }
        public DbSet<Pilot> Pilots { get; set; }
        public DbSet<Plane> Planes { get; set; }
        public DbSet<Flight> Flights { get; set; }
        public DbSet<Passenger> Passengers { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Baggage> Baggages { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }
    }
}
