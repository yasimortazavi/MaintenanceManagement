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
    public class MaintenanceWorkLogConfiguration : IEntityTypeConfiguration<MaintenanceWorkLog>
    {
        public void Configure(EntityTypeBuilder<MaintenanceWorkLog> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.TechnicianId)
                .IsRequired()
                .HasMaxLength(450);

            builder.Property(x => x.Description)
                .IsRequired()
                .HasMaxLength(2000);

            builder.Property(x => x.DurationMinutes)
                .IsRequired(false);

            builder.HasOne(x => x.MaintenanceRequest)
                .WithMany(x => x.WorkLogs)
                .HasForeignKey(x => x.MaintenanceRequestId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
