namespace AirportAPI.DTOs.BaggageDTOs
{
    public record BaggageToUpdateDto
    {
        public int BookingId { get; set; }
        public double Weight { get; set; }
        public int Fee { get; set; }
        public string Description { get; set; }
    }
}
