namespace Project.Domain
{
    public class Goal : BaseDomainModel
    {
        public string? GoalName { get; set; }
        public decimal TargetAmount { get; set; }
        public decimal CurrentAmount { get; set; }
        public DateTime TargetDate { get; set; }
        public string? Status { get; set; }
        public int AppUserId { get; set; }

    }
    public enum GoalStatus
    {
        Active,
        Completed,
        Cancelled
    }
}
