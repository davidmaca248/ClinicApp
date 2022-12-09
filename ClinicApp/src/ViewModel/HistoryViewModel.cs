using ClinicApp.Globals;
using ClinicApp.Model;
using ClinicApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.ViewModel
{
    public class HistoryViewModel : BaseViewModel
    {
        public List<Appointment> PastAppointments {
            get => _PastAppointments;
            set
            {
                _PastAppointments = value;
                OnPropertyChanged();
            }
        }

        private List<Appointment> _PastAppointments;

        public HistoryViewModel() {
            PastAppointments = GlobalAppointmentDataBase.PastAppointments;
        }

        public void updateContent(string query)
        {
            PastAppointments = GlobalAppointmentDataBase.PastAppointments
                .Where(x => x.Name.ToUpper().Contains(query)).ToList();
        }
    }
}
