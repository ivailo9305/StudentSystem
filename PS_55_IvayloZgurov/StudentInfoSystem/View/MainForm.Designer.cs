namespace StudentInfoSystem.View
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabMarks = new System.Windows.Forms.TabPage();
            this.tabStudent = new System.Windows.Forms.TabPage();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.btnOpenPic = new System.Windows.Forms.Button();
            this.gbStudentInfo = new System.Windows.Forms.GroupBox();
            this.txtGroup = new System.Windows.Forms.TextBox();
            this.lblGroup = new System.Windows.Forms.Label();
            this.txtPotok = new System.Windows.Forms.TextBox();
            this.lblPotok = new System.Windows.Forms.Label();
            this.numCourse = new System.Windows.Forms.NumericUpDown();
            this.lblCourse = new System.Windows.Forms.Label();
            this.comboStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.comboOKS = new System.Windows.Forms.ComboBox();
            this.lblOKS = new System.Windows.Forms.Label();
            this.txtFakNumber = new System.Windows.Forms.TextBox();
            this.lblFakNumber = new System.Windows.Forms.Label();
            this.txtSpeciality = new System.Windows.Forms.TextBox();
            this.lblSpeciality = new System.Windows.Forms.Label();
            this.txtFaculty = new System.Windows.Forms.TextBox();
            this.lblFaculty = new System.Windows.Forms.Label();
            this.gbPersonalInfo = new System.Windows.Forms.GroupBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtSecondName = new System.Windows.Forms.TextBox();
            this.lblSecondName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.gbStudentPhoto = new System.Windows.Forms.GroupBox();
            this.pbStudentPhoto = new System.Windows.Forms.PictureBox();
            this.tabControlStudentInfo = new System.Windows.Forms.TabControl();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.informationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openPictureDialog = new System.Windows.Forms.OpenFileDialog();
            this.registrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabStudent.SuspendLayout();
            this.gbStudentInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCourse)).BeginInit();
            this.gbPersonalInfo.SuspendLayout();
            this.gbStudentPhoto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbStudentPhoto)).BeginInit();
            this.tabControlStudentInfo.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMarks
            // 
            this.tabMarks.Location = new System.Drawing.Point(4, 22);
            this.tabMarks.Name = "tabMarks";
            this.tabMarks.Padding = new System.Windows.Forms.Padding(3);
            this.tabMarks.Size = new System.Drawing.Size(694, 414);
            this.tabMarks.TabIndex = 1;
            this.tabMarks.Text = "Оценки";
            this.tabMarks.UseVisualStyleBackColor = true;
            // 
            // tabStudent
            // 
            this.tabStudent.Controls.Add(this.btnAddStudent);
            this.tabStudent.Controls.Add(this.btnOpenPic);
            this.tabStudent.Controls.Add(this.gbStudentInfo);
            this.tabStudent.Controls.Add(this.gbPersonalInfo);
            this.tabStudent.Controls.Add(this.gbStudentPhoto);
            this.tabStudent.Location = new System.Drawing.Point(4, 22);
            this.tabStudent.Name = "tabStudent";
            this.tabStudent.Padding = new System.Windows.Forms.Padding(3);
            this.tabStudent.Size = new System.Drawing.Size(694, 414);
            this.tabStudent.TabIndex = 0;
            this.tabStudent.Text = "Студент";
            this.tabStudent.UseVisualStyleBackColor = true;
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(40, 344);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(141, 23);
            this.btnAddStudent.TabIndex = 4;
            this.btnAddStudent.Text = "Add Student";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Visible = false;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // btnOpenPic
            // 
            this.btnOpenPic.Location = new System.Drawing.Point(40, 279);
            this.btnOpenPic.Name = "btnOpenPic";
            this.btnOpenPic.Size = new System.Drawing.Size(141, 30);
            this.btnOpenPic.TabIndex = 3;
            this.btnOpenPic.Text = "Open Picutre";
            this.btnOpenPic.UseVisualStyleBackColor = true;
            this.btnOpenPic.Click += new System.EventHandler(this.btnOpenPic_Click);
            // 
            // gbStudentInfo
            // 
            this.gbStudentInfo.Controls.Add(this.txtGroup);
            this.gbStudentInfo.Controls.Add(this.lblGroup);
            this.gbStudentInfo.Controls.Add(this.txtPotok);
            this.gbStudentInfo.Controls.Add(this.lblPotok);
            this.gbStudentInfo.Controls.Add(this.numCourse);
            this.gbStudentInfo.Controls.Add(this.lblCourse);
            this.gbStudentInfo.Controls.Add(this.comboStatus);
            this.gbStudentInfo.Controls.Add(this.lblStatus);
            this.gbStudentInfo.Controls.Add(this.comboOKS);
            this.gbStudentInfo.Controls.Add(this.lblOKS);
            this.gbStudentInfo.Controls.Add(this.txtFakNumber);
            this.gbStudentInfo.Controls.Add(this.lblFakNumber);
            this.gbStudentInfo.Controls.Add(this.txtSpeciality);
            this.gbStudentInfo.Controls.Add(this.lblSpeciality);
            this.gbStudentInfo.Controls.Add(this.txtFaculty);
            this.gbStudentInfo.Controls.Add(this.lblFaculty);
            this.gbStudentInfo.Location = new System.Drawing.Point(231, 156);
            this.gbStudentInfo.Name = "gbStudentInfo";
            this.gbStudentInfo.Size = new System.Drawing.Size(427, 249);
            this.gbStudentInfo.TabIndex = 2;
            this.gbStudentInfo.TabStop = false;
            this.gbStudentInfo.Text = "Студентска информация";
            // 
            // txtGroup
            // 
            this.txtGroup.Location = new System.Drawing.Point(324, 152);
            this.txtGroup.Name = "txtGroup";
            this.txtGroup.Size = new System.Drawing.Size(88, 20);
            this.txtGroup.TabIndex = 22;
            // 
            // lblGroup
            // 
            this.lblGroup.AutoSize = true;
            this.lblGroup.Location = new System.Drawing.Point(257, 156);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Size = new System.Drawing.Size(36, 13);
            this.lblGroup.TabIndex = 21;
            this.lblGroup.Text = "Група";
            // 
            // txtPotok
            // 
            this.txtPotok.Location = new System.Drawing.Point(324, 105);
            this.txtPotok.Name = "txtPotok";
            this.txtPotok.Size = new System.Drawing.Size(88, 20);
            this.txtPotok.TabIndex = 20;
            // 
            // lblPotok
            // 
            this.lblPotok.AutoSize = true;
            this.lblPotok.Location = new System.Drawing.Point(257, 108);
            this.lblPotok.Name = "lblPotok";
            this.lblPotok.Size = new System.Drawing.Size(38, 13);
            this.lblPotok.TabIndex = 19;
            this.lblPotok.Text = "Поток";
            // 
            // numCourse
            // 
            this.numCourse.Location = new System.Drawing.Point(323, 50);
            this.numCourse.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numCourse.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCourse.Name = "numCourse";
            this.numCourse.Size = new System.Drawing.Size(89, 20);
            this.numCourse.TabIndex = 18;
            this.numCourse.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.Location = new System.Drawing.Point(257, 53);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(31, 13);
            this.lblCourse.TabIndex = 16;
            this.lblCourse.Text = "Курс";
            // 
            // comboStatus
            // 
            this.comboStatus.FormattingEnabled = true;
            this.comboStatus.Items.AddRange(new object[] {
            "Regular",
            "NotRegular"});
            this.comboStatus.Location = new System.Drawing.Point(97, 159);
            this.comboStatus.Name = "comboStatus";
            this.comboStatus.Size = new System.Drawing.Size(121, 21);
            this.comboStatus.TabIndex = 15;
            this.comboStatus.Text = "Избери...";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(50, 159);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(41, 13);
            this.lblStatus.TabIndex = 14;
            this.lblStatus.Text = "Статус";
            // 
            // comboOKS
            // 
            this.comboOKS.FormattingEnabled = true;
            this.comboOKS.Items.AddRange(new object[] {
            "Bachelor",
            "Master"});
            this.comboOKS.Location = new System.Drawing.Point(99, 120);
            this.comboOKS.Name = "comboOKS";
            this.comboOKS.Size = new System.Drawing.Size(121, 21);
            this.comboOKS.TabIndex = 13;
            this.comboOKS.Text = "Избери...";
            // 
            // lblOKS
            // 
            this.lblOKS.AutoSize = true;
            this.lblOKS.Location = new System.Drawing.Point(56, 123);
            this.lblOKS.Name = "lblOKS";
            this.lblOKS.Size = new System.Drawing.Size(29, 13);
            this.lblOKS.TabIndex = 12;
            this.lblOKS.Text = "ОКС";
            // 
            // txtFakNumber
            // 
            this.txtFakNumber.Location = new System.Drawing.Point(99, 192);
            this.txtFakNumber.Name = "txtFakNumber";
            this.txtFakNumber.Size = new System.Drawing.Size(120, 20);
            this.txtFakNumber.TabIndex = 11;
            // 
            // lblFakNumber
            // 
            this.lblFakNumber.AutoSize = true;
            this.lblFakNumber.Location = new System.Drawing.Point(18, 195);
            this.lblFakNumber.Name = "lblFakNumber";
            this.lblFakNumber.Size = new System.Drawing.Size(70, 13);
            this.lblFakNumber.TabIndex = 10;
            this.lblFakNumber.Text = "Фак. Номер";
            // 
            // txtSpeciality
            // 
            this.txtSpeciality.Location = new System.Drawing.Point(99, 85);
            this.txtSpeciality.Name = "txtSpeciality";
            this.txtSpeciality.Size = new System.Drawing.Size(120, 20);
            this.txtSpeciality.TabIndex = 9;
            // 
            // lblSpeciality
            // 
            this.lblSpeciality.AutoSize = true;
            this.lblSpeciality.Location = new System.Drawing.Point(20, 88);
            this.lblSpeciality.Name = "lblSpeciality";
            this.lblSpeciality.Size = new System.Drawing.Size(73, 13);
            this.lblSpeciality.TabIndex = 8;
            this.lblSpeciality.Text = "Специалност";
            // 
            // txtFaculty
            // 
            this.txtFaculty.Location = new System.Drawing.Point(99, 50);
            this.txtFaculty.Name = "txtFaculty";
            this.txtFaculty.Size = new System.Drawing.Size(120, 20);
            this.txtFaculty.TabIndex = 7;
            // 
            // lblFaculty
            // 
            this.lblFaculty.AutoSize = true;
            this.lblFaculty.Location = new System.Drawing.Point(28, 52);
            this.lblFaculty.Name = "lblFaculty";
            this.lblFaculty.Size = new System.Drawing.Size(57, 13);
            this.lblFaculty.TabIndex = 6;
            this.lblFaculty.Text = "Факултет";
            // 
            // gbPersonalInfo
            // 
            this.gbPersonalInfo.Controls.Add(this.txtLastName);
            this.gbPersonalInfo.Controls.Add(this.lblLastName);
            this.gbPersonalInfo.Controls.Add(this.txtSecondName);
            this.gbPersonalInfo.Controls.Add(this.lblSecondName);
            this.gbPersonalInfo.Controls.Add(this.txtFirstName);
            this.gbPersonalInfo.Controls.Add(this.lblFirstName);
            this.gbPersonalInfo.Location = new System.Drawing.Point(231, 19);
            this.gbPersonalInfo.Name = "gbPersonalInfo";
            this.gbPersonalInfo.Size = new System.Drawing.Size(435, 131);
            this.gbPersonalInfo.TabIndex = 1;
            this.gbPersonalInfo.TabStop = false;
            this.gbPersonalInfo.Text = "Лични данни";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(99, 91);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(313, 20);
            this.txtLastName.TabIndex = 5;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(32, 95);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(56, 13);
            this.lblLastName.TabIndex = 4;
            this.lblLastName.Text = "Фамилия";
            // 
            // txtSecondName
            // 
            this.txtSecondName.Location = new System.Drawing.Point(99, 59);
            this.txtSecondName.Name = "txtSecondName";
            this.txtSecondName.Size = new System.Drawing.Size(313, 20);
            this.txtSecondName.TabIndex = 3;
            // 
            // lblSecondName
            // 
            this.lblSecondName.AutoSize = true;
            this.lblSecondName.Location = new System.Drawing.Point(32, 63);
            this.lblSecondName.Name = "lblSecondName";
            this.lblSecondName.Size = new System.Drawing.Size(53, 13);
            this.lblSecondName.TabIndex = 2;
            this.lblSecondName.Text = "Презиме";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(99, 27);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(313, 20);
            this.txtFirstName.TabIndex = 1;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(32, 31);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(29, 13);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "Име";
            // 
            // gbStudentPhoto
            // 
            this.gbStudentPhoto.Controls.Add(this.pbStudentPhoto);
            this.gbStudentPhoto.Location = new System.Drawing.Point(19, 19);
            this.gbStudentPhoto.Name = "gbStudentPhoto";
            this.gbStudentPhoto.Size = new System.Drawing.Size(200, 205);
            this.gbStudentPhoto.TabIndex = 0;
            this.gbStudentPhoto.TabStop = false;
            this.gbStudentPhoto.Text = "Снимка";
            // 
            // pbStudentPhoto
            // 
            this.pbStudentPhoto.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pbStudentPhoto.ErrorImage")));
            this.pbStudentPhoto.Location = new System.Drawing.Point(21, 27);
            this.pbStudentPhoto.Name = "pbStudentPhoto";
            this.pbStudentPhoto.Size = new System.Drawing.Size(141, 143);
            this.pbStudentPhoto.TabIndex = 0;
            this.pbStudentPhoto.TabStop = false;
            // 
            // tabControlStudentInfo
            // 
            this.tabControlStudentInfo.Controls.Add(this.tabStudent);
            this.tabControlStudentInfo.Controls.Add(this.tabMarks);
            this.tabControlStudentInfo.Location = new System.Drawing.Point(0, 28);
            this.tabControlStudentInfo.Name = "tabControlStudentInfo";
            this.tabControlStudentInfo.SelectedIndex = 0;
            this.tabControlStudentInfo.Size = new System.Drawing.Size(702, 440);
            this.tabControlStudentInfo.TabIndex = 1;
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.helpToolStripMenuItem.Text = "File";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.logoutToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.loginToolStripMenuItem,
            this.registrationToolStripMenuItem,
            this.logoutToolStripMenuItem,
            this.informationToolStripMenuItem,
            this.groupsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(805, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // informationToolStripMenuItem
            // 
            this.informationToolStripMenuItem.Name = "informationToolStripMenuItem";
            this.informationToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.informationToolStripMenuItem.Text = "Information";
            this.informationToolStripMenuItem.Click += new System.EventHandler(this.informationToolStripMenuItem_Click);
            // 
            // groupsToolStripMenuItem
            // 
            this.groupsToolStripMenuItem.Name = "groupsToolStripMenuItem";
            this.groupsToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.groupsToolStripMenuItem.Text = "Groups";
            this.groupsToolStripMenuItem.Click += new System.EventHandler(this.groupsToolStripMenuItem_Click);
            // 
            // openPictureDialog
            // 
            this.openPictureDialog.FileName = "openFileDialog1";
            this.openPictureDialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
            // 
            // registrationToolStripMenuItem
            // 
            this.registrationToolStripMenuItem.Name = "registrationToolStripMenuItem";
            this.registrationToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.registrationToolStripMenuItem.Text = "Registration";
            this.registrationToolStripMenuItem.Click += new System.EventHandler(this.registrationToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 467);
            this.Controls.Add(this.tabControlStudentInfo);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.tabStudent.ResumeLayout(false);
            this.gbStudentInfo.ResumeLayout(false);
            this.gbStudentInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCourse)).EndInit();
            this.gbPersonalInfo.ResumeLayout(false);
            this.gbPersonalInfo.PerformLayout();
            this.gbStudentPhoto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbStudentPhoto)).EndInit();
            this.tabControlStudentInfo.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabPage tabMarks;
        private System.Windows.Forms.TabPage tabStudent;
        private System.Windows.Forms.GroupBox gbStudentInfo;
        private System.Windows.Forms.GroupBox gbPersonalInfo;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.GroupBox gbStudentPhoto;
        private System.Windows.Forms.PictureBox pbStudentPhoto;
        private System.Windows.Forms.TabControl tabControlStudentInfo;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.ComboBox comboStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox comboOKS;
        private System.Windows.Forms.Label lblOKS;
        private System.Windows.Forms.TextBox txtFakNumber;
        private System.Windows.Forms.Label lblFakNumber;
        private System.Windows.Forms.TextBox txtSpeciality;
        private System.Windows.Forms.Label lblSpeciality;
        private System.Windows.Forms.TextBox txtFaculty;
        private System.Windows.Forms.Label lblFaculty;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtSecondName;
        private System.Windows.Forms.Label lblSecondName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtGroup;
        private System.Windows.Forms.Label lblGroup;
        private System.Windows.Forms.TextBox txtPotok;
        private System.Windows.Forms.Label lblPotok;
        private System.Windows.Forms.NumericUpDown numCourse;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button btnOpenPic;
        private System.Windows.Forms.OpenFileDialog openPictureDialog;
        private System.Windows.Forms.ToolStripMenuItem informationToolStripMenuItem;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.ToolStripMenuItem groupsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrationToolStripMenuItem;

    }
}