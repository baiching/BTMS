using BTMS.Entity;
using System.Collections.Generic;

namespace BTMS.Data.Interfaces
{
    public interface ITrafficRepository : IUserRepository<Traffic>
    {
        IEnumerable<Traffic> Traffics { get; }
    }
}
