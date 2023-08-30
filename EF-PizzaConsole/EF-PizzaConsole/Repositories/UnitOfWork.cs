using EF_PizzaConsole.Models;
using EF_PizzaConsole.Repositories.IRepositories;
using EF_PizzaConsole.Repositories.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_PizzaConsole.Repositories
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly PlutoContext _context;

        public UnitOfWork(PlutoContext context)
        {
            _context = context;
            Course = new CourseRepository(_context);
          
        }

        public ICourseRepository Course { get;  }
      //  public IAuthorRepository Authors { get;  }



        public int Complete()
        {
            return _context.SaveChanges();
        }
        public void Dispose() 
        {
            _context.Dispose();
        }

    }
}
