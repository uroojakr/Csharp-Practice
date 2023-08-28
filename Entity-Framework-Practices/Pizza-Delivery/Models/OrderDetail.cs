using System.Diagnostics.Contracts;

namespace Pizza_Delivery.Models
{
    public class OrderDetail
    {
        //has navigation property for bothh order and product M-M
        public int Id { get; set; }
        public int Quantity { get; set; }
        public int ProductId { get; set; }  
        public int OrderId { get; set; }
        public Order Order { get; set; } = null!;

        public Product Product { get; set; } = null!;

    }
}