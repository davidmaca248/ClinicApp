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

        private DateTime Datetime;

        private DateTime EndTime;
        public string DurationStr { get; set; }
        public string Time { get; set; }    
        public string DoctorName { get; set; }
        public Doctor Doctor { get; set; }
        public Client Client { get; set; }


        public Appointment(string name, string description, DateTime dateTime, DateTime endTime, string doctorName)
        {
            Name = name;
            Description = description;
            Datetime = dateTime;
            EndTime = endTime;
            DurationStr = (EndTime - Datetime).TotalMinutes.ToString() + " Min";
            Time = Datetime.ToString("h:mm tt");
            DoctorName = doctorName;
        }

        public DateTime getDateTime()
        {
            return Datetime;
        }

        public DateTime getEndTime()
        {
            return EndTime;
        }
        public void setDateTime(DateTime dateTime)
        {
            Datetime = dateTime;
            DurationStr = (EndTime - Datetime).TotalMinutes.ToString() + " Min";
        }
        public void setEndTime(DateTime endTime)
        {
            EndTime = endTime;
            DurationStr = (EndTime - Datetime).TotalMinutes.ToString() + " Min";
        }
    }
}
