using AirportAPI.DTOs.BookingDTOs;
using AirportAPI.Entities;

namespace AirportAPI.DTOs.TicketDTOs
{
    public record TicketByIdDto
    {
        public int Id { get; set; }
        public BookingToListDto Booking { get; set; }
        public EnumValue TicketType { get; set; }
        public int Price { get; set; }
    }
}
