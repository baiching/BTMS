using BTMS.Core.interfaces;
using BTMS.Data;
using BTMS.Data.Interfaces;
using BTMS.Entity;
using System;
using System.Collections.Generic;

namespace BTMS.Core
{
    public class JourneyService : DomainService<Journey>, IJourneyService
    {
        public IEnumerable<Journey> Journeys => throw new NotImplementedException();

        protected internal IJourneyRepository repository;

        public JourneyService()
        {
            repository = new JourneyRepository();
        }

        public bool RemoveJourney(Journey journey)
        {
            return repository.RemoveJourney(journey);
        }
    }
}
