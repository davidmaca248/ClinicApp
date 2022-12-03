using ClinicApp.Globals;
using ClinicApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.ViewModel
{
    internal class DoctorsListViewModel : BaseViewModel
    {
        public List<Doctor> Doctors
        {
            get => _doctors;
            set
            {
                _doctors = value;
                OnPropertyChanged();
            }
        }

        private List<Doctor> _doctors;

        public DoctorsListViewModel()
        {
            _doctors = GlobalAppointmentDataBase.Doctors;
        }
    }
}
