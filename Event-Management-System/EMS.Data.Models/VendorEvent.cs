
namespace Event_Management_System.Models
{
    //for Many-Many Relation junctions
    public class VendorEvent
    {
        public int VendorId { get; set; }
        public Vendor Vendor { get; set; } = null!;
        public int EventId { get; set; }
        public Events Event { get; set; } = null!;
    }
}
