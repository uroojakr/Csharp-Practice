namespace Pizza_Delivery.Models
{
    public class Customer
    {
        public int Id { get; set; }

        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public string? Address { get; set; }

        public string? Phone { get; set; }
        public string? Email { get; set; }

        public ICollection<Order> Orders { get; set; } = null!; // ArrayList implements ICollection, indicates that customer may have zero or more orders, this is 1-M relationship, Navigation property
    }
}
