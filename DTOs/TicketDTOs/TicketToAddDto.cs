using AirportAPI.Entities;

namespace AirportAPI.DTOs.TicketDTOs
{
    public record TicketToAddDto
    {
        public int BookingId { get; set; }
        public int TicketTypeId { get; set; }
        public int Price { get; set; }
    }
}
