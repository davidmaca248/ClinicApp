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
        string _Email, _PhoneNumber;
        public EditAppointmentPopup()
        {
            _Email = GlobalAppointmentDataBase.SelectedAppointment.Email;
            _PhoneNumber = GlobalAppointmentDataBase.SelectedAppointment.PhoneNumber;
            InitializeComponent();
        }

        private void ChangePhone(object sender, RoutedEventArgs e)
        {
            TextBox tb = sender as TextBox;
            _PhoneNumber= tb.Text;
        }

        private void ChangeEmail(object sender, RoutedEventArgs e)
        {
            TextBox tb = sender as TextBox;
            _Email = tb.Text;
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
                GlobalAppointmentDataBase.AppointmentList.RemoveAll(x => x.Id == GlobalAppointmentDataBase.SelectedAppointment.Id);
                GlobalAppointmentDataBase.SelectedAppointment.Id = GlobalAppointmentDataBase.AppointmentList.
                    Where(x => x.StartTime.TimeOfDay < DateTime.Now.TimeOfDay)
                    .OrderBy(o => o.StartTime).ToList().Count + 1;
                GlobalAppointmentDataBase.SelectedAppointment.Status = "Canceled";
                GlobalAppointmentDataBase.DeletedAppointments.Add(GlobalAppointmentDataBase.SelectedAppointment);
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
                // Hardcoded, need to figure out how appointment details will be displayed first. 
                Appointment app = GlobalAppointmentDataBase.SelectedAppointment;
                if (_Email != app.Email || _PhoneNumber != app.PhoneNumber)
                {
                    app.PhoneNumber = _PhoneNumber;
                    app.Email = _Email;
                }
                this.Close();
            }

        }

        private void Reschedule(object sender, RoutedEventArgs e)
        {
            GlobalAppointmentDataBase.Rescheduling = true;
            this.Close();
            Switcher.Switch(new AppointmentBookingTime());
        }
    }
}
