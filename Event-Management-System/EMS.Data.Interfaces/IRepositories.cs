using System.Linq.Expressions;

public interface IRepository<TEntity> where TEntity : class
{
    bool Add(TEntity entity);
    IEnumerable<TEntity> GetAll();
    TEntity GetById(int id);
    bool Update(TEntity entity); 
    bool Delete(int id);
    IEnumerable<TEntity> GetByCondition(Expression<Func<TEntity, bool>> condition);
}
