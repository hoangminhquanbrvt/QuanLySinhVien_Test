namespace StudentManagement
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblDescription;

        private System.Windows.Forms.Button btnStudents;
        private System.Windows.Forms.Button btnClasses;
        private System.Windows.Forms.Button btnDepartments;
        private System.Windows.Forms.Button btnSubjects;
        private System.Windows.Forms.Button btnGrades;
        private System.Windows.Forms.Button btnExit;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            pnlHeader = new Panel();
            lblTitle = new Label();
            lblSubtitle = new Label();
            pnlMenu = new Panel();
            btnStudents = new Button();
            btnClasses = new Button();
            btnDepartments = new Button();
            btnSubjects = new Button();
            btnGrades = new Button();
            btnExit = new Button();
            pnlContent = new Panel();
            lblWelcome = new Label();
            lblDescription = new Label();
            pnlHeader.SuspendLayout();
            pnlMenu.SuspendLayout();
            pnlContent.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(31, 78, 121);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Controls.Add(lblSubtitle);
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Margin = new Padding(3, 4, 3, 4);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1099, 144);
            pnlHeader.TabIndex = 2;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(30, 25);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(699, 56);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "HỆ THỐNG QUẢN LÝ SINH VIÊN";
            // 
            // lblSubtitle
            // 
            lblSubtitle.Font = new Font("Segoe UI", 10F);
            lblSubtitle.ForeColor = Color.FromArgb(220, 230, 240);
            lblSubtitle.Location = new Point(33, 88);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(600, 31);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "STUDENT MANAGEMENT SYSTEM";
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.White;
            pnlMenu.Controls.Add(btnStudents);
            pnlMenu.Controls.Add(btnClasses);
            pnlMenu.Controls.Add(btnDepartments);
            pnlMenu.Controls.Add(btnSubjects);
            pnlMenu.Controls.Add(btnGrades);
            pnlMenu.Controls.Add(btnExit);
            pnlMenu.Location = new Point(0, 144);
            pnlMenu.Margin = new Padding(3, 4, 3, 4);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(280, 669);
            pnlMenu.TabIndex = 1;
            // 
            // btnStudents
            // 
            btnStudents.Location = new Point(14, 8);
            btnStudents.Margin = new Padding(3, 4, 3, 4);
            btnStudents.Name = "btnStudents";
            btnStudents.Size = new Size(251, 100);
            btnStudents.TabIndex = 0;
            btnStudents.Text = "Quản lý sinh viên";
            btnStudents.Click += btnStudents_Click;
            // 
            // btnClasses
            // 
            btnClasses.Location = new Point(14, 119);
            btnClasses.Margin = new Padding(3, 4, 3, 4);
            btnClasses.Name = "btnClasses";
            btnClasses.Size = new Size(251, 100);
            btnClasses.TabIndex = 1;
            btnClasses.Text = "Quản lý lớp học";
            btnClasses.Click += btnClasses_Click;
            // 
            // btnDepartments
            // 
            btnDepartments.Location = new Point(14, 231);
            btnDepartments.Margin = new Padding(3, 4, 3, 4);
            btnDepartments.Name = "btnDepartments";
            btnDepartments.Size = new Size(251, 100);
            btnDepartments.TabIndex = 2;
            btnDepartments.Text = "Quản lý khoa";
            btnDepartments.Click += btnDepartments_Click;
            // 
            // btnSubjects
            // 
            btnSubjects.Location = new Point(14, 343);
            btnSubjects.Margin = new Padding(3, 4, 3, 4);
            btnSubjects.Name = "btnSubjects";
            btnSubjects.Size = new Size(251, 100);
            btnSubjects.TabIndex = 3;
            btnSubjects.Text = "Quản lý môn học";
            btnSubjects.Click += btnSubjects_Click;
            // 
            // btnGrades
            // 
            btnGrades.Location = new Point(14, 452);
            btnGrades.Margin = new Padding(3, 4, 3, 4);
            btnGrades.Name = "btnGrades";
            btnGrades.Size = new Size(251, 100);
            btnGrades.TabIndex = 4;
            btnGrades.Text = "Quản lý điểm";
            btnGrades.Click += btnGrades_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(14, 565);
            btnExit.Margin = new Padding(3, 4, 3, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(251, 100);
            btnExit.TabIndex = 5;
            btnExit.Text = "Thoát chương trình";
            btnExit.Click += btnExit_Click;
            // 
            // pnlContent
            // 
            pnlContent.BackColor = Color.FromArgb(245, 247, 250);
            pnlContent.Controls.Add(lblWelcome);
            pnlContent.Controls.Add(lblDescription);
            pnlContent.Location = new Point(280, 144);
            pnlContent.Margin = new Padding(3, 4, 3, 4);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(821, 669);
            pnlContent.TabIndex = 0;
            // 
            // lblWelcome
            // 
            lblWelcome.Font = new Font("Segoe UI", 23F, FontStyle.Bold);
            lblWelcome.ForeColor = Color.FromArgb(31, 78, 121);
            lblWelcome.Location = new Point(65, 163);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(690, 75);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "CHÀO MỪNG ĐẾN VỚI HỆ THỐNG";
            lblWelcome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDescription
            // 
            lblDescription.Font = new Font("Segoe UI", 12F);
            lblDescription.ForeColor = Color.FromArgb(90, 100, 110);
            lblDescription.Location = new Point(101, 256);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(619, 88);
            lblDescription.TabIndex = 1;
            lblDescription.Text = "Phần mềm hỗ trợ quản lý thông tin sinh viên, lớp học, khoa, môn học và kết quả học tập.";
            lblDescription.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(1099, 812);
            Controls.Add(pnlContent);
            Controls.Add(pnlMenu);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HỆ THỐNG QUẢN LÝ SINH VIÊN";
            Load += MainForm_Load;
            pnlHeader.ResumeLayout(false);
            pnlMenu.ResumeLayout(false);
            pnlContent.ResumeLayout(false);
            ResumeLayout(false);
        }

        private void ConfigureButton(
            System.Windows.Forms.Button button,
            string text,
            int x,
            int y)
        {
            button.Location = new System.Drawing.Point(x, y);
            button.Size = new System.Drawing.Size(240, 50);
            button.Text = text;

            button.Font = new System.Drawing.Font(
                "Segoe UI", 10F, System.Drawing.FontStyle.Bold);

            button.ForeColor = System.Drawing.Color.White;
            button.BackColor =
                System.Drawing.Color.FromArgb(31, 78, 121);

            button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.Cursor = System.Windows.Forms.Cursors.Hand;
        }
    }
}