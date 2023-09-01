using Pizza_Delivery.Models;

namespace Pizza_Delivery.Repositories.Interfaces
{
    public interface IPaymentRepository : IRepository<Payment>
    {
        IEnumerable<Payment> GetAllPaymentMethodByCredit();
    }
}
