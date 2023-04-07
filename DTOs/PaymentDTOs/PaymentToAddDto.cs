using AirportAPI.DTOs.BookingDTOs;
using AirportAPI.Entities;

namespace AirportAPI.DTOs.PaymentDTOs
{
    public record PaymentToAddDto
    {
        public int BookingId { get; set; }
        public int Amount { get; set; }
    }
}
