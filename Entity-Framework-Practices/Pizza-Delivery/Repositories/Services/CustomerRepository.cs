using Pizza_Delivery.Data;
using Pizza_Delivery.Models;

namespace Pizza_Delivery.Repositories
{
    public class CustomerRepository : Repository<Customer>
    {
        public CustomerRepository(ItallianPizzaContext context) : base(context)
        {
        }
    }
}
