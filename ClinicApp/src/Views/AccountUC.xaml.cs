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

namespace ClinicApp.Views
{
    /// <summary>
    /// Interaction logic for AccountUC.xaml
    /// </summary>
    public partial class AccountUC : UserControl
    {
        public UserControl AccountLogUC { get; set; }
        int selectedUser = 0;



        String user1Password = "111111";
        String user2Password = "222222";
        String user3Password = "333333";

        public AccountUC()
        {
            InitializeComponent();
        }

        private void user1_Click(object sender, RoutedEventArgs e)
        {
            username1.FontSize = 24;
            username2.FontSize = 20;
            username3.FontSize = 20;
            selectedUser = 1;
        }

        private void user2_Click(object sender, RoutedEventArgs e)
        {
            username1.FontSize = 20;
            username2.FontSize = 24;
            username3.FontSize = 20;
            selectedUser = 2;
        }

        private void user3_Click(object sender, RoutedEventArgs e)
        {
            username1.FontSize = 20;
            username2.FontSize = 20;
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
                        contentgrid.Children.Clear();
                    }
                    break;
                case 2:
                    if (pbox.Password == user2Password)
                    {
                        contentgrid.Children.Clear();

                    }
                    break;
                case 3:
                    if (pbox.Password == user3Password)
                    {
                        contentgrid.Children.Clear();
                    }
                    break;
                default:
                    break;
            }

        }
    }
}
