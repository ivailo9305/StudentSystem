using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentInfoSystem.Data;
using StudentInfoSystem.Logic;

namespace StudentInfoSystem.View
{
    public partial class MainForm : Form
    {
      
        public UserStatus userStatus { get; private set;}
   

        public MainForm()
        {
            InitializeComponent();
            userStatus = UserStatus.ANONYMOUS;
            DisableAllControls();
        }

        private void showStudentInfo(Data.Student s)
        {
            if (s != null)
            {
            txtFirstName.Text = s.FirstName;
            txtSecondName.Text = s.SecondName;
            txtLastName.Text = s.LastName;
            txtFaculty.Text = s.Faculty;
            txtSpeciality.Text = s.Specialty;
            comboOKS.SelectedIndex = s.OKS.Equals("Bachelor") ? 0 : 1;
            comboStatus.SelectedIndex = s.StudentStatus;
            txtFakNumber.Text = s.FakNumber;
            numCourse.Value = s.Course;
            txtPotok.Text = s.Potok;
            txtGroup.Text = s._Group_.ToString();
            }
            else 
            {
                MessageBox.Show("No data for this user");
            }
        }

        private void ClearAllControls() 
        {
            txtFirstName.Text = "";
            txtSecondName.Text = "";
            txtLastName.Text = "";
            txtFaculty.Text = "";
            txtSpeciality.Text = "";
            comboOKS.SelectedIndex = 0;
            comboStatus.SelectedIndex = 0;
            txtFakNumber.Text = "";
            numCourse.Value = 1;
            txtPotok.Text = "";
            txtGroup.Text = "";
        }

        private void EnableAllControls() 
        {
            txtFirstName.Enabled = true;
            txtSecondName.Enabled = true;
            txtLastName.Enabled = true;
            txtFaculty.Enabled = true;
            txtSpeciality.Enabled = true;
            comboOKS.Enabled = true;
            comboStatus.Enabled = true;
            txtFakNumber.Enabled = true;
            numCourse.Enabled = true;
            txtPotok.Enabled = true;
            txtGroup.Enabled = true;
            btnOpenPic.Enabled = true;
            informationToolStripMenuItem.Enabled = true;
        }

        private void DisableAllControls()
        {
            txtFirstName.Enabled = false;
            txtSecondName.Enabled = false;
            txtLastName.Enabled = false;
            txtFaculty.Enabled = false;
            txtSpeciality.Enabled = false;
            comboOKS.Enabled = false;
            comboStatus.Enabled = false;
            txtFakNumber.Enabled = false;
            numCourse.Enabled = false;
            txtPotok.Enabled = false;
            txtGroup.Enabled = false;
            btnOpenPic.Enabled = false;
            informationToolStripMenuItem.Enabled = false;
        }



        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {

            switch (userStatus)
            {
                case UserStatus.ANONYMOUS:
                    login();
                    break;

                case UserStatus.STUDENT:
                    logout();
                    break;

                case UserStatus.ADMIN:
                    logout();
                    break;

                default:
                    break;
            } 
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            DialogResult result = aboutBox.ShowDialog(); 
            if (result == DialogResult.OK)
            {
                aboutBox.Close();
            }         
        }

        private void login()
        {
            LoginForm loginForm = new LoginForm();
            DialogResult result = loginForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                EnableAllControls();     
                loginToolStripMenuItem.Text = "Log Out";
                if (loginForm.user.Role == 3) 
                {
                    userStatus = UserStatus.ADMIN;
                    btnAddStudent.Visible = true;
                }
                else if (loginForm.user.Role == 1)
                {
                    showStudentInfo(StudentValidation.isThereStudent(loginForm.user));
                    userStatus = UserStatus.STUDENT;
                }
            }
        }
        
        private Data.Student ReadStudentInfo()
        {
            Data.Student st = new Data.Student();
            st.FirstName = txtFirstName.Text;
            st.LastName = txtLastName.Text;
            st.SecondName = txtSecondName.Text;
            st.Faculty = txtFaculty.Text;
            st.Specialty = txtSpeciality.Text;
            st.OKS = (short) comboOKS.SelectedIndex;
            st.StudentStatus = (short) comboStatus.SelectedIndex;
            st.FakNumber = txtFakNumber.Text;
            st.Course = (short) numCourse.Value;
            st.Potok = txtPotok.Text;
            if (String.IsNullOrEmpty(txtGroup.Text))
            {
                txtGroup.Text = "0";
                st._Group_ = int.Parse(txtGroup.Text);
            }
            st._Group_ = int.Parse(txtGroup.Text);
            
            return st;

        }

        private void logout() 
        {
            DisableAllControls();
            ClearAllControls();
            loginToolStripMenuItem.Text = "Log In";
            userStatus = UserStatus.ANONYMOUS;
            btnAddStudent.Visible = false;
        }

        private void LoadStudentPicture()
        {
            if (openPictureDialog.ShowDialog() == DialogResult.OK)
            {
                pbStudentPhoto.ImageLocation = openPictureDialog.FileName;
            }
        }

        private void btnOpenPic_Click(object sender, EventArgs e)
        {
            LoadStudentPicture();
        }

        private void informationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string text = GenerateInfoText();
            InfoForm infoForm = new InfoForm(text);
            infoForm.Show();
        }

        private string GenerateInfoText()
        {
            string text = "Уверение\n"; 
            text += txtFirstName.Text + " "+ txtSecondName.Text + " "+ txtLastName.Text;
            text += " е студент/ка във Факултет "+ txtFaculty.Text + ", специалност "+ txtSpeciality.Text;
            text += "\n";
            return text;
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            bool result = StudentValidation.InsertStudentIfValid(ReadStudentInfo());
            if (result) 
            {
                MessageBox.Show("New Student Added Successfully");
            }
            
            else 
            {
                MessageBox.Show("An Error occured while adding the student");
            }
        }

        private void groupsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GroupsForm groupsForm = new GroupsForm();
            groupsForm.Show();
        }

        private void registrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrationForm regForm = new RegistrationForm();
            regForm.Show();
        }   
    }
}
