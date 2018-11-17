using BTMS.Data.Interfaces;
using BTMS.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTMS.Data
{
    public class TicketRepository : UserRepository<Ticket>, ITicketRepository
    {
        public bool RemoveTicket(Ticket ticket)
        {
            using(var context = new BtmsContext())
            {
                try
                {
                    var removeTicket = context.Tickets.Find(ticket.Id);
                    context.Tickets.Remove(removeTicket);
                    return context.SaveChanges() > 0;
                }
                catch
                {
                    return false;
                }
            }
        }
    }
}
