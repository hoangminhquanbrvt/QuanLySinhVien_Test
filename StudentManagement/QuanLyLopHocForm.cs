using StudentManagement.BLL.Services;
using StudentManagement.DTO;

namespace StudentManagement.UI
{
    public partial class QuanLyLopHocForm : Form
    {
        private readonly ClassBLL classBLL = new ClassBLL();
        private readonly DepartmentBLL departmentBLL = new DepartmentBLL();

        private int selectedClassID = 0;

        public QuanLyLopHocForm()
        {
            InitializeComponent();
        }

        private void QuanLyLopHocForm_Load(object? sender, EventArgs e)
        {
            LoadDepartments();
            LoadClasses();
            ClearInputs();
        }

        // Đổ danh sách khoa vào ComboBox
        private void LoadDepartments()
        {
            try
            {
                cboDepartment.DataSource = departmentBLL.GetAll();
                cboDepartment.DisplayMember = "DepartmentName";
                cboDepartment.ValueMember = "DepartmentID";
                cboDepartment.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                ShowError(ex);
            }
        }

        // Đổ danh sách lớp lên DataGridView (có lọc theo từ khóa nếu có)
        private void LoadClasses(string? keyword = null)
        {
            try
            {
                List<ClassDTO> classes = classBLL.GetAll();

                if (!string.IsNullOrWhiteSpace(keyword))
                {
                    string key = keyword.Trim();
                    classes = classes.FindAll(c =>
                        Contains(c.ClassName, key) ||
                        Contains(c.DepartmentName, key) ||
                        Contains(c.AcademicYear, key));
                }

                dgvClasses.DataSource = classes;
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
                ClassDTO classDTO = ReadInputs();

                if (classBLL.Insert(classDTO))
                {
                    MessageBox.Show("Thêm lớp học thành công.", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadClasses();
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
            if (selectedClassID <= 0)
            {
                MessageBox.Show("Vui lòng chọn lớp học cần sửa.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                ClassDTO classDTO = ReadInputs();
                classDTO.ClassID = selectedClassID;

                if (classBLL.Update(classDTO))
                {
                    MessageBox.Show("Cập nhật lớp học thành công.", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadClasses(txtSearch.Text);
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
            if (selectedClassID <= 0)
            {
                MessageBox.Show("Vui lòng chọn lớp học cần xóa.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show(
                $"Bạn có chắc muốn xóa lớp \"{txtClassName.Text}\"?",
                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes)
                return;

            try
            {
                if (classBLL.Delete(selectedClassID))
                {
                    MessageBox.Show("Xóa lớp học thành công.", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadClasses(txtSearch.Text);
                    ClearInputs();
                }
            }
            catch (Exception ex)
            {
                // Có thể bị chặn bởi khóa ngoại (lớp đã có sinh viên)
                MessageBox.Show(
                    "Không thể xóa lớp học. Có thể lớp đã có sinh viên.\n\n" + ex.Message,
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
            LoadClasses(txtSearch.Text);
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
            LoadClasses();
            ClearInputs();
        }

        // Chọn dòng -> đổ dữ liệu lên các ô nhập
        private void dgvClasses_SelectionChanged(object? sender, EventArgs e)
        {
            if (dgvClasses.CurrentRow?.DataBoundItem is not ClassDTO classDTO)
                return;

            selectedClassID = classDTO.ClassID;
            txtClassName.Text = classDTO.ClassName;
            cboDepartment.SelectedValue = classDTO.DepartmentID;
            txtAcademicYear.Text = classDTO.AcademicYear ?? "";
        }

        // Đọc dữ liệu từ form thành ClassDTO
        private ClassDTO ReadInputs()
        {
            return new ClassDTO
            {
                ClassName = txtClassName.Text.Trim(),
                DepartmentID = cboDepartment.SelectedValue is int departmentID ? departmentID : 0,
                AcademicYear = string.IsNullOrWhiteSpace(txtAcademicYear.Text)
                    ? null
                    : txtAcademicYear.Text.Trim()
            };
        }

        private void ClearInputs()
        {
            selectedClassID = 0;
            txtClassName.Clear();
            cboDepartment.SelectedIndex = -1;
            txtAcademicYear.Clear();
            dgvClasses.ClearSelection();
            txtClassName.Focus();
        }

        private static bool Contains(string? text, string key)
        {
            return text != null &&
                   text.Contains(key, StringComparison.CurrentCultureIgnoreCase);
        }

        private static void ShowError(Exception ex)
        {
            MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
