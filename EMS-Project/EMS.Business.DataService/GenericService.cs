using AutoMapper;
using EMS.Business.Interfaces;
using EMS.Data;
using EMS.Data.Interfaces;


namespace EMS.Business.Services
{
    public class GenericService<TEntity> : IGenericService<TEntity> where TEntity : class
    {
        protected readonly EMSDbContext _dbContext;
        protected readonly IUnitOfWork _unitOfWork;
        protected readonly IRepository<TEntity> _repository;
        protected readonly IMapper _mapper;

        public GenericService(IUnitOfWork unitOfWork, IMapper mapper, EMSDbContext dbContext)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _repository = _unitOfWork.GetRepository<TEntity>();
            _mapper = mapper;   
            _dbContext = dbContext;

        }

        public async Task<IEnumerable<TEntity>> GetAll()
        {
            return await _repository.GetAll();
        }

        public async Task<TEntity> GetById(int id)
        {
            return await _repository.GetById(id);
        }

        public async Task<bool> Create(TEntity model)
        {
            _repository.Add(model);
            return await _unitOfWork.SaveChangesAsync() > 0;
        }

        public async Task<bool> Update(TEntity model)
        {
            _repository.Update(model);
            return await _unitOfWork.SaveChangesAsync() > 0;
        }

        public async Task<bool> Delete(int id)
        {
            var entity = await _repository.GetById(id);
            if (entity == null)
            {
                return false; // Entity not found
            }

            _repository.Delete(id);
            return await _unitOfWork.SaveChangesAsync() > 0;
        }
    }
}
