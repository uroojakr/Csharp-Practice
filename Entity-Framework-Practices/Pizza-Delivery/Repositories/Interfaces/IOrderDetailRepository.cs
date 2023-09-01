using Pizza_Delivery.Models;

namespace Pizza_Delivery.Repositories.Interfaces
{
    public interface IOrderDetailRepository : IRepository<OrderDetail>
    {
        IEnumerable<OrderDetail> GetOrderDetailForOrder(int orderId);
    }
}
