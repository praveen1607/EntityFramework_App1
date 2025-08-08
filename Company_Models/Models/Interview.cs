namespace Company_Models.Models
{
    public class Interview
    {
        public int Id { get; set; }
        public int JobApplicationId { get; set; }
        public DateTime ScheduledOn { get; set; }
        public string Interviewer { get; set; }
    }

}
