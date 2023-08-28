using Pizza_Delivery.Data;
using Pizza_Delivery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Delivery.Operations
{
    public class ProductRepository
    {
        private readonly ItallianPizzaContext _context;
        public ProductRepository(ItallianPizzaContext context) 
        {
            _context = context;
        }

        public void AddProduct(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }

        public IEnumerable<Product> GetProductsbyPrice(decimal minPrice) 
        {
            return _context.Products.Where( p => p.Price > minPrice).OrderBy( p => p.Name).ToList();
        }

        public void UpdateProduction(string ProductName, decimal newPrice)
        {
            var product = _context.Products.FirstOrDefault( p => p.Name == ProductName );

            if (product != null)
            {
                product.Price = newPrice;
                _context.SaveChanges();
            }
        }

        public void DeleteProduct(string ProductName) 
        {
            var product = _context.Products.FirstOrDefault( p => p.Name.Equals(ProductName) );

            if(product != null)
            {
                _context.Products.Remove(product);
                _context.SaveChanges();
            }
        }
    }
}
