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
    /// Interaction logic for HomeContentUC.xaml
    /// </summary>
    public partial class HomeContentUC : UserControl
    {
        private HomeViewModel _viewModel;
        public HomeContentUC()
        {
            _viewModel = new HomeViewModel();
            DataContext = _viewModel;

            InitializeComponent();

        }

        private void PrevButtonClick(object sender, RoutedEventArgs e)
        {
            _viewModel.DisplayedDay = _viewModel.DisplayedDay.AddDays(-1);
        }

        private void NextButtonClick(object sender, RoutedEventArgs e)
        {
            _viewModel.DisplayedDay = _viewModel.DisplayedDay.AddDays(1);
        }


    }
}
