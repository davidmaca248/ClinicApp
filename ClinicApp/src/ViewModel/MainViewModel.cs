using ClinicApp.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.ViewModel
{
    internal class MainViewModel : BaseViewModel
    {
        #region Propeties

        private HomeViewModel HomeVM;
		private TestContentViewModel TestContentVM;
        private AppointmentViewModel AppointmentBookVM;
        private CalendarViewModel CalendarVM;

        // Navigation Commands
        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand TestContentViewCommand { get; set; }
        public RelayCommand AppointmentViewCommand { get; set; }
        public RelayCommand CalendarViewCommand{ get; set; }

        #endregion

        private object _currentView;

		public object CurrentView
		{
			get  => _currentView;
			set 
			{ 
				_currentView = value; 
				OnPropertyChanged();
			}
		}

		public MainViewModel()
		{
			HomeVM = new HomeViewModel();
			TestContentVM = new TestContentViewModel();
			AppointmentBookVM = new AppointmentViewModel();
			CalendarVM = new CalendarViewModel();

			CurrentView = HomeVM;

			HomeViewCommand = new RelayCommand(o =>
			{
				CurrentView = HomeVM;
			});

			TestContentViewCommand = new RelayCommand(o =>
			{
				CurrentView = TestContentVM;
			});

            AppointmentViewCommand = new RelayCommand(o =>
            {
                CurrentView = AppointmentBookVM;
            });

            CalendarViewCommand = new RelayCommand(o =>
            {
                CurrentView = CalendarVM;
            });
        }
	}
}
