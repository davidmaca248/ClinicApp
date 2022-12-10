using ClinicApp.Globals;
using ClinicApp.ViewModel;
using ClinicApp.Model;
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
using System.Windows.Media.Effects;

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
            vm = new FindClientViewModel();

            InitializeComponent();
        }
        
        private void Click(object sender, RoutedEventArgs e)
        {
            StackPanel panel = sender as StackPanel;
            TextBlock text = panel.FindName("id") as TextBlock;
            ClientId = int.Parse(text.Text);
            GlobalAppointmentDataBase.AppointmentClient = GlobalAppointmentDataBase.Clients.Find(x => x.PersonId == ClientId);
            this.Close();
            Switcher.Switch(new AppointmentBookingTime());
            // There should be error checking code here, but for now theres nothing
        }

        private void Close(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Search(object sender, RoutedEventArgs e)
        {
            TextBox query = sender as TextBox;
            vm.updateContent(query.Text.ToUpper());
            
        }
    }
}
