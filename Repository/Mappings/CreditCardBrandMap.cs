using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Mappings
{
    public class CreditCardBrandMap : IEntityTypeConfiguration<CreditCardBrand>
    {
        public void Configure(EntityTypeBuilder<CreditCardBrand> builder)
        {
            builder.ToTable("CreditCardBrand");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name).IsRequired().HasMaxLength(20);

            builder.HasData
                (
                    new CreditCardBrand
                    {
                        Id = new Guid("c32b3780-5c90-4990-896f-502a478f9a22"),
                        Name = "Mastercard",
                        Active = true,
                        CreationDate = DateTime.Now,
                        UserUpdate = new Guid("5cf7137c-ae20-497d-831d-8df824697c8a")
                    },
                    new CreditCardBrand
                    {
                        Id = new Guid("9f780c05-7252-485d-8cf6-9279272e1086"),
                        Name = "Visa",
                        Active = true,
                        CreationDate = DateTime.Now,
                        UserUpdate = new Guid("5cf7137c-ae20-497d-831d-8df824697c8a")
                    }
                );
        }
    }
}
