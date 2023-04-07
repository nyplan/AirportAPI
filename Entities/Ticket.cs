namespace AirportAPI.Entities
{
    public class Ticket
    {
        public int Id { get; set; }
        public int BookingId { get; set; }
        public Booking Booking { get; set; }
        public int TicketTypeId { get; set; }
        public EnumValue TicketType { get; set; }
        public int Price { get; set; }
    }
}
