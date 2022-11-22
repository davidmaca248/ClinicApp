using ClinicApp.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.ViewModel
{
    internal class CalendarTabViewModel : BaseViewModel
    {
        #region Propeties
        private CalendarContentViewModel CalendarContentVM;
        private DayViewModel DayVM;

        // Navigation Commands

        #endregion

        private object _currentContent;

        public object CurrentContent
        {
            get => _currentContent;
            set
            {
                _currentContent= value;
                OnPropertyChanged();
            }
        }

        public CalendarTabViewModel()
        {
            CalendarContentVM = new CalendarContentViewModel();
            DayVM = new DayViewModel();
            CurrentContent = CalendarContentVM;

            //HomeViewCommand = new RelayCommand(o =>
            //{
            //    CurrentView = HomeVM;
            //});


        }
    }
}
