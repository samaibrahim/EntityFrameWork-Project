using iti_DB_forms.Context;
using Microsoft.EntityFrameworkCore;
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
    public partial class StudentCrsForm : Form
    {
        ITIEFContext db = new ITIEFContext();
        public StudentCrsForm()
        {
            InitializeComponent();
        }

        private void LoadBtn_Click(object sender, EventArgs e)
        {
            db.Student_Courses.Load();
            GridStu_crs.DataSource = db.Student_Courses.Local.ToBindingList();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            GridStu_crs.EndEdit();
            db.SaveChanges();
        }

        private void StudentCrsForm_Load(object sender, EventArgs e)
        {
            comboBoxStudent.DataSource = db.Students
                .Select(s => new
                {
                    FullName = s.FName + " " + s.LName,
                    s.St_Id
                }).ToList();
            comboBoxStudent.DisplayMember = "FullName";
            comboBoxStudent.ValueMember = "St_Id";

            comboBoxCourse.DataSource = db.Courses.ToList();
            comboBoxCourse.DisplayMember = "Crs_Name";
            comboBoxCourse.ValueMember = "Crs_Id";
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            int StudentId = (int)comboBoxStudent.SelectedValue;
            int courseId = (int)comboBoxCourse.SelectedValue;

            db.Student_Courses.Add(new Models.Student_Course
            {
                St_Id = StudentId,
                Crs_Id = courseId,
                Grade = int.Parse(TxtGrade.Text)
            });

            db.SaveChanges();

            MessageBox.Show("student grade regard course added successfully!");

            // Clear input fields
            TxtGrade.Clear();
        }

        private void MenueBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
