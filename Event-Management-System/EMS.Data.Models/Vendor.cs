
using System.ComponentModel.DataAnnotations;


namespace Event_Management_System.Models
{
    public class Vendor
    {
        public int VendorId { get; set; }
        [Required]
        public string Name { get; set; } = null!;
        [Required]
        public string Description { get; set; } = null!;
        [Required]
        public string ContactInformation { get; set; } = null!;

        public ICollection<VendorEvent> VendorEvents { get; set; } = null!;
    }
}
