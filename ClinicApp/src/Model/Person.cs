using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.Model
{
    public class Person
    {
        public int PersonId { get; set; } = 0;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;

        // stored as a string since our application doesn't directly connect to email and cannot
        // make a phone call.
        public string Email { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public DateTime DateOfBirth { get; set; }
        public List<Appointment> Appointments { get; set; } = new List<Appointment>();

    }
}
