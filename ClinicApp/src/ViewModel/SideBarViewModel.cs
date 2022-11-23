﻿using ClinicApp.Globals;
using ClinicApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.ViewModel
{
    internal class SideBarViewModel
    {
        public List<Appointment> AppointmentList { get; set; }

        public SideBarViewModel()
        {
            AppointmentList = GlobalAppointmentDataBase.AppointmentList;

        }
        
    }
}
