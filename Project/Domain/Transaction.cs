using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project.Domain
{
    public class Transaction : BaseDomainModel
    {
        public decimal Amount { get; set; }

        public DateTime TransactionDate { get; set; }

        public string TransactionType { get; set; } = string.Empty;
        public string? Description { get; set; }
        public int AppUserId { get; set; }
        public int CategoryId { get; set; }
    }
}
