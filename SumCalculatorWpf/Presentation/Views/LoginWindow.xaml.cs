using SumCalculatorWpf.Infrastructure;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace SumCalculatorWpf.Presentation.Views
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window.GetWindow(this).Close();
        }

        private async void BtnLogIn_Click(object sender, RoutedEventArgs e)
        {
            //var hashedBytes = SHA256.HashData(Encoding.UTF8.GetBytes("hej"));
            //Debug.WriteLine(BitConverter.ToString(hashedBytes).Replace("-","").ToLower());

            try
            {
                bool loginSuccess = await CurrentUserSession.LogIn(tbEmail.Text, pbPassword.Password);

                if (loginSuccess)
                {
                    MainWindow mainWindow = new MainWindow();
                    mainWindow.Show();
                    Window.GetWindow(this).Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Login failed. Please check your credentials.",
                    "Login error",
                    MessageBoxButton.YesNo,
                    MessageBoxImage.Warning);
            }
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }
    }
}
