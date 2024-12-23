﻿using SumCalculatorWpf.Entitites;
using SumCalculatorWpf.Presentation.ViewModels;
using System.Diagnostics;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SumCalculatorWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public UsersViewModel usersViewModel;
        public MainWindow()
        {
            InitializeComponent();
            usersViewModel = new UsersViewModel();
            DataContext = usersViewModel;

            usersViewModel.GetAllUsers();
        }

        private void MenuButton_Click(object sender, RoutedEventArgs e)
        {
            // Get all buttons in the MenuPanel
            var buttons = MenuPanel.Children.OfType<ToggleButton>();

            var checkedButton = (ToggleButton)sender;

            // Uncheck all other buttons
            foreach (var button in buttons)
            {
                if (button != checkedButton)
                {
                    button.IsChecked = false;
                    checkedButton.IsChecked = true;
                }
            }
        }

        private void SidbarButton_Click(object sender, RoutedEventArgs e)
        {
            GridLength tempGridLengthZero = new GridLength(0);
            if(MenuSidebar.Width.Equals(tempGridLengthZero)) 
            {
                MenuSidebar.Width = new GridLength(250);
                return;
            }
            MenuSidebar.Width = tempGridLengthZero;
        }

        private void Button_Click_Delete(object sender, RoutedEventArgs e)
        {
            if (usersListView.SelectedItems[0] is UserInfo selectedUser)
            {
                Debug.WriteLine(selectedUser.Username);
                usersViewModel.DeleteUser(selectedUser.Id);
            }
        }
    }
}