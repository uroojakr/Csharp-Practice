
using AutoMapper;
using EMS.Business.Interfaces;
using EMS.Business.Models;
using EMS.Business.Services;
using EMS.Data;
using EMS.Data.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace EMS.Business.DataService
{
    public class EventService : GenericService<EventsModel>, IEventsService
    {
        public EventService(IUnitOfWork unitOfWork, IMapper mapper, EMSDbContext dbContext) : base(unitOfWork, mapper, dbContext)
        {
        }

        public async Task<IEnumerable<EventsModel>> GetEventsByDateRange(DateTime startDate, DateTime endDate)
        {
            var dateRangeQuery =  _repository.GetQuery(e => e.Date >= startDate && e.Date <= endDate);
            var events = await dateRangeQuery.ToListAsync();
            return _mapper.Map<IEnumerable<EventsModel>>(events);
        }

        public async Task<IEnumerable<EventsModel>> GetEventsByLocation(string location)
        {
            var eventsQuery =  _repository.GetQuery(e => e.Location == location);
            var events = await eventsQuery.ToListAsync();
            return _mapper.Map<IEnumerable<EventsModel>>(events);
        }

    }
}

