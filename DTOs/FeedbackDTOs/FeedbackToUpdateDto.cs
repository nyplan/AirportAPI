namespace AirportAPI.DTOs.FeedbackDTOs
{
    public record FeedbackToUpdateDto
    {
        public int PassengerId { get; set; }
        public DateTime FeedbackDate { get; set; }
        public int RatingId { get; set; }
        public string Message { get; set; }
    }
}
