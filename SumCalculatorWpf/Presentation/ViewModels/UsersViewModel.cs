using SumCalculatorWpf.ApplicationLayer;
using SumCalculatorWpf.Entitites;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumCalculatorWpf.Presentation.ViewModels
{
    public class UsersViewModel
    {
        private readonly IUserService _userService;
        public ObservableCollection<UserInfo> UserList { get; private set; }

        public async Task DeleteUserAsync(string id)
        {
            await _userService.DeleteUserAsync(id);
            var userToRemove = UserList.FirstOrDefault(x => x.Id == id);
            if (userToRemove != null)
            {
                UserList.Remove(userToRemove);
            }
        }

        public async Task UpdateUserAsync(UserInfo user)
        {
            await _userService.UpdateUserAsync(user);
            var userToUpdate = UserList.FirstOrDefault(x => x.Id == user.Id);
            if (userToUpdate != null)
            {
                UserList.Remove(userToUpdate);
                UserList.Add(userToUpdate);
            }
        }

        public async Task GetAllUsers()
        {
            var users = await _userService.GetAllUsersAsync();
            var users = new ObservableCollection<UserInfo>();

        }
    }
}
