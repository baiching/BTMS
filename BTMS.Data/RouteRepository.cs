using BTMS.Data.Interfaces;
using BTMS.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTMS.Data
{
    public class RouteRepository : UserRepository<Route>, IRouteRepository
    {
        public bool RemoveRoute(Route route)
        {
            using(var context = new BtmsContext())
            {
                try
                {
                    var removeRoute = context.Routes.Find(route.Id);
                    context.Routes.Remove(removeRoute);

                    return context.SaveChanges() > 0;
                }
                catch(Exception e)
                {
                    return false;
                }
            }
        }
    }
}
