using ClinicApp.Common;
using ClinicApp.Views.Calendar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.ViewModel
{
    public class CalendarTabViewModel : BaseViewModel
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
            _CalendarContentView = new CalendarContentUC(this);
            _DayView = new DayViewUC(this);

            CurrentContent = _CalendarContentView;
        }

        public void DayClicked(DateTime day)
        {
            _DayView.ViewModel.DisplayedDay = day;

            CurrentContent = _DayView;
        }

        public void BackClicked()
        {
            _DayView.ViewModel.DisplayedDay = DateTime.Now;

            CurrentContent = _CalendarContentView;
        }
    }
}
