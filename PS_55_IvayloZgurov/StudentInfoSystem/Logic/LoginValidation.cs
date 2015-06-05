using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentInfoSystem.Data;

namespace StudentInfoSystem.Logic
{
    class LoginValidation
    {
        private String _username;
        private String _password;

        public LoginValidation(String username, String password) 
        {
            _username = username;
            _password = password;
            errText = String.Empty;
        }

        public String errText { get; private set; }

        private bool IsStringEmpty(String str) 
        {
            if(str.Length == 0) 
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

        public bool ValidateUserInput(out User user) 
        {

            if (IsStringEmpty(_username))
            {
                errText = "The username field cannot be empty";
                user = null;
                return false;
                
            }
            else if (IsStringEmpty(_password))
            {
                errText = "The password field cannot be empty";
                user = null;
                return false;
            }
            else if (IsStringLessThan(_password, 4))
            {
                errText = "The password must be at least 4 symbols long";
                user = null;
                return false;
            }

            

          
                User queryResult = UserData.IsUserPassCorrect(_username, _password);
                if (queryResult == null)
                {
                    errText = "You have entered a wrong username or password";
                    user = null;
                    return false;
                }  
                else 
                {
                user = queryResult;
                return true;
                }
        }
    }
}
