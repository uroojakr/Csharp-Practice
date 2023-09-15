
using System.Linq.Expressions;

namespace Event_Management_System.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class // where is reference type class
    {
        private readonly EventManagementContext _context;
        public Repository(EventManagementContext context) => _context = context;
        public bool Add(TEntity entity)
        {
            try
            {
                _context.Set<TEntity>().Add(entity);
                return true;
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        public bool Delete(int id)
        {
            var entity = _context.Set<TEntity>().Find(id);
            if (entity != null)
            {
                _context.Set<TEntity>().Remove(entity);
                return true; 
            }

            return false; 
        }
        public bool Update(TEntity entity)
        {
            try
            {
                _context.Set<TEntity>().Update(entity);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public IEnumerable<TEntity> GetAll() => _context.Set<TEntity>().ToList(); 
        public TEntity GetById(int id) => _context.Set<TEntity>().Find(id)!;

        public IEnumerable<TEntity> GetByCondition(Expression<Func<TEntity, bool>> condition)
        {
            return _context.Set<TEntity>().Where(condition).ToList();
        }
    }
}
