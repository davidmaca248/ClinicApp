using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.Model
{
    public class Client : Person
    {
        public Doctor FamilyDoctor { get; set; }
        public int HealthCareNumber { get; set; } 
    }
}
