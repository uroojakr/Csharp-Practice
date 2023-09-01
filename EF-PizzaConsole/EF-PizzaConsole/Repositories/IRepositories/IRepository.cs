using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EF_PizzaConsole.Repositories.IRepositories
{
    //collection 
    public interface IRepository<TEntity> where TEntity : class
    {
        TEntity Get(int id);
        IEnumerable<TEntity> GetAll();
       // IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate); //for lambda funtions to filter objects acts like where method in linqs


        void Add(TEntity entity);
        void Remove(TEntity entity);
        void Update(TEntity entity);

    }
}
