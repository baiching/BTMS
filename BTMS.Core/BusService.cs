using BTMS.Core.interfaces;
using BTMS.Data;
using BTMS.Data.Interfaces;
using BTMS.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTMS.Core
{
    public class BusService : IBusService
    {
        public IEnumerable<Bus> Buses => throw new NotImplementedException();

        protected internal IBusRepository repository;

        public BusService()
        {
            repository = new BusRepository();
        }

        public bool RegisterBus(Bus bus)
        {
            return repository.RegisterBus(bus);
        }

        public bool Remove(Bus bus)
        {
            return repository.Remove(bus);
        }

        public bool Update(Bus bus)
        {
            return repository.Update(bus);
        }
    }
}
