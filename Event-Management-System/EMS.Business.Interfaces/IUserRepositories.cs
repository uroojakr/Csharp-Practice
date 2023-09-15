

using Event_Management_System.Models;

namespace Event_Management_System.Repositories.Interfaces
{
    public  interface IUserRepositories : IRepository<User>
    {
        User Autheticate(string username, string password); 
        IEnumerable<User> GetUserByUserType(UserType userType);
        User ChangePassword(int userId,string newPassword);
        public void DeleteRange(IEnumerable<int> userIds);
    }
}
