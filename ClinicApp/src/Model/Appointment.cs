using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.Model
{
    internal class Appointment
    {
        public string Name { get; set; }

        public string Description { get; set; }
        public string Time { get; set; }

        public Appointment(string name, string description, string time)
        {
            Name = name;
            Description = description;
            Time = time;
        }
    }
}
