using System.Collections.Generic;
using BTMS.Entity;

namespace BTMS.Data.Interfaces
{
    public interface IRoutePointRepository : IUserRepository<RoutePoint>
    {
        bool RemoveRoutePoint(RoutePoint routePoint);
    }
}
