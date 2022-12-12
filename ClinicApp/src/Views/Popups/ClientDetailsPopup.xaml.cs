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
    /// Interaction logic for ClientDetailsPopup.xaml
    /// </summary>
    public partial class ClientDetailsPopup : Window
    {
        public ClientDetailsPopup()
        {
            InitializeComponent();
        }

        private void Edit(object sender, RoutedEventArgs e)
        {
            EditClientPopup modal = new EditClientPopup();
            modal.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            modal.ShowDialog();
            if (GlobalAppointmentDataBase.Confirm)
            {
                this.Close();
                Switcher.Switch(new ClientUC());
            }
        }

        private void Close(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void UpcomingAppointments(object sender, RoutedEventArgs e)
        {
            ClientUpcomingAppointment modal = new ClientUpcomingAppointment();
            modal.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            modal.ShowDialog();
            if (GlobalAppointmentDataBase.Rescheduling) 
            { 
                this.Close();
            }
        }
    }
}
