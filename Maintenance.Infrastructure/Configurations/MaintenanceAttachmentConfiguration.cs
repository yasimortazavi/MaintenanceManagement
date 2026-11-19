using Maintenance.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Maintenance.Infrastructure.Configurations
{
    public class MaintenanceAttachmentConfiguration : IEntityTypeConfiguration<MaintenanceAttachment>
    {
        public void Configure(EntityTypeBuilder<MaintenanceAttachment> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.OriginalFileName)
                .IsRequired()
                .HasMaxLength(255);

            builder.Property(x => x.StoredFileName)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(x => x.ContentType)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(x => x.FileSize)
                .IsRequired();

            builder.HasOne(x => x.MaintenanceRequest)
                .WithMany(x => x.Attachments)
                .HasForeignKey(x => x.MaintenanceRequestId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
