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
    /// Interaction logic for HistoryUC.xaml
    /// </summary>
    public partial class HistoryUC : UserControl
    {
        public HistoryUC()
        {
            _viewModel = new HistoryViewModel();
            InitializeComponent();
        }

        private void RowDoubleClick(object sender, RoutedEventArgs e)
        {

        }

        private void Search(object sender, RoutedEventArgs e)
        {
            TextBox query = sender as TextBox;
            _viewModel.updateContent(query.Text.ToUpper());
        }
    }
}
