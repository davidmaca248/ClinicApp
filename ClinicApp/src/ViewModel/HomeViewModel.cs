using ClinicApp.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.ViewModel
{
    public class HomeViewModel : BaseViewModel
    {
        public List<string> NotesList { get; set; }
        public List<string> TodoList { get; set; }

        public ObservableCollection<Appointment> AppointmentList { get; set; }
        public HomeViewModel()
        {
            NotesList = new List<string>()
            {
                "Arhum's test results came in last night",
                "Alden Hoffman canceled appointment",
                "Dan called in sick"
            };

            TodoList = new List<string>()
            {
                "Call David Maca to confirm appointment",
                "Let Dr. Frank know about Arhum's test results",
                "Let Dr. Josh know about Alden Hoffman's cancellation",
                "Let manager know that Dan cannot make it to work today"
            };

            AppointmentList = new ObservableCollection<Appointment>()
            {
                new Appointment("David Maca", "Checkup", "11:00 AM", "Dr. Farquad"),
                new Appointment("Alden John", "Checkup and xRay", "1:30 PM", "Dr. Drake"),
                new Appointment("Josh Richards", "Checkup and consultation", "4:15 PM", "Dr. Wade"),
                new Appointment("Arhum Gambino", "Checkup", "4:30 PM", "Dr. Tate"),
                new Appointment("Frank Garfield", "Consultation", "5:15 PM", "Dr. Shaw"),
            };

            
        }

    }
}
