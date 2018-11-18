using BTMS.Data;
using BTMS.Entity;
using BTMS.Data.Interfaces;
using BTMS.Core.interfaces;

namespace BTMS.Core
{
    public class TicketService : DomainService<Ticket>, ITicketService
    {
        protected ITicketRepository repository;

        public TicketService()
        {
            repository = new TicketRepository();
        }

        public bool PurchaseTicket(Ticket ticket)
        {
            return repository.Add(ticket);
        }
    }
}
