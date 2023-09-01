

using Microsoft.EntityFrameworkCore;
using Pizza_Delivery.Data;
using Pizza_Delivery.Models;
using Pizza_Delivery.Repositories.Interfaces;

namespace Pizza_Delivery.Repositories.Services
{
    internal class DeliveriesRepository : Repository<Deliveries>, IDeliveriesRepository
    {
        private readonly DbContext _context;
        public DeliveriesRepository(ItallianPizzaContext context) : base(context) => _context = context;

        public IEnumerable<Deliveries> GetAllDeliveryPersons() => _context.Set<Deliveries>().ToList();

        public IEnumerable<Deliveries> GetAvailableDrivers() => _context.Set<Deliveries>().OrderByDescending(d => d.IsAvailable).ToList();



    }
}
