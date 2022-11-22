using ClinicApp.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.ViewModel
{
    internal class CalendarViewModel : BaseViewModel
    {
        #region Propeties

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

        public CalendarViewModel()
        {
            DayVM = new DayViewModel();
            CurrentContent = DayVM;

            //HomeViewCommand = new RelayCommand(o =>
            //{
            //    CurrentView = HomeVM;
            //});


        }
    }
}
