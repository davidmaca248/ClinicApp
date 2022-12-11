using ClinicApp.Globals;
using ClinicApp.Model;
using ClinicApp.ViewModel;
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
    /// Interaction logic for HomeContentUC.xaml
    /// </summary>
    public partial class HomeContentUC : UserControl
    {
        private HomeViewModel _viewModel;
        public HomeContentUC()
        {
            _viewModel = new HomeViewModel();
            DataContext = _viewModel;

            InitializeComponent();
        }

        private void PrevButtonClick(object sender, RoutedEventArgs e)
        {
            _viewModel.DisplayedDay = _viewModel.DisplayedDay.AddDays(-1);
        }

        private void NextButtonClick(object sender, RoutedEventArgs e)
        {
            _viewModel.DisplayedDay = _viewModel.DisplayedDay.AddDays(1);
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
            _viewModel.updateContent();
        }

        private void AddTodoButtonClick(object sender, RoutedEventArgs e)
        {
            string text = AddTodo.Text;
            int id = GlobalHomePageListDatabase.TodoList.Count + 1;
            // add text to list
            GlobalHomePageListDatabase.TodoList.Add(new NoteListItem(id, text, _viewModel.DisplayedDay));
            _viewModel.TodoList = GlobalHomePageListDatabase.TodoList.Where(x => x.Date.Date == _viewModel.DisplayedDay.Date).ToList();

            AddTodo.Text = string.Empty;
        }
        private void DeleteTodoButtonClick(object sender, RoutedEventArgs e)
        {
            int id = (int)((Button)sender).Tag;


            GlobalHomePageListDatabase.TodoList.RemoveAll(x => x.Id == id);
            _viewModel.TodoList = GlobalHomePageListDatabase.TodoList.Where(x => x.Date.Date == _viewModel.DisplayedDay.Date).ToList();
        }

        private void AddNoteButtonClick(object sender, RoutedEventArgs e)
        {
            string text = AddNote.Text;
            int id = GlobalHomePageListDatabase.NotesList.Count + 1;

            GlobalHomePageListDatabase.NotesList.Add(new NoteListItem(id, text, _viewModel.DisplayedDay));
            _viewModel.NotesList = GlobalHomePageListDatabase.NotesList.Where(x => x.Date.Date == _viewModel.DisplayedDay.Date).ToList();

            AddNote.Text = string.Empty;
        }

        private void DeleteNoteButtonClick(object sender, RoutedEventArgs e)
        {
            int id = (int)((Button)sender).Tag;


            GlobalHomePageListDatabase.NotesList.RemoveAll(x => x.Id == id);
            _viewModel.NotesList = GlobalHomePageListDatabase.NotesList.Where(x => x.Date.Date == _viewModel.DisplayedDay.Date).ToList();
        }
    }
}
