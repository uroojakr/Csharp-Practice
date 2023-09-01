using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_PizzaConsole.Repositories.IRepositories
{
    public interface IUnitOfWork : IDisposable
    {
        ICourseRepository Course { get; }
       // IAuthorRepository Authors { get; }

        int Complete();
    }
}
