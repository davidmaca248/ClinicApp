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
    /// Interaction logic for AccountTabUC.xaml
    /// </summary>
    public partial class AccountTabUC : UserControl
    {
        private AccountTabViewModel _viewModel;
        public AccountTabUC()
        {
            _viewModel = new AccountTabViewModel();
            // pass the view Model the 
            DataContext = _viewModel;
            InitializeComponent();
        }
    }
}
