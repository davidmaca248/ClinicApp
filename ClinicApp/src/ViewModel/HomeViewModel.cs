using ClinicApp.Globals;
using ClinicApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;

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

        public HomeViewModel()
        {
            DisplayedDay = DateTime.Now;
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
