using Pizza_Delivery.Data;
using Pizza_Delivery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class OrderRepository
{
    private readonly ItallianPizzaContext _context;

    public OrderRepository(ItallianPizzaContext context)
    {
        _context = context;
    }

    public void AddOrder(Order order)
    {
        _context.Orders.Add(order);
        _context.SaveChanges();
    }

    public IEnumerable<Order> GetOrdersByCustomers(int customerId) 
    {
        return _context.Orders.Where(o => o.CustomerId == customerId).ToList();
    }
}

