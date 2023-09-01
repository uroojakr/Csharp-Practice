using Microsoft.EntityFrameworkCore;
using Pizza_Delivery.Data;
using Pizza_Delivery.Models;
using Pizza_Delivery.Repositories.Interfaces;

namespace Pizza_Delivery.Repositories.Services
{
    public class OrderDetailRepository : Repository<OrderDetail>, IOrderDetailRepository
    {
        private readonly DbContext _context;

        public OrderDetailRepository(ItallianPizzaContext context) : base(context) => _context = context;

        public IEnumerable<OrderDetail> GetOrderDetailForOrder(int orderId) => _context.Set<OrderDetail>().Where(o => o.OrderId == orderId).ToList();
    }
}
