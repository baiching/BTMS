﻿using System.Collections.Generic;
using BTMS.Entity;

namespace BTMS.Data.Interfaces
{
    public interface IRoutePointRepository : IUserRepository<RoutePoint>
    {
        IEnumerable<RoutePoint> RoutePoints { get; }
        
        RoutePoint RemoveRoutePoint(RoutePoint routePoint);
    }
}
