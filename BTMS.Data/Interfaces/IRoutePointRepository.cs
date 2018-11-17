using System.Collections.Generic;
using BTMS.Entity;

namespace BTMS.Data.Interfaces
{
    public interface IRoutePointRepository
    {
        IEnumerable<RoutePoint> RoutePoints { get; }

        void AddRoutePoint(RoutePoint routePoint);
        RoutePoint RemoveRoutePoint(RoutePoint routePoint);
        RoutePoint UpdateRoutePoint(RoutePoint routePoint);
    }
}
