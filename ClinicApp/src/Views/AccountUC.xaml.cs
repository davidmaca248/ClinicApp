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
            username2.FontSize = 19;
            username3.FontSize = 19;
            selectedUser = 1;

        }

        private void user2_Click(object sender, RoutedEventArgs e)
        {
            username1.FontSize = 19;
            username2.FontSize = 24;
            username3.FontSize = 19;
            selectedUser = 2;
        }

        private void user3_Click(object sender, RoutedEventArgs e)
        {
            username1.FontSize = 19;
            username2.FontSize = 19;
            username3.FontSize = 24;
            selectedUser = 3;
        }

        private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            switch (selectedUser)
            {
                case 1:
                    if (pbox.Password == user1Password)
                    {
                        _parentViewModel.UserLoggedIn(selectedUser);

                    }
                    break;
                case 2:
                    if (pbox.Password == user2Password)
                    {
                        _parentViewModel.UserLoggedIn(selectedUser);

                    }
                    break;
                case 3:
                    if (pbox.Password == user3Password)
                    {
                        _parentViewModel.UserLoggedIn(selectedUser);
                    }
                    break;
                default:
                    break;
            }

        }
    }
}
