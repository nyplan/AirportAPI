using AirportAPI.Entities;

namespace AirportAPI.DTOs.BaggageDTOs
{
    public record BaggageToAddDto
    {
        public int BookingId { get; set; }
        public double Weight { get; set; }
        public int Fee { get; set; }
        public string Description { get; set; }
    }
}
