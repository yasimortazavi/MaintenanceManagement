using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maintenance.Domain.Entities;

public class MaintenanceWorkLog
{
    public int Id { get; set; }

    public int MaintenanceRequestId { get; set; }

    public MaintenanceRequest MaintenanceRequest { get; set; }
        = null!;

    public string TechnicianId { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public int? DurationMinutes { get; set; }
}
