namespace AirportAPI.Entities
{
    public class Booking
    {
        public int Id { get; set; }
        public int FlightId { get; set; }
        public Flight Flight { get; set; }
        public int PassengerId { get; set; }
        public Passenger Passenger { get; set; }
        public int SeatNumber { get; set; }
        public DateTime Bookingdate { get; set; }
    }
}
