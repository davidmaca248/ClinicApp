using ClinicApp.Globals;
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
using ClinicApp.Model;
using System.Runtime.InteropServices.ComTypes;
using System.Collections.ObjectModel;
using ClinicApp.Views.Popups;
using System.Reflection;
using System.Windows.Media.Effects;

namespace ClinicApp.Views
{
    /// <summary>
    /// Interaction logic for AppointmentBookingDate.xaml
    /// </summary>
    public partial class AppointmentBookingDate : UserControl
    {
        int duration = GlobalAppointmentDataBase.NewAppointment.Duration;
        DateTime currentDate = new DateTime();
        DateTime[] availableDates = {
            new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 9, 0, 0),
            new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 9, 30, 0),
            new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 10, 0, 0),
            new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 10, 30, 0),
            new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 11, 0, 0),
            new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 11, 30, 0),
            new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 12, 00, 0),
            new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 12, 30, 0),
            new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 13, 00, 0),
            new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 13, 30, 0),
            new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 14, 00, 0),
            new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 14, 30, 0),
            new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 15, 00, 0),
            new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 15, 30, 0),
            new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 16, 00, 0),
            new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 16, 30, 0),
            new DateTime()
        };
        DatePicker calendar = new DatePicker();
        private string[] allTimes =
        {
            "9:00 am", "9:30 am", "10:00 am", "10:30 am", "11:00 am", "11:30 am",
            "12:00 pm", "12:30 pm", "1:00 pm", "1:30 pm", "2:00 pm", "2:30 pm",
            "3:00 pm", "3:30 pm", "4:00 pm", "4:30 pm"
        };
        Button prevButton = new Button();
        Doctor AppointmentDoctor = new Doctor();
        StackPanel panel = new StackPanel();
        WrapPanel wpanel = new WrapPanel();

        public AppointmentBookingDate()
        {
            InitializeComponent();
            currentDate = DateTime.Now;
            calendar = this.FindName("datePicker") as DatePicker;
            calendar.SelectedDate = currentDate;
            // Load twice because of some weird bug (double loads the buttons so clear then load again)
            panel.Children.Clear();
            wpanel.Children.Clear();
            LoadContent();
            ResetAvailableTimes();
            panel.Children.Clear();
            wpanel.Children.Clear();
            LoadContent();

            if (GlobalAppointmentDataBase.Rescheduling)
            {
                GlobalAppointmentDataBase.NewAppointment.Doctor = GlobalAppointmentDataBase.SelectedAppointment.Doctor;
                GlobalAppointmentDataBase.NewAppointment.StartTime = GlobalAppointmentDataBase.SelectedAppointment.StartTime;
                GlobalAppointmentDataBase.NewAppointment.EndTime = GlobalAppointmentDataBase.SelectedAppointment.EndTime;
            }
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new AppointmentBookingTime());
        }

        private void To_Clients(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new AppointmentBookingClient());
        }

        private void Back(object sender, RoutedEventArgs e)
        {
            panel.Children.Clear();
            wpanel.Children.Clear();
            Switcher.Switch(new AppointmentBookingTime());
        }

        private void Confirm(object sender, RoutedEventArgs e)
        {
            if (GlobalAppointmentDataBase.NewAppointment.StartTime != new DateTime())
            {
                GlobalAppointmentDataBase.NewAppointment.Id = GlobalAppointmentDataBase.AppointmentList.Count + 1;
                GlobalAppointmentDataBase.NewAppointment.Name = GlobalAppointmentDataBase.AppointmentClient.FirstName + ' ' + GlobalAppointmentDataBase.AppointmentClient.LastName;
                if (GlobalAppointmentDataBase.NewClient) {
                    GlobalAppointmentDataBase.NewClient = false;
                    GlobalAppointmentDataBase.Clients.Add(GlobalAppointmentDataBase.AppointmentClient);
                }
                GlobalAppointmentDataBase.NewAppointment.Date = GlobalAppointmentDataBase.NewAppointment.StartTime.ToString("MMMM dd, yyyy");
                GlobalAppointmentDataBase.NewAppointment.Email = GlobalAppointmentDataBase.AppointmentClient.Email;
                GlobalAppointmentDataBase.NewAppointment.PhoneNumber = GlobalAppointmentDataBase.AppointmentClient.PhoneNumber;
                GlobalAppointmentDataBase.NewAppointment.Status = "Upcoming";
                GlobalAppointmentDataBase.NewAppointment.DoctorName = "Dr. " + AppointmentDoctor.LastName;
                GlobalAppointmentDataBase.NewAppointment.DurationStr = GlobalAppointmentDataBase.NewAppointment.Duration.ToString() + " " + "Min";
                GlobalAppointmentDataBase.NewAppointment.Time = GlobalAppointmentDataBase.NewAppointment.StartTime.ToString("h:mm tt");
                if (!GlobalAppointmentDataBase.Rescheduling)
                {
                    GlobalAppointmentDataBase.Doctors.Find(x => x == AppointmentDoctor).Appointments.Add(GlobalAppointmentDataBase.NewAppointment);
                    GlobalAppointmentDataBase.AppointmentList.Add(GlobalAppointmentDataBase.NewAppointment);
                    GlobalAppointmentDataBase.AppointmentClient.Appointments.Add(GlobalAppointmentDataBase.NewAppointment);
                }
                if (!GlobalAppointmentDataBase.Rescheduling)
                {
                    GlobalAppointmentDataBase.NewClient = false;
                    GlobalAppointmentDataBase.AppointmentClient = new Client();
                    GlobalAppointmentDataBase.NewAppointment = new Appointment();
                    Switcher.Switch(new HomeContentUC());
                }
            }
            if (GlobalAppointmentDataBase.Rescheduling)
            {
                GlobalAppointmentDataBase.Rescheduling = false;
                SaveChangesPopup modal = new SaveChangesPopup();
                modal.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                Switcher.pageSwitcher.Effect = new BlurEffect();
                modal.ShowDialog();
                Switcher.pageSwitcher.Effect = null;

                if (GlobalAppointmentDataBase.Confirm)
                {
                    GlobalAppointmentDataBase.Confirm = false;
                    Switcher.Switch(new HomeContentUC()); // Should edit b/c of reference to original object (hopefully)
                    GlobalAppointmentDataBase.SelectedAppointment.Description = GlobalAppointmentDataBase.NewAppointment.Description;
                    GlobalAppointmentDataBase.SelectedAppointment.StartTime = GlobalAppointmentDataBase.NewAppointment.StartTime;
                    GlobalAppointmentDataBase.SelectedAppointment.EndTime = GlobalAppointmentDataBase.NewAppointment.EndTime;
                    GlobalAppointmentDataBase.SelectedAppointment.Time = GlobalAppointmentDataBase.NewAppointment.Time;
                    GlobalAppointmentDataBase.SelectedAppointment.Date = GlobalAppointmentDataBase.NewAppointment.StartTime.ToString("MMMM dd, yyyy");
                    GlobalAppointmentDataBase.SelectedAppointment.Doctor = GlobalAppointmentDataBase.NewAppointment.Doctor;
                    GlobalAppointmentDataBase.SelectedAppointment.DoctorName = GlobalAppointmentDataBase.NewAppointment.DoctorName;
                    GlobalAppointmentDataBase.SelectedAppointment.Duration = GlobalAppointmentDataBase.NewAppointment.Duration;
                    GlobalAppointmentDataBase.SelectedAppointment.DurationStr = GlobalAppointmentDataBase.NewAppointment.DurationStr;
                    GlobalAppointmentDataBase.Doctors.Find(x => x == AppointmentDoctor).Appointments.Add(GlobalAppointmentDataBase.SelectedAppointment);
                }
            }
            else
            {
                TextBlock error = this.FindName("errormsg") as TextBlock;
                error.Visibility = Visibility.Visible;
            }
        }

        private void SetDate(object sender, RoutedEventArgs e)
        {
            ResetAvailableTimes();
            calendar = sender as DatePicker;
            currentDate = (DateTime)calendar.SelectedDate;
            panel.Children.Clear();
            wpanel.Children.Clear();
            LoadContent();
        }

        private void LoadContent()
        {
            panel = (StackPanel)this.FindName("panel1");
            foreach (Doctor d in GlobalAppointmentDataBase.Doctors)
            {
                wpanel = new WrapPanel();
                foreach (Appointment a in d.Appointments)
                {
                    if (a.StartTime.Date == currentDate.Date)
                    {
                        for (int i = 0; i < d.AvailableTimes.Count; i++)
                        {
                            if (CheckDate(d.AvailableTimes[i].TimeOfDay, a.StartTime.TimeOfDay, a.EndTime.TimeOfDay))
                            {
                                availableDates[i] = new DateTime();
                            }
                        }
                    }
                }

                for (int i = 0; i < availableDates.Length; i++)
                {
                    if (i == availableDates.Length - 1) break;
                    if (availableDates[i] == new DateTime())
                        d.displayTimes[i] = false;
                    else
                    {
                        if (duration == 30) d.displayTimes[i] = true;
                        if (duration == 60)
                        {
                            if (availableDates[i + 1] == new DateTime()) d.displayTimes[i] = false;
                            else d.displayTimes[i] = true;
                        }
                        if (duration == 90)
                        {
                            // Should always be true at 4:30 pm (so there should not be an out of bounds exception)
                            try
                            {
                                if (availableDates[i + 1] == new DateTime()) d.displayTimes[i] = false;
                                else if (availableDates[i + 2] == new DateTime()) d.displayTimes[i] = false;
                                else d.displayTimes[i] = true;
                            }
                            catch (Exception e)
                            {
                                d.displayTimes[i] = false;
                            }
                        }
                    }
                }

                for (int i = 0; i < d.displayTimes.Length; i++)
                {
                    if (d.displayTimes[i])
                    {
                        d.Display.Add(allTimes[i]);
                    }
                }

                Label name = new Label();
                name.Content = "Dr. " + d.LastName;
                panel.Children.Add(name);
                foreach (string s in d.Display)
                {
                    Button b = new Button();
                    b.Name = d.LastName;
                    b.Content = s;
                    b.Click += TimeSelected;
                    wpanel.Children.Add(b);
                }
                d.Display.Clear();
                panel.Children.Add(wpanel);
                ResetAvailableTimes();
            }

        }

        public void TimeSelected(object sender, RoutedEventArgs e)
        {
            prevButton.Background = Brushes.DarkOrchid;
            prevButton.Foreground = Brushes.MintCream;
            Button button = sender as Button;
            button.Background = Brushes.MintCream;
            button.Foreground = Brushes.DarkOrchid;

            AppointmentDoctor = GlobalAppointmentDataBase.Doctors.Find(x => x.LastName == button.Name);
            if (GlobalAppointmentDataBase.Rescheduling)
            {
                GlobalAppointmentDataBase.Doctors.Find(x => x == GlobalAppointmentDataBase.NewAppointment.Doctor).Appointments.RemoveAll(x => x == GlobalAppointmentDataBase.SelectedAppointment);
            }
            GlobalAppointmentDataBase.NewAppointment.Doctor = AppointmentDoctor;
            SetAppointmentTime((string)button.Content);
            GlobalAppointmentDataBase.NewAppointment.EndTime = GlobalAppointmentDataBase.NewAppointment.StartTime.AddMinutes(duration);

            prevButton = button;
        }

        // Could probably do this with a timespan parse but...
        private void SetAppointmentTime(string time)
        {
            if (time == "9:00 am")
            {
                GlobalAppointmentDataBase.NewAppointment.StartTime = new DateTime(currentDate.Year, currentDate.Month, currentDate.Day, 9, 0, 0);
            }
            else if (time == "9:30 am")
            {
                GlobalAppointmentDataBase.NewAppointment.StartTime = new DateTime(currentDate.Year, currentDate.Month, currentDate.Day, 9, 30, 0);
            }
            else if (time == "10:00 am")
            {
                GlobalAppointmentDataBase.NewAppointment.StartTime = new DateTime(currentDate.Year, currentDate.Month, currentDate.Day, 10, 0, 0);
            }
            else if (time == "10:30 am")
            {
                GlobalAppointmentDataBase.NewAppointment.StartTime = new DateTime(currentDate.Year, currentDate.Month, currentDate.Day, 10, 30, 0);
            }
            else if (time == "11:00 am")
            {
                GlobalAppointmentDataBase.NewAppointment.StartTime = new DateTime(currentDate.Year, currentDate.Month, currentDate.Day, 11, 0, 0);
            }
            else if (time == "11:30 am")
            {
                GlobalAppointmentDataBase.NewAppointment.StartTime = new DateTime(currentDate.Year, currentDate.Month, currentDate.Day, 11, 30, 0);
            }
            else if (time == "12:00 pm")
            {
                GlobalAppointmentDataBase.NewAppointment.StartTime = new DateTime(currentDate.Year, currentDate.Month, currentDate.Day, 12, 0, 0);
            }
            else if (time == "12:30 pm")
            {
                GlobalAppointmentDataBase.NewAppointment.StartTime = new DateTime(currentDate.Year, currentDate.Month, currentDate.Day, 12, 30, 0);
            }
            else if (time == "1:00 pm")
            {
                GlobalAppointmentDataBase.NewAppointment.StartTime = new DateTime(currentDate.Year, currentDate.Month, currentDate.Day, 13, 0, 0);
            }
            else if (time == "1:30 pm")
            {
                GlobalAppointmentDataBase.NewAppointment.StartTime = new DateTime(currentDate.Year, currentDate.Month, currentDate.Day, 13, 30, 0);
            }
            else if (time == "2:00 pm")
            {
                GlobalAppointmentDataBase.NewAppointment.StartTime = new DateTime(currentDate.Year, currentDate.Month, currentDate.Day, 14, 0, 0);
            }
            else if (time == "2:30 pm")
            {
                GlobalAppointmentDataBase.NewAppointment.StartTime = new DateTime(currentDate.Year, currentDate.Month, currentDate.Day, 14, 30, 0);
            }
            else if (time == "3:00 pm")
            {
                GlobalAppointmentDataBase.NewAppointment.StartTime = new DateTime(currentDate.Year, currentDate.Month, currentDate.Day, 15, 0, 0);
            }
            else if (time == "3:30 pm")
            {
                GlobalAppointmentDataBase.NewAppointment.StartTime = new DateTime(currentDate.Year, currentDate.Month, currentDate.Day, 15, 30, 0);
            }
            else if (time == "4:00 pm")
            {
                GlobalAppointmentDataBase.NewAppointment.StartTime = new DateTime(currentDate.Year, currentDate.Month, currentDate.Day, 16, 0, 0);
            }
            else if (time == "4:30 pm")
            {
                GlobalAppointmentDataBase.NewAppointment.StartTime = new DateTime(currentDate.Year, currentDate.Month, currentDate.Day, 16, 30, 0);
            }
        }

        private bool CheckDate(TimeSpan dateToCheck, TimeSpan start, TimeSpan end)
        {
            return dateToCheck >= start && dateToCheck < end;
        }

        private void ResetAvailableTimes()
        {
            DateTime[] reset = {
            new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 9, 0, 0),
            new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 9, 30, 0),
            new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 10, 0, 0),
            new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 10, 30, 0),
            new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 11, 0, 0),
            new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 11, 30, 0),
            new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 12, 00, 0),
            new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 12, 30, 0),
            new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 13, 00, 0),
            new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 13, 30, 0),
            new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 14, 00, 0),
            new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 14, 30, 0),
            new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 15, 00, 0),
            new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 15, 30, 0),
            new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 16, 00, 0),
            new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 16, 30, 0),
            new DateTime()
            };

            availableDates = reset;
        }
    }
}
