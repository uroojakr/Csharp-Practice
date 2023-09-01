using Pizza_Delivery.Models;

namespace Pizza_Delivery.Repositories.Interfaces
{
    public interface IOrderRepository : IRepository<Order>
    {
        IEnumerable<Order> OrderPlacedAt(DateTime datetime);
        IEnumerable<Order> CustomerNameofOrderPlaced();
    }
}
