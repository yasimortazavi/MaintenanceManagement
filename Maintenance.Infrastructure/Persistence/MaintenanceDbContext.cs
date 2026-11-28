using Maintenance.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maintenance.Infrastructure.Persistence
{
    public class MaintenanceDbContext : DbContext
    {
        public MaintenanceDbContext(DbContextOptions options) : base(options)
        {

        }


        public DbSet<MaintenanceRequest> MaintenanceRequests { get; set; }
        public DbSet<Equipment> Equipments { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<FaultType> FaultTypes { get; set; }
        public DbSet<RequestFaultType> RequestFaultTypes { get; set; }
        public DbSet<MaintenanceAttachment> MaintenanceAttachments { get; set; }
        public DbSet<TechnicianAssignment> TechnicianAssignments { get; set; }
        public DbSet<MaintenanceWorkLog> MaintenanceWorkLogs { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(
                typeof(MaintenanceDbContext).Assembly);
        }


    }
}
