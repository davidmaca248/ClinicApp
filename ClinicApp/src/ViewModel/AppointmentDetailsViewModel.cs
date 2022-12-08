using ClinicApp.Globals;
using ClinicApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.ViewModel
{
    internal class AppointmentDetailsViewModel : BaseViewModel
    {
        public Appointment app
        {
            get => _app;
            set
            {
                _app = value;
                OnPropertyChanged();
            }
        }

        private Appointment _app;


        public AppointmentDetailsViewModel()
        {
            _app = GlobalAppointmentDataBase.SelectedAppointment;
        }

        public void update()
        {
            _app = GlobalAppointmentDataBase.SelectedAppointment;
        }
    }
}
