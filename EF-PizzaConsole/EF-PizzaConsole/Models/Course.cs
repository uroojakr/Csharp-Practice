namespace EF_PizzaConsole.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; } = null!;
        public int SalesCount { get; set; }
    }
}
