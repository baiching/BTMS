using BTMS.Entity.UserModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTMS.Entity.ClientModels
{
    public class ClientDetails
    {
        public Client Client { get; set; }

        public IEnumerable<Ticket> Tickets { get; set; }

        ///counting valid tickets
        public int OpenTicketCount { get; set; }
    }
}
