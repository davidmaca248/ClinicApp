using ClinicApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.ViewModel
{
    internal class SideBarViewModel
    {
        public List<Appointment> AppointmentList { get; set; }

        public SideBarViewModel()
        {
            AppointmentList = new List<Appointment>()
            {
                new Appointment("David Maca", "Checkup", "11:00 AM"),
                new Appointment("Alden John", "Checkup and xRay", "1:30 PM"),
                new Appointment("Josh Richards", "Checkup and consultation", "4:15 PM"),
                new Appointment("Arhum Gambino", "Checkup", "4:30 PM"),
                new Appointment("Frank Garfield", "Consultation", "5:15 PM"),
            };


        }
        
    }
}
