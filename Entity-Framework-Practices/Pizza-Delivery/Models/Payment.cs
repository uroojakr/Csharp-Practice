using System.ComponentModel.DataAnnotations.Schema;

namespace Pizza_Delivery.Models
{
    public class Payment
    {
        public int Id { get; set; }
        [Column(TypeName = "decimal(6, 2)")]
        public decimal TotalAmount { get; set; }
        public DateTime PaymentDate { get; set; }
        public string Status { get; set; } = null!;
        public string PaymentMethod { get; set; } = null!;

        public int OrderID { get; set; }    
        public ICollection<Order>? Orders { get; set; }
    }
}
