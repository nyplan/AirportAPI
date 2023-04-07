namespace AirportAPI.Entities
{
    public class Payment
    {
        public int Id { get; set; }
        public int BookingId { get; set; }
        public Booking Booking { get; set; }
        public DateTime PaymentDate { get; set; }
        public int Amount { get; set; }
    }
}
