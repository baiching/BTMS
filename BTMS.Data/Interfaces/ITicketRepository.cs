using BTMS.Entity;
using System;
using System.Collections.Generic;

namespace BTMS.Data.Interfaces
{
    public interface ITicketRepository : IUserRepository<Ticket>
    {
        bool RemoveTicket(Ticket ticket);
    }
}
