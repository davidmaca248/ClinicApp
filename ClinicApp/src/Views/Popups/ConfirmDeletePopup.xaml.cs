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
    /// Interaction logic for ConfirmDeletePopup.xaml
    /// </summary>
    public partial class ConfirmDeletePopup : Window
    {
        public ConfirmDeletePopup()
        {
            InitializeComponent();
        }

        private void Yes(object sender, RoutedEventArgs e)
        {
            GlobalAppointmentDataBase.Confirm = true;
            this.Close();
        }

        private void No(object sender, RoutedEventArgs e)
        {
            GlobalAppointmentDataBase.Confirm = false;
            this.Close();
        }
    }
}
