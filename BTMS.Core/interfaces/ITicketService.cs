using BTMS.Entity;

namespace BTMS.Core.interfaces
{
    public interface ITicketService : IDomainService<Ticket>
    {
        bool PurchaseTicket(Ticket ticket);
    }
}
