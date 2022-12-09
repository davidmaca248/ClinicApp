using ClinicApp.Globals;
using ClinicApp.Model;
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
    /// Interaction logic for EditClientPopup.xaml
    /// </summary>
    public partial class EditClientPopup : Window
    {
        public EditClientPopup()
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
                // Hardcoded, need to figure out how appointment details will be displayed first. 
                GlobalAppointmentDataBase.Clients.RemoveAll(x => x.PersonId == GlobalAppointmentDataBase.SelectedClient.PersonId);
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
                /*Appointment app = GlobalAppointmentDataBase.SelectedAppointment;
                if (_Email != app.Email || _PhoneNumber != app.PhoneNumber)
                {
                    app.PhoneNumber = _PhoneNumber;
                    app.Email = _Email;
                }*/
                this.Close();
            }
        }
    }
}
