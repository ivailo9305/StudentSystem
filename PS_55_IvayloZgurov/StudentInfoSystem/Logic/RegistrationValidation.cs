using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoSystem.Logic
{
    class RegistrationValidation
    {
        private String _username;
        private String _pass;
        private String _pass2;
        private String _facNumber;
        private int _role;

        public RegistrationValidation(String username, String pass, String pass2, String facNumber, int role)
        {
            _username = username;
            _pass = pass;
            _pass2 = pass2;
            _facNumber = facNumber;
            _role = role;
            errText = String.Empty;
        }

        public String errText { get; private set; }

        private bool IsStringEmpty(String str)
        {
            if (str.Length == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool IsStringLessThan(String str, int length)
        {
            if (str.Length < length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ValidateUserInput(out Data.User user)
        {

            if (IsStringEmpty(_username))
            {
                errText = "The username field cannot be empty";
                user = null;
                return false;

            }
            else if (IsStringEmpty(_pass))
            {
                errText = "The password field cannot be empty";
                user = null;
                return false;
            }
            else if (IsStringEmpty(_pass2))
            {
                errText = "The password field cannot be empty";
                user = null;
                return false;
            }
            else if (IsStringLessThan(_pass, 4))
            {
                errText = "The password must be at least 4 symbols long";
                user = null;
                return false;
            }
            else if (IsStringLessThan(_pass2, 4))
            {
                errText = "The password must be at least 4 symbols long";
                user = null;
                return false;
            }
            else if (!(_pass.Equals(_pass2)))
            {
                errText = "The passwords dont match";
                user = null;
                return false;
            }
            user = new Data.User();
            user.Username = _username;
            user.Password = _pass;
            user.FacNumber = _facNumber;
            user.Role = _role;
            return true;
        }
    }
}
