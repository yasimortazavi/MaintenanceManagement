using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maintenance.Domain.Entities;

public class Department
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public string Code { get; set; } = string.Empty;

    public bool IsActive { get; set; } = true;

    // تجهیزاتی که متعلق به این دپارتمان هستند
    public ICollection<Equipment> Equipments { get; set; }
        = new List<Equipment>();

    // درخواست‌هایی که کارکنان این دپارتمان ثبت کرده‌اند
    public ICollection<MaintenanceRequest> MaintenanceRequests { get; set; }
        = new List<MaintenanceRequest>();
}
