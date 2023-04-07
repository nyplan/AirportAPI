using AirportAPI.DTOs.BookingDTOs;
using AirportAPI.Entities;

namespace AirportAPI.DTOs.PaymentDTOs
{
    public record PaymentToListDto
    {
        public int Id { get; set; }
        public BookingToListDto Booking { get; set; }
        public DateTime PaymentDate { get; set; }
        public int Amount { get; set; }
    }
}
