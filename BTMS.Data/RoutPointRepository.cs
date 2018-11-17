using BTMS.Data.Interfaces;
using BTMS.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTMS.Data
{
    public class RoutPointRepository : UserRepository<RoutePoint>, IRoutePointRepository
    {

        public bool RemoveRoutePoint(RoutePoint routePoint)
        {
            using(var context = new BtmsContext())
            {
                var removeRoutePoint = context.RoutePoints.Find(routePoint.Id);
                context.RoutePoints.Remove(removeRoutePoint);
                return context.SaveChanges() > 0;
            }
        }
    }
}
