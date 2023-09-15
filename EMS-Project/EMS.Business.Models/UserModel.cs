


using EMS.Data.Models;

namespace EMS.Business.Models
{
    public class UserModel
    {
        public int UserId { get; set; }
        public string UserName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public UserType UserType { get; set; }
    }
}
