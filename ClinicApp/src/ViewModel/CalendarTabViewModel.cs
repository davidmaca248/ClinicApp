using ClinicApp.Common;
using ClinicApp.Views.Calendar;
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
        private CalendarContentUC _CalendarContentView;
        private DayViewUC _DayView;
        #endregion

        public CalendarTabViewModel()
        {
            _CalendarContentView = new CalendarContentUC();
            _DayView = new DayViewUC();

            CurrentContent = _CalendarContentView;


        }
    }
}
