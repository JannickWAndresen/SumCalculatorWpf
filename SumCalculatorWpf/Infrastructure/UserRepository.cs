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
    public class UserRepository : IUserService
    {
        public async virtual Task DeleteUser(string userId)
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

        public async Task<List<UserInfo>> GetAllUsers()
        {
            HttpClientService service = new HttpClientService();
            try
            {
                return await service.GetAsync<List<UserInfo>>("https://localhost:7214/api/users");

            }
            catch
            {
                Debug.WriteLine("error happened while trying to delete!");
                return new List<UserInfo>();
            }
        }

        public virtual Task GetUserById(string userId)
        {
            throw new NotImplementedException();
        }

        public virtual Task UpdateUser(UserInfo user)
        {
            throw new NotImplementedException();
        }
    }
}
