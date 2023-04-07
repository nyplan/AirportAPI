using AirportAPI.Entities;

namespace AirportAPI.DTOs.AirportDTOs
{
    public record AirportToListDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
    }
}
