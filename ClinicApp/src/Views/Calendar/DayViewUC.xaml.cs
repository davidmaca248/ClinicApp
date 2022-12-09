using ClinicApp.Globals;
using ClinicApp.Model;
using ClinicApp.ViewModel;
using ClinicApp.Views.Popups;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Effects;

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
            GlobalAppointmentDataBase.SelectedAppointment = (Appointment)row.Item;
            AppointmentDetailsPopup modal = new AppointmentDetailsPopup();
            modal.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            Switcher.pageSwitcher.Effect = new BlurEffect();
            modal.ShowDialog();
            Switcher.pageSwitcher.Effect = null;
            ViewModel.UpdateContent();
        }
    }
}
