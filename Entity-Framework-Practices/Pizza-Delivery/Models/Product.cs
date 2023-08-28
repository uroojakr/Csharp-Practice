using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Delivery.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; } //this is the primary key

       //[required] if needed for null to not be stored in database but only for model
        public string Name { get; set; } = null!;

        [Column(TypeName = "decimal(6, 2)")] //decimal with two points of precision

        public decimal Price { get; set; }
    }
}
