using BTMS.Data.Interfaces;
using BTMS.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTMS.Data
{
    public class DriverRepository : IDriverRepository
    {
        internal BtmsContext context = new BtmsContext();
        public IEnumerable<Driver> Drivers => context.Drivers;

        public bool RegisterDriver(Driver driver)
        {
            context.Drivers.Add(driver);
            return context.SaveChanges() > 0;
        }

        public bool Remove(Driver driver)
        {
            try
            {
                if (driver == null)
                {
                    throw new ArgumentNullException(nameof(driver), "Bus cannot be null");
                }

                var removeDriver = context.Drivers.Find(driver.Id);

                context.Drivers.Remove(removeDriver);
                return context.SaveChanges() > 0;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool Update(Driver driver)
        {
            if (driver == null)
            {
                throw new ArgumentNullException(nameof(driver), "Bus cannot be null");
            }

            context.Entry(driver).State = System.Data.Entity.EntityState.Modified;

            return context.SaveChanges() > 0;
        }
    }
}
