using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Repository
{
    public class RepositoryContext : DbContext
    {
        // https://learn.microsoft.com/en-us/ef/core/modeling/
        // https://learn.microsoft.com/en-us/ef/core/modeling/relationships?tabs=fluent-api%2Cfluent-api-composite-key%2Csimple-key
        // https://learn.microsoft.com/en-us/ef/core/modeling/relationships?tabs=fluent-api%2Cfluent-api-simple-key%2Csimple-key

        public RepositoryContext(DbContextOptions<RepositoryContext> options) : base(options)
        {

        }

        public DbSet<Company>? Companies { get; set; }
        public DbSet<Infrastructure>? Infrastructures { get; set; }
        public DbSet<CreditCardBrand>? CreditCardBrands { get; set; }        
        public DbSet<Product>? Products { get; set; }
        public DbSet<ProductManufacturer>? ProductManufacturers { get; set; }
        public DbSet<Service>? Services { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // modelBuilder.ApplyConfiguration(new CompanyMap());
            // base.OnModelCreating(modelBuilder);
            // modelBuilder.ApplyConfigurationsFromAssembly(typeof(CompanyMap).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            foreach(var entityType in modelBuilder.Model.GetEntityTypes())
            {
                entityType.GetForeignKeys()
                    .Where(fk => !fk.IsOwnership && fk.DeleteBehavior == DeleteBehavior.Cascade)
                    .ToList()
                    .ForEach(fk => fk.DeleteBehavior = DeleteBehavior.NoAction);
            }
        }               
    }
}
