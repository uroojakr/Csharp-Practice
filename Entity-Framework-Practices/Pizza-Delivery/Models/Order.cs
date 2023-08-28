namespace Pizza_Delivery.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderPlaced { get; set; }   
        public DateTime? Orderfulfilled { get; set; }
        public int CustomerId { get; set; }
        public string Customer { get; set; } = null!;
        public ICollection<OrderDetail> OrderDetails { get; set; } = null!;
    }
}