using BTMS.Core.interfaces;
using BTMS.Data;
using BTMS.Data.Interfaces;
using BTMS.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTMS.Core
{
    public class RoutePointService : DomainService<RoutePoint>, IRoutePointService
    {
        protected internal IRoutePointRepository repository;

        public RoutePointService()
        {
            repository = new RoutPointRepository();
        }

        public bool RemoveRoutePoint(RoutePoint routePoint)
        {
            return repository.RemoveRoutePoint(routePoint);
        }
    }
}
