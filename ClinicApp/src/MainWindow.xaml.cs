using ClinicApp.Globals;
using ClinicApp.Views;
using ClinicApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace ClinicApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MainViewModel viewModel;
        public MainWindow()
        {
            viewModel = new MainViewModel();
            this.DataContext = viewModel;
            InitializeComponent();
            Switcher.pageSwitcher = this;
        }
        
        public void Navigate(UserControl nextPage)
        {
            viewModel.SwitchPage(nextPage);
            //(this.FindName("mainContent") as ContentControl).Content = viewModel.CurrentView;
        }
    }
}
