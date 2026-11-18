using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maintenance.Domain.Entities;

public class TechnicianAssignment
{
    public int Id { get; set; }

    public int MaintenanceRequestId { get; set; }

    public MaintenanceRequest MaintenanceRequest { get; set; }
        = null!;

    public string TechnicianId { get; set; } = string.Empty;

    public DateTime AssignedAt { get; set; } = DateTime.UtcNow;

    public DateTime? EndedAt { get; set; }

    public string? Notes { get; set; }
}
