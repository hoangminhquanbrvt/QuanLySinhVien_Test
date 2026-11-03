namespace StudentManagement.UI
{
    partial class QuanLySinhVienForm
    {
        private System.ComponentModel.IContainer components = null;

        private Panel pnlHeader;
        private Label lblTitle;

        private GroupBox grpInfo;
        private Label lblStudentCode;
        private Label lblFullName;
        private Label lblDateOfBirth;
        private Label lblGender;
        private Label lblPhone;
        private Label lblEmail;
        private Label lblAddress;
        private Label lblClass;
        private TextBox txtStudentCode;
        private TextBox txtFullName;
        private DateTimePicker dtpDateOfBirth;
        private ComboBox cboGender;
        private TextBox txtPhone;
        private TextBox txtEmail;
        private TextBox txtAddress;
        private ComboBox cboClass;

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

        private DataGridView dgvStudents;
        private DataGridViewTextBoxColumn colStudentID;
        private DataGridViewTextBoxColumn colStudentCode;
        private DataGridViewTextBoxColumn colFullName;
        private DataGridViewTextBoxColumn colDateOfBirth;
        private DataGridViewTextBoxColumn colGender;
        private DataGridViewTextBoxColumn colPhone;
        private DataGridViewTextBoxColumn colEmail;
        private DataGridViewTextBoxColumn colAddress;
        private DataGridViewTextBoxColumn colClassName;

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
            lblStudentCode = new Label();
            lblFullName = new Label();
            lblDateOfBirth = new Label();
            lblGender = new Label();
            lblPhone = new Label();
            lblEmail = new Label();
            lblAddress = new Label();
            lblClass = new Label();
            txtStudentCode = new TextBox();
            txtFullName = new TextBox();
            dtpDateOfBirth = new DateTimePicker();
            cboGender = new ComboBox();
            txtPhone = new TextBox();
            txtEmail = new TextBox();
            txtAddress = new TextBox();
            cboClass = new ComboBox();
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
            dgvStudents = new DataGridView();
            colStudentID = new DataGridViewTextBoxColumn();
            colStudentCode = new DataGridViewTextBoxColumn();
            colFullName = new DataGridViewTextBoxColumn();
            colDateOfBirth = new DataGridViewTextBoxColumn();
            colGender = new DataGridViewTextBoxColumn();
            colPhone = new DataGridViewTextBoxColumn();
            colEmail = new DataGridViewTextBoxColumn();
            colAddress = new DataGridViewTextBoxColumn();
            colClassName = new DataGridViewTextBoxColumn();

            pnlHeader.SuspendLayout();
            grpInfo.SuspendLayout();
            pnlButtons.SuspendLayout();
            pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            SuspendLayout();

            // pnlHeader
            pnlHeader.BackColor = primary;
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1000, 60);

            // lblTitle
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Name = "lblTitle";
            lblTitle.Padding = new Padding(15, 0, 0, 0);
            lblTitle.Text = "QUẢN LÝ SINH VIÊN";
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;

            // grpInfo
            grpInfo.Controls.Add(lblStudentCode);
            grpInfo.Controls.Add(txtStudentCode);
            grpInfo.Controls.Add(lblFullName);
            grpInfo.Controls.Add(txtFullName);
            grpInfo.Controls.Add(lblDateOfBirth);
            grpInfo.Controls.Add(dtpDateOfBirth);
            grpInfo.Controls.Add(lblGender);
            grpInfo.Controls.Add(cboGender);
            grpInfo.Controls.Add(lblPhone);
            grpInfo.Controls.Add(txtPhone);
            grpInfo.Controls.Add(lblEmail);
            grpInfo.Controls.Add(txtEmail);
            grpInfo.Controls.Add(lblAddress);
            grpInfo.Controls.Add(txtAddress);
            grpInfo.Controls.Add(lblClass);
            grpInfo.Controls.Add(cboClass);
            grpInfo.Font = new Font("Segoe UI", 10F);
            grpInfo.Location = new Point(12, 70);
            grpInfo.Name = "grpInfo";
            grpInfo.Size = new Size(976, 165);
            grpInfo.Text = "Thông tin sinh viên";

            // Hàng 1
            lblStudentCode.AutoSize = true;
            lblStudentCode.Location = new Point(15, 32);
            lblStudentCode.Name = "lblStudentCode";
            lblStudentCode.Text = "Mã sinh viên:";

            txtStudentCode.Location = new Point(115, 29);
            txtStudentCode.MaxLength = 20;
            txtStudentCode.Name = "txtStudentCode";
            txtStudentCode.Size = new Size(180, 25);
            txtStudentCode.TabIndex = 0;

            lblFullName.AutoSize = true;
            lblFullName.Location = new Point(320, 32);
            lblFullName.Name = "lblFullName";
            lblFullName.Text = "Họ tên:";

            txtFullName.Location = new Point(385, 29);
            txtFullName.MaxLength = 100;
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(240, 25);
            txtFullName.TabIndex = 1;

            lblDateOfBirth.AutoSize = true;
            lblDateOfBirth.Location = new Point(650, 32);
            lblDateOfBirth.Name = "lblDateOfBirth";
            lblDateOfBirth.Text = "Ngày sinh:";

            dtpDateOfBirth.Format = DateTimePickerFormat.Short;
            dtpDateOfBirth.Location = new Point(730, 29);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.ShowCheckBox = true;
            dtpDateOfBirth.Checked = false;
            dtpDateOfBirth.Size = new Size(225, 25);
            dtpDateOfBirth.TabIndex = 2;

            // Hàng 2
            lblGender.AutoSize = true;
            lblGender.Location = new Point(15, 72);
            lblGender.Name = "lblGender";
            lblGender.Text = "Giới tính:";

            cboGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGender.Items.AddRange(new object[] { "Nam", "Nữ", "Khác" });
            cboGender.Location = new Point(115, 69);
            cboGender.Name = "cboGender";
            cboGender.Size = new Size(180, 25);
            cboGender.TabIndex = 3;

            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(320, 72);
            lblPhone.Name = "lblPhone";
            lblPhone.Text = "Điện thoại:";

            txtPhone.Location = new Point(400, 69);
            txtPhone.MaxLength = 15;
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(225, 25);
            txtPhone.TabIndex = 4;

            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(650, 72);
            lblEmail.Name = "lblEmail";
            lblEmail.Text = "Email:";

            txtEmail.Location = new Point(730, 69);
            txtEmail.MaxLength = 100;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(225, 25);
            txtEmail.TabIndex = 5;

            // Hàng 3
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(15, 112);
            lblAddress.Name = "lblAddress";
            lblAddress.Text = "Địa chỉ:";

            txtAddress.Location = new Point(115, 109);
            txtAddress.MaxLength = 255;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(510, 25);
            txtAddress.TabIndex = 6;

            lblClass.AutoSize = true;
            lblClass.Location = new Point(650, 112);
            lblClass.Name = "lblClass";
            lblClass.Text = "Lớp:";

            cboClass.DropDownStyle = ComboBoxStyle.DropDownList;
            cboClass.Location = new Point(730, 109);
            cboClass.Name = "cboClass";
            cboClass.Size = new Size(225, 25);
            cboClass.TabIndex = 7;

            // pnlButtons
            pnlButtons.Controls.Add(btnAdd);
            pnlButtons.Controls.Add(btnEdit);
            pnlButtons.Controls.Add(btnDelete);
            pnlButtons.Controls.Add(btnClear);
            pnlButtons.Location = new Point(12, 243);
            pnlButtons.Name = "pnlButtons";
            pnlButtons.Size = new Size(520, 40);

            ConfigureButton(btnAdd, "btnAdd", "Thêm", 0, primary, 8);
            btnAdd.Click += btnAdd_Click;
            ConfigureButton(btnEdit, "btnEdit", "Sửa", 130, primary, 9);
            btnEdit.Click += btnEdit_Click;
            ConfigureButton(btnDelete, "btnDelete", "Xóa", 260, Color.FromArgb(192, 57, 43), 10);
            btnDelete.Click += btnDelete_Click;
            ConfigureButton(btnClear, "btnClear", "Làm mới", 390, Color.FromArgb(108, 117, 125), 11);
            btnClear.Click += btnClear_Click;

            // pnlSearch
            pnlSearch.Controls.Add(lblSearch);
            pnlSearch.Controls.Add(txtSearch);
            pnlSearch.Controls.Add(btnSearch);
            pnlSearch.Controls.Add(btnShowAll);
            pnlSearch.Location = new Point(540, 243);
            pnlSearch.Name = "pnlSearch";
            pnlSearch.Size = new Size(448, 40);

            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 10F);
            lblSearch.Location = new Point(0, 11);
            lblSearch.Name = "lblSearch";
            lblSearch.Text = "Tìm kiếm:";

            txtSearch.Font = new Font("Segoe UI", 10F);
            txtSearch.Location = new Point(70, 8);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Mã SV, họ tên hoặc lớp";
            txtSearch.Size = new Size(185, 25);
            txtSearch.TabIndex = 12;
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
            btnSearch.TabIndex = 13;
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
            btnShowAll.TabIndex = 14;
            btnShowAll.Text = "Tất cả";
            btnShowAll.UseVisualStyleBackColor = false;
            btnShowAll.Click += btnShowAll_Click;

            // dgvStudents
            dgvStudents.AllowUserToAddRows = false;
            dgvStudents.AllowUserToDeleteRows = false;
            dgvStudents.AutoGenerateColumns = false;
            dgvStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStudents.BackgroundColor = Color.White;
            dgvStudents.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = primary,
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                SelectionBackColor = primary
            };
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudents.EnableHeadersVisualStyles = false;
            dgvStudents.Columns.AddRange(new DataGridViewColumn[]
            {
                colStudentID, colStudentCode, colFullName, colDateOfBirth,
                colGender, colPhone, colEmail, colAddress, colClassName
            });
            dgvStudents.Location = new Point(12, 292);
            dgvStudents.MultiSelect = false;
            dgvStudents.Name = "dgvStudents";
            dgvStudents.ReadOnly = true;
            dgvStudents.RowHeadersVisible = false;
            dgvStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudents.Size = new Size(976, 358);
            dgvStudents.TabIndex = 15;
            dgvStudents.SelectionChanged += dgvStudents_SelectionChanged;

            ConfigureColumn(colStudentID, "colStudentID", "ID", "StudentID", 40);
            colStudentID.Visible = false;
            ConfigureColumn(colStudentCode, "colStudentCode", "Mã SV", "StudentCode", 80);
            ConfigureColumn(colFullName, "colFullName", "Họ tên", "FullName", 140);
            ConfigureColumn(colDateOfBirth, "colDateOfBirth", "Ngày sinh", "DateOfBirth", 85);
            colDateOfBirth.DefaultCellStyle.Format = "dd/MM/yyyy";
            ConfigureColumn(colGender, "colGender", "Giới tính", "Gender", 65);
            ConfigureColumn(colPhone, "colPhone", "Điện thoại", "Phone", 95);
            ConfigureColumn(colEmail, "colEmail", "Email", "Email", 140);
            ConfigureColumn(colAddress, "colAddress", "Địa chỉ", "Address", 130);
            ConfigureColumn(colClassName, "colClassName", "Lớp", "ClassName", 75);

            // QuanLySinhVienForm
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(1000, 662);
            Controls.Add(dgvStudents);
            Controls.Add(pnlSearch);
            Controls.Add(pnlButtons);
            Controls.Add(grpInfo);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "QuanLySinhVienForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý sinh viên";
            Load += QuanLySinhVienForm_Load;

            pnlHeader.ResumeLayout(false);
            grpInfo.ResumeLayout(false);
            grpInfo.PerformLayout();
            pnlButtons.ResumeLayout(false);
            pnlSearch.ResumeLayout(false);
            pnlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
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
            button.Size = new Size(120, 32);
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
