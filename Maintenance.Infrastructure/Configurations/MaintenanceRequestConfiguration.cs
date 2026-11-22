using Maintenance.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maintenance.Infrastructure.Configurations
{
    public class MaintenanceRequestConfiguration : IEntityTypeConfiguration<MaintenanceRequest>
    {
        public void Configure(EntityTypeBuilder<MaintenanceRequest> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.TrackingCode)
                .IsRequired()
                .HasMaxLength(50);

            builder.HasIndex(x => x.TrackingCode)
                .IsUnique();

            builder.Property(x => x.Location)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(x => x.Description)
                .IsRequired()
                .HasMaxLength(2000);

            builder.Property(x => x.AdditionalNotes)
                .HasMaxLength(1000);

            builder.HasOne(x => x.Equipment)
                .WithMany(x => x.MaintenanceRequests)
                .HasForeignKey(x => x.EquipmentId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.Department)
                .WithMany(x => x.MaintenanceRequests)
                .HasForeignKey(x => x.DepartmentId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Property(x => x.RequesterId)
                .IsRequired()
                .HasMaxLength(450);
        }
    }
}
