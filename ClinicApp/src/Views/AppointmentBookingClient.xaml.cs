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
using ClinicApp.Globals;
using ClinicApp.Model;
using ClinicApp.Views.Popups;

namespace ClinicApp.Views
{
    /// <summary>
    /// Interaction logic for AppointmentBookingClient.xaml
    /// </summary>
    public partial class AppointmentBookingClient : UserControl
    {
        bool existingClient = false;
        string FirstName = null, LastName = null, Contact = null;
        public AppointmentBookingClient()
        {
            InitializeComponent();
        }

        private void ExistingClient(object sender, RoutedEventArgs e)
        {
            FindClientPopup modal = new FindClientPopup();
            modal.ShowDialog();
        }

        private void NextPage(object sender, RoutedEventArgs e)
        {
            FirstName = (this.FindName("Fname") as TextBox).Text;
            LastName = (this.FindName("Lname") as TextBox).Text;
            Contact = (this.FindName("ContactInfo") as TextBox).Text;
            if (FirstName != string.Empty && LastName != string.Empty && Contact != string.Empty && !existingClient)
            {
                GlobalAppointmentDataBase.AppointmentClient = new Client(FirstName, LastName, Contact);
                // Do this as part of the last step with adding appointment to client
                //GlobalAppointmentDataBase.Clients.Add(GlobalAppointmentDataBase.AppointmentClient);
            }
            if (GlobalAppointmentDataBase.AppointmentClient != null)
                Switcher.Switch(new AppointmentBookingTime());
            else
            {
                // For future: Popup error msg
                Console.WriteLine("Need to select or create new client to continue");
            }
        }

        private void CancelBooking(object sender, RoutedEventArgs e)
        {
            GlobalAppointmentDataBase.AppointmentClient = null;
            GlobalAppointmentDataBase.NewAppointment = null;
            Switcher.Switch(new HomeContentUC());
        }
    }
}
