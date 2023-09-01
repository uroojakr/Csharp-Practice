using Microsoft.EntityFrameworkCore;

namespace EF_PizzaConsole.Models
{
    public class PlutoContext : DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Course> Courses { get; set; }


    }
}
