using ClinicApp.Globals;
using ClinicApp.Model;
using ClinicApp.Views.Popups;
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
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ClinicApp.Views
{
    /// <summary>
    /// Interaction logic for ClientUC.xaml
    /// </summary>
    public partial class ClientUC : UserControl
    {
        List<Client> clients = new List<Client>();
        public ClientUC()
        {
            InitializeComponent();
            clients = GlobalAppointmentDataBase.Clients;
            LoadContent();
        }
        private void Search(object sender, RoutedEventArgs e)
        {
            TextBox tb = sender as TextBox;
            string query = tb.Text.ToUpper();
            clients = GlobalAppointmentDataBase.Clients.Where(x => x.FirstName.ToUpper().Contains(query) || x.LastName.ToUpper().Contains(query) || (x.FirstName.ToUpper() + " " + x.LastName.ToUpper()).Contains(query)).ToList();
            LoadContent();
        }

        private void OpenDetails(object sender, RoutedEventArgs e)
        {
            Border b = sender as Border;
            string tag = b.Tag.ToString();
            int id = Int32.Parse(tag);
            GlobalAppointmentDataBase.SelectedClient = GlobalAppointmentDataBase.Clients.Find(x => x.PersonId == id);
            ClientDetailsPopup modal = new ClientDetailsPopup();
            modal.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            Switcher.pageSwitcher.Effect = new BlurEffect();
            modal.ShowDialog();
            Switcher.pageSwitcher.Effect = null;
        }

        private void LoadContent()
        {
            StackPanel panel = this.FindName("panel1") as StackPanel;
            panel.Children.Clear();
            WrapPanel wpanel = new WrapPanel();
            foreach (Client d in clients)
            {
                Border b = new Border();
                StackPanel panel2 = new StackPanel();
                panel2.Orientation = Orientation.Vertical;
                TextBlock tb = new TextBlock();
                tb.Foreground = Brushes.MintCream;
                tb.Text = d.FirstName + " " + d.LastName;
                panel2.Children.Add(tb);
                tb = new TextBlock();
                tb.Foreground = Brushes.MintCream;
                tb.Text = d.Email;
                panel2.Children.Add(tb);
                tb = new TextBlock();
                tb.Foreground = Brushes.MintCream;
                tb.Text = d.PhoneNumber;
                panel2.Children.Add(tb);
                b.Tag = d.PersonId.ToString();
                b.Child = panel2;
                wpanel.Children.Add(b);
            }
            panel.Children.Add(wpanel);
        }
    }
}
