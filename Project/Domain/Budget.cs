namespace Project.Domain
{
    public class Budget : BaseDomainModel
    {
        public double BudgetAmount { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public BudgetPeriod Period { get; set; }
        public string RuleName { get; set; } = "50/30/20"; // or "Custom"
        public decimal NeedsPercentage { get; set; } = 50;
        public decimal WantsPercentage { get; set; } = 30;
        public decimal SavingsPercentage { get; set; } = 20;
        public int AppUserId { get; set; }
        public int CategoryId  { get; set; }
    }

    public enum BudgetPeriod
    {
        Weekly,
        Monthly,
        Yearly
    }
}
