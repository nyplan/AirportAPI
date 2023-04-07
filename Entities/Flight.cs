namespace AirportAPI.Entities
{
    public class Flight
    {
        public int Id { get; set; }
        public int OriginAirportId { get; set; }
        public Airport OriginAirport { get; set; }
        public int DestinationAirportId { get; set; }
        public Airport DestinationAirport { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime ArrivalTime { get; set; }
        public int PlaneId { get; set; }
        public Plane Plane { get; set; }
        public int PilotId { get; set; }
        public Pilot Pilot { get; set; }
        public int FlightStatusId { get; set; }
        public EnumValue FlightStatus { get; set; }

    }
}
