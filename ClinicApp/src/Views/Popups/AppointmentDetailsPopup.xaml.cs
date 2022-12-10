using ClinicApp.Globals;
using ClinicApp.Model;
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
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ClinicApp.Views.Popups
{
    /// <summary>
    /// Interaction logic for AppointmentDetailsPopup.xaml
    /// </summary>
    public partial class AppointmentDetailsPopup : Window
    {
        AppointmentDetailsViewModel viewModel;
        public AppointmentDetailsPopup()
        {
            viewModel = new AppointmentDetailsViewModel();
            DataContext = viewModel;
            InitializeComponent();
        }

        private void Close(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Reschedule(object sender, RoutedEventArgs e)
        {
            GlobalAppointmentDataBase.Rescheduling = true;
            this.Close();
            Switcher.Switch(new AppointmentBookingTime());
        }

        private void Edit(object sender, RoutedEventArgs e)
        {
            EditAppointmentPopup modal = new EditAppointmentPopup();
            modal.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            modal.ShowDialog();
            if (GlobalAppointmentDataBase.Rescheduling)
                this.Close();
            if (GlobalAppointmentDataBase.Confirm)
            {
                GlobalAppointmentDataBase.Confirm = false;
                this.Close();
            }
            viewModel.update();
        }
    }
}
