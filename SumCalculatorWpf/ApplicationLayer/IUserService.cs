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
        Task DeleteUserAsync(string userId);
        Task UpdateUserAsync(UserInfo user);
        Task GetAllUsersAsync();
        Task GetUserByIdAsync(string userId);
    }
}
