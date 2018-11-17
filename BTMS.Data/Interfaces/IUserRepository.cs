using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTMS.Data.Interfaces
{
    public interface IUserRepository<T> 
    {
        T GetByEmail(string email);
        List<T> GetAll();
        bool Add(T t);
        bool Update(T t);
        bool Insert(T t);
    }
}
