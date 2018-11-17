using BTMS.Entity;
using System.Collections.Generic;


namespace BTMS.Data.Interfaces
{
    public interface IRouteRepository : IUserRepository<Route>
    {
        IEnumerable<Route> Routes { get; }
        
        Route RemoveRoute(Route route);
    }
}
