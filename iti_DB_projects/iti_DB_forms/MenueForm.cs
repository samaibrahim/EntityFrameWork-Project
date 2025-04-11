using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iti_DB_forms
{
    public partial class MenueForm : Form
    {
        public MenueForm()
        {
            InitializeComponent();
        }

        private void DeptBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            DepartmentForm departmentForm = new DepartmentForm();
            departmentForm.ShowDialog();
            this.Show();
        }

        private void StuBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentForm studentForm = new StudentForm();
            studentForm.ShowDialog();
            this.Show();
        }

        private void InsBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            InstructorForm instructorForm = new InstructorForm();
            instructorForm.ShowDialog();
            this.Show();
        }

        private void crsBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            CourseForm courseForm = new CourseForm();
            courseForm.ShowDialog();
            this.Show();
        }

        private void TopicBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            TopicForm topicForm = new TopicForm();
            topicForm.ShowDialog();
            this.Show();
        }

        private void Stu_crs_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentCrsForm studentCrsForm = new StudentCrsForm();
            studentCrsForm.ShowDialog();
            this.Show();
        }

        private void ins_crs_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            InstructorCourseForm instructorCourseForm = new InstructorCourseForm();
            instructorCourseForm.ShowDialog();
            this.Show();
        }
    }
}
