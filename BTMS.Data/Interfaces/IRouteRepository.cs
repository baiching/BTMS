using BTMS.Entity;
using System.Collections.Generic;


namespace BTMS.Data.Interfaces
{
    public interface IRouteRepository : IUserRepository<Route>
    {
        bool RemoveRoute(Route route);
    }
}
