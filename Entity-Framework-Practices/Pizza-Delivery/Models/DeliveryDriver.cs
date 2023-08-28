using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Delivery.Models
{
    public class DeliveryDriver
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;   
        public string Phone { get; set; } = null!;
        public bool IsAvailable { get; set; }
    }
}
