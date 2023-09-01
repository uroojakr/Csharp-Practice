namespace Pizza_Delivery.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderPlaced { get; set; }
        public DateTime? Orderfulfilled { get; set; }
        public int CustomerId { get; set; } // reference to the customer for which the payment is made

        //1-1
        public Customer Customer { get; set; } = null!;
        //1-M
        public ICollection<OrderDetail> OrderDetails { get; set; } = null!;

        public int ProductID { get; set; }
        public Product Product { get; set; } = null!;

        //public int PaymentID { get; set; }
        //public Payment Payment { get; set; } = null!;
       // public Deliveries Deliveries { get; set; } = null!;
        public int DeliveryID { get; set; }

    }
}