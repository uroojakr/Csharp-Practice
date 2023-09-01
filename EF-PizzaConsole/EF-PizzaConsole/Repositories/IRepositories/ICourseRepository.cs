using EF_PizzaConsole.Models;
using System.Collections.Generic;

namespace EF_PizzaConsole.Repositories.IRepositories
{
    public interface ICourseRepository : IRepository<Course> // gets all the repo cruds and we give it two more methods
    {
        //IEnumerable<Course> Find(Func<object, bool> value);
        IEnumerable<Course> GetTopSellingCourses(int count); // Get a list of top selling courses
        void UpdateSalesCount(int courseId, int newSalesCount); // Update the sales count of a course
    }
}
