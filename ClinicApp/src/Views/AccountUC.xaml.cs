using ClinicApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static ClinicApp.Views.AccountTabUC;


namespace ClinicApp.Views
{
    /// <summary>
    /// Interaction logic for AccountUC.xaml
    /// </summary>
    public partial class AccountUC : UserControl
    {
        int selectedUser = 0;
        private readonly AccountTabViewModel _parentViewModel;


        String user1Password = "111111";
        String user2Password = "222222";
        String user3Password = "333333";
        public AccountUC()
        {
            InitializeComponent();
        }
        public AccountUC(AccountTabViewModel parentViewModel)
        {
            _parentViewModel = parentViewModel;
            InitializeComponent();
        }

        private void user1_Click(object sender, RoutedEventArgs e)
        {
            username1.FontSize = 24;

            username2.FontSize = 20;
            username3.FontSize = 20;

            userbutton1.Height = 160;
            userbutton1.Width = 160;
            userbutton2.Height = 150;
            userbutton2.Width = 150;
            userbutton3.Height = 150;
            userbutton3.Width = 150;

            selectedUser = 1;

        }

        private void user2_Click(object sender, RoutedEventArgs e)
        {
            username1.FontSize = 19;
            username2.FontSize = 24;
            username3.FontSize = 20;

            userbutton1.Height = 150;
            userbutton1.Width = 150;
            userbutton2.Height = 160;
            userbutton2.Width = 160;
            userbutton3.Height = 150;
            userbutton3.Width = 150;
            selectedUser = 2;
        }

        private void user3_Click(object sender, RoutedEventArgs e)
        {
            username1.FontSize = 19;
            username2.FontSize = 19;
            username3.FontSize = 24;

            userbutton1.Height = 150;
            userbutton1.Width = 150;
            userbutton2.Height = 150;
            userbutton2.Width = 150;
            userbutton3.Height = 160;
            userbutton3.Width = 160;

            selectedUser = 3;
        }
        private void OnKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key != Key.Return && e.Key != Key.Enter)
                return;
            e.Handled = true;
            
            switch (selectedUser)
            {
                case 1:
                    if (pbox.Password == user1Password)
                    {

                        _parentViewModel.UserLoggedIn(1);
                    }
                    else
                    {
                        wrongPassword();
                    }
                    break;
                case 2:
                    if (pbox.Password == user2Password)
                    {

                        _parentViewModel.UserLoggedIn(2);
                    }
                    else
                    {
                        wrongPassword();
                    }
                    break;
                case 3:
                    if (pbox.Password == user3Password)
                    {
                        _parentViewModel.UserLoggedIn(3);
                    }
                    else
                    {
                        wrongPassword();
                    }
                    break;
                default:
                    
                    break;
            }


        }

        private void wrongPassword()
        {
            if (pbox.Password.Length > 0)
            {
                Window win = new Window();
                win.Content = "Error: Wrong password";
                win.Title = "ERROR";
                win.Width = 140;
                win.Height = 60;
                win.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                win.Show();
                pbox.Clear();
            }

        }
        
    }
}
