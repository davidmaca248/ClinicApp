using ClinicApp.Globals;
using ClinicApp.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using Timer = System.Timers.Timer;

namespace ClinicApp.ViewModel
{
    public class HomeViewModel : BaseViewModel
    {
        public List<NoteListItem> NotesList 
        {
            get => _notesList;
            set
            {
                _notesList = value;
                OnPropertyChanged();
            }
        }
        public List<NoteListItem> TodoList 
        {
            get => _todoList;
            set
            {
                _todoList = value;
                OnPropertyChanged();
            }
        }

        public List<Appointment> AppointmentList {
            get => _appointmentList;
            set
            {
                _appointmentList = value;
                OnPropertyChanged();
            }
        }

        public DateTime DisplayedDay { 
            get => _displayedDay; 
            set
            {
                _displayedDay = value;
                DisplayedDayString = _displayedDay.ToString("MMMM dd, yyyy");
                updateContent();
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


        private List<Appointment> _appointmentList;
        private List<NoteListItem> _notesList;
        private List<NoteListItem> _todoList;
        private DateTime _displayedDay;
        private string _displayedDayString;
        private static Timer timer;

        public HomeViewModel()
        {
            timer = new Timer();
            timer.Interval = 5000;
            timer.Elapsed += TimerEvent;
            timer.AutoReset = true;
            timer.Enabled = true;
            DisplayedDay = DateTime.Now;
        }

        private void TimerEvent(object source, ElapsedEventArgs e)
        {
            List<Appointment> finishedApps = GlobalAppointmentDataBase.AppointmentList.Where(x => x.EndTime <= DateTime.Now).ToList();
            GlobalAppointmentDataBase.AppointmentList.RemoveAll(x => x.EndTime <= DateTime.Now);
            foreach (Appointment app in finishedApps)
            {
                app.Id = GlobalAppointmentDataBase.PastAppointments.Count + 1;
                app.Status = "Completed";
                GlobalAppointmentDataBase.PastAppointments.Add(app);

            }
            AppointmentList = GlobalAppointmentDataBase.AppointmentList;
            updateContent();
        }


        /// <summary>
        /// Updates Todo, Notes, and Appointment Table based on the displayed date
        /// </summary>
        public void updateContent()
        {
            AppointmentList = GlobalAppointmentDataBase.AppointmentList
                .Where(x => x.StartTime.Date == DisplayedDay.Date).OrderBy(o => o.StartTime).ToList();
            TodoList = GlobalHomePageListDatabase.TodoList.Where(x => x.Date.Date == DisplayedDay.Date).ToList();
            NotesList = GlobalHomePageListDatabase.NotesList.Where(x => x.Date.Date == DisplayedDay.Date).ToList();
        }
    }
}
