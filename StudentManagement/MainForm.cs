using System;
using System.Windows.Forms;

namespace StudentManagement
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnStudents_Click(object sender, EventArgs e)
        {
            using (var form = new StudentManagement.UI.QuanLySinhVienForm())
            {
                form.ShowDialog(this);
            }
        }

        private void btnClasses_Click(object sender, EventArgs e)
        {
            using (var form = new StudentManagement.UI.QuanLyLopHocForm())
            {
                form.ShowDialog(this);
            }
        }

        private void btnDepartments_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng quản lý khoa đang được xây dựng.");
        }

        private void btnSubjects_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng quản lý môn học đang được xây dựng.");
        }

        private void btnGrades_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng quản lý điểm đang được xây dựng.");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}