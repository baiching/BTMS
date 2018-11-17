using BTMS.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTMS.Data.Interfaces
{
    public interface IDriverRepository
    {
        IEnumerable<Driver> Drivers { get; }

        bool RegisterDriver(Driver driver);
        bool Remove(Driver driver);
        bool Update(Driver driver);
    }
}
