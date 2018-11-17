using BTMS.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTMS.Data.Interfaces
{
    public interface IBusRepository
    {
        IEnumerable<Bus> Buses { get; }

        void RegisterBus(Bus bus);
        Bus Remove(Bus bus);
        Bus Update(Bus bus);
    }
}
