using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Mappings
{
    public class ProductManufacturerMap : IEntityTypeConfiguration<ProductManufacturer>
    {
        public void Configure(EntityTypeBuilder<ProductManufacturer> builder)
        {
            builder.ToTable("ProductManufacturer");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name).IsRequired().HasMaxLength(30);

            builder.HasData
                (
                    new ProductManufacturer
                    {
                        Id = new Guid("45a0fbef-bd12-4fc5-ae7a-4f99a8e8f34d"),
                        Name = "Lubrax Petrobras",
                        Active = true,
                        CreationDate = DateTime.Now,
                        UserUpdate = new Guid("5cf7137c-ae20-497d-831d-8df824697c8a")
                    },
                    new ProductManufacturer
                    {
                        Id = new Guid("d6f0bb03-97c9-41a2-a20c-19e8fc788d72"),
                        Name = "Mobil Industrial",
                        Active = true,
                        CreationDate = DateTime.Now,
                        UserUpdate = new Guid("5cf7137c-ae20-497d-831d-8df824697c8a")
                    },
                    new ProductManufacturer
                    {
                        Id = new Guid("07ca7d2c-08f0-4848-b760-03aac0ad29f4"),
                        Name = "Shell",
                        Active = true,
                        CreationDate = DateTime.Now,
                        UserUpdate = new Guid("5cf7137c-ae20-497d-831d-8df824697c8a")
                    },
                    new ProductManufacturer
                    {
                        Id = new Guid("f7becb0d-770c-4fc2-a6e2-c7eb75069af4"),
                        Name = "Ipiranga",
                        Active = true,
                        CreationDate = DateTime.Now,
                        UserUpdate = new Guid("5cf7137c-ae20-497d-831d-8df824697c8a")
                    }
                );
        }
    }
}
