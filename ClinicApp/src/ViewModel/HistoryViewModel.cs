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
            updateList();
        }

        public void updateContent(string query)
        {
            if (!query.Equals(string.Empty))
            {
                var past = GlobalAppointmentDataBase.AppointmentList.Concat(GlobalAppointmentDataBase.DeletedAppointments).
                    Where(x => x.StartTime < DateTime.Now)
                    .OrderBy(o => o.StartTime).ToList();
                var search = past.Where(x => x.Name.ToUpper().Contains(query)).ToList();

                PastAppointments = search.Intersect(past).ToList();
            }
            else
            {
                updateList();
            }
        }

        public void updateList()
        {
            GlobalAppointmentDataBase.AppointmentList.
                Where(x => x.EndTime < DateTime.Now).ToList().ForEach(y => y.Status = "Completed");
            PastAppointments = GlobalAppointmentDataBase.AppointmentList.Concat(GlobalAppointmentDataBase.DeletedAppointments).
                Where(x => x.EndTime < DateTime.Now)
                .OrderBy(o => o.StartTime).ToList();
        }
    }
}
