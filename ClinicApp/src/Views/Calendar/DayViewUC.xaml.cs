using ClinicApp.Model;
using ClinicApp.ViewModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;


namespace ClinicApp.Views.Calendar
{
    /// <summary>
    /// Interaction logic for DayViewUC.xaml
    /// </summary>
    public partial class DayViewUC : UserControl
    {
        public DayViewModel ViewModel;
        private readonly CalendarTabViewModel _parentViewModel;

        public DayViewUC(CalendarTabViewModel parentViewModel)
        { 
            _parentViewModel = parentViewModel;
            ViewModel = new DayViewModel();
            DataContext = ViewModel;

            InitializeComponent();
        }

        private void PrevButtonClick(object sender, RoutedEventArgs e)
        {
            ViewModel.DisplayedDay = ViewModel.DisplayedDay.AddDays(-1);
        }

        private void NextButtonClick(object sender, RoutedEventArgs e)
        {
            ViewModel.DisplayedDay = ViewModel.DisplayedDay.AddDays(1);
        }
        private void BackButtonClick(object sender, RoutedEventArgs e)
        {
            _parentViewModel.BackClicked();
        }

        private void RowDoubleClick(object sender, MouseButtonEventArgs e)
        {
            DataGridRow row = (DataGridRow)sender;
            Appointment selected = (Appointment)row.Item;

        }
    }
}
