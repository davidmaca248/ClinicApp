using ClinicApp.Common;
using ClinicApp.Globals;
using ClinicApp.Model;
using ClinicApp.Views;
using ClinicApp.Views.Calendar;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.ViewModel
{
    internal class AppointmentViewModel : BaseViewModel
    {
        #region Propeties
        public object CurrentContent
        {
            get => _currentContent;
            set
            {
                _currentContent = value;
                OnPropertyChanged();
            }
        }
        #endregion

        #region Members
        private object _currentContent;
        private AppointmentBookingClient _AppointmentBookingClient;
        private AppointmentBookingDate _AppointmentBookingDate;
        private AppointmentBookingTime _AppointmentBookingTime;
        #endregion

        public AppointmentViewModel()
        {
            //_AppointmentBookingClient = new AppointmentBookingClient();
            //_AppointmentBookingTime = new AppointmentBookingTime();
            //_AppointmentBookingDate = new AppointmentBookingDate();

            //CurrentContent = _AppointmentBookingClient;
        }

        public void ToTime()
        {
            CurrentContent = _AppointmentBookingTime;
        }

        public void ToClient()
        {
            CurrentContent = _AppointmentBookingClient;
        }

        public void ToDate()
        {
            CurrentContent = _AppointmentBookingDate;
        }
    }
}
