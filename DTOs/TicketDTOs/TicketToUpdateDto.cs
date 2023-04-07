namespace AirportAPI.DTOs.TicketDTOs
{
    public record TicketToUpdateDto
    {
        public int BookingId { get; set; }
        public int TicketTypeId { get; set; }
        public int Price { get; set; }
    }
}
