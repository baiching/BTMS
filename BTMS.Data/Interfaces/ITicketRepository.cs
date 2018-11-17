using BTMS.Entity;
using System;
using System.Collections.Generic;

namespace BTMS.Data.Interfaces
{
    public interface ITicketRepository : IUserRepository<Ticket>
    {
        IEnumerable<Ticket> Tickets { get; }
        
        Ticket RemoveTicket(Ticket ticket);
    }
}
