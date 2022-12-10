using ClinicApp.Globals;
using ClinicApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.ViewModel
{
    internal class DoctorDetailedViewModel : BaseViewModel
    {
        public Doctor Doctor
        {
            get => _Doctor;
            set
            {
                _Doctor = value;
                OnPropertyChanged();
            }
        }

        private Doctor _Doctor;

        public DoctorDetailedViewModel()
        {
            Doctor = GlobalAppointmentDataBase.SelectedDoctor;
        }

        public void Update()
        {
            Doctor = GlobalAppointmentDataBase.SelectedDoctor;
        }
    }
}
