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
        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime Datetime { get; set;}

        public string Date { get; set; }   

        public string Time { get; set; }    
        public string DoctorName { get; set; }
        public Doctor Doctor { get; set; }
        public Client Client { get; set; }

        public Appointment(string name, string description, DateTime dateTime, string doctorName)
        {
            Name = name;
            Description = description;
            Datetime = dateTime;
            Time = Datetime.ToString("h:mm tt");
            Date = Datetime.Date.ToShortDateString();
            DoctorName = doctorName;
        }
    }
}
