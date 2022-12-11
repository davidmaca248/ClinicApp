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
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ClinicApp.Views.Popups
{
    /// <summary>
    /// Interaction logic for AddDoctorPopup.xaml
    /// </summary>
    public partial class AddDoctorPopup : Window
    {
        Doctor NewDoctor = new Doctor();
        public AddDoctorPopup()
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
            NewDoctor.DateOfBirth = (DateTime)datePicker.SelectedDate;
        }

        private void Add(object sender, RoutedEventArgs e)
        {
            TextBox Firstname = this.FindName("Fname") as TextBox;
            TextBox Lastname = this.FindName("Lname") as TextBox;
            TextBox email = this.FindName("Email") as TextBox;
            TextBox phone = this.FindName("Phone") as TextBox;
            TextBox PracNum = this.FindName("PracId") as TextBox;
            ComboBox takingpatients = this.FindName("TakingPatients") as ComboBox;
            ComboBoxItem item = takingpatients.SelectedItem as ComboBoxItem;

            NewDoctor.AcceptingPatients = item.Content.ToString();
            NewDoctor.FirstName = Firstname.Text;
            NewDoctor.LastName = Lastname.Text;
            NewDoctor.Email = email.Text;
            NewDoctor.PhoneNumber = phone.Text;
            if (PracNum.Text != string.Empty)
                NewDoctor.PractionerId = PracNum.Text;

            if (NewDoctor.FirstName != string.Empty && NewDoctor.LastName != string.Empty && NewDoctor.PhoneNumber != string.Empty)
            {
                NewDoctor.PersonId = GlobalAppointmentDataBase.Doctors.Count + 1;
                GlobalAppointmentDataBase.Doctors.Add(NewDoctor);
                this.Close();
            }
            else
            {
                TextBlock error = this.FindName("errormsg") as TextBlock;
                error.Visibility = Visibility.Visible;
            }
        }

        private void Close(object sender, RoutedEventArgs e)
        {
            NewDoctor = new Doctor();
            this.Close();
        }
    }
}
