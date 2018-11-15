using BTMS.Entity.UserModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTMS.Entity.TicketModels
{
    public class TicketDetails
    {
        public Ticket Ticket { get; set; }

        public Client Client { get; set; }

        public List<AdminTime> Time { get; set; }

    }
}
