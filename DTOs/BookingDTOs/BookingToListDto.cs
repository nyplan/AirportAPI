using AirportAPI.DTOs.FlightDTOs;
using AirportAPI.DTOs.PassengerDTOs;
using AirportAPI.Entities;

namespace AirportAPI.DTOs.BookingDTOs
{
    public record BookingToListDto
    {
        public int Id { get; set; }
        public FlightToListDto Flight { get; set; }
        public PassengerToListDto Passenger { get; set; }
        public int SeatNumber { get; set; }
        public DateTime Bookingdate { get; set; }
    }
}
