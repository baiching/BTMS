using BTMS.Core.interfaces;
using BTMS.Data;
using BTMS.Data.Interfaces;
using BTMS.Entity;
using System;
using System.Collections.Generic;

namespace BTMS.Core
{
    public class AdminService : IAdminService
    {
        protected internal IAdminRepository repository;

        public AdminService()
        {
            repository = new AdminRepository();
        }

        public bool Login(string username, string password)
        {
            return repository.Login(username, password);
        }

        public bool RegisterAdmin(Admin admin)
        {
            return repository.RegisterAdmin(admin);
        }
    }
}
