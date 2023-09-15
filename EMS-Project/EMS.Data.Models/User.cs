using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.Data.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        [Required]
        public string UserName { get; set; } = null!;
        [Required]
        public string Email { get; set; } = null!;
        [Required]
        public string Password { get; set; } = null!;

        public UserType UserType { get; set; }
        public ICollection<Events> OrganizedEvents { get; set; } = null!;
        public ICollection<Review> Reviews { get; set; } = null!;
    }
}
