using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Maintenance.Domain.Enums;


namespace Maintenance.Domain.Entities
{
    public class MaintenanceRequest
    {
        public int Id { get; set; }

        public string TrackingCode { get; set; } = string.Empty;

        public string RequesterId { get; set; } = string.Empty;

        public int EquipmentId { get; set; }
        public Equipment Equipment { get; set; } = null!;

        public int DepartmentId { get; set; }
        public Department Department { get; set; } = null!;

        public string Location { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public string? AdditionalNotes { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public MaintenanceRequestStatus Status { get; set; }
    = MaintenanceRequestStatus.Submitted;

        public ICollection<RequestFaultType> RequestFaultTypes { get; set; }
            = new List<RequestFaultType>();

        public ICollection<MaintenanceAttachment> Attachments { get; set; }
            = new List<MaintenanceAttachment>();

        public ICollection<TechnicianAssignment> TechnicianAssignments { get; set; }
            = new List<TechnicianAssignment>();

        public ICollection<MaintenanceWorkLog> WorkLogs { get; set; }
            = new List<MaintenanceWorkLog>();
    }
}
