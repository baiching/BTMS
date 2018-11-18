using BTMS.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTMS.Core.interfaces
{
    public interface IRoutePointService : IDomainService<RoutePoint>
    {
        bool RemoveRoutePoint(RoutePoint routePoint);
    }
}
