namespace StudentManagement.UI
{
    partial class QuanLyLopHocForm
    {
        private System.ComponentModel.IContainer components = null;

        private Panel pnlHeader;
        private Label lblTitle;

        private GroupBox grpInfo;
        private Label lblClassName;
        private Label lblDepartment;
        private Label lblAcademicYear;
        private TextBox txtClassName;
        private ComboBox cboDepartment;
        private TextBox txtAcademicYear;

        private Panel pnlButtons;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnClear;

        private Panel pnlSearch;
        private Label lblSearch;
        private TextBox txtSearch;
        private Button btnSearch;
        private Button btnShowAll;

        private DataGridView dgvClasses;
        private DataGridViewTextBoxColumn colClassID;
        private DataGridViewTextBoxColumn colClassName;
        private DataGridViewTextBoxColumn colDepartmentName;
        private DataGridViewTextBoxColumn colAcademicYear;

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
            components = new System.ComponentModel.Container();

            Color primary = Color.FromArgb(31, 78, 121);
            pnlHeader = new Panel();
            lblTitle = new Label();
            grpInfo = new GroupBox();
            lblClassName = new Label();
            lblDepartment = new Label();
            lblAcademicYear = new Label();
            txtClassName = new TextBox();
            cboDepartment = new ComboBox();
            txtAcademicYear = new TextBox();
            pnlButtons = new Panel();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            pnlSearch = new Panel();
            lblSearch = new Label();
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnShowAll = new Button();
            dgvClasses = new DataGridView();
            colClassID = new DataGridViewTextBoxColumn();
            colClassName = new DataGridViewTextBoxColumn();
            colDepartmentName = new DataGridViewTextBoxColumn();
            colAcademicYear = new DataGridViewTextBoxColumn();

            pnlHeader.SuspendLayout();
            grpInfo.SuspendLayout();
            pnlButtons.SuspendLayout();
            pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClasses).BeginInit();
            SuspendLayout();

            // pnlHeader
            pnlHeader.BackColor = primary;
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(900, 60);

            // lblTitle
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Name = "lblTitle";
            lblTitle.Padding = new Padding(15, 0, 0, 0);
            lblTitle.Text = "QUẢN LÝ LỚP HỌC";
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;

            // grpInfo
            grpInfo.Controls.Add(lblClassName);
            grpInfo.Controls.Add(txtClassName);
            grpInfo.Controls.Add(lblDepartment);
            grpInfo.Controls.Add(cboDepartment);
            grpInfo.Controls.Add(lblAcademicYear);
            grpInfo.Controls.Add(txtAcademicYear);
            grpInfo.Font = new Font("Segoe UI", 10F);
            grpInfo.Location = new Point(12, 70);
            grpInfo.Name = "grpInfo";
            grpInfo.Size = new Size(1076, 110);
            grpInfo.Text = "Thông tin lớp học";

            lblClassName.AutoSize = true;
            lblClassName.Location = new Point(15, 32);
            lblClassName.Name = "lblClassName";
            lblClassName.Text = "Tên lớp:";

            txtClassName.Location = new Point(110, 29);
            txtClassName.MaxLength = 50;
            txtClassName.Name = "txtClassName";
            txtClassName.Size = new Size(220, 25);
            txtClassName.TabIndex = 0;

            lblDepartment.AutoSize = true;
            lblDepartment.Location = new Point(360, 32);
            lblDepartment.Name = "lblDepartment";
            lblDepartment.Text = "Khoa:";

            cboDepartment.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDepartment.Location = new Point(420, 29);
            cboDepartment.Name = "cboDepartment";
            cboDepartment.Size = new Size(630, 25);
            cboDepartment.TabIndex = 1;

            lblAcademicYear.AutoSize = true;
            lblAcademicYear.Location = new Point(15, 72);
            lblAcademicYear.Name = "lblAcademicYear";
            lblAcademicYear.Text = "Niên khóa:";

            txtAcademicYear.Location = new Point(110, 69);
            txtAcademicYear.MaxLength = 20;
            txtAcademicYear.Name = "txtAcademicYear";
            txtAcademicYear.PlaceholderText = "VD: 2024-2028";
            txtAcademicYear.Size = new Size(220, 25);
            txtAcademicYear.TabIndex = 2;

            // pnlButtons
            pnlButtons.Controls.Add(btnAdd);
            pnlButtons.Controls.Add(btnEdit);
            pnlButtons.Controls.Add(btnDelete);
            pnlButtons.Controls.Add(btnClear);
            pnlButtons.Location = new Point(12, 188);
            pnlButtons.Name = "pnlButtons";
            pnlButtons.Size = new Size(500, 40);

            ConfigureButton(btnAdd, "btnAdd", "Thêm", 0, primary, 3);
            btnAdd.Click += btnAdd_Click;
            ConfigureButton(btnEdit, "btnEdit", "Sửa", 125, primary, 4);
            btnEdit.Click += btnEdit_Click;
            ConfigureButton(btnDelete, "btnDelete", "Xóa", 250, Color.FromArgb(192, 57, 43), 5);
            btnDelete.Click += btnDelete_Click;
            ConfigureButton(btnClear, "btnClear", "Làm mới", 375, Color.FromArgb(108, 117, 125), 6);
            btnClear.Click += btnClear_Click;

