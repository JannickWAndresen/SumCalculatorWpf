using SumCalculatorWpf.Entitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumCalculatorWpf.ApplicationLayer
{
    internal interface IUserService
    {
        Task DeleteUser(string userId);
        Task UpdateUser(UserInfo user);
        Task<List<UserInfo>> GetAllUsers();
        Task GetUserById(string userId);
    }
}
