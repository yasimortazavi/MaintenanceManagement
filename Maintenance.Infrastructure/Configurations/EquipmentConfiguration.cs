using Maintenance.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Maintenance.Infrastructure.Configurations
{
    public class EquipmentConfiguration : IEntityTypeConfiguration<Equipment>
    {
        public void Configure(EntityTypeBuilder<Equipment> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(150);

            builder.Property(e => e.AssetCode)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(e => e.Model)
                .HasMaxLength(100);

            builder.Property(e => e.SerialNumber)
                .HasMaxLength(100);

            builder.HasIndex(e => e.AssetCode)
                .IsUnique();

            builder.HasData(
                new Equipment
                {
                    Id = 1,
                    Name = "الکتروموتور",
                    AssetCode = "EQ-001",
                    DepartmentId = 1,
                    IsActive = true
                },
                new Equipment
                {
                    Id = 2,
                    Name = "تابلو برق",
                    AssetCode = "EQ-002",
                    DepartmentId = 1,
                    IsActive = true
                },
                new Equipment
                {
                    Id = 3,
                    Name = "پمپ صنعتی",
                    AssetCode = "EQ-003",
                    DepartmentId = 2,
                    IsActive = true
                },
                new Equipment
                {
                    Id = 4,
                    Name = "گیربکس",
                    AssetCode = "EQ-004",
                    DepartmentId = 2,
                    IsActive = true
                },
                new Equipment
                {
                    Id = 5,
                    Name = "سنسور فشار",
                    AssetCode = "EQ-005",
                    DepartmentId = 3,
                    IsActive = true
                },
                new Equipment
                {
                    Id = 6,
                    Name = "ترانسمیتر دما",
                    AssetCode = "EQ-006",
                    DepartmentId = 3,
                    IsActive = true
                }
            );
        }
    }
}
