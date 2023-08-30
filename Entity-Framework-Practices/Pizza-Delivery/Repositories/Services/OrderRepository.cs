using Pizza_Delivery.Data;
using Pizza_Delivery.Models;
using Pizza_Delivery.Repositories;

public class OrderRepository : Repository<Order>
{
    public OrderRepository(ItallianPizzaContext context) : base(context)
    {

    }
}

