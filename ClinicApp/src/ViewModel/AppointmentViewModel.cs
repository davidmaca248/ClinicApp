using ClinicApp.Common;
using ClinicApp.Globals;
using ClinicApp.Model;
using ClinicApp.Views;
using ClinicApp.Views.Calendar;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.ViewModel
{
    internal class AppointmentViewModel : BaseViewModel
    {
        public List<Client> Clients { get; set; }

        public AppointmentViewModel()
        {
            Clients = GlobalAppointmentDataBase.Clients;
            OnPropertyChanged();
        }
    }
}
