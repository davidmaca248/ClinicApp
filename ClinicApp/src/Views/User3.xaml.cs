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

namespace ClinicApp.Views
{
    /// <summary>
    /// Interaction logic for User3.xaml
    /// </summary>
    public partial class User3 : UserControl
    {
        public AccountContentViewModel ViewModel;
        private readonly AccountTabViewModel _parentViewModel;

        public User3(AccountTabViewModel parentViewModel)
        {
            _parentViewModel = parentViewModel;
            ViewModel = new AccountContentViewModel();
            DataContext = ViewModel;

            InitializeComponent();
        }
        private void logOut(object sender, RoutedEventArgs e)
        {
            _parentViewModel.UserLoggedOut();

        }
    }
}
