using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.Model
{
    public class Doctor : Person
    {
        public int PractionerId { get; set; }

        // Only assigned yes or no depending on a dropdown menu
        public string AcceptingPatients { get; set; }
    }
}
