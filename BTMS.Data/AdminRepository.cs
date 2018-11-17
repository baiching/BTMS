using BTMS.Data.Interfaces;
using BTMS.Entity;
using System;
using System.Linq;

namespace BTMS.Data
{
    public class AdminRepository : IAdminRepository
    {
        internal BtmsContext context = new BtmsContext();
        public bool Login(string username, string password)
        {
            if(string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                throw new ArgumentException("Username or Password must contain value");
            }
            var admin = context.Admins.FirstOrDefault(a => a.Username == username  );

            return admin.Password == password;
        }

        public bool RegisterAdmin(Admin admin)
        {
            context.Admins.Add(admin);
            return context.SaveChanges() > 0;
        }
    }
}
