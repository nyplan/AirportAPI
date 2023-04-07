using AirportAPI.Entities;

namespace AirportAPI.DTOs.AirportDTOs
{
    public record AirportToAddDto
    {
        public string Name { get; set; }
        public int CityId { get; set; }
    }
}
