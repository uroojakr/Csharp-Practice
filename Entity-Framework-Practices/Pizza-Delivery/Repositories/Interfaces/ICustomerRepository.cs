using Pizza_Delivery.Models;

namespace Pizza_Delivery.Repositories.Interfaces
{
    public interface ICustomerRepository : IRepository<Customer>
    {
        IEnumerable<Customer> GetCustomersByPhone(string phoneNumber);
        IEnumerable<Customer> GetCustomersByEmail(string email);
    }
}
