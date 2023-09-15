
using Event_Management_System.Models;
using Microsoft.EntityFrameworkCore;

namespace Event_Management_System.Repositories.Services
{
    public class TicketRepository : Repository<Ticket>, ITicketRepositories
    {
        private readonly DbContext _context;
        public TicketRepository(EventManagementContext context) : base(context) => _context = context;
   
    }
}
