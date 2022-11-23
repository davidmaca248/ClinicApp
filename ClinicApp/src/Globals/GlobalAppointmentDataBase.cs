using ClinicApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.Globals
{
    public static class GlobalAppointmentDataBase
    {
        // Not sure if the navbar should lock while booking appointments or not yet
        public static bool IsBooking = false;
        public static List<Doctor> Doctors { get; set; }
        public static List<Client> Clients { get; set; }
        public static List<Appointment> AppointmentList { get; set; }
        public static Appointment NewAppointment { get; set; }
        public static Client AppointmentClient { get; set; }

        static GlobalAppointmentDataBase()
        {
            AppointmentList = new List<Appointment>()
            {
                // Dummy Appointments
                new Appointment("David Maca", "Checkup", new DateTime(2022,05,09,9,15,0), "Dr. Farquad"),
                new Appointment("Alden John", "Checkup and xRay", new DateTime(2022,05,09,13,30,0), "Dr. Drake"),
                new Appointment("Josh Richards", "Checkup and consultation", new DateTime(2022,05,09,16,15,0), "Dr. Wade"),
                new Appointment("Arhum Gambino", "Checkup", new DateTime(2022,05,09,16,30,0), "Dr. Tate"),
                new Appointment("Frank Garfield", "Consultation", new DateTime(2022,05,09,18,00,0), "Dr. Shaw"),
            };
        }
    }
}
