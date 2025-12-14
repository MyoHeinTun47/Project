using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.Domain;
using System.Drawing;

namespace Project.Configurations.Entities
{
    public class TransactionSeed : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
            builder.HasData(
                new Transaction
                {
                    TransactionId = 1,
                    Amount = 100,
                    TransactionDate = DateTime.Now,
                    TransactionType = "dinner",
                    Description = "System"
                },
                new Transaction
                {
                    TransactionId = 2,
                    Amount = 500,
                    TransactionDate = DateTime.Now,
                    TransactionType = "lunch",
                    Description = "System"
                }
             );
        }
    } 
}
