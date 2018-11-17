using BTMS.Entity;
using System;
using System.Collections.Generic;

namespace BTMS.Data.Interfaces
{
    public interface ITicketRepository
    {
        IEnumerable<Ticket> Tickets { get; }

        void AddTicket(Ticket ticket);
        void AddTicket(Journey journey, DateTime purchaseDateTime, decimal price, Passenger passenger, int seat);
        Ticket RemoveTicket(Ticket ticket);
    }
}
