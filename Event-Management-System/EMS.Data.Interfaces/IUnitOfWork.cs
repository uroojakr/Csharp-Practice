using Event_Management_System.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore.Storage;

namespace EMS.Data.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<TEntity> GetRepository<TEntity>() where TEntity : class;
        IEventRepository EventRepository { get; }
        IUserRepositories UserRepositories { get; }
        IReviewRepositories ReviewRepositories { get; }
        ITicketRepositories TicketRepositories { get; }
        IVendorRepositories VendorRepositories { get; }
        IVendorEventRepositories VendorEventRepositories { get; }

        IDbContextTransaction BeginTransaction();
        bool Commit();
       
    }
}
