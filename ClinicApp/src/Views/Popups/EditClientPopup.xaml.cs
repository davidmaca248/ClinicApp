using ClinicApp.Globals;
using ClinicApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
        Client ModifiedClient;
        public EditClientPopup()
        {
            InitializeComponent();
            ModifiedClient = new Client();
            ModifiedClient.FamilyDoctor = GlobalAppointmentDataBase.SelectedClient.FamilyDoctor;
            ModifiedClient.DateOfBirth = GlobalAppointmentDataBase.SelectedClient.DateOfBirth;
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
                ModifiedClient.PersonId = GlobalAppointmentDataBase.SelectedClient.PersonId;
                TextBox Firstname = this.FindName("Fname") as TextBox;
                TextBox Lastname = this.FindName("Lname") as TextBox;
                TextBox email = this.FindName("email") as TextBox;
                TextBox phone = this.FindName("phone") as TextBox;
                TextBox hcnum = this.FindName("HCNum") as TextBox;
                ComboBox familydoctor = this.FindName("FamilyDoctor") as ComboBox;

                ModifiedClient.FirstName = Firstname.Text;
                ModifiedClient.LastName = Lastname.Text;
                ModifiedClient.Email = email.Text;
                ModifiedClient.PhoneNumber= phone.Text;
                ModifiedClient.HealthCareNumber = hcnum.Text;
                if (ModifiedClient != GlobalAppointmentDataBase.SelectedClient)
                {
                    foreach (Appointment app in GlobalAppointmentDataBase.SelectedClient.Appointments) {
                        app.Name = ModifiedClient.FirstName + " " + ModifiedClient.LastName;
                        app.Email = ModifiedClient.Email;
                        app.PhoneNumber = ModifiedClient.PhoneNumber;
                    }
                }

                GlobalAppointmentDataBase.SelectedClient.FirstName = ModifiedClient.FirstName;
                GlobalAppointmentDataBase.SelectedClient.LastName = ModifiedClient.LastName;
                GlobalAppointmentDataBase.SelectedClient.Email = ModifiedClient.Email;
                GlobalAppointmentDataBase.SelectedClient.PhoneNumber = ModifiedClient.PhoneNumber;
                GlobalAppointmentDataBase.SelectedClient.HealthCareNumber = ModifiedClient.HealthCareNumber;
                GlobalAppointmentDataBase.SelectedClient.FamilyDoctor = ModifiedClient.FamilyDoctor;
                this.Close();
            }
        }

        private void SetFamilyDoctor(object sender, RoutedEventArgs e)
        {
            ComboBox familydoc = sender as ComboBox;
            Doctor item = familydoc.SelectedItem as Doctor;
            ModifiedClient.FamilyDoctor = GlobalAppointmentDataBase.Doctors.Find(x => x == item);
        }

    }
}
