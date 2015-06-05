using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentInfoSystem.Logic;
using StudentInfoSystem.Data;

namespace StudentInfoSystem.View
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        public Data.User user { get; private set; }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            int role = rbStudent.Checked ? 1 : 2;
            RegistrationValidation rv = new RegistrationValidation(tbUserName.Text, tbPassword.Text, tbPassword2.Text, tbFacNumber.Text, role);
            Data.User usr;
            if (rv.ValidateUserInput(out usr))
            {
                this.user = usr;
                if (Data.UserData.InsertUser(user))
                {
                    MessageBox.Show("Registration Successful");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show(rv.errText);
            }
        }

        private void btnRegister_Click_1(object sender, EventArgs e)
        {
            int role = rbStudent.Checked ? 1 : 2;
            RegistrationValidation rv = new RegistrationValidation(tbUserName.Text, tbPassword.Text, tbPassword2.Text, tbFacNumber.Text, role);
            Data.User usr;
            if (rv.ValidateUserInput(out usr))
            {
                this.user = usr;
                if (Data.UserData.InsertUser(user))
                {
                    MessageBox.Show("Registration Successful");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show(rv.errText);
            }
        }
    }
}
