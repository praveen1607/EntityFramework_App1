namespace Company_Models.Models
{
    public class Feedback
    {
        public int Id { get; set; }
        public int InterviewId { get; set; }
        public string Comments { get; set; }
        public string Rating { get; set; }
    }

}
