

using Event_Management_System.Models;
using Event_Management_System.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Event_Management_System.Repositories.Services
{
    public class EventRepository : Repository<Events>, IEventRepository
    {
        private readonly DbContext _context;

        public EventRepository(EventManagementContext context) : base(context) => _context = context;
        //public void AddVendorToEvent(Vendor vendor)
        //{ 
        //}
        public IEnumerable<Events> GetEventByDate(DateTime date) => _context.Set<Events>().Where(ed => ed.Date == date);
        

    }
}
