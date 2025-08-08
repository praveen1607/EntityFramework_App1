namespace Company_Models.Models
{
    public class JobApplication
    {
        public int Id { get; set; }
        public int CandidateId { get; set; }
        public int JobId { get; set; }
        public DateTime AppliedOn { get; set; }
        public string Status { get; set; }
    }

}
