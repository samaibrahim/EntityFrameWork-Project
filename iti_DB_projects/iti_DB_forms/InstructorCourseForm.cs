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
using System.Xml.Linq;

namespace iti_DB_forms
{
    public partial class InstructorCourseForm : Form
    {

        ITIEFContext db = new ITIEFContext();
        public InstructorCourseForm()
        {
            InitializeComponent();
        }

        private void InstructorCourseForm_Load(object sender, EventArgs e)
        {
            comboBoxInstructor.DataSource = db.Instructors.ToList();
            comboBoxInstructor.DisplayMember = "Ins_Name";
            comboBoxInstructor.ValueMember = "Ins_Id";

            comboBoxCourse.DataSource = db.Courses.ToList();
            comboBoxCourse.DisplayMember = "Crs_Name";
            comboBoxCourse.ValueMember = "Crs_Id";
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            int instructorId = (int)comboBoxInstructor.SelectedValue;
            int courseId = (int)comboBoxCourse.SelectedValue;

            db.Ins_Cources.Add(new Models.Ins_Cource
            {
                Ins_Id = instructorId,
                Crs_Id = courseId,
                Evaluation = TxtEvaluation.Text
            });

            db.SaveChanges();

            MessageBox.Show("Instructor evaluation regard course added successfully!");

            // Clear input fields
            TxtEvaluation.Clear();
        }

        private void LoadBtn_Click(object sender, EventArgs e)
        {

            db.Ins_Cources.Load();
            GridIns_crs.DataSource = db.Ins_Cources.Local.ToBindingList();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            GridIns_crs.EndEdit();
            db.SaveChanges();
        }

        private void MenueBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
