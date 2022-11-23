using ClinicApp.Common;
using ClinicApp.Views;
using ClinicApp.Views.Calendar;
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
		// Navigation Commands
		public RelayCommand HomeViewCommand { get; set; }
		public RelayCommand CalendarViewCommand { get; set; }

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
        #endregion

        public MainViewModel()
		{
			_HomeView = new HomeContentUC();
			_CalendarTabView = new CalendarTabUC();	

			CurrentView = _HomeView;

			HomeViewCommand = new RelayCommand(o =>
			{
				CurrentView = _HomeView;
			});

			CalendarViewCommand = new RelayCommand(o =>
			{
				CurrentView = _CalendarTabView;
			});
		}
	}
}
