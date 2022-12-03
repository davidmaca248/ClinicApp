using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClinicApp.Globals;

namespace ClinicApp.Model
{
    public class Appointment
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Description { get; set; } = string.Empty;

        public DateTime Datetime { get; set; }

        public string Date { get; set; }

        public DateTime StartTime { get; set; } = new DateTime();
        public DateTime EndTime { get; set; }
        public int Duration { get; set; } = 0;

        public double DurationMinutes { get; set; }
        public string DurationStr { get; set; }
        public string Time { get; set; }    
        public string DoctorName { get; set; }

        // Should be storing Foreign Keys, possibly change for the future
        public Doctor Doctor { get; set; } = new Doctor();
        public Client Client { get; set; }

        public Appointment() { }

        public Appointment(string name, string description, DateTime dateTime, double duration, string doctorName)
        {
            Name = name;
            Description = description;
            Datetime = dateTime;
            DurationMinutes = duration;
            DurationStr = DurationMinutes.ToString() + " Min";
            Time = Datetime.ToString("h:mm tt");
            DoctorName = doctorName;
        }
    }
}
