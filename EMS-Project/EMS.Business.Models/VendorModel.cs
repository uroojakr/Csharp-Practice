

using EMS.Data.Models;

namespace EMS.Business.Models
{
    public class VendorModel
    {
        public int VendorId { get; set; }
        public string Name { get; set; } = null!;   
        public string Description { get; set; } = null!;
        public string ContactInformation { get; set; } = null!;

        public ICollection<VendorEvent> VendorEvents { get; set; } = null!;
    }
}
