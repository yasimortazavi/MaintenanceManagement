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
        }
    }
}
