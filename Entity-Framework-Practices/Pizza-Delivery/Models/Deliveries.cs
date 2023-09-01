namespace Pizza_Delivery.Models
{
    public class Deliveries
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public bool IsAvailable { get; set; }

        public int OrderID { get; set; }
        public ICollection<Order> Orders { get; set; } = new List<Order>(); //ensuring navigation properties are always initialized when instance is created.
    }
}
