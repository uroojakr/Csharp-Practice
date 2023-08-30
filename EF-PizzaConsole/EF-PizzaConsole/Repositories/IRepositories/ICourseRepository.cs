using EF_PizzaConsole.Models;
using System.Collections.Generic;

namespace EF_PizzaConsole.IRepositories
{
    public interface ICourseRepository : IRepository<Course>
    {
        IEnumerable<Course> GetTopSellingCourses(int count);
        IEnumerable<Course> GetCoursesWithAuthors(int pageIndex, int pageSize);
    }
}
