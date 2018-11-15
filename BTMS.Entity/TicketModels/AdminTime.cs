using BTMS.Entity.UserModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTMS.Entity.TicketModels
{
    // Tech time model
    public class AdminTime
    {
        public Admin Technician { get; set; }

        public AdminTicketTime Time { get; set; }
    }
}
