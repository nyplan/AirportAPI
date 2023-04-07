using AirportAPI.DTOs.AirportDTOs;
using AirportAPI.Entities;

namespace AirportAPI.DTOs.FlightDTOs
{
    public record FlightToListDto
    {
        public int Id { get; set; }
        public AirportToListDto OriginAirport { get; set; }
        public AirportToListDto DestinationAirport { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime ArrivalTime { get; set; }
        public Plane Plane { get; set; }
        public Pilot Pilot { get; set; }
        public EnumValue FlightStatus { get; set; }
    }
}
