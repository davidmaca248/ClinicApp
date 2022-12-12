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

namespace ClinicApp.Views
{
    /// <summary>
    /// Interaction logic for AppointmentBookingTime.xaml
    /// </summary>
    public partial class AppointmentBookingTime : UserControl
    {
        Button prevButton = new Button(); 
        public AppointmentBookingTime()
        {
            if (GlobalAppointmentDataBase.Rescheduling)
            {
                GlobalAppointmentDataBase.NewAppointment.Duration = GlobalAppointmentDataBase.SelectedAppointment.Duration;
                GlobalAppointmentDataBase.NewAppointment.Description = GlobalAppointmentDataBase.SelectedAppointment.Description;
            }
            InitializeComponent();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new AppointmentBookingClient());
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            if (GlobalAppointmentDataBase.NewAppointment.Description != string.Empty)
            {
                Switcher.Switch(new AppointmentBookingDate());
            }
            else
            {
                TextBlock error = this.FindName("errormsg") as TextBlock;
                error.Visibility = Visibility.Visible;
            }
        }

        private void Back(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new AppointmentBookingClient());
        }

        private void Next(object sender, RoutedEventArgs e)
        {
            if (GlobalAppointmentDataBase.NewAppointment.Description != string.Empty)
            {
                Switcher.Switch(new AppointmentBookingDate());
            }
            else
            {
                TextBlock error = this.FindName("errormsg") as TextBlock;
                error.Visibility = Visibility.Visible;
            }
        }

        // Buttons for appointment reason

        // 30 Minute Tab
        private void Checkup(object sender, RoutedEventArgs e)
        {
            prevButton.Background = Brushes.DarkOrchid;
            prevButton.Foreground = Brushes.MintCream;
            Button button = sender as Button;
            button.Background = Brushes.MintCream;
            button.Foreground = Brushes.DarkOrchid;

            GlobalAppointmentDataBase.NewAppointment.Description = "Checkup";
            GlobalAppointmentDataBase.NewAppointment.Duration = 30;

            prevButton = button;

        }

        private void Cold(object sender, RoutedEventArgs e)
        {
            prevButton.Background = Brushes.DarkOrchid;
            prevButton.Foreground = Brushes.MintCream;
            Button button = sender as Button;
            button.Background = Brushes.MintCream;
            button.Foreground = Brushes.DarkOrchid;

            GlobalAppointmentDataBase.NewAppointment.Description = "Cold";
            GlobalAppointmentDataBase.NewAppointment.Duration = 30;

            prevButton = button;
        }

        private void Muscle(object sender, RoutedEventArgs e)
        {
            prevButton.Background = Brushes.DarkOrchid;
            prevButton.Foreground = Brushes.MintCream;
            Button button = sender as Button;
            button.Background = Brushes.MintCream;
            button.Foreground = Brushes.DarkOrchid;

            GlobalAppointmentDataBase.NewAppointment.Description = "Muscle";
            GlobalAppointmentDataBase.NewAppointment.Duration = 30;

            prevButton = button;
        }
        private void Flu(object sender, RoutedEventArgs e)
        {
            prevButton.Background = Brushes.DarkOrchid;
            prevButton.Foreground = Brushes.MintCream;
            Button button = sender as Button;
            button.Background = Brushes.MintCream;
            button.Foreground = Brushes.DarkOrchid;

            GlobalAppointmentDataBase.NewAppointment.Description = "Flu Shot";
            GlobalAppointmentDataBase.NewAppointment.Duration = 30;

            prevButton = button;
        }

        private void Prescription(object sender, RoutedEventArgs e)
        {
            prevButton.Background = Brushes.DarkOrchid;
            prevButton.Foreground = Brushes.MintCream;
            Button button = sender as Button;
            button.Background = Brushes.MintCream;
            button.Foreground = Brushes.DarkOrchid;

            GlobalAppointmentDataBase.NewAppointment.Description = "Prescription";
            GlobalAppointmentDataBase.NewAppointment.Duration = 30;

            prevButton = button;
        }

        private void Other30(object sender, RoutedEventArgs e)
        {
            prevButton.Background = Brushes.DarkOrchid;
            prevButton.Foreground = Brushes.MintCream;

            TextBox tb = sender as TextBox;
            string text = tb.Text;
            GlobalAppointmentDataBase.NewAppointment.Description = text;
            GlobalAppointmentDataBase.NewAppointment.Duration = 30;
        }

        // 60 Minute Tab
        private void Consultation(object sender, RoutedEventArgs e)
        {
            prevButton.Background = Brushes.DarkOrchid;
            prevButton.Foreground = Brushes.MintCream;
            Button button = sender as Button;
            button.Background = Brushes.MintCream;
            button.Foreground = Brushes.DarkOrchid;

            GlobalAppointmentDataBase.NewAppointment.Description = "Consultation";
            GlobalAppointmentDataBase.NewAppointment.Duration = 60;

            prevButton = button;
        }

        private void Diagnostics(object sender, RoutedEventArgs e)
        {
            prevButton.Background = Brushes.DarkOrchid;
            prevButton.Foreground = Brushes.MintCream;
            Button button = sender as Button;
            button.Background = Brushes.MintCream;
            button.Foreground = Brushes.DarkOrchid;

            GlobalAppointmentDataBase.NewAppointment.Description = "Diagnostics";
            GlobalAppointmentDataBase.NewAppointment.Duration = 60;

            prevButton = button;
        }

        private void PhysicalExam(object sender, RoutedEventArgs e)
        {
            prevButton.Background = Brushes.DarkOrchid;
            prevButton.Foreground = Brushes.MintCream;
            Button button = sender as Button;
            button.Background = Brushes.MintCream;
            button.Foreground = Brushes.DarkOrchid;

            GlobalAppointmentDataBase.NewAppointment.Description = "Physical Exam";
            GlobalAppointmentDataBase.NewAppointment.Duration = 60;

            prevButton = button;
        }

        private void XRay(object sender, RoutedEventArgs e)
        {
            prevButton.Background = Brushes.DarkOrchid;
            prevButton.Foreground = Brushes.MintCream;
            Button button = sender as Button;
            button.Background = Brushes.MintCream;
            button.Foreground = Brushes.DarkOrchid;

            GlobalAppointmentDataBase.NewAppointment.Description = "X-Ray";
            GlobalAppointmentDataBase.NewAppointment.Duration = 60;

            prevButton = button;
        }

        private void BloodTest(object sender, RoutedEventArgs e)
        {
            prevButton.Background = Brushes.DarkOrchid;
            prevButton.Foreground = Brushes.MintCream;
            Button button = sender as Button;
            button.Background = Brushes.MintCream;
            button.Foreground = Brushes.DarkOrchid;

            GlobalAppointmentDataBase.NewAppointment.Description = "Blood Test";
            GlobalAppointmentDataBase.NewAppointment.Duration = 60;

            prevButton = button;
        }

        private void Other60(object sender, RoutedEventArgs e)
        {
            prevButton.Background = Brushes.DarkOrchid;
            prevButton.Foreground = Brushes.MintCream;

            TextBox tb = sender as TextBox;
            string text = tb.Text;
            GlobalAppointmentDataBase.NewAppointment.Description = text;
            GlobalAppointmentDataBase.NewAppointment.Duration = 60;
        }

        // 90 Minute Tab
        private void FullCheckup(object sender, RoutedEventArgs e)
        {
            prevButton.Background = Brushes.DarkOrchid;
            prevButton.Foreground = Brushes.MintCream;
            Button button = sender as Button;
            button.Background = Brushes.MintCream;
            button.Foreground = Brushes.DarkOrchid;

            GlobalAppointmentDataBase.NewAppointment.Description = "Full Checkup";
            GlobalAppointmentDataBase.NewAppointment.Duration = 90;

            prevButton = button;
        }

        private void FullDiagnostic(object sender, RoutedEventArgs e)
        {
            prevButton.Background = Brushes.DarkOrchid;
            prevButton.Foreground = Brushes.MintCream;
            Button button = sender as Button;
            button.Background = Brushes.MintCream;
            button.Foreground = Brushes.DarkOrchid;

            GlobalAppointmentDataBase.NewAppointment.Description = "Full Diagnostics";
            GlobalAppointmentDataBase.NewAppointment.Duration = 90;

            prevButton = button;
        }

        private void MultiPeople(object sender, RoutedEventArgs e)
        {
            prevButton.Background = Brushes.DarkOrchid;
            prevButton.Foreground = Brushes.MintCream;
            Button button = sender as Button;
            button.Background = Brushes.MintCream;
            button.Foreground = Brushes.DarkOrchid;

            GlobalAppointmentDataBase.NewAppointment.Description = "Multiple People";
            GlobalAppointmentDataBase.NewAppointment.Duration = 90;

            prevButton = button;
        }

        private void Diabetes(object sender, RoutedEventArgs e)
        {
            prevButton.Background = Brushes.DarkOrchid;
            prevButton.Foreground = Brushes.MintCream;
            Button button = sender as Button;
            button.Background = Brushes.MintCream;
            button.Foreground = Brushes.DarkOrchid;

            GlobalAppointmentDataBase.NewAppointment.Description = "Diabetes";
            GlobalAppointmentDataBase.NewAppointment.Duration = 90;

            prevButton = button;
        }

        private void Psychological(object sender, RoutedEventArgs e)
        {
            prevButton.Background = Brushes.DarkOrchid;
            prevButton.Foreground = Brushes.MintCream;
            Button button = sender as Button;
            button.Background = Brushes.MintCream;
            button.Foreground = Brushes.DarkOrchid;

            GlobalAppointmentDataBase.NewAppointment.Description = "Psychological";
            GlobalAppointmentDataBase.NewAppointment.Duration = 90;

            prevButton = button;
        }

        private void Other90(object sender, RoutedEventArgs e)
        {
            prevButton.Background = Brushes.DarkOrchid;
            prevButton.Foreground = Brushes.MintCream;

            TextBox tb = sender as TextBox;
            string text = tb.Text;
            GlobalAppointmentDataBase.NewAppointment.Description = text;
            GlobalAppointmentDataBase.NewAppointment.Duration = 90;
        }
    }
}
