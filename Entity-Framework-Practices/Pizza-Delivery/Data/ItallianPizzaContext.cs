using Microsoft.EntityFrameworkCore;
using Pizza_Delivery.Models;

namespace Pizza_Delivery.Data
{
    public class ItallianPizzaContext : DbContext // inherit from DbContext
    {
        readonly string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Pizza_DB;Integrated Security=True;" +
            "Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

        //mapping to table that will be created in the database
        public DbSet<Customer> Customers { get; set; } = null!;
        public DbSet<Order> Orders { get; set; } = null!;
        public DbSet<Product> Products { get; set; } = null!;
        public DbSet<OrderDetail> OrderDetails { get; set; } = null!;
        public DbSet<Deliveries> Deliveries { get; set; } = null!;
        public DbSet<Payment> Payments { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
