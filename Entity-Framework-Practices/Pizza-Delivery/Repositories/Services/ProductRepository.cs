using Microsoft.EntityFrameworkCore;
using Pizza_Delivery.Data;
using Pizza_Delivery.Models;
using Pizza_Delivery.Repositories.Interfaces;

namespace Pizza_Delivery.Repositories.Services
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private readonly DbContext _context;
        public ProductRepository(ItallianPizzaContext context) : base(context) => _context = context;

        public IEnumerable<Order> GetOrdersForProduct(int productId)
        {
            return _context.Set<Product>().Find(productId)?.Orders ?? new List<Order>();
        }

        public IEnumerable<Product> GetProductsByPriceRange(decimal minPrice, decimal maxPrice)
        {
            return _context.Set<Product>()
                .Where(p => p.Price >= minPrice && p.Price <= maxPrice).ToList();
        }


    }
}