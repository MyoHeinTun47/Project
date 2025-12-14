using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Project.Configurations.Entities;
using Project.Data;

namespace Project.Data
{
    public class IdentityContext(DbContextOptions<IdentityContext> options) : IdentityDbContext<ProjectUser>(options)
    {
        public DbSet<Project.Domain.Transaction> Transaction { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new TransactionSeed());
        }
    }
}
