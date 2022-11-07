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
		private DoctorsViewModel DoctorsVM;
        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand DoctorViewCommand { get; set; }

        #endregion

        #region Navigation Commands



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
			DoctorsVM = new DoctorsViewModel();
			CurrentView = HomeVM;

			HomeViewCommand = new RelayCommand(o =>
			{
				CurrentView = HomeVM;
			});

			DoctorViewCommand = new RelayCommand(o =>
			{
				CurrentView = DoctorsVM;
			});
		}
	}
}
