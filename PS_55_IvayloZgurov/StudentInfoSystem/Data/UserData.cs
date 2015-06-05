using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoSystem.Data
{
    class UserData
    {
        public static User IsUserPassCorrect(string username, string password)
        {
            return UserData._IsUserPassCorrect(username, password);
        }

        private static User _IsUserPassCorrect(string username, string password) 
        {
            UserDataClassesDataContext dc = new UserDataClassesDataContext();
            var queryResult = (from users in dc.GetTable<User>()
                               where (users.Username == username) && (users.Password == password)
                               select users).ToArray<User>();
            if (queryResult.Count<User>() > 0 )
            {
                return queryResult.ElementAt<User>(0);
            }
            else 
            {
                return null;
            }
        }

        public static int IsUsernameTaken(string username)
        {
            return UserData._IsUserNametaken(username);
        }

        private static int _IsUserNametaken(string username)
        {
            UserDataClassesDataContext dc = new UserDataClassesDataContext();
            var queryResult = (from users in dc.GetTable<User>()
                               where (users.Username == username)
                               select users).ToArray<User>();
            if (queryResult.Count<User>() > 0)
            {
                return queryResult.ElementAt<User>(0).Role;
            }
            else
            {
                return -1;
            }
        }

        public static Student GetStudentDataByUser(String facNumber)
        {
            UserDataClassesDataContext dc = new UserDataClassesDataContext();
            var queryResult = (from students in dc.GetTable<Student>()
                               where (students.FakNumber.Equals(facNumber))
                               select students).ToArray<Student>();
            if (queryResult.Count<Student>() > 0)
            {
                return queryResult.ElementAt<Student>(0);
            }
            else
            {
                return null;
            }
        }

        public static bool InsertStudent(Student s)
        {
            UserDataClassesDataContext dc = new UserDataClassesDataContext();
            try
            {
                dc.AddNewStudent(s.FirstName, s.SecondName, s.LastName, s.Faculty, s.Specialty, s.OKS, s.StudentStatus,
                s.FakNumber, s.Course, s.Potok, s._Group_);
                dc.SubmitChanges();
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
                return false;
            }
            return true;
        }

        public static bool InsertUser(User user)
        {
            UserDataClassesDataContext dc = new UserDataClassesDataContext();
            try
            {
                dc.AddNewUser(user.Username, user.Password, user.FacNumber, (short)user.Role);
                dc.SubmitChanges();
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
                return false;
            }
            return true;
        }

        public static List<int> GetStudentGroups()
        {
            UserDataClassesDataContext dc = new UserDataClassesDataContext();
            var queryResult = (from students in dc.GetTable<Student>()
                               select students._Group_).Distinct().ToList<int>();
            return queryResult;
        }

    }
}
