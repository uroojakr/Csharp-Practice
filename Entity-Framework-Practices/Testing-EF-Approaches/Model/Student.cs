using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing_EF_Approaches.Model
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string MobileNo { get; set; } = null!;   
    }
}
