using BTMS.Entity;
using System.Collections.Generic;

namespace BTMS.Data.Interfaces
{
    public interface ITrafficRepository
    {
        IEnumerable<Traffic> Traffics { get; }

        void AddTraffic(Traffic traffic);
        void AddTraffic(Journey journey, Ticket ticket);
    }
}
