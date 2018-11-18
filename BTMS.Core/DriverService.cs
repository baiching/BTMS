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
    public class DriverService : IDriverService
    {
        public IEnumerable<Driver> Drivers => throw new NotImplementedException();

        protected internal IDriverRepository repository;

        public DriverService()
        {
            repository = new DriverRepository();
        }

        public bool RegisterDriver(Driver driver)
        {
            return repository.RegisterDriver(driver);
        }

        public bool Remove(Driver driver)
        {
            return repository.Remove(driver);
        }

        public bool Update(Driver driver)
        {
            return repository.Update(driver);
        }
    }
}
