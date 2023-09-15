using Event_Management_System.Models;

public interface ITicketRepositories : IRepository<Ticket>
{
    IQueryable<Ticket> GetTicketsByUserName();
    IQueryable<Ticket> GetTicketsByUserNameFilter(string userNameFilter);
}