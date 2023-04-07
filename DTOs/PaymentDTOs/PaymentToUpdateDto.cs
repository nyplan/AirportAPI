namespace AirportAPI.DTOs.PaymentDTOs
{
    public record PaymentToUpdateDto
    {
        public int BookingId { get; set; }
        public int Amount { get; set; }
    }
}
