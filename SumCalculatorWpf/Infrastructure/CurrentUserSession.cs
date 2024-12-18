using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Text.Json;
using System.Threading.Tasks;
using SumCalculatorWpf.Entitites;
using System.Diagnostics;

namespace SumCalculatorWpf.Infrastructure
{
    public class CurrentUserSession
    {
        private static CurrentUserSession _instance;

        private static CurrentUser _currentUser;

        private CurrentUserSession() { }

        public static CurrentUserSession Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new CurrentUserSession();
                }
                return _instance;
            }
        }

        public static async Task<bool> LogIn(string name, string pwd)
        {
            HttpClientService httpClientService = new HttpClientService();
            _currentUser = await httpClientService.PostAsync<CurrentUser>("https://localhost:7214/api/users/login", new { username = name, password = pwd});

            Debug.WriteLine(_currentUser.User.FirstName);
            if(_currentUser.Token != null)
            {
                return true;
            }
            return false;
        }
    }
}
