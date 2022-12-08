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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Controls.Primitives;
using static System.Net.Mime.MediaTypeNames;
using Image = System.Windows.Controls.Image;

namespace ClinicApp.Views
{
    /// <summary>
    /// Interaction logic for AccountLoggedIn.xaml
    /// </summary>
    public partial class AccountLoggedIn : UserControl
    {
        public AccountContentViewModel ViewModel;
        private readonly AccountTabViewModel _parentViewModel;

        public Uri ImageUri { get; set; }
        public Image ImageURL { get; set; }

        public AccountLoggedIn(AccountTabViewModel parentViewModel)
        {
            _parentViewModel = parentViewModel;
            ViewModel = new AccountContentViewModel();
            DataContext = ViewModel;

            ImageUri= new Uri("pack://application:,,,/Views/doctor.png");
            if (ViewModel.UserLoggedIn == 1)
            {
                
                //pfp.Source = new BitmapImage(new Uri("Images/Num1_Over.png", UriKind.Relative));
                //Image finalImage = new Image();
                //finalImage.Width = 200;
                //finalImage.Height = 200;
                //finalImage.Source = new BitmapImage(new Uri("C:\\Users\\Frank\\source\\repos\\ClinicApp1\\ClinicApp\\src\\Photos\\doctor.png"));
                
                //userGrid.Children.Add(finalImage);
                //Grid.SetColumn(finalImage,0);
                //Grid.SetRow(finalImage,1);
                //Grid.SetColumnSpan(finalImage,3);
                //Grid.SetRowSpan(finalImage,2);

            }
            else if(ViewModel.UserLoggedIn == 2)
            {

            }
            else if(ViewModel.UserLoggedIn==3)
            {

            }


            InitializeComponent();


        }

        private void logOut(object sender, RoutedEventArgs e)
        {
            _parentViewModel.UserLoggedOut();
            
        }

        
    }
}
