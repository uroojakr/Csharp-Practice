using System.Collections.Generic;

namespace EF_PizzaConsole.Models
{
    public class Author
    {
        public int AuthorId { get; set; }
        public string AuthorName { get; set; } = null!;

        // Navigation property for courses authored by this author
        public ICollection<Course> Courses { get; set; } = new List<Course>();
    }
}
