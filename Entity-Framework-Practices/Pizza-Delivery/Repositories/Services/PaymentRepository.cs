using Microsoft.EntityFrameworkCore;
using Pizza_Delivery.Data;
using Pizza_Delivery.Models;
using Pizza_Delivery.Repositories.Interfaces;

namespace Pizza_Delivery.Repositories.Services
{
    public class PaymentRepository : Repository<Payment>, IPaymentRepository
    {
        public readonly DbContext _context;
        public PaymentRepository(ItallianPizzaContext context) : base(context) => _context = context;

        public IEnumerable<Payment> GetAllPaymentMethodByCredit()
        {
            return _context.Set<Payment>().Where(p => p.PaymentMethod.Equals("Credit")).ToList();
        }
    }
}
