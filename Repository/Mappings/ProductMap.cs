using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Mappings
{
    public class ProductMap : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Product");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Description).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Price).HasPrecision(5,2).IsRequired();

            builder.HasOne(p => p.ProductManufacturer)
                .WithMany(pm => pm.Products)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasData
                (
                    new Product
                    {
                        Id = new Guid("4fb540e6-7b18-4904-bef6-82323c423dc3"),
                        Name = "Óleo Motor 20w50 Essencial SL",
                        Description = "Óleo Lubrax 20w50",
                        Price = 62.22M,
                        Active = true,
                        CreationDate = DateTime.Now,
                        UserUpdate = new Guid("5cf7137c-ae20-497d-831d-8df824697c8a"),
                        ProductManufacturerId = new Guid("45a0fbef-bd12-4fc5-ae7a-4f99a8e8f34d")
                    },
                    new Product
                    {
                        Id = new Guid("47ee3977-ddb6-4d10-aa33-2f5d08d521eb"),
                        Name = "Óleo Lubrax 20w50 SL 3lt",
                        Description = "Óleo Lubrax 20w50",
                        Price = 149.85M,
                        Active = true,
                        CreationDate = DateTime.Now,
                        UserUpdate = new Guid("5cf7137c-ae20-497d-831d-8df824697c8a"),
                        ProductManufacturerId = new Guid("45a0fbef-bd12-4fc5-ae7a-4f99a8e8f34d")
                    },
                    new Product
                    {
                        Id = new Guid("a892244e-1ec6-4349-b11c-94c85655a820"),
                        Name = "Óleo Do Motor Lubrax Essencial",
                        Description = "Óleo Lubrax 20w50",
                        Price = 39.99M,
                        Active = true,
                        CreationDate = DateTime.Now,
                        UserUpdate = new Guid("5cf7137c-ae20-497d-831d-8df824697c8a"),
                        ProductManufacturerId = new Guid("45a0fbef-bd12-4fc5-ae7a-4f99a8e8f34d")
                    }
                );
        }
    }
}
