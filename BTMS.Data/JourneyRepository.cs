using BTMS.Data.Interfaces;
using BTMS.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTMS.Data
{
    public class JourneyRepository : UserRepository<Journey>, IJourneyRepository
    {
        internal BtmsContext context = new BtmsContext();
        public IEnumerable<Journey> Journeys => context.Journeys;

        public bool RemoveJourney(Journey journey)
        {
            var journeyRemove = context.Journeys.Find(journey.Id);
            context.Journeys.Remove(journeyRemove);
            return context.SaveChanges() > 0;

        }
    }
}
