using System.ComponentModel.DataAnnotations;

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
