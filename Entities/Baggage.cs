namespace AirportAPI.Entities
{
    public class Baggage
    {
        public int Id { get; set; }
        public int BookingId { get; set; }
        public Booking Booking { get; set; }
        public double Weight { get; set; }
        public int Fee { get; set; }
        public string Description { get; set; }
    }
}
