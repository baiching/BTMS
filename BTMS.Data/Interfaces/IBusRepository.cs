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

        bool RegisterBus(Bus bus);
        bool Remove(Bus bus);
        bool Update(Bus bus);
    }
}
