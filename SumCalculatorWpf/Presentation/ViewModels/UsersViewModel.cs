using SumCalculatorWpf.ApplicationLayer;
using SumCalculatorWpf.Entitites;
using SumCalculatorWpf.Infrastructure;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumCalculatorWpf.Presentation.ViewModels
{
    public class UsersViewModel : INotifyPropertyChanged
    {
        private readonly UserRepository userService = new();

        private ObservableCollection<UserInfo> _users;
        public ObservableCollection<UserInfo> Users
        {
            get => _users;
            set
            {
                _users = value;
                OnPropertyChanged(nameof(Users));
            }
        }

        public UsersViewModel()
        {
            Users = new ObservableCollection<UserInfo>();
        }

        public async Task DeleteUser(string id)
        {
            await userService.DeleteUser(id);
            var userToRemove = Users.FirstOrDefault(x => x.Id == id);
            if (userToRemove != null)
            {
                Users.Remove(userToRemove);
            }
        }

        public async Task UpdateUser(UserInfo user)
        {
            await userService.UpdateUser(user);
            var userToUpdate = Users.FirstOrDefault(x => x.Id == user.Id);
            if (userToUpdate != null)
            {
                Users.Remove(userToUpdate);
                Users.Add(userToUpdate);
            }
        }

        public async Task GetAllUsers()
        {
            Users.Clear();
            var items = await userService.GetAllUsers();
            foreach (var item in items)
            {
                Users.Add(item);
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
