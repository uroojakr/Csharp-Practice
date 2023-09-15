using EMS.Business.Models;

namespace EMS.Business.Interfaces
{
    public interface IVendorEventService : IGenericService<VendorEventModel>
    {
        public Task<IEnumerable<VendorEventModel>> GetVendorEventsByEventTitleWithInclude(string eventTitle);
    }
}
