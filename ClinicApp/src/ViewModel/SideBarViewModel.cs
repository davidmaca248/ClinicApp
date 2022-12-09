using ClinicApp.Globals;
using ClinicApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using Timer = System.Timers.Timer;

namespace ClinicApp.ViewModel
{
    internal class SideBarViewModel : BaseViewModel
    {
        public List<Appointment> AppointmentList { 
            get => _appointmentList;
            set
            {
                _appointmentList = value;
                OnPropertyChanged();
            }
        }

        private static Timer timer;
        private List<Appointment> _appointmentList;

        public SideBarViewModel()
        {
            timer = new Timer();
            timer.Interval = 5000;
            timer.Elapsed += TimerEvent;
            timer.AutoReset = true;
            timer.Enabled = true;

            AppointmentList = GlobalAppointmentDataBase.AppointmentList.
                Where(x => x.StartTime.Date == DateTime.Now.Date && x.StartTime.TimeOfDay >= DateTime.Now.TimeOfDay)
                .OrderBy(o => o.StartTime).ToList();
        }
        private void TimerEvent(object source, ElapsedEventArgs e)
        {
            AppointmentList = GlobalAppointmentDataBase.AppointmentList.
                Where(x => x.StartTime.Date == DateTime.Now.Date && x.StartTime.TimeOfDay >= DateTime.Now.TimeOfDay)
                .OrderBy(o => o.StartTime).ToList();
        }

        public void update()
        {
            timer = new Timer();
            timer.Interval = 5000;
            timer.Elapsed += TimerEvent;
            timer.AutoReset = true;
            timer.Enabled = true;

            AppointmentList = GlobalAppointmentDataBase.AppointmentList.
                Where(x => x.StartTime.Date == DateTime.Now.Date && x.StartTime.TimeOfDay >= DateTime.Now.TimeOfDay)
                .OrderBy(o => o.StartTime).ToList();
        }
    }
}
