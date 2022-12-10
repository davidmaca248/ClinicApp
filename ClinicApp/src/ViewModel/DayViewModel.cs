using ClinicApp.Globals;
using ClinicApp.Model;
using ClinicApp.Views.Popups;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.ViewModel
{
    public class DayViewModel : BaseViewModel
    {
        // appointmentList
        public List<Appointment> AppointmentList
        {
            get => _AppointmentList;
            set
            {
                _AppointmentList = value;
                OnPropertyChanged();
            }
        }

        public DateTime DisplayedDay
        {
            get => _displayedDay;
            set
            {
                _displayedDay = value;
                DisplayedDayString = _displayedDay.ToString("MMMM dd, yyyy");
                UpdateContent();
                OnPropertyChanged();
            }
        }

        public string DisplayedDayString
        {
            get => _displayedDayString;
            set
            {
                _displayedDayString = value;
                OnPropertyChanged();
            }
        }

        private List<Appointment> _AppointmentList;
        private DateTime _displayedDay;
        private string _displayedDayString;

        public DayViewModel()
        {
            DisplayedDay = DateTime.Now;
        }

        /// <summary>
        /// Updates Todo, Notes, and Appointment Table based on the displayed date
        /// </summary>
        public void UpdateContent()
        {
            AppointmentList = GlobalAppointmentDataBase.AppointmentList
                .Where(x => x.StartTime.Date == DisplayedDay.Date).OrderBy(o => o.StartTime).ToList();
        }
    }
}
