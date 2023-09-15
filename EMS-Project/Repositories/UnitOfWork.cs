using Castle.Components.DictionaryAdapter;
using EMS.Data.Interfaces;
using EMS.Data.Models;
using Microsoft.Extensions.Logging;


namespace EMS.Data
{
    public class UnitOfWork : IUnitOfWork 
    {
        private readonly EMSDbContext _context;
        private readonly ILogger _logger;
        public UnitOfWork(EMSDbContext context, ILogger<UnitOfWork> logger)
        {
            _context = context;
            _logger = logger;

            UserRepository = new Repository<User>(_context, (ILogger<Repository<User>>)_logger);
            EventsRepository = new Repository<Events>(_context, (ILogger<Repository<Events>>)_logger);
            ReviewRepository = new Repository<Review>(_context, (ILogger<Repository<Review>>)_logger);
            TicketRepository = new Repository<Ticket>(_context, (ILogger<Repository<Ticket>>)_logger);
            VendorRepository = new Repository<Vendor>(_context, (ILogger<Repository<Vendor  >>)_logger);
        }


        public IRepository<User> UserRepository { get; }
        public IRepository<Events> EventsRepository { get; }
        public IRepository<Review> ReviewRepository { get; }
        public IRepository<Ticket> TicketRepository { get; }
        public IRepository<Vendor> VendorRepository { get; }

        public async Task<int> SaveChangesAsync()
        {
            try
            {
                return await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{ErrorMessage}", ex.Message);
                throw; 
            }
        }

        public void Dispose()
        {

            _context.Dispose();
        }

        public IRepository  <TEntityModel> GetRepository<TEntityModel>() where TEntityModel : class
        {
            return new Repository<TEntityModel>(_context, (ILogger<Repository<TEntityModel>>)_logger);
        }
    }
}
