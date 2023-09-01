public interface IRepository<TEntity> where TEntity : class
{
    void Add(TEntity entity);
    IEnumerable<TEntity> GetAll();
    TEntity GetById(int id);
    void Update(TEntity entity);
    void Delete(int id);
}
