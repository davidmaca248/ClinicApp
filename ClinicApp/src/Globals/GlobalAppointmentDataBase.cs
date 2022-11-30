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
        public static Appointment NewAppointment { get; set; } = null;
        public static Client AppointmentClient { get; set; } = null;

        static GlobalAppointmentDataBase()
        {
            AppointmentList = new List<Appointment>()
            {
                // Dummy Appointments
                new Appointment("David Maca", "Checkup", new DateTime(2022,11,30,9,15,0), 30,"Dr. Far"),
                new Appointment("Alden John", "X-Ray", new DateTime(2022,11,30,13,30,0), 15,"Dr. Drake"),
                new Appointment("Abe Jay", "Checkup and X-Ray", new DateTime(2022,11,30,13,30,0), 30,"Dr. Guy"),
                new Appointment("Josh Richards", "Checkup and consultation", new DateTime(2022,11,29,16,15,0), 45,"Dr. Wade"),
                new Appointment("Arhum Gambino", "Checkup", new DateTime(2022,11,27,16,30,0), 30,"Dr. James"),
                new Appointment("Frank Garfield", "Consultation", new DateTime(2022,12,01,18,00,0), 15, "Dr. Shaw"),

                new Appointment("David Max", "Checkup", new DateTime(2022,11,30,12,01,0), 30,"Dr. Far"),
                new Appointment("Alden Bay", "X-Ray", new DateTime(2022,11,30,12,30,0), 15,"Dr. Drake"),
                new Appointment("Abe John", "Checkup and X-Ray", new DateTime(2022,11,27,14,30,0), 30,"Dr. Guy"),
                new Appointment("Josh Rich", "Checkup and consultation", new DateTime(2022,11,28,16,15,0), 45,"Dr. Wade"),
                new Appointment("Arhum Lino", "Checkup", new DateTime(2022,11,27,16,30,0), 30,"Dr. James"),
                new Appointment("Frank Field", "Consultation", new DateTime(2022,12,01,18,00,0), 15, "Dr. Shaw"),

            };

            Doctors = new List<Doctor>()
            {
                // Dummy Doctors
                new Doctor("Steven", "Strange", "steveS@email.com", "403-123-4567", "yes", new DateTime(1980,05,10))
            };

            Clients = new List<Client>()
            {
                // Dummy Clients
                new Client("Josh", "Richards", "jrichards@email.com", "403-123-1234", 12345678, Doctors[0], new DateTime(1990, 10, 10), 1),
                new Client("David", "Maca", "Dmaca@email.com", "403-123-1234", 12345678, Doctors[0], new DateTime(1992, 10, 10), 2)
            };

        }
    }
}
