
using NUnit.Framework.Internal.Execution;

namespace Event_Management_System.Repositories.Interfaces
{
    public interface IEventRepository : IRepository<Events>
    {
        IEnumerable<Events> GetEventByDate(DateTime date);
      //  public void AddVendorToEvent(Vendor vendor);
    }
}
