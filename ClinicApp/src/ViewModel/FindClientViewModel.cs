using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClinicApp.Globals;
using ClinicApp.Model;
using ClinicApp.Views;

namespace ClinicApp.ViewModel
{
    public class FindClientViewModel : BaseViewModel
    {

        public List<Client> Clients {
            get => _Clients;
            set
            {
                _Clients = value;
                OnPropertyChanged();
            }
        }

        private List<Client> _Clients;

        public void updateContent()
        {
            _Clients = GlobalAppointmentDataBase.Clients;
        }

        public FindClientViewModel()
        {
            Clients = GlobalAppointmentDataBase.Clients;
        }
    }
}
