using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTMS.Core.interfaces
{
    public interface IDomainService<T> : IService where T : class
    {
        T GetByEmail(string email);
        List<T> GetAll();
        bool Add(T t);
        bool Update(T t);
        bool Insert(T t);
    }
}
