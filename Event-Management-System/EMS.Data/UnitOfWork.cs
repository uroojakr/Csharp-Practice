
using EMS.Data.Interfaces;
using Event_Management_System.Repositories;
using Event_Management_System.Repositories.Interfaces;
using Event_Management_System.Repositories.Services;
using Microsoft.EntityFrameworkCore.Storage;
using System.Data;

namespace EMS.Data
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly EventManagementContext _context;
        private IDbTransaction _transaction;
        private IEventRepository _eventRepository;
        private IReviewRepositories _reviewRepository;
        private ITicketRepositories _ticketRepository;
        private IVendorEventRepositories _vendorEventRepository;
        private IVendorRepositories _vendorrepositories;
        private IUserRepositories _userRepository;

        //dictionary to store repositories by entity type 
        private readonly Dictionary<Type, object> _repositories = new Dictionary<Type, object>();

        public UnitOfWork(EventManagementContext context) => _context = context;

        public IEventRepository EventRepository { get {  return _eventRepository ??= new EventRepository(_context); } } //if null set new instance
        public IUserRepositories UserRepositories { get { return _userRepository ??= new UserRepository(_context); } }
        public IReviewRepositories ReviewRepositories { get { return _reviewRepository ??= new ReviewRepository(_context); } }
        public ITicketRepositories TicketRepositories { get { return _ticketRepository ??= new TicketRepository(_context); } }
        public IVendorRepositories VendorRepositories { get { return _vendorrepositories ??= new VendorRepository(_context); } }
        public IVendorEventRepositories VendorEventRepositories { get { return _vendorEventRepository ??= new VendorEventRepository(_context); } }

        public IDbContextTransaction BeginTransaction()
        {
            if (_transaction == null)
            {
                _transaction = (IDbTransaction?)_context.Database.BeginTransaction()!;
            }
            return (IDbContextTransaction)_transaction!;
        }


        public bool Commit()
        {
            if(_transaction !=null)
            {
                _transaction.Commit();
                _transaction.Dispose();
                _transaction = null!;
                return true;
            }
            else
            {
                return false;
            }

        }

        public void Dispose()
        {
            if(_transaction != null )
            {
                _transaction.Dispose();
            }
            _context.Dispose();
        }

        //ensures to create and cache one instance of each repository per entity type
        public IRepository<TEntity> GetRepository<TEntity>() where TEntity : class
        {
            var entityType = typeof(TEntity);

            if (_repositories.ContainsKey(entityType))
            {
                return (IRepository<TEntity>)_repositories[entityType];
            }

            var repository = new Repository<TEntity>(_context);
            _repositories.Add(entityType, repository);
            return repository;
        }
    }
}
