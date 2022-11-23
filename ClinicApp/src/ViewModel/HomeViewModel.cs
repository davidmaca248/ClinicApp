using ClinicApp.Globals;
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

        public List<Appointment> AppointmentList { get; set; }


        public DateTime DisplayedDay { 
            get => _displayedDay; 
            set
            {
                _displayedDay = value;
                DisplayedDayString = _displayedDay.ToString("MMMM dd, yyyy");
                OnPropertyChanged();
            } 
        }

        public string DisplayedDayString {
            get => _displayedDayString;
            set
            {
                _displayedDayString = value;
                OnPropertyChanged();
            }
        }


        private DateTime _displayedDay;

        private string _displayedDayString;

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

            AppointmentList = GlobalAppointmentDataBase.AppointmentList;

            DisplayedDay = DateTime.Now;
        }

    }
}
