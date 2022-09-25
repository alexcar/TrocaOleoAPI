using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Repository
{
    public class RepositoryContext : DbContext
    {
        // https://learn.microsoft.com/en-us/ef/core/modeling/
        // https://learn.microsoft.com/en-us/ef/core/modeling/relationships?tabs=fluent-api%2Cfluent-api-composite-key%2Csimple-key

        public RepositoryContext(DbContextOptions<RepositoryContext> options) : base(options)
        {

        }

        public DbSet<Company>? Companies { get; set; }
        public DbSet<Infrastructure>? Infrastructures { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // modelBuilder.ApplyConfiguration(new CompanyMap());
            // base.OnModelCreating(modelBuilder);
            // modelBuilder.ApplyConfigurationsFromAssembly(typeof(CompanyMap).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        
    }
}
