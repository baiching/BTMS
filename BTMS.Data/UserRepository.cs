using BTMS.Data.Interfaces;
using BTMS.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTMS.Data
{
    public class UserRepository<T> : IUserRepository<T> where T : class
    {
        internal BtmsContext context = new BtmsContext();

        public virtual bool Add(T t)
        {
            try
            {
                context.Set<T>().Add(t);
                return context.SaveChanges() > 0;
            }
            catch(Exception e)
            {
                return false;
            }
        }

        public virtual List<T> GetAll()
        {
            return context.Set<T>().ToList();
        }

        public virtual T GetByEmail(string email)
        {
            return context.Set<T>().Find(email);
        }

        public bool Insert(T t)
        {
            context.Set<T>().Add(t);
            return context.SaveChanges() > 0;
        }

        public virtual bool Update(T t)
        {
            context.Entry<T>(t).State = EntityState.Modified;
            return context.SaveChanges() > 0;
        }

        public virtual bool UpdatePassword(string email, string password)
        {
            throw new NotImplementedException();
        }
    }
}
