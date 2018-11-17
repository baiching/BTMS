using BTMS.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTMS.Data.Interfaces
{
    public interface IAdminRepository
    {
        void RegisterAdmin(Admin admin);
        bool Login(string username, string password);
    }
}
