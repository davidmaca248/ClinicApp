using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.ViewModel
{
    public class AccountContentViewModel : BaseViewModel
    {

        public int UserLoggedIn
        {
            get => _userloggedin;
            set
            {
                _userloggedin = value;
            }

        }

        private int _userloggedin;


        public AccountContentViewModel() 
        { 

        }
    }
}
