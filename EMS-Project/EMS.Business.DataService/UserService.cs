

using AutoMapper;
using EMS.Business.Interfaces;
using EMS.Business.Models;
using EMS.Business.Services;
using EMS.Data;
using EMS.Data.Interfaces;
using EMS.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace EMS.Business.DataService
{
    public class UserService : GenericService<UserModel>, IUserService
    {
        public UserService(IUnitOfWork unitOfWork, IMapper mapper, EMSDbContext dbContext) : base(unitOfWork, mapper, dbContext)
        {
        }

        public async Task<UserModel> AuthenticateUser(string username, string password)
        {
           var user = await _dbContext.Users.FirstOrDefaultAsync( u => u.UserName == username && u.Password == password);
            if (user == null) 
            {
                return _mapper.Map<UserModel>(user);
            }
            return null!; //authentication failed.
        }

        public async Task<User> ChangePassword(int userId, string oldPassword, string newPassword)
        {
            var user = await _dbContext.Users.FirstOrDefaultAsync(u => u.UserId == userId);
            if( user != null ) 
            {
                if(user.Password == oldPassword)
                {
                    user.Password = newPassword;
                    await _unitOfWork.SaveChangesAsync();
                    return user;
                }
            }
            return null!; //error
        }

        public async Task<IEnumerable<UserModel>> GetUserByUserType(UserType userType)
        {
            var users = await _dbContext.Users.Where( u => u.UserType == userType).ToListAsync();
            return _mapper.Map<IEnumerable<UserModel>>(users);
        }
    }
}
