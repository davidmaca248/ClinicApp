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
        public Doctor FamilyDoctor { get; set; } = null;
        public int HealthCareNumber { get; set; }

        // Constructor for adding an appointment
        public Client(string firstname, string lastname, string contactinfo)
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
        }

        public Client(string firstname, string lastname, string email, string phonenumber, 
            int healcarenum, Doctor familyDoctor, DateTime DoB, int id) 
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
