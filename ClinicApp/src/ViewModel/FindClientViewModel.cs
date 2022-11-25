using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClinicApp.Globals;
using ClinicApp.Model;

namespace ClinicApp.ViewModel
{ 
    public class FindClientViewModel : BaseViewModel
    {
        public List<Client> Clients { get; set; }

        public FindClientViewModel() 
        {
            Clients = GlobalAppointmentDataBase.Clients;
        }
    }
}
