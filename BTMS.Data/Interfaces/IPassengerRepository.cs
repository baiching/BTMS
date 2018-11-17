using System.Collections.Generic;
using BTMS.Entity;

namespace BTMS.Data.Interfaces
{
    public interface IPassengerRepository : IUserRepository<Passenger>
    {
        IEnumerable<Passenger> Passengers { get; }
    }
}
