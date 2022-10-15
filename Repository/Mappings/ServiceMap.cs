using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Mappings
{
    public class ServiceMap : IEntityTypeConfiguration<Service>
    {
        public void Configure(EntityTypeBuilder<Service> builder)
        {
            builder.ToTable("Service");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name).IsRequired().HasMaxLength(20);

            builder.HasData
                (
                new Service
                {
                    Id = new Guid("3e3d9cbd-470d-493b-9fed-fafed765b47a"),
                    Name = "Troca de Óleo",
                    Active = true,
                    CreationDate = DateTime.Now,
                    UserUpdate = new Guid("5cf7137c-ae20-497d-831d-8df824697c8a")
                });
        }
    }
}
