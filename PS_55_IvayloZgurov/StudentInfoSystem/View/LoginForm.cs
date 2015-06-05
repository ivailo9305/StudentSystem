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

namespace StudentInfoSystem.View
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            user = null;
        }

        public Data.User user { get; private set; }

        private void btnOk_Click(object sender, EventArgs e)
        {
            LoginValidation lv = new LoginValidation(txtUsername.Text, txtPassword.Text);
            Data.User usr;
            if (lv.ValidateUserInput(out usr)) 
            {
                this.user = usr;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show(lv.errText);
            }
        }
    }
}
