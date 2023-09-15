﻿
using EMS.Business.Models;
using EMS.Data.Models;

namespace EMS.Business.Interfaces
{
    public interface IUserService : IGenericService<UserModel>
    {
        Task<UserModel> AuthenticateUser(string username, string password); 
        Task<IEnumerable<UserModel>> GetUserByUserType(UserType userType);
        Task<User> ChangePassword(int userId, string oldPassword, string newPassword);

    }
}