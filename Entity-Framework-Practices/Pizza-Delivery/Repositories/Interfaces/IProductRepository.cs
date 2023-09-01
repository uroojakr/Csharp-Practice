using Pizza_Delivery.Models;

namespace Pizza_Delivery.Repositories.Interfaces
{
    public interface IProductRepository : IRepository<Product>
    {
        IEnumerable<Order> GetOrdersForProduct(int productId);
        IEnumerable<Product> GetProductsByPriceRange(decimal minPrice, decimal maxPrice);
    }
}
