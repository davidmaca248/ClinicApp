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

namespace ClinicApp.Views.Calendar
{
    /// <summary>
    /// Interaction logic for CalendarUC.xaml
    /// </summary>
    public partial class CalendarTabUC : UserControl
    {
        private CalendarTabViewModel _viewModel;
        public CalendarTabUC()
        {
            _viewModel = new CalendarTabViewModel();
            // pass the view Model the 
            DataContext = _viewModel;

            InitializeComponent();

  
        }

    }
}
