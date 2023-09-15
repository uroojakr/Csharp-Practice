
using NUnit.Framework.Internal.Execution;
using Event_Management_System.Repositories;

namespace Event_Management_System.Repositories.Interfaces
{
    public interface IEventRepository : IRepository<Events>
    {
        IEnumerable<Events> GetEventByDate(DateTime date);
      //  public void AddVendorToEvent(Vendor vendor);
    }
}
