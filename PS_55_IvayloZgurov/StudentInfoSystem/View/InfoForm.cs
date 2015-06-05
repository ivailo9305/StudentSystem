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
    public partial class InfoForm : Form
    {
        public InfoForm()
        {
            InitializeComponent();
        }

        public InfoForm(String text)
        {
            InitializeComponent();
            richTextBox.Text = text;
            richTextBox.SelectAll();
            richTextBox.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK) 
            {
                if (richTextBox.SelectedText == "")
                {
                    richTextBox.Font = fontDialog.Font;
                }
                else 
                {
                    richTextBox.SelectionFont = fontDialog.Font;
                }
            }
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                if (richTextBox.SelectedText == "")
                {
                    richTextBox.ForeColor = colorDialog.Color;
                }
                else
                {
                    richTextBox.SelectionColor = colorDialog.Color;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.DefaultExt = "*.rtf";
            saveFileDialog.Filter = "RTF Files|*.rtf";
            if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK
            && (saveFileDialog.FileName.Length > 0))
            {
                try
                {
                    // Save the contents of the RichTextBox into the file.
                    richTextBox.SaveFile(saveFileDialog.FileName);
                }
                catch (Exception)
                {
                    MessageBox.Show("Файлът не беше съхранен, поради грешка в записа!",
                    "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
