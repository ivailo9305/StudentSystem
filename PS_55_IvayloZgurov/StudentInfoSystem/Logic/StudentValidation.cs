using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentInfoSystem.Data;

namespace StudentInfoSystem.Logic
{
    class StudentValidation
    {
        public static Data.Student isThereStudent(Data.User user)
        {
            return UserData.GetStudentDataByUser(user.FacNumber);
        }

        public static bool InsertStudentIfValid(Student s)
        {

            bool valid = true;

            if (String.IsNullOrEmpty(s.FirstName))
            {
                valid = false;
            }
            
            if (String.IsNullOrEmpty(s.LastName))
            {
                valid = false;
            }
            
            if (String.IsNullOrEmpty(s.SecondName))
            {
                valid = false;
            }

            if (String.IsNullOrEmpty(s.Faculty))
            {
                valid = false;
            }

            if (String.IsNullOrEmpty(s.FakNumber))
            {
                valid = false;
            }

            if (String.IsNullOrEmpty(s.Specialty))
            {
                valid = false;
            }

            if (String.IsNullOrEmpty(s.Potok))
            {
                valid = false;
            }

            if (s._Group_ == 0)
            {
                valid = false;
            }

            if (valid) 
            {
                bool result = UserData.InsertStudent(s);
                return result;
            }

            else 
            {
                return false;
            }
        }
    }
}
