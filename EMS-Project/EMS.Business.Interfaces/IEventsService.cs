

using EMS.Business.Models;

namespace EMS.Business.Interfaces
{
    public interface IEventsService : IGenericService<EventsModel>
    {
        Task<IEnumerable<EventsModel>> GetEventsByLocation(string location);
        Task<IEnumerable<EventsModel>> GetEventsByDateRange(DateTime startDate, DateTime endDate);
    }
}
