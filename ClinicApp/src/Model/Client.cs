using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClinicApp.Model
{
    public class Client : Person
    {
        public Doctor FamilyDoctor { get; set; } = new Doctor();
        public string HealthCareNumber { get; set; } = string.Empty;

        public Client() { }

        // Constructor for adding an appointment
        public Client(int id, string firstname, string lastname, string contactinfo)
        {
            if (contactinfo.Contains("@")) 
            {
                Email = contactinfo;
            }
            else
            {
                PhoneNumber= contactinfo;
            }
            FirstName = firstname;
            LastName = lastname;
            PersonId = id;
        }

        public Client(string firstname, string lastname, string email, string phonenumber, 
            string healcarenum, Doctor familyDoctor, DateTime DoB, int id) 
        { 
            PersonId = id;
            FirstName= firstname;
            LastName= lastname;
            Email = email;
            PhoneNumber = phonenumber;
            DateOfBirth = DoB;
            HealthCareNumber = healcarenum;
            FamilyDoctor = familyDoctor;
        }
    }
}
