using System;
using System.Collections.Generic;
using BTMS.Entity;

namespace BTMS.Data.Interfaces
{
    public interface IJourneyRepository : IUserRepository<Journey>
    {
        IEnumerable<Journey> Journeys { get; }
        bool RemoveJourney(Journey journey);
    }
}
