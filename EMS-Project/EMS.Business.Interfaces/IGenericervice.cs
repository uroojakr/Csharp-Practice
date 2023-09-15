

namespace EMS.Business.Interfaces
{
    public interface IGenericService<TEntity> where TEntity : class
    {
        Task<IEnumerable<TEntity>> GetAll();
        Task<TEntity> GetById(int id);
        Task<bool> Create(TEntity model);
        Task<bool> Update(TEntity model);
        Task<bool> Delete(int id);
    }
}
