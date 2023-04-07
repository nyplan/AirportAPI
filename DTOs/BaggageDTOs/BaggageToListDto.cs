using AirportAPI.Entities;

namespace AirportAPI.DTOs.BaggageDTOs
{
    public record BaggageToListDto
    {
        public int Id { get; set; }
        public string Passenger { get; set; }
        public double Weight { get; set; }
        public int Fee { get; set; }
        public string Description { get; set; }
    }
}
