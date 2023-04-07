namespace AirportAPI.DTOs.AirportDTOs
{
    public record AirportToUpdateDto
    {
        public string Name { get; set; }
        public int CityId { get; set; }
    }
}
