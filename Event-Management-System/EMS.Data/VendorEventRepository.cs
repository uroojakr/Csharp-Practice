using Event_Management_System.Models;
using Event_Management_System.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;


namespace Event_Management_System.Repositories.Services
{
    public class VendorEventRepository : Repository<VendorEvent>, IVendorEventRepositories
    {
        private readonly DbContext _context;
        public VendorEventRepository(EventManagementContext context) : base(context) => _context = context;

        public IQueryable<VendorEvent> GetVendorEventsByEventId(int eventId)
        {
            // Retrieve VendorEvents based on EventId
            return _context.Set<VendorEvent>().Where(ve => ve.EventId == eventId)
            .Include(ve => ve.Event)
            .Include(ve => ve.Vendor);
        }
        public VendorEvent UpdateVendorEventDetails(Func<Vendor, bool> predicate, int eventId,string newDescription)
        {
            var vendor = _context.Set<Vendor>().FirstOrDefault(predicate);

            if (vendor != null) 
            {
                vendor.Description = newDescription;
              
            }
            var updatedVendorEvent = _context.Set<VendorEvent>()
                .FirstOrDefault(ve => ve.EventId == eventId && ve.VendorId == vendor!.VendorId);
            return updatedVendorEvent!;
        }
        public VendorEvent GetVendorEventByVendorId(int vendorId)
        {
            return _context.Set<VendorEvent>().FirstOrDefault(ve => ve.VendorId == vendorId)!;
        }

    }
}
