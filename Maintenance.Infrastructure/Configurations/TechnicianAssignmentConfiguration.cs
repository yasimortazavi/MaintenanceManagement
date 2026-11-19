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
    public class TechnicianAssignmentConfiguration : IEntityTypeConfiguration<TechnicianAssignment>
    {
        public void Configure(EntityTypeBuilder<TechnicianAssignment> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.TechnicianId)
                .IsRequired()
                .HasMaxLength(450);

            builder.Property(x => x.Notes)
                .HasMaxLength(1000);

            builder.HasOne(x => x.MaintenanceRequest)
                .WithMany(x => x.TechnicianAssignments)
                .HasForeignKey(x => x.MaintenanceRequestId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
