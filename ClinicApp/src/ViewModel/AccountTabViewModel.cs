using ClinicApp.Views;
using ClinicApp.Views.Calendar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.ViewModel
{
    public class AccountTabViewModel : BaseViewModel
    {
        #region Propeties
        public object CurrentAccountContent
        {
            get => _currentContent;
            set
            {
                _currentContent = value;
                OnPropertyChanged();
            }
        }
        #endregion

        #region Members
        private object _currentContent;
        private AccountLoggedIn _AccountLoggedView;
        private AccountUC _AccountContentView;
        #endregion
        public AccountTabViewModel()
        {
            _AccountLoggedView = new AccountLoggedIn(this);
            _AccountContentView = new AccountUC(this);

            CurrentAccountContent = _AccountContentView;
        }
        public void UserLoggedIn(int user)
        {
          
            _AccountLoggedView.ViewModel.UserLoggedIn = user;
            
            CurrentAccountContent = _AccountLoggedView;

        }

        public void UserLoggedOut()
        {
            _AccountContentView.pbox.Clear();
            CurrentAccountContent = _AccountContentView;
            
        }

    }
}
