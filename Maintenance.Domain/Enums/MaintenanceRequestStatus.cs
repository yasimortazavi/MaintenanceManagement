using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Maintenance.Domain.Enums
{
    public enum MaintenanceRequestStatus
    {
        Submitted = 1,
        UnderReview = 2,
        Assigned = 3,
        InProgress = 4,
        WaitingForParts = 5,
        Resolved = 6,
        Closed = 7,
        Rejected = 8
    }
}