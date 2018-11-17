﻿
namespace BTMS.Data.Interfaces
{
    public interface IUnitOfWork
    {
        IBusRepository BusRepository { get; }
        IDriverRepository DriverRepository { get; }
        IJourneyRepository JourneyRepository { get; }
        IPassengerRepository PassengerRepository { get; }
        IRoutePointRepository RoutePointRepository { get; }
        IRouteRepository RouteRepository { get; }
        ITicketRepository TicketRepository { get; }
        ITrafficRepository TrafficRepository { get; }
        IAdminRepository AdministratorRepository { get; }
    }
}
