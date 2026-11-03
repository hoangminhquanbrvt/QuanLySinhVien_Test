using StudentManagement.BLL.Services;
using StudentManagement.DTO;

namespace StudentManagement.UI
{
    public partial class QuanLySinhVienForm : Form
    {
        private readonly StudentBLL studentBLL = new StudentBLL();
        private readonly ClassBLL classBLL = new ClassBLL();

        private int selectedStudentID = 0;

        public QuanLySinhVienForm()
        {
            InitializeComponent();
        }

        private void QuanLySinhVienForm_Load(object? sender, EventArgs e)
        {
            LoadClasses();
            LoadStudents();
            ClearInputs();
        }

        // Đổ danh sách lớp vào ComboBox
        private void LoadClasses()
        {
            try
            {
                cboClass.DataSource = classBLL.GetAll();
                cboClass.DisplayMember = "ClassName";
                cboClass.ValueMember = "ClassID";
                cboClass.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                ShowError(ex);
            }
        }

        // Đổ danh sách sinh viên lên DataGridView
        private void LoadStudents(string? keyword = null)
        {
            try
            {
                dgvStudents.DataSource = string.IsNullOrWhiteSpace(keyword)
                    ? studentBLL.GetAll()
                    : studentBLL.Search(keyword.Trim());
            }
            catch (Exception ex)
            {
                ShowError(ex);
            }
        }

        // Thêm
        private void btnAdd_Click(object? sender, EventArgs e)
        {
            try
            {
                StudentDTO student = ReadInputs();

                if (studentBLL.Insert(student))
                {
                    MessageBox.Show("Thêm sinh viên thành công.", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadStudents();
                    ClearInputs();
                }
            }
            catch (Exception ex)
            {
                ShowError(ex);
            }
        }

        // Sửa
        private void btnEdit_Click(object? sender, EventArgs e)
        {
            if (selectedStudentID <= 0)
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần sửa.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                StudentDTO student = ReadInputs();
                student.StudentID = selectedStudentID;

                if (studentBLL.Update(student))
                {
                    MessageBox.Show("Cập nhật sinh viên thành công.", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadStudents(txtSearch.Text);
                    ClearInputs();
                }
            }
            catch (Exception ex)
            {
                ShowError(ex);
            }
        }

        // Xóa
        private void btnDelete_Click(object? sender, EventArgs e)
        {
            if (selectedStudentID <= 0)
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần xóa.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show(
                $"Bạn có chắc muốn xóa sinh viên \"{txtFullName.Text}\"?",
                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes)
                return;

            try
            {
                if (studentBLL.Delete(selectedStudentID))
                {
                    MessageBox.Show("Xóa sinh viên thành công.", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadStudents(txtSearch.Text);
                    ClearInputs();
                }
            }
            catch (Exception ex)
            {
                // Có thể bị chặn bởi khóa ngoại (sinh viên đã có điểm)
                MessageBox.Show(
                    "Không thể xóa sinh viên. Có thể sinh viên đã có dữ liệu điểm.\n\n" + ex.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Làm mới form
        private void btnClear_Click(object? sender, EventArgs e)
        {
            ClearInputs();
        }

        // Tìm kiếm
        private void btnSearch_Click(object? sender, EventArgs e)
        {
            LoadStudents(txtSearch.Text);
            ClearInputs();
        }

        private void txtSearch_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnSearch_Click(sender, EventArgs.Empty);
            }
        }

        private void btnShowAll_Click(object? sender, EventArgs e)
        {
            txtSearch.Clear();
            LoadStudents();
            ClearInputs();
        }

        // Chọn dòng -> đổ dữ liệu lên các ô nhập
        private void dgvStudents_SelectionChanged(object? sender, EventArgs e)
        {
            if (dgvStudents.CurrentRow?.DataBoundItem is not StudentDTO student)
                return;

            selectedStudentID = student.StudentID;
            txtStudentCode.Text = student.StudentCode;
            txtFullName.Text = student.FullName;

            if (student.DateOfBirth.HasValue)
            {
                dtpDateOfBirth.Value = student.DateOfBirth.Value;
                dtpDateOfBirth.Checked = true;
            }
            else
            {
                dtpDateOfBirth.Checked = false;
            }

            cboGender.SelectedIndex = cboGender.FindStringExact(student.Gender ?? "");
            txtPhone.Text = student.Phone ?? "";
            txtEmail.Text = student.Email ?? "";
            txtAddress.Text = student.Address ?? "";
            cboClass.SelectedValue = student.ClassID;
        }

        // Đọc dữ liệu từ form thành StudentDTO
        private StudentDTO ReadInputs()
        {
            return new StudentDTO
            {
                StudentCode = txtStudentCode.Text.Trim(),
                FullName = txtFullName.Text.Trim(),
                DateOfBirth = dtpDateOfBirth.Checked ? dtpDateOfBirth.Value.Date : null,
                Gender = cboGender.SelectedItem?.ToString(),
                Phone = NullIfEmpty(txtPhone.Text),
                Email = NullIfEmpty(txtEmail.Text),
                Address = NullIfEmpty(txtAddress.Text),
                ClassID = cboClass.SelectedValue is int classID ? classID : 0
            };
        }

        private void ClearInputs()
        {
            selectedStudentID = 0;
            txtStudentCode.Clear();
            txtFullName.Clear();
            dtpDateOfBirth.Checked = false;
            cboGender.SelectedIndex = -1;
            txtPhone.Clear();
            txtEmail.Clear();
            txtAddress.Clear();
            cboClass.SelectedIndex = -1;
            dgvStudents.ClearSelection();
            txtStudentCode.Focus();
        }

        private static string? NullIfEmpty(string text)
        {
            return string.IsNullOrWhiteSpace(text) ? null : text.Trim();
        }

        private static void ShowError(Exception ex)
        {
            MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
