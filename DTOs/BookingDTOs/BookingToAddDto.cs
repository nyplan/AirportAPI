using AirportAPI.Entities;

namespace AirportAPI.DTOs.BookingDTOs
{
    public record BookingToAddDto
    {
        public int FlightId { get; set; }
        public int PassengerId { get; set; }
        public int SeatNumber { get; set; }
        public DateTime? Bookingdate { get; set; } = DateTime.Now;
    }
}
