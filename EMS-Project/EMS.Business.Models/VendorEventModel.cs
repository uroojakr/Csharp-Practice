using EMS.Data.Models;

namespace EMS.Business.Models
{
    public class VendorEventModel
    {
        public int VendorId { get; set; }
        public Vendor Vendor { get; set; } = null!;
        public int EventId { get; set; }
        public Events Event { get; set; } = null!;

    }
}