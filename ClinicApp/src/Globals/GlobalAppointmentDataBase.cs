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
        public static bool IsDoctor = false;
        public static bool Confirm = false;
        public static bool NewClient = false;
        public static bool Rescheduling = false;
        public static List<Doctor> Doctors { get; set; }
        public static List<Client> Clients { get; set; }
        public static List<Appointment> AppointmentList { get; set; }
        public static List<Appointment> DeletedAppointments { get; set; } = new List<Appointment>();
        public static Appointment NewAppointment { get; set; } = new Appointment();
        public static Client AppointmentClient { get; set; } = new Client();
        public static Appointment SelectedAppointment { get; set; } = new Appointment();
        public static Client SelectedClient { get; set; } = new Client();
        public static Doctor SelectedDoctor { get; set; } = new Doctor();

        static GlobalAppointmentDataBase()
        {
            DateTime d = DateTime.Now;
            int day1 = d.AddDays(-1).Day;
            int day2 = d.Day;
            int day3 = d.AddDays(1).Day;
            int day4 = d.AddDays(2).Day;

            Doctors = new List<Doctor>()
            {
                // Dummy Doctors
                new Doctor("Steven", "Strange", "steveS@gmail.ca", "403-133-4557", "yes", new DateTime(1980,05,10), 0),
                new Doctor("Will", "Range", "WRange@gmail.com", "403-112-4465", "yes", new DateTime(1982,06,11), 1),
                new Doctor("Derek", "Shaw", "DShaw@gmail.com", "403-111-4665", "yes", new DateTime(1984,01,12), 2),
                new Doctor("Brandon", "James", "BJames@gmail.com", "403-111-4115", "no", new DateTime(1977,03,03), 3),
                new Doctor("Steven", "Drake", "SDrake@gmail.com", "403-114-4535", "yes", new DateTime(1962,06,10), 4),
                new Doctor("John", "Doe", "JDoe@gmail.com", "403-115-1565", "no", new DateTime(1987,10,12), 5),
                new Doctor("Adam", "Smith", "ASmith@gmail.com", "403-111-4565", "yes", new DateTime(1969,11,11), 6) 
            };

            Clients = new List<Client>()
            {
                // Dummy Clients
                new Client("Josh", "Richards", "jrich@email.com", "403-154-1324", "12345678", Doctors[0], new DateTime(1990, 10, 10), 1),
                new Client("David", "Maca", "Dmaca@email.com", "587-131-1312", "87654321", Doctors[0], new DateTime(1992, 10, 10), 2),
                  new Client("John", "Smith", "jsmith@email.com", "403-321-3453", "74831739", new Doctor(), new DateTime(1997, 11, 11), 3),
                new Client("Josh", "Kim", "jkim@email.com", "587-321-0932", "09218981", Doctors[3], new DateTime(1989, 02, 15), 4),
                  new Client("Alfred", "Richards", "arich@email.com", "403-190-8490", "12345679", Doctors[4], new DateTime(1999, 12, 25), 5),
                new Client("Frank", "Mak", "fmak@email.com", "587-231-2312", "87314321", Doctors[4], new DateTime(1995, 10, 10), 6),
                  new Client("Josh", "Riche", "jriche@email.com", "403-124-1334", "23345678", new Doctor(), new DateTime(2009, 11, 15), 7),
                new Client("William", "Maca", "wmaca@email.com", "587-132-2322", "87222321", Doctors[5], new DateTime(1994, 10, 10), 8),
                  new Client("Ryan", "Johnson", "rjohn@email.com", "403-156-1333", "131245678", Doctors[6], new DateTime(1997, 11, 13), 9),
                new Client("Serena", "Mac", "Smac@email.com", "587-135-1111", "11154321", Doctors[1], new DateTime(1996, 11, 04), 10),
                  new Client("Logan", "Richards", "lrich@email.com", "403-122-1224", "12322228", Doctors[3], new DateTime(1999, 11, 10), 11),
                new Client("Fred", "Richards", "Frich@email.com", "587-171-1312", "87674321", new Doctor(), new DateTime(1991, 10, 10), 12),
                  new Client("Nick", "Fields", "nf@email.com", "403-154-1222", "12348908", Doctors[0], new DateTime(1994, 02, 10), 13),
                new Client("Shannon", "Maca", "Smaca@email.com", "587-139-1312", "87654321", Doctors[6], new DateTime(1998, 11, 10), 14),
                  new Client("Alex", "Martin", "amartin@email.com", "403-194-1329", "19995678", Doctors[2], new DateTime(1991, 11, 02), 15),
                new Client("Matt", "Maca", "Mmaca@email.com", "587-133-1333", "87633331", Doctors[1], new DateTime(1998, 02, 12), 16),
                  new Client("Josh", "Finch", "jfinch@email.com", "403-154-1324", "12215678", Doctors[2], new DateTime(1994, 12, 12), 17),
                new Client("Harry", "Potter", "hpotter@email.com", "587-181-1812", "87854321", new Doctor(), new DateTime(1996, 12, 12), 18),
                  new Client("Ron", "Richards", "rrich@email.com", "403-164-1624", "12336678", Doctors[0], new DateTime(1992, 12, 12), 19),
                new Client("Dan", "Maca", "Dmaca1@email.com", "587-133-1333", "87653331", Doctors[5], new DateTime(1993, 11, 12), 20),
                  new Client("Josh", "Lee", "jlee@email.com", "403-152-1222", "22245678", Doctors[3], new DateTime(1980, 10, 10), 21),
                new Client("David", "Kim", "DK@email.com", "587-111-1112", "17654321", new Doctor(), new DateTime(1982, 02, 10), 22)
            };

            AppointmentList = new List<Appointment>()
            {
                // Dummy Appointments
                new Appointment(Clients[1], "Checkup", new DateTime(2022,12,day1,9,0,0), 30,Doctors[3]),
                new Appointment(Clients[0], "X-Ray", new DateTime(2022,12,day1,13,30,0), 30,Doctors[2]),
                new Appointment(Clients[0], "Checkup and X-Ray", new DateTime(2022,12,day2,13,30,0), 30,Doctors[1]),
                new Appointment(Clients[2], "Checkup and consultation", new DateTime(2022,12,day3,11,30,0), 60,Doctors[1]),
                new Appointment(Clients[10], "Checkup", new DateTime(2022,12,day2,18,30,0), 30,Doctors[2]),
                new Appointment(Clients[5], "Consultation", new DateTime(2022,12,day3,18,00,0), 30, Doctors[6]),

                new Appointment(Clients[6], "Checkup", new DateTime(2022,12,day4,12,00,0), 30,Doctors[5]),
                new Appointment(Clients[3], "X-Ray", new DateTime(2022,12,day1,12,30,0), 30,Doctors[4]),
                new Appointment(Clients[4], "Checkup and X-Ray", new DateTime(2022,12,day3,14,30,0), 30,Doctors[0]),
                new Appointment(Clients[21], "Checkup and consultation", new DateTime(2022,12,day4,16,30,0), 30,Doctors[4]),
                new Appointment(Clients[17], "Checkup", new DateTime(2022,12,day2,16,30,0), 30,Doctors[2]),
                new Appointment(Clients[3], "Consultation", new DateTime(2022,12,day1,18,00,0), 30, Doctors[4]),
                new Appointment(Clients[3], "Consultation", new DateTime(2022,12,day2,15,30,0), 30, Doctors[3])

            };

            // Assign IDs
            for(int i = 0; i < AppointmentList.Count; i++)
            {
                AppointmentList.ElementAt(i).Id = i + 1;
            }

        }
    }
}
