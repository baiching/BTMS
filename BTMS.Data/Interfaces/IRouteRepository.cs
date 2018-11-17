using BTMS.Entity;
using System.Collections.Generic;


namespace BTMS.Data.Interfaces
{
    public interface IRouteRepository
    {
        IEnumerable<Route> Routes { get; }

        void AddRoute(Route route);
        void AddRoute(RoutePoint departurePoint, RoutePoint arrivalPoint, double length);
        Route RemoveRoute(Route route);
        Route UpdateRoute(Route route);
    }
}
