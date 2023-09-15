
using System.Linq.Expressions;

namespace EMS.Data.Interfaces
{
    public interface IRepository<TEntity> where TEntity : class
    {
        Task<IEnumerable<TEntity>> GetAll();
        IQueryable<TEntity> GetQuery(Expression<Func<TEntity, bool>> predicate);
        Task<IEnumerable<TEntity>> GetWithInclude(Expression<Func<TEntity, bool>> predicate, string include);
        Task<TEntity> GetById(int id);

        bool Add(TEntity entity);
        bool AddRange(IEnumerable<TEntity> entities);
        bool Update(TEntity entity);
        bool Delete(int id);
    }

}
