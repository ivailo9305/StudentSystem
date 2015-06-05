using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentInfoSystem.View
{
    public partial class GroupsForm : Form
    {
        public GroupsForm()
        {
            InitializeComponent();
            List<int> groups = Data.UserData.GetStudentGroups();
            foreach (var group in groups)
            {
                comboBoxGroups.Items.Add(group);
            }
            comboBoxGroups.Items.Add("All");
        }

        private void GroupsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentInfoDatabaseDataSet.Students' table. You can move, or remove it, as needed.
            this.studentsTableAdapter.Fill(this.studentInfoDatabaseDataSet.Students);

        }

        private void fillByGroupToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.studentsTableAdapter.FillByGroup(this.studentInfoDatabaseDataSet.Students, ((int)(System.Convert.ChangeType(comboBoxGroups.SelectedItem, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void comboBoxGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(!comboBoxGroups.SelectedItem.Equals("All"))
            {
                try
            {
                this.studentsTableAdapter.FillByGroup(this.studentInfoDatabaseDataSet.Students, ((int)(System.Convert.ChangeType(comboBoxGroups.SelectedItem, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            }

            else
            {
            try
            {
                this.studentsTableAdapter.Fill(this.studentInfoDatabaseDataSet.Students);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            }
        }
    }
}
