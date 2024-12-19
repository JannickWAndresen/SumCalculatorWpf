using SumCalculatorWpf.ApplicationLayer;
using SumCalculatorWpf.Entitites;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumCalculatorWpf.Infrastructure
{
    internal class UserRepository : IUserService
    {
        public async Task DeleteUserAsync(string userId)
        {
            HttpClientService service = new HttpClientService();
            try
            {
                var response = await service.DeleteAsync<object>("https://localhost:7214/api/users", userId);
            }
            catch
            {
                Debug.WriteLine("error happened while trying to delete!");
            }
        }

        public Task GetAllUsersAsync()
        {
            HttpClientService service = new HttpClientService();
            try
            {
                var response = service.GetAsync<object>("https://localhost:7214/api/users");

            }
            catch
            {
                Debug.WriteLine("error happened while trying to delete!");
            }
        }

        public Task GetUserByIdAsync(string userId)
        {
            throw new NotImplementedException();
        }

        public Task UpdateUserAsync(UserInfo user)
        {
            throw new NotImplementedException();
        }
    }
}
