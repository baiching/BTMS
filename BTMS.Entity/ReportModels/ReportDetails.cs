using BTMS.Entity.UserModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTMS.Entity.ReportModels
{
    public class ReportDetails
    {
        public TimeSpan AverageWait { get; set; }

        public int AverageQueueLength { get; set; }

        public double EmptyQueuePercentage { get; set; }

        public int TicketsNotAddressedSameDay { get; set; }

        //Admins Free Time
        public List<(Admin Admin, int HoursIdle)> AdminIdleHours { get; set; }
    }
}
