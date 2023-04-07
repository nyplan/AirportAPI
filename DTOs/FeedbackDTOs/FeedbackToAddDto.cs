namespace AirportAPI.DTOs.FeedbackDTOs
{
    public record FeedbackToAddDto
    {
        public int PassengerId { get; set; }
        public DateTime FeedbackDate { get; set; }
        public int RatingId { get; set; }
        public string Message { get; set; }
    }
}
