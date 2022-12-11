using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.Model
{
    public class Doctor : Person
    {
        public string PractionerId { get; set; } = string.Empty;

        // Only assigned yes or no depending on a dropdown menu
        public string AcceptingPatients { get; set; }

        // Hardcoded available times (possible work in progress: get doctors times from spreadsheet)
        public List<DateTime> AvailableTimes { get; set; } = new List<DateTime>()
        {
            new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 9, 0, 0),
            new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 9, 30, 0),
            new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 10, 0, 0),
            new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 10, 30, 0),
            new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 11, 0, 0),
            new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 11, 30, 0),
            new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 12, 00, 0),
            new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 12, 30, 0),
            new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 13, 00, 0),
            new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 13, 30, 0),
            new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 14, 00, 0),
            new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 14, 30, 0),
            new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 15, 00, 0),
            new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 15, 30, 0),
            new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 16, 00, 0),
            new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 16, 30, 0)
        };

        public bool[] displayTimes = new bool[16];

        public List<string> Display = new List<string>();

        public Doctor() { }

        public Doctor(string firstname, string lastname, string email, string phonenumber,
             string acceptingPatients, DateTime DoB, int id)
        {
            PersonId = id;
            FirstName = firstname;
            LastName = lastname;
            Email = email;
            PhoneNumber = phonenumber;
            DateOfBirth = DoB;
            AcceptingPatients = acceptingPatients;
        }
    }
}
