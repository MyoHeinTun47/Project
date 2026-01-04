using Microsoft.Data.SqlClient;

namespace Project.Domain
{
    public class Notification : BaseDomainModel
    {
        public string? Title { get; set; }
        public string? Message { get; set; }
        public NotificationType NotificationType { get; set; }

        public int AppUserId { get; set; }
    }
    public enum NotificationType
    {
        BudgetAlert,
        GoalAchieved,
        GoalDeadlineApproaching,
        SystemNotice
    }
}
