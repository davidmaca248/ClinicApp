using ClinicApp.Globals;
using ClinicApp.Model;
using ClinicApp.ViewModel;
using ClinicApp.Views.Popups;
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
using System.Windows.Media.Effects;
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

            Console.WriteLine(GlobalAppointmentDataBase.SelectedAppointment.Name);
            Console.WriteLine(GlobalAppointmentDataBase.SelectedAppointment.Duration);
            Console.WriteLine(GlobalAppointmentDataBase.SelectedAppointment.DoctorName);
            Console.WriteLine(GlobalAppointmentDataBase.SelectedAppointment.Time);
            Console.WriteLine(GlobalAppointmentDataBase.SelectedAppointment.Date);
            Console.WriteLine(GlobalAppointmentDataBase.SelectedAppointment.Description);
        }

        private void PrevButtonClick(object sender, RoutedEventArgs e)
        {
            _viewModel.DisplayedDay = _viewModel.DisplayedDay.AddDays(-1);
        }

        private void NextButtonClick(object sender, RoutedEventArgs e)
        {
            _viewModel.DisplayedDay = _viewModel.DisplayedDay.AddDays(1);
        }

        private void RowDoubleClick(object sender, MouseButtonEventArgs e)
        {
            DataGridRow row = (DataGridRow)sender;
            GlobalAppointmentDataBase.SelectedAppointment = (Appointment)row.Item;
            AppointmentDetailsPopup modal = new AppointmentDetailsPopup();
            modal.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            Switcher.pageSwitcher.Effect = new BlurEffect();
            modal.ShowDialog();
            Switcher.pageSwitcher.Effect = null;
        }

    }
}
