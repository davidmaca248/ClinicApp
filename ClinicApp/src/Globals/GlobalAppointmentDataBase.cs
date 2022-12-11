﻿using ClinicApp.Model;
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

            AppointmentList = new List<Appointment>()
            {
                // Dummy Appointments
                new Appointment("Davis Mark", "Checkup", new DateTime(2022,12,day1,9,15,0), 30,"Dr. Far"),
                new Appointment("Alden John", "X-Ray", new DateTime(2022,12,day1,13,30,0), 15,"Dr. Drake"),
                new Appointment("Abe Jay", "Checkup and X-Ray", new DateTime(2022,12,day2,13,30,0), 30,"Dr. Guy"),
                new Appointment("Josh Richards", "Checkup and consultation", new DateTime(2022,12,day2,16,15,0), 45,"Dr. Wade"),
                new Appointment("Arhum Gambino", "Checkup", new DateTime(2022,12,day2,16,30,0), 30,"Dr. James"),
                new Appointment("Frank Garfield", "Consultation", new DateTime(2022,12,day3,18,00,0), 15, "Dr. Shaw"),

                new Appointment("Dave Max", "Checkup", new DateTime(2022,12,day4,12,01,0), 30,"Dr. Far"),
                new Appointment("Alden Bay", "X-Ray", new DateTime(2022,12,day1,12,30,0), 15,"Dr. Drake"),
                new Appointment("Abe John", "Checkup and X-Ray", new DateTime(2022,12,day3,14,30,0), 30,"Dr. Guy"),
                new Appointment("Josh Rich", "Checkup and consultation", new DateTime(2022,12,day4,16,15,0), 45,"Dr. Wade"),
                new Appointment("Arhum Lino", "Checkup", new DateTime(2022,12,day2,16,30,0), 30,"Dr. James"),
                new Appointment("Frank Field", "Consultation", new DateTime(2022,12,day1,18,00,0), 15, "Dr. Shaw"),

            };

            // Assign IDs
            for(int i = 0; i < AppointmentList.Count; i++)
            {
                AppointmentList.ElementAt(i).Id = i + 1;
            }

            Doctors = new List<Doctor>()
            {
                // Dummy Doctors
                new Doctor("Steven", "Strange", "steveS@gmail.ca", "403-133-4557", "yes", new DateTime(1980,05,10)),
                new Doctor("Will", "Range", "WRange@gmail.com", "403-113-4565", "yes", new DateTime(1980,05,10))
            };

            Clients = new List<Client>()
            {
                // Dummy Clients
                new Client("Josh", "Richards", "jrich@email.com", "403-154-1324", "12345678", Doctors[0], new DateTime(1990, 10, 10), 1),
                new Client("David", "Maca", "Dmaca@email.com", "587-131-1312", "87654321", Doctors[0], new DateTime(1992, 10, 10), 2)
            };

        }
    }
}
