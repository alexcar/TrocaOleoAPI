using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Mappings
{
    public class CompanyMap : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.ToTable("Company");
            builder.HasKey(x => x.Id);
            
            builder.Property(x => x.Name).IsRequired().HasMaxLength(60);
            builder.Property(x => x.CommercialName).IsRequired().HasMaxLength(60);
            builder.Property(x => x.Cnpj).IsRequired();
            builder.Property(x => x.Contact).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Ddd).IsRequired().HasMaxLength(3);
            builder.Property(x => x.Phone).IsRequired().HasMaxLength(9);
            builder.Property(x => x.WebSite).IsRequired().HasMaxLength(90);
            builder.Property(x => x.Email).IsRequired().HasMaxLength(90);
            builder.Property(x => x.Address).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Neighborhood).IsRequired().HasMaxLength(50);
            builder.Property(x => x.County).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Country).IsRequired().HasMaxLength(30);
            builder.Property(x => x.UF).HasMaxLength(2);
            builder.Property(x => x.ZipCode).IsRequired().HasMaxLength(10);
            builder.Property(x => x.Active).IsRequired();

            builder.HasData
                (
                    new Company
                    {
                        Id = new Guid("c5eb9331-ae52-4c97-9f1a-eeef506f05df"),
                        Name = "Zé Gracha Ltda",
                        CommercialName = "Zé Gracha",
                        Cnpj = "05.185.409/0001-43",
                        Contact = "José da Silva",
                        Ddd = "011",
                        Phone = "984561122",
                        WebSite = "zegracha.com",
                        Email = "contato@zegracha.com",
                        Address = "Av. Central, 100",
                        Neighborhood = "Centro",
                        County = "Santa isabel",
                        Country = "Brasil",
                        UF = "SP",
                        ZipCode = "07500000",
                        Active = true,
                        UserUpdate = new Guid("5cf7137c-ae20-497d-831d-8df824697c8a"),
                        CreationDate = DateTime.Now,
                    }
                );
        }
    }
}
