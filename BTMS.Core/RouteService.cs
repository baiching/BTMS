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
    public class RouteService : DomainService<Route>, IRouteService
    {
        protected internal IRouteRepository repository;

        public RouteService()
        {
            repository = new RouteRepository();
        }
        public bool RemoveRoute(Route route)
        {
            return repository.RemoveRoute(route);
        }
    }
}
