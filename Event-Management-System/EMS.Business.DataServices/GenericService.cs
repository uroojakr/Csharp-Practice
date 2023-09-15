

using EMS.Data.Interfaces;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.EntityFrameworkCore.Storage;
using System.Linq.Expressions;

namespace EMS.Business.DataServices
{
    public class GenericService<TEntity> where TEntity : class
    {
        private readonly IRepository<TEntity> _repository;
        private readonly IUnitOfWork _unitOfWork;

        public GenericService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _repository = _unitOfWork.GetRepository<TEntity>();
        }
        public IEnumerable<TEntity> GetAll() 
        {
            return _repository.GetAll();
        }

        public TEntity GetbyID(int id) 
        {
            return _repository.GetById(id);
        }
        public IEnumerable<TEntity> GetByCondition(Expression<Func<TEntity, bool>> condition)
        {
            return _repository.GetByCondition(condition);
        }

        public void Add(TEntity entity) 
        {
            _repository.Add(entity);
            _unitOfWork.Commit();
        }

        public void Update(TEntity entity) 
        {
            _repository.Update(entity);
            _unitOfWork.Commit();
        }

        public void Delete(int id) 
        {
            _repository.Delete(id);
            _unitOfWork.Commit();
        }

        public IDbContextTransaction BeginTransaction()
        {
            return _unitOfWork.BeginTransaction();
        }
    }
}
