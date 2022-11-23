﻿using ClinicApp.Globals;
using ClinicApp.Views;
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

namespace ClinicApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Switcher.pageSwitcher = this;
        }

        private void NavbarUC_Loaded(object sender, RoutedEventArgs e)
        {

        }

        public void Navigate(UserControl nextPage)
        {
            (this.FindName("mainContent") as ContentControl).Content = nextPage;
        }
    }
}
