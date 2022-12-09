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
using ClinicApp.Globals;
using ClinicApp.Model;
using ClinicApp.ViewModel;
using ClinicApp.Views.Popups;

namespace ClinicApp.Views
{
    /// <summary>
    /// Interaction logic for AppointmentBookingClient.xaml
    /// </summary>
    public partial class AppointmentBookingClient : UserControl
    {
        //AppointmentViewModel viewModel;
        bool existingClient = false;
        string FirstName = string.Empty, LastName = string.Empty, Contact = string.Empty;
        public AppointmentBookingClient()
        {
            //viewModel = new AppointmentViewModel();
            InitializeComponent();
        }

        private void ExistingClient(object sender, RoutedEventArgs e)
        {
            GlobalAppointmentDataBase.NewClient = false;
            FindClientPopup modal = new FindClientPopup();
            modal.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            Switcher.pageSwitcher.Effect = new BlurEffect();
            modal.ShowDialog();
            Switcher.pageSwitcher.Effect = null;
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            FirstName = (this.FindName("Fname") as TextBox).Text;
            LastName = (this.FindName("Lname") as TextBox).Text;
            Contact = (this.FindName("ContactInfo") as TextBox).Text;
            if (FirstName != string.Empty && LastName != string.Empty && Contact != string.Empty && !existingClient)
            {
                GlobalAppointmentDataBase.AppointmentClient = new Client(GlobalAppointmentDataBase.Clients.Count+1, FirstName, LastName, Contact);
                GlobalAppointmentDataBase.NewClient = true;
                // Do this as part of the last step with adding appointment to client
                // b/c they may not complete booking
                //GlobalAppointmentDataBase.Clients.Add(GlobalAppointmentDataBase.AppointmentClient);
            }
            if (GlobalAppointmentDataBase.AppointmentClient.FirstName != string.Empty)
            { 
                GlobalAppointmentDataBase.NewAppointment.Client = GlobalAppointmentDataBase.AppointmentClient;
                Switcher.Switch(new AppointmentBookingTime());
            }

            else
            {
                TextBlock error = this.FindName("errormsg") as TextBlock;
                error.Visibility = Visibility.Visible;
            }
        }

        private void To_Date(object sender, RoutedEventArgs e)
        {
            if (GlobalAppointmentDataBase.NewAppointment.Duration != 0)
            {
                Switcher.Switch(new AppointmentBookingDate());
            }
        }

        private void NextPage(object sender, RoutedEventArgs e)
        {
            FirstName = (this.FindName("Fname") as TextBox).Text;
            LastName = (this.FindName("Lname") as TextBox).Text;
            Contact = (this.FindName("ContactInfo") as TextBox).Text;
            if (FirstName != string.Empty && LastName != string.Empty && Contact != string.Empty && !existingClient)
            {
                GlobalAppointmentDataBase.AppointmentClient = new Client(GlobalAppointmentDataBase.Clients.Count + 1, FirstName, LastName, Contact);
                GlobalAppointmentDataBase.NewClient = true;
                // Do this as part of the last step with adding appointment to client
                //GlobalAppointmentDataBase.Clients.Add(GlobalAppointmentDataBase.AppointmentClient);
            }
            if (GlobalAppointmentDataBase.AppointmentClient.FirstName != string.Empty)
            {
                GlobalAppointmentDataBase.NewAppointment.Client = GlobalAppointmentDataBase.AppointmentClient;
                Switcher.Switch(new AppointmentBookingTime());
            }
                
            else
            {
                TextBlock error = this.FindName("errormsg") as TextBlock;
                error.Visibility = Visibility.Visible;
            }
        }

        private void CancelBooking(object sender, RoutedEventArgs e)
        {
            GlobalAppointmentDataBase.AppointmentClient = new Client();
            GlobalAppointmentDataBase.NewAppointment = new Appointment();
            GlobalAppointmentDataBase.NewClient = false;
            Switcher.Switch(new HomeContentUC());
        }
    }
}
