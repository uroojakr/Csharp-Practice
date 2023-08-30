using EF_PizzaConsole.IRepositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EF_PizzaConsole.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly DbContext Context; //generic

        public Repository(DbContext context) 
        {
            Context = context;
        }
        public void Add(TEntity entity)
        {
           Context.Set<TEntity>().Add(entity);
        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate) //ienumerable for encapsulating queries
        {
           return Context.Set<TEntity>().Where(predicate);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return Context.Set<TEntity>().ToList();
        }

        public TEntity Get(int id)
        {
            return Context.Set<TEntity>().Find(id) ?? throw new InvalidOperationException($"Entity with ID {id} not found."); ;
        }

        public void Remove(TEntity entity)
        {
            Context.Set<TEntity>().Remove(entity);  
        }
    }
}
