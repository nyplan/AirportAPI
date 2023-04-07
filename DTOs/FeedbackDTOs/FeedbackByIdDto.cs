namespace AirportAPI.DTOs.FeedbackDTOs
{
    public record FeedbackByIdDto
    {
        public int Id { get; set; }
        public string Passenger { get; set; }
        public string Rating { get; set; }
        public string Message { get; set; }
        public DateTime FeedbackDate { get; set; }
    }
}
