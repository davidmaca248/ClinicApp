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
                new Appointment("David Maca", "Checkup", new DateTime(2022,11,28,9,15,0),  new DateTime(2022,11,28,9,30,0),"Dr. Far"),
                new Appointment("Alden John", "X-Ray", new DateTime(2022,11,28,13,30,0),  new DateTime(2022,11,28,14,00,0),"Dr. Drake"),
                new Appointment("Abe Jay", "Checkup and X-Ray", new DateTime(2022,11,28,13,30,0),  new DateTime(2022,11,28,13,45,0),"Dr. Guy"),
                new Appointment("Josh Richards", "Checkup and consultation", new DateTime(2022,11,29,16,15,0),  new DateTime(2022,11,29,16,45,0),"Dr. Wade"),
                new Appointment("Arhum Gambino", "Checkup", new DateTime(2022,11,27,16,30,0),  new DateTime(2022,11,27,17,00,0),"Dr. James"),
                new Appointment("Frank Garfield", "Consultation", new DateTime(2022,11,29,18,00,0), new DateTime(2022, 11, 29, 18, 15, 0), "Dr. Shaw"),
            };
        }
    }
}
