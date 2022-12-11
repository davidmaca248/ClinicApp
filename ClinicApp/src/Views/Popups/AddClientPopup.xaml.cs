using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using ClinicApp.Globals;
using ClinicApp.Model;

namespace ClinicApp.Views.Popups
{
    /// <summary>
    /// Interaction logic for AddClientPopup.xaml
    /// </summary>
    public partial class AddClientPopup : Window
    {
        Client NewClient = new Client();
        public AddClientPopup()
        {
            InitializeComponent();
        }

        public void _CalendarOpened(object sender, RoutedEventArgs e)
        {
            DatePicker datepicker = (DatePicker)sender;
            Popup popup = (Popup)datepicker.Template.FindName("PART_Popup", datepicker);
            System.Windows.Controls.Calendar cal = (System.Windows.Controls.Calendar)popup.Child;
            cal.DisplayMode = System.Windows.Controls.CalendarMode.Decade;

        }

        public void SetDateOfBirth(object sender, RoutedEventArgs e)
        {
            DatePicker datePicker = (DatePicker)sender;
            NewClient.DateOfBirth = (DateTime)datePicker.SelectedDate;
        }

        private void Close(object sender, RoutedEventArgs e)
        {
            NewClient = new Client();
            this.Close();
        }

        private void Add(object sender, RoutedEventArgs e)
        {
            TextBox Firstname = this.FindName("Fname") as TextBox;
            TextBox Lastname = this.FindName("Lname") as TextBox;
            TextBox email = this.FindName("Email") as TextBox;
            TextBox phone = this.FindName("Phone") as TextBox;
            TextBox hcnum = this.FindName("HCNum") as TextBox;
            ComboBox familydoctor = this.FindName("FamilyDoctor") as ComboBox;
            Doctor familydoc = familydoctor.SelectedItem as Doctor;
            NewClient.FirstName = Firstname.Text;
            NewClient.LastName = Lastname.Text;
            NewClient.Email = email.Text;
            NewClient.PhoneNumber = phone.Text;
            if (hcnum.Text != string.Empty)
                NewClient.HealthCareNumber = hcnum.Text;
            NewClient.FamilyDoctor = GlobalAppointmentDataBase.Doctors.Find(x => x == familydoc);
            if (NewClient.FamilyDoctor == null) NewClient.FamilyDoctor = new Doctor();

            if (NewClient.FirstName != string.Empty && NewClient.LastName != string.Empty && NewClient.PhoneNumber != string.Empty)
            {
                NewClient.PersonId = GlobalAppointmentDataBase.Clients.Count + 1;
                GlobalAppointmentDataBase.Clients.Add(NewClient);
                this.Close();
            }
            else
            {
                TextBlock error = this.FindName("errormsg") as TextBlock;
                error.Visibility = Visibility.Visible;
            }
        }
    }
}
