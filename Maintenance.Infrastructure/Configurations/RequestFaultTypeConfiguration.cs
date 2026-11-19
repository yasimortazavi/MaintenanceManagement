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
    public class RequestFaultTypeConfiguration : IEntityTypeConfiguration<RequestFaultType>
    {
        public void Configure(EntityTypeBuilder<RequestFaultType> builder)
        {
            builder.HasKey(x => new
            {
                x.MaintenanceRequestId,
                x.FaultTypeId
            });

            builder.HasOne(x => x.MaintenanceRequest)
                .WithMany(x => x.RequestFaultTypes)
                .HasForeignKey(x => x.MaintenanceRequestId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(x => x.FaultType)
                .WithMany(x => x.RequestFaultTypes)
                .HasForeignKey(x => x.FaultTypeId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
