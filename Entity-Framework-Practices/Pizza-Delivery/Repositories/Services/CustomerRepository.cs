using Microsoft.EntityFrameworkCore;
using Pizza_Delivery.Data;
using Pizza_Delivery.Models;
using Pizza_Delivery.Repositories.Interfaces;

namespace Pizza_Delivery.Repositories
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        private readonly DbContext _context;
        public CustomerRepository(ItallianPizzaContext context) : base(context) => _context = context;

        public IEnumerable<Customer> GetCustomersByEmail(string email)
        {
            return _context.Set<Customer>().Where(c => c.Email == email).ToList();
        }

        public IEnumerable<Customer> GetCustomersByPhone(string phoneNumber)
        {
            return _context.Set<Customer>().Where(c => c.Phone == phoneNumber).ToList();
        }
    }
}
