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
    /// Interaction logic for EditDoctor.xaml
    /// </summary>
    public partial class EditDoctor : Window
    {
        Doctor ModifiedDoctor = new Doctor();
        public EditDoctor()
        {
            InitializeComponent();
            
            ModifiedDoctor.DateOfBirth = GlobalAppointmentDataBase.SelectedDoctor.DateOfBirth;
            ModifiedDoctor.AcceptingPatients = GlobalAppointmentDataBase.SelectedDoctor.AcceptingPatients;
        }

        private void SetTakingPatients(object sender, RoutedEventArgs e)
        {
            ComboBox takingPatients = sender as ComboBox;
            ModifiedDoctor.AcceptingPatients = takingPatients.Text;
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
                ModifiedDoctor.PersonId = GlobalAppointmentDataBase.SelectedClient.PersonId;
                TextBox Firstname = this.FindName("Fname") as TextBox;
                TextBox Lastname = this.FindName("Lname") as TextBox;
                TextBox email = this.FindName("Email") as TextBox;
                TextBox phone = this.FindName("Phone") as TextBox;
                TextBox pracId = this.FindName("PracId") as TextBox;

                ModifiedDoctor.FirstName = Firstname.Text;
                ModifiedDoctor.LastName = Lastname.Text;
                ModifiedDoctor.Email = email.Text;
                ModifiedDoctor.PhoneNumber = phone.Text;
                ModifiedDoctor.PractionerId = Int32.Parse(pracId.Text);

                if (ModifiedDoctor != GlobalAppointmentDataBase.SelectedDoctor)
                {
                    foreach (Appointment app in GlobalAppointmentDataBase.SelectedClient.Appointments)
                    {
                        app.Name = ModifiedDoctor.FirstName + " " + ModifiedDoctor.LastName;
                        app.Email = ModifiedDoctor.Email;
                        app.PhoneNumber = ModifiedDoctor.PhoneNumber;
                    }
                }

                GlobalAppointmentDataBase.SelectedDoctor = ModifiedDoctor;
                this.Close();
            }
        }

        private void Cancel(object sender, RoutedEventArgs e)
        {
            this.Close();
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
                GlobalAppointmentDataBase.Doctors.RemoveAll(x => x.PersonId == GlobalAppointmentDataBase.SelectedDoctor.PersonId);
                this.Close();
            }
        }
    }
}
