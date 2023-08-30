

using EF_PizzaConsole.Models;
using EF_PizzaConsole.Repositories;

static void Main(string[] args)
{


    using (var unitOfWork = new UnitOfWork(new PlutoContext()))
    {
        //getting course id
        var course = unitOfWork.Course.Get(1);

        //getting sales
        var sales = unitOfWork.Course.GetTopSellingCourses(1);

        //deleting courses
        unitOfWork.Course.Remove(course);

        unitOfWork.Complete();
    }
}