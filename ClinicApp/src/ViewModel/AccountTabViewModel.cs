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


        public int currUser {
            get => curruser;
            set
            {
                curruser= value;
            }
        }

        private int curruser;

        #endregion

        #region Members
        private object _currentContent;
        private AccountLoggedIn _AccountLoggedView;
        private AccountUC _AccountContentView;

        private User1 user1;
        private User2 user2;
        private User3 user3;


        #endregion
        public AccountTabViewModel()
        {
            _AccountLoggedView = new AccountLoggedIn(this);
            _AccountContentView = new AccountUC(this);
            user1 = new User1(this);
            user2 = new User2(this);
            user3 = new User3(this);
            CurrentAccountContent = _AccountContentView;
        }
        public void UserLoggedIn(int user)
        {
          
            _AccountLoggedView.ViewModel.UserLoggedIn = user;
            curruser= user;
            if(user == 1)
            {
                CurrentAccountContent = user1;

            }
            else if(user == 2)
            {
                CurrentAccountContent = user2;
            }
            else if(user == 3)
            {
                CurrentAccountContent = user3;
            }

        }

        public void UserLoggedOut()
        {
            _AccountContentView.pbox.Clear();
            CurrentAccountContent = _AccountContentView;
            
        }

    }
}
