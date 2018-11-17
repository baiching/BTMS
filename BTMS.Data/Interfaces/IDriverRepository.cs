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

        void RegisterDriver(Driver driver);
        Driver Remove(Driver driver);
        Driver Update(Driver driver);
    }
}
