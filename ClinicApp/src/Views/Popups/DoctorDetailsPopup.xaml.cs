using ClinicApp.Globals;
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
    /// Interaction logic for DoctorDetailsPopup.xaml
    /// </summary>
    public partial class DoctorDetailsPopup : Window
    {
        public DoctorDetailsPopup()
        {
            InitializeComponent();
        }

        private void UpcomingAppointments(object sender, RoutedEventArgs e)
        {
            GlobalAppointmentDataBase.IsDoctor = true;
            DoctorUpcomingApps modal = new DoctorUpcomingApps();
            modal.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            modal.ShowDialog();
            if (GlobalAppointmentDataBase.Rescheduling)
                this.Close();
        }

        private void Edit(object sender, RoutedEventArgs e)
        {
            EditDoctor modal = new EditDoctor();
            modal.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            modal.ShowDialog();
            if (GlobalAppointmentDataBase.Confirm)
            {
                this.Close();
                Switcher.Switch(new DoctorUC());
            }
        }

        private void Close(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
