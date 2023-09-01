using Pizza_Delivery.Models;

namespace Pizza_Delivery.Repositories.Interfaces
{
    public interface IDeliveriesRepository : IRepository<Deliveries>
    {
        IEnumerable<Deliveries> GetAvailableDrivers();

        IEnumerable<Deliveries> GetAllDeliveryPersons();
        //IEnumerable<Deliveries> GetDeliveryPersonAvailable(DateTime dateTime);

        // IEnumerable<Deliveries> GetDeliveryPersonWithOrders();


    }
}
