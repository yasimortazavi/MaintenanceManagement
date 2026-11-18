using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maintenance.Domain.Entities;

public class RequestFaultType
{
    public int MaintenanceRequestId { get; set; }

    public MaintenanceRequest MaintenanceRequest { get; set; }
        = null!;

    public int FaultTypeId { get; set; }

    public FaultType FaultType { get; set; }
        = null!;
}
