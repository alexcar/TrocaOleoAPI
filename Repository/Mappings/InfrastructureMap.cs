using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Mappings
{
    public class InfrastructureMap : IEntityTypeConfiguration<Infrastructure>
    {
        public void Configure(EntityTypeBuilder<Infrastructure> builder)
        {
            builder.ToTable("Infrastructure");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name).IsRequired().HasMaxLength(60);
            builder.Property(x => x.Active).IsRequired();

            //builder
            //    .HasOne(i => i.Company)
            //    .WithMany(c => c.Infrastructures)
            //    .OnDelete(DeleteBehavior.NoAction);

            builder
                .HasMany(i => i.Companies)
                .WithMany(c => c.Infrastructures)
                .UsingEntity(j => j.ToTable("InfrastructureCompany"));

            builder.HasData
                (
                    new Infrastructure
                    {
                        Id = new Guid("884bc531-f0e6-463b-aa9f-f0ac9d8b521a"),
                        Name = "Ar condicionado",
                        Active = true,
                        UserUpdate = new Guid("5cf7137c-ae20-497d-831d-8df824697c8a"),
                        CreationDate = DateTime.Now
                    },
                    new Infrastructure
                    {
                        Id = new Guid("3b90f7bc-2bb1-455f-a46e-2fdffbdd0167"),
                        Name = "Sala de espera",
                        Active = true,
                        UserUpdate = new Guid("5cf7137c-ae20-497d-831d-8df824697c8a"),
                        CreationDate = DateTime.Now
                    },
                    new Infrastructure
                    {
                        Id = new Guid("05dd35ae-c60d-4349-98b1-ba990fed57d5"),
                        Name = "Área para fumante",
                        Active = true,
                        UserUpdate = new Guid("5cf7137c-ae20-497d-831d-8df824697c8a"),
                        CreationDate = DateTime.Now
                    }
                );
        }
    }
}
