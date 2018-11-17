using System;
using System.Collections.Generic;
using BTMS.Entity;

namespace BTMS.Data.Interfaces
{
    public interface IJourneyRepository
    {
        IEnumerable<Journey> Journeys { get; }

        void AddJourney(Journey journey);
        void AddJourney(Route route, DateTime departureDateTime, DateTime arrivalDateTime, Bus bus, Driver driver);
        Journey RemoveJourney(Journey journey);
        Journey UpdateJourney(Journey journey);
        IEnumerable<int> GetAllSeats(Journey journey);
    }
}
