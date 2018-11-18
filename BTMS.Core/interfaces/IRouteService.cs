using BTMS.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTMS.Core.interfaces
{
    public interface IRouteService : IDomainService<Route>
    {
        bool RemoveRoute(Route route);
    }
}
