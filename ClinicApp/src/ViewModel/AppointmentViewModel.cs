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
        private AppointmentBookingTime _AppointmentView;
        #endregion

        public AppointmentViewModel()
        {
            _AppointmentView = new AppointmentBookingTime();

            CurrentContent = _AppointmentView;
        }
    }
}
