using ClinicApp.Globals;
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
using System.Windows.Shapes;

namespace ClinicApp.Views.Popups
{
    /// <summary>
    /// Interaction logic for ClientUpcomingAppointment.xaml
    /// </summary>
    public partial class ClientUpcomingAppointment : Window
    {
        public ClientUpcomingAppointment()
        {
            vm = new ViewModel.AppointmentDetailsViewModel();
            InitializeComponent();
        }

        private void Search(object sender, RoutedEventArgs e)
        {
            TextBox query = sender as TextBox;
            vm.updateClientContent(query.Text.ToUpper());
        }

        private void Close(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Click(object sender, RoutedEventArgs e)
        {
            StackPanel panel = sender as StackPanel;
            int id = Int32.Parse(panel.Tag.ToString());
            GlobalAppointmentDataBase.SelectedAppointment = GlobalAppointmentDataBase.AppointmentList.Find(x => x.Id == id);
            AppointmentDetailsPopup modal = new AppointmentDetailsPopup();
            modal.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            modal.ShowDialog();
            if (GlobalAppointmentDataBase.Rescheduling)
                this.Close();
        }
    }
}
