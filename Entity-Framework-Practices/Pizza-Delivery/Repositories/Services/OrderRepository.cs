using Microsoft.EntityFrameworkCore;
using Pizza_Delivery.Data;
using Pizza_Delivery.Models;
using Pizza_Delivery.Repositories;
using Pizza_Delivery.Repositories.Interfaces;

public class OrderRepository : Repository<Order>, IOrderRepository
{
    private readonly DbContext _context;
    public OrderRepository(ItallianPizzaContext context) : base(context) => _context = context;

    public IEnumerable<Order> CustomerNameofOrderPlaced() => _context.Set<Order>().OrderBy(o => o.Customer.FirstName);

    public IEnumerable<Order> OrderPlacedAt(DateTime datetime) => _context.Set<Order>().Where(o => o.OrderPlaced.Date == datetime);
}

