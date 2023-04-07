namespace AirportAPI.DTOs.FlightDTOs
{
    public record FlightToUpdateDto
    {
        public int OriginAirportId { get; set; }
        public int DestinationAirportId { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime ArrivalTime { get; set; }
        public int PlaneId { get; set; }
        public int PilotId { get; set; }
        public int FlightStatusId { get; set; }
    }
}
