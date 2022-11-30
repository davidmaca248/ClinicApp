using ClinicApp.Common;
using ClinicApp.Views;
using ClinicApp.Views.Calendar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ClinicApp.ViewModel
{
	internal class MainViewModel : BaseViewModel
	{
        #region Propeties
		// Navigation Commands
		public RelayCommand HomeViewCommand { get; set; }
		public RelayCommand CalendarViewCommand { get; set; }
		public RelayCommand AppointmentViewCommand { get; set; }
        public RelayCommand AppointmentTypeViewCommand { get; set; }

        public object CurrentView
        {
            get => _currentView;
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }
		#endregion

		#region Members
		private object _currentView;
        private HomeContentUC _HomeView;
        private CalendarTabUC _CalendarTabView;
		private AppointmentBookingClient _AppointmentBookingClientView;
        private AppointmentBookingTime _AppointmentBookingTypeView;
        private AppointmentBookingDate _AppointmentBookingDateView;

        private AppointmentViewModel AppointmentBookVM;
        #endregion

        public MainViewModel()
		{
			_HomeView = new HomeContentUC();
			_CalendarTabView = new CalendarTabUC();
            _AppointmentBookingClientView = new AppointmentBookingClient();
            _AppointmentBookingTypeView = new AppointmentBookingTime();
            _AppointmentBookingDateView = new AppointmentBookingDate();

            AppointmentBookVM = new AppointmentViewModel();

			CurrentView = _HomeView;

			HomeViewCommand = new RelayCommand(o =>
			{
				CurrentView = _HomeView;
			});

			CalendarViewCommand = new RelayCommand(o =>
			{
				CurrentView = _CalendarTabView;
			});

			AppointmentViewCommand = new RelayCommand(o =>
			{
                CurrentView = _AppointmentBookingClientView;		
            });

            AppointmentTypeViewCommand = new RelayCommand(o =>
            {
                CurrentView = _HomeView;
            });
        }

        public void SwitchPage(UserControl uc)
        {
            CurrentView = uc;
        }

    }
}
