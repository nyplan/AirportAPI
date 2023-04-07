namespace AirportAPI.Entities
{
    public class Feedback
    {
        public int Id { get; set; }
        public int PassengerId { get; set; }
        public Passenger Passenger { get; set; }
        public DateTime FeedbackDate { get; set; }
        public int RatingId { get; set; }
        public EnumValue Rating { get; set; }
        public string Message { get; set; }
    }
}
