using EF_PizzaConsole.Repositories.IRepositories;
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
        private readonly DbContext _context; //generic 

        public Repository(DbContext context) 
        {
            _context = context;
        }
        public void Add(TEntity entity)
        {
           _context.Set<TEntity>().Add(entity);
        }

        //public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate) //ienumerable for encapsulating queries
        //{
        //   return _context.Set<TEntity>().Where(predicate);
        //}

        public IEnumerable<TEntity> GetAll() //all instances
        {
            return _context.Set<TEntity>().ToList();
        }

        public TEntity Get(int id) //specific instance
        {
            return _context.Set<TEntity>().Find(id) ?? throw new InvalidOperationException($"Entity with ID {id} not found."); ;
        }

        public void Remove(TEntity entity)
        {
            _context.Set<TEntity>().Remove(entity);  
        }

        public void Update(TEntity entity)
        {
            _context.Set<TEntity>().Update(entity);
        }
    }
}
