using BTMS.Data.Interfaces;
using BTMS.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTMS.Data
{
    public class BusRepository : IBusRepository
    {
        internal BtmsContext context = new BtmsContext();

        public BusRepository()
        {
        }

        public IEnumerable<Bus> Buses => context.Buses;

        public bool RegisterBus(Bus bus)
        {
            context.Buses.Add(bus);
            return context.SaveChanges() > 0;
        }

        public bool Remove(Bus bus)
        {
            if (bus == null)
            {
                throw new ArgumentNullException(nameof(bus), "Bus cannot be null");
            }

            var removeBus = context.Buses.Find(bus.Id);

            if(removeBus != null)
            {
                context.Buses.Remove(removeBus);
                return context.SaveChanges() > 0;
            }

            return false;
        }

        public bool Update(Bus bus)
        {
            if (bus == null)
            {
                throw new ArgumentNullException(nameof(bus), "Bus cannot be null");
            }

            context.Entry(bus).State = System.Data.Entity.EntityState.Modified;

            return context.SaveChanges() > 0;
        }
    }
}
