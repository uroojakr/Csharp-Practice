using Event_Management_System.Models;
using Event_Management_System.Repositories;
using Event_Management_System.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;


    public class UserRepository : Repository<User>, IUserRepositories
    {
        private readonly DbContext _context;
        public UserRepository(EventManagementContext context) : base(context) => _context = context;
        public User Autheticate(string username, string password) => _context.Set<User>().FirstOrDefault(u => u.UserName == username && u.Password == password)!;

    
    public User ChangePassword(int userId, string newPassword)
    {
        var user = _context.Set<User>().FirstOrDefault(u => u.UserId == userId);

        if (user != null)
        {
            user.Password = newPassword;
            
            return user;
        }
        return null!;
    }


    public IEnumerable<User> GetUserByUserType(UserType userType) => _context.Set<User>().Where(ut => ut.UserType == userType);

        public void DeleteRange(IEnumerable<int> userIds)
        {
        var usersToDelete = _context.Set<User>().Where(u => userIds.Contains(u.UserId)).ToList();
        foreach ( var user in usersToDelete)
        {
            _context.Set<User>().Remove(user);
        }
       
        }
    }

