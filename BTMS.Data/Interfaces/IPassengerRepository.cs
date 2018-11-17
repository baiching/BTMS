using System.Collections.Generic;
using BTMS.Entity;

namespace BTMS.Data.Interfaces
{
    public interface IPassengerRepository
    {
        IEnumerable<Passenger> Passengers { get; }

        void AddPassenger(Passenger passenger);
        void AddPassenger(string firstName, string lastName);
    }
}
