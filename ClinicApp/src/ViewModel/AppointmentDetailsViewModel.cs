using ClinicApp.Globals;
using ClinicApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.ViewModel
{
    internal class AppointmentDetailsViewModel : BaseViewModel
    {
        public Appointment app
        {
            get => _app;
            set
            {
                _app = value;
                OnPropertyChanged();
            }
        }

        public Doctor Doctor
        {
            get => _Doctor;
            set
            {
                _Doctor = value;
                OnPropertyChanged();
            }
        }
        public Client Client
        {
            get => _Client;
            set
            {
                _Client = value;
                OnPropertyChanged();
            }
        }
        public List<Doctor> Doctors
        {
            get => _Doctors;
            set
            {
                _Doctors = value;
                OnPropertyChanged();
            }
        }

        public List<Appointment> DocAppointments { 
            get => _DocAppointments; 
            set 
            { 
                _DocAppointments = value;
                OnPropertyChanged();
            } 
        }

        public List<Appointment> ClientAppointments
        {
            get => _ClientAppointments;
            set
            {
                _ClientAppointments = value;
                OnPropertyChanged();
            }
        }

        public string DoctorDoB { get; set; }
        public string ClientDoB { get; set; } 
        public string familydoctor { get; set; } 

        private Appointment _app;
        private Doctor _Doctor;
        private Client _Client;
        private List<Doctor> _Doctors;
        private List<Appointment> _DocAppointments;
        private List<Appointment> _ClientAppointments;


        public AppointmentDetailsViewModel()
        {
            app = GlobalAppointmentDataBase.SelectedAppointment;
            Doctor = GlobalAppointmentDataBase.SelectedDoctor;
            Client = GlobalAppointmentDataBase.SelectedClient;
            DocAppointments = GlobalAppointmentDataBase.SelectedDoctor.Appointments;
            ClientAppointments = GlobalAppointmentDataBase.SelectedClient.Appointments;
            Doctors = GlobalAppointmentDataBase.Doctors;
            DoctorDoB = Doctor.DateOfBirth.ToString("MMMM dd, yyyy");
            ClientDoB = Client.DateOfBirth.ToString("MMMM dd, yyyy");
            if (Client.FamilyDoctor.LastName != string.Empty)
                familydoctor = "Dr. " + Client.FamilyDoctor.LastName;
            else
                familydoctor = "None";
        }   

        public void update()
        {
            app = GlobalAppointmentDataBase.SelectedAppointment;
            Doctor = GlobalAppointmentDataBase.SelectedDoctor;
            DoctorDoB = Doctor.DateOfBirth.ToString("MMMM dd, yyyy");
        }

        public void updateDocContent(string query)
        {
            DocAppointments = GlobalAppointmentDataBase.SelectedDoctor.Appointments.Where(x => x.Date.ToUpper().Contains(query)).ToList();
        }

        public void updateClientContent(string query)
        {
            ClientAppointments = GlobalAppointmentDataBase.SelectedClient.Appointments.Where(x => x.Date.ToUpper().Contains(query)).ToList();
        }
    }
}
