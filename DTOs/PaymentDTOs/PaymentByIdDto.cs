using AirportAPI.DTOs.BookingDTOs;

namespace AirportAPI.DTOs.PaymentDTOs
{
    public record PaymentByIdDto
    {
        public int Id { get; set; }
        public BookingToListDto Booking { get; set; }
        public DateTime PaymentDate { get; set; }
        public int Amount { get; set; }
    }
}
