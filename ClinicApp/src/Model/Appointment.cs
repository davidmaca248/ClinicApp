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

        //public DateTime Datetime { get; set; }

        public string Date { get; set; }

        public DateTime StartTime { get; set; } = new DateTime();
        public DateTime EndTime { get; set; }
        public int Duration { get; set; } = 0;

        public string Email { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;

        //public double DurationMinutes { get; set; }
        public string DurationStr { get; set; }
        public string Time { get; set; }    
        public string DoctorName { get; set; }
        public string Status { get; set; }

        // Should be storing Foreign Keys, possibly change for the future
        public Doctor Doctor { get; set; } = new Doctor();
        public Client Client { get; set; } = new Client();

        public Appointment() { }

        public Appointment(string name, string description, DateTime dateTime, int duration, string doctorName)
        {
            Name = name;
            Client client = GlobalAppointmentDataBase.Clients.Find(x => name.Contains(x.LastName) && name.Contains(x.FirstName));
            //Email = client.Email;
            //PhoneNumber = client.PhoneNumber;
            Description = description;
            StartTime = dateTime;
            Date = StartTime.ToString("MMMM dd, yyyy");
            EndTime = StartTime.AddMinutes(duration);
            Duration = duration;
            DurationStr = Duration.ToString() + " Min";
            Time = StartTime.ToString("h:mm tt");
            DoctorName = doctorName;
        }

        public Appointment(Client client, string description, DateTime dateTime, int duration, Doctor doctor)
        {
            Client = GlobalAppointmentDataBase.Clients.Find(x => x == client);
            Email = client.Email;
            PhoneNumber = client.PhoneNumber;
            Client.Appointments.Add(this);
            Name = client.FirstName + " " + client.LastName;
            Description = description;
            StartTime = dateTime;
            Date = StartTime.ToString("MMMM dd, yyyy");
            EndTime = StartTime.AddMinutes(duration);
            Duration = duration;
            DurationStr = Duration.ToString() + " Min";
            Time = StartTime.ToString("h:mm tt");
            Doctor = GlobalAppointmentDataBase.Doctors.Find(x => x == doctor);
            Doctor.Appointments.Add(this);
            DoctorName = "Dr. " + doctor.LastName;
        }
    }
}
