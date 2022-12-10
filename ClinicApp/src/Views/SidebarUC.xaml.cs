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
using ClinicApp.Views.Popups;
using ClinicApp.Model;
using ClinicApp.Globals;
using ClinicApp.ViewModel;

namespace ClinicApp.Views
{
    /// <summary>
    /// Interaction logic for SideBarUC.xaml
    /// </summary>
    public partial class SideBarUC : UserControl
    {
        SideBarViewModel viewModel;
        public SideBarUC()
        {
            viewModel = new SideBarViewModel();
            DataContext = viewModel;
            InitializeComponent();
        }

        private void addClientModal(object sender, RoutedEventArgs e)
        {
            AddClientPopup modal = new AddClientPopup();
            modal.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            Switcher.pageSwitcher.Effect = new BlurEffect();
            modal.ShowDialog();
            Switcher.pageSwitcher.Effect = null;
        }

        private void addDoctorModal(object sender, RoutedEventArgs e)
        {
            AddDoctorPopup modal = new AddDoctorPopup();
            modal.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            Switcher.pageSwitcher.Effect = new BlurEffect();
            modal.ShowDialog();
            Switcher.pageSwitcher.Effect = null;
        }

        private void AddAppointmentButton(object sender, RoutedEventArgs e)
        {
            GlobalAppointmentDataBase.Rescheduling = false;
            Switcher.Switch(new AppointmentBookingClient());
        }

        private void ShowAppointmentDetails(object sender, RoutedEventArgs e)
        {
            StackPanel row = (StackPanel)sender;
            TextBlock name = row.FindName("Name") as TextBlock;
            TextBlock doctorName = row.FindName("DoctorName") as TextBlock;
            GlobalAppointmentDataBase.SelectedAppointment = GlobalAppointmentDataBase.AppointmentList.Find(x => x.Name == name.Text && x.DoctorName == doctorName.Text);
            AppointmentDetailsPopup modal = new AppointmentDetailsPopup();
            modal.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            Switcher.pageSwitcher.Effect = new BlurEffect();
            modal.ShowDialog();
            Switcher.pageSwitcher.Effect = null;
            Switcher.Switch(new HomeContentUC());
        }
    }
}


