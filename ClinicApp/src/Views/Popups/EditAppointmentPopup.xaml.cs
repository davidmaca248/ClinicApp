using ClinicApp.Globals;
using ClinicApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
    /// Interaction logic for EditAppointmentPopup.xaml
    /// </summary>
    public partial class EditAppointmentPopup : Window
    {
        public EditAppointmentPopup()
        {
            InitializeComponent();
        }

        private void Delete(object sender, RoutedEventArgs e)
        {
            ConfirmDeletePopup confirm = new ConfirmDeletePopup();
            confirm.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            this.Effect = new BlurEffect();
            confirm.ShowDialog();
            this.Effect = null;
            if (GlobalAppointmentDataBase.Confirm)
            {
                GlobalAppointmentDataBase.Confirm= false;
                // Hardcoded, need to figure out how appointment details will be displayed first. 
                GlobalAppointmentDataBase.AppointmentList.RemoveAll(x => x.Id == 0);
                this.Close();
            }
        }

        private void Cancel(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Save(object sender, RoutedEventArgs e)
        {
            SaveChangesPopup confirm = new SaveChangesPopup();
            confirm.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            this.Effect = new BlurEffect();
            confirm.ShowDialog();
            this.Effect = null;
            if (GlobalAppointmentDataBase.Confirm)
            {
                GlobalAppointmentDataBase.Confirm = false;
                // Hardcoded, need to figure out how appointment details will be displayed first. 
                Appointment app = GlobalAppointmentDataBase.AppointmentList.Find(x => x.Id == 0);
                TextBox email = this.FindName("Email") as TextBox;
                TextBox phone = this.FindName("Phone") as TextBox;
                if (email.Text != app.Email || phone.Text != app.PhoneNumber)
                {
                    app.PhoneNumber = phone.Text;
                    app.Email = email.Text;
                }
                this.Close();
            }

        }

        private void Reschedule(object sender, RoutedEventArgs e)
        {
            GlobalAppointmentDataBase.NewAppointment = GlobalAppointmentDataBase.AppointmentList.Find(x => x.Id == 0);
            GlobalAppointmentDataBase.Rescheduling = true;
            // Go to step 2 of add client
            Switcher.Switch(new AppointmentBookingTime());
        }
    }
}
