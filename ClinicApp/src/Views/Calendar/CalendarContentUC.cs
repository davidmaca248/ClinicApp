using ClinicApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ClinicApp.Views.Calendar
{
    /// <summary>
    /// Interaction logic for CalendarViewUC.xaml
    /// </summary>
    public partial class CalendarContentUC : UserControl
    {
        private readonly CalendarTabViewModel _parentViewModel;
        public CalendarContentUC(CalendarTabViewModel parentViewModel)
        {
            _parentViewModel = parentViewModel;
            InitializeComponent();
        }

        private void MonthlyCalendar_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            System.Windows.Controls.Calendar calendar = (System.Windows.Controls.Calendar)sender;

            if (calendar.SelectedDate != null)
            {
                DateTime day = (DateTime)calendar.SelectedDate;
                _parentViewModel.DayClicked(day);
            }
        }
    }
}
