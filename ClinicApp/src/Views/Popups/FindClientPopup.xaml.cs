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
    /// Interaction logic for FindClientPopup.xaml
    /// </summary>
    public partial class FindClientPopup : Window
    {
        private int ClientId;
        public FindClientPopup()
        {
            InitializeComponent();
        }
        
        private void Click(object sender, RoutedEventArgs e)
        {
            StackPanel panel = sender as StackPanel;
            TextBlock text = panel.FindName("id") as TextBlock;
            ClientId = int.Parse(text.Text);
            GlobalAppointmentDataBase.AppointmentClient = GlobalAppointmentDataBase.Clients.Find(x => x.PersonId == ClientId);
            Console.WriteLine(GlobalAppointmentDataBase.AppointmentClient.FirstName);
            // There should be error checking code here, but for now theres nothing
        }

    }
}
