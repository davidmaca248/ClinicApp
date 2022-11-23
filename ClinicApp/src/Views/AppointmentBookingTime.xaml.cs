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
using ClinicApp.Globals;

namespace ClinicApp.Views
{
    /// <summary>
    /// Interaction logic for AppointmentBookingTime.xaml
    /// </summary>
    public partial class AppointmentBookingTime : UserControl
    {
        public AppointmentBookingTime()
        {
            InitializeComponent();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new AppointmentBookingClient());
        }
    }
}
