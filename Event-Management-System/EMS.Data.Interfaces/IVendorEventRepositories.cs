

using Event_Management_System.Models;

namespace Event_Management_System.Repositories.Interfaces
{
    public interface IVendorEventRepositories : IRepository<VendorEvent>
    {
        IQueryable<VendorEvent> GetVendorEventsByEventId(int eventId);
        public VendorEvent UpdateVendorEventDetails(Func<Vendor, bool> predicate, int eventId, string newDescription);
    }
}
