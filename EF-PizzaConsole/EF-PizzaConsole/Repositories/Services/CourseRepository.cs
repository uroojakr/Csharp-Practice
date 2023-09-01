using EF_PizzaConsole.Models;
using EF_PizzaConsole.Repositories.IRepositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EF_PizzaConsole.Repositories.Services
{
    public class CourseRepository : Repository<Course>, ICourseRepository
    {
        private readonly PlutoContext _plutoContext;
        public CourseRepository(PlutoContext context) : base(context)
        {
            _plutoContext = context;
        }

        public IEnumerable<Course> GetTopSellingCourses(int count)
        {
            return _plutoContext.Courses
                .OrderByDescending(c => c.SalesCount)
                .Take(count)
                .ToList();
        }

        public void UpdateSalesCount(int courseId, int newSalesCount)
        {
            var course = _plutoContext.Courses.Find(courseId);
            if (course != null)
            {
                course.SalesCount = newSalesCount;
                _plutoContext.SaveChanges();
            }
        }



        public PlutoContext? PlutoContext
        {
            get { return _plutoContext; }
        }
    }
}
