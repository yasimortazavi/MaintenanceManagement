using Maintenance.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Maintenance.Infrastructure.Configurations
{
    public class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.HasKey(d => d.Id);

            builder.Property(d => d.Name)
                .IsRequired()
                .HasMaxLength(150);

            builder.Property(d => d.Code)
                .IsRequired()
                .HasMaxLength(50);

            builder.HasIndex(d => d.Code)
                .IsUnique();

            builder.HasMany(d => d.Equipments)
                .WithOne(e => e.Department)
                .HasForeignKey(e => e.DepartmentId)
                .OnDelete(DeleteBehavior.Restrict);



                builder.HasData(
                new Department
                {
                    Id = 1,
                    Name = "واحد برق",
                    Code = "ELEC",
                    IsActive = true
                },
                new Department
                {
                    Id = 2,
                    Name = "واحد مکانیک",
                    Code = "MECH",
                    IsActive = true
                },
                new Department
                {
                    Id = 3,
                    Name = "واحد ابزار دقیق",
                    Code = "INST",
                    IsActive = true
                }
            );
        }
    }
}
