using BTMS.Core.interfaces;
using BTMS.Data;
using BTMS.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTMS.Core
{
    public class DomainService<T> : IDomainService<T> where T : class
    {
        protected internal IUserRepository<T> repository;

        public DomainService()
        {
            repository = new UserRepository<T>();
        }

        public virtual bool Add(T t)
        {
            return repository.Add(t);
        }

        public virtual List<T> GetAll()
        {
            return repository.GetAll();
        }

        public virtual T GetByEmail(string email)
        {
            return GetByEmail(email);
        }

        public bool Insert(T t)
        {
            return repository.Insert(t);
        }

        public bool Update(T t)
        {
            return repository.Update(t);
        }
    }
}
