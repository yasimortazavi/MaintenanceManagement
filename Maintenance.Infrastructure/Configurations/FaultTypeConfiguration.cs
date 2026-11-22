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
    public class FaultTypeConfiguration : IEntityTypeConfiguration<FaultType>
    {
        public void Configure(EntityTypeBuilder<FaultType> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Title)
                .IsRequired()
                .HasMaxLength(150);

            builder.Property(x => x.Description)
                .HasMaxLength(500);

            builder.HasIndex(x => x.Title)
                .IsUnique();

            builder.HasData(
            new FaultType
            {
                Id = 1,
                Title = "خرابی الکتریکی",
                Description = "مشکلات مربوط به سیستم برق",
                IsActive = true
            },
            new FaultType
            {
                Id = 2,
                Title = "خرابی مکانیکی",
                Description = "مشکلات مربوط به قطعات مکانیکی",
                IsActive = true
            },
            new FaultType
            {
                Id = 3,
                Title = "خرابی ابزار دقیق",
                Description = "مشکلات مربوط به تجهیزات اندازه‌گیری و کنترل",
                IsActive = true
            }
        );


        }
    }
}