            // pnlSearch
            pnlSearch.Controls.Add(lblSearch);
            pnlSearch.Controls.Add(txtSearch);
            pnlSearch.Controls.Add(btnSearch);
            pnlSearch.Controls.Add(btnShowAll);
            pnlSearch.Location = new Point(530, 188);
            pnlSearch.Name = "pnlSearch";
            pnlSearch.Size = new Size(558, 40);

            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 10F);
            lblSearch.Location = new Point(0, 11);
            lblSearch.Name = "lblSearch";
            lblSearch.Text = "Tìm kiếm:";

            txtSearch.Font = new Font("Segoe UI", 10F);
            txtSearch.Location = new Point(70, 8);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Tên lớp, khoa hoặc niên khóa";
            txtSearch.Size = new Size(185, 25);
            txtSearch.TabIndex = 7;
            txtSearch.KeyDown += txtSearch_KeyDown;

            btnSearch.BackColor = primary;
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(262, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(85, 32);
            btnSearch.TabIndex = 8;
            btnSearch.Text = "Tìm";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            btnShowAll.BackColor = Color.FromArgb(108, 117, 125);
            btnShowAll.Cursor = Cursors.Hand;
            btnShowAll.FlatAppearance.BorderSize = 0;
            btnShowAll.FlatStyle = FlatStyle.Flat;
            btnShowAll.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnShowAll.ForeColor = Color.White;
            btnShowAll.Location = new Point(353, 4);
            btnShowAll.Name = "btnShowAll";
            btnShowAll.Size = new Size(90, 32);
            btnShowAll.TabIndex = 9;
            btnShowAll.Text = "Tất cả";
            btnShowAll.UseVisualStyleBackColor = false;
            btnShowAll.Click += btnShowAll_Click;

            // dgvClasses
            dgvClasses.AllowUserToAddRows = false;
            dgvClasses.AllowUserToDeleteRows = false;
            dgvClasses.AutoGenerateColumns = false;
            dgvClasses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClasses.BackgroundColor = Color.White;
            dgvClasses.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = primary,
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                SelectionBackColor = primary
            };
            dgvClasses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClasses.EnableHeadersVisualStyles = false;
            dgvClasses.Columns.AddRange(new DataGridViewColumn[]
            {
                colClassID, colClassName, colDepartmentName, colAcademicYear
            });
            dgvClasses.Location = new Point(12, 237);
            dgvClasses.MultiSelect = false;
            dgvClasses.Name = "dgvClasses";
            dgvClasses.ReadOnly = true;
            dgvClasses.RowHeadersVisible = false;
            dgvClasses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClasses.Size = new Size(1076, 313);
            dgvClasses.TabIndex = 10;
            dgvClasses.SelectionChanged += dgvClasses_SelectionChanged;

            ConfigureColumn(colClassID, "colClassID", "ID", "ClassID", 40);
            colClassID.Visible = false;
            ConfigureColumn(colClassName, "colClassName", "Tên lớp", "ClassName", 100);
            ConfigureColumn(colDepartmentName, "colDepartmentName", "Khoa", "DepartmentName", 200);
            ConfigureColumn(colAcademicYear, "colAcademicYear", "Niên khóa", "AcademicYear", 100);

            // QuanLyLopHocForm
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(1100, 562);
            Controls.Add(dgvClasses);
            Controls.Add(pnlSearch);
            Controls.Add(pnlButtons);
            Controls.Add(grpInfo);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "QuanLyLopHocForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý lớp học";
            Load += QuanLyLopHocForm_Load;

            pnlHeader.ResumeLayout(false);
            grpInfo.ResumeLayout(false);
            grpInfo.PerformLayout();
            pnlButtons.ResumeLayout(false);
            pnlSearch.ResumeLayout(false);
            pnlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClasses).EndInit();
            ResumeLayout(false);
        }

        private static void ConfigureButton(
            Button button, string name, string text, int x, Color backColor, int tabIndex)
        {
            button.BackColor = backColor;
            button.Cursor = Cursors.Hand;
            button.FlatAppearance.BorderSize = 0;
            button.FlatStyle = FlatStyle.Flat;
            button.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button.ForeColor = Color.White;
            button.Location = new Point(x, 4);
            button.Name = name;
            button.Size = new Size(115, 32);
            button.TabIndex = tabIndex;
            button.Text = text;
            button.UseVisualStyleBackColor = false;
        }

        private static void ConfigureColumn(
            DataGridViewTextBoxColumn column, string name, string header,
            string dataProperty, float fillWeight)
        {
            column.DataPropertyName = dataProperty;
            column.FillWeight = fillWeight;
            column.HeaderText = header;
            column.Name = name;
            column.ReadOnly = true;
        }
    }
}
