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
using static ClinicApp.Views.Calendar.CalendarTabUC;

namespace ClinicApp.Views.Calendar
{
    /// <summary>
    /// Interaction logic for DayViewUC.xaml
    /// </summary>
    public partial class DayViewUC : UserControl
    {
        public DayViewUC()
        {
            InitializeComponent();

            List<User> timeslot = new List<User>();
            timeslot.Add(new User() { Time = "07:00", DrJohnstone = "", DrKeith = "Xavier Z", DrStevenson = "", DrLawson = "Walter W", DrPhil = "Aspen M", DrLeon = "" });
            timeslot.Add(new User() { Time = "08:00", DrJohnstone = "Sandra W", DrKeith = "", DrStevenson = "", DrLawson = "Amanda L", DrPhil = "Quinnten C", DrLeon = "Gary V" });
            timeslot.Add(new User() { Time = "09:00", DrJohnstone = "Joshua K", DrKeith = "", DrStevenson = "Chris R", DrLawson = "", DrPhil = "Sandra W", DrLeon = "" });
            timeslot.Add(new User() { Time = "10:00", DrJohnstone = "", DrKeith = "", DrStevenson = "Simran S", DrLawson = "", DrPhil = "Greg A", DrLeon = "Kim K" });
            timeslot.Add(new User() { Time = "11:00", DrJohnstone = "", DrKeith = "", DrStevenson = "", DrLawson = "", DrPhil = "", DrLeon = "" });
            timeslot.Add(new User() { Time = "12:00", DrJohnstone = "John C", DrKeith = "", DrStevenson = "Jonah A", DrLawson = "", DrPhil = "Baasil C", DrLeon = "" });
            timeslot.Add(new User() { Time = "13:00", DrJohnstone = "", DrKeith = "Gus B", DrStevenson = "Emily Z", DrLawson = "", DrPhil = "Joe M", DrLeon = "" });
            timeslot.Add(new User() { Time = "14:00", DrJohnstone = "", DrKeith = "", DrStevenson = "", DrLawson = "", DrPhil = "", DrLeon = "" });
            timeslot.Add(new User() { Time = "15:00", DrJohnstone = "Steve K.", DrKeith = "", DrStevenson = "", DrLawson = "", DrPhil = "Watson D", DrLeon = "" });
            timeslot.Add(new User() { Time = "16:00", DrJohnstone = "Alex J", DrKeith = "", DrStevenson = "", DrLawson = "Hamza M", DrPhil = "Mary A", DrLeon = "Bill N" });
            timeslot.Add(new User() { Time = "17:00", DrJohnstone = "", DrKeith = "Wanda V", DrStevenson = "", DrLawson = "", DrPhil = "", DrLeon = "Frank A" });
            timeslot.Add(new User() { Time = "18:00", DrJohnstone = "", DrKeith = "", DrStevenson = "Simran S", DrLawson = "Jill K", DrPhil = "Viggo W", DrLeon = "Joshua M" });

            dgSimple.ItemsSource = timeslot;
        }
        public class User
        {

            public string Time { get; set; }
            public string DrJohnstone { get; set; }
            public string DrKeith { get; set; }
            public string DrStevenson { get; set; }
            public string DrLawson { get; set; }
            public string DrPhil { get; set; }
            public string DrLeon { get; set; }



        }

        private void MonthlyCalendar_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
