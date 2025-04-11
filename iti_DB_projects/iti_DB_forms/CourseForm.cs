using iti_DB_forms.Context;
using iti_DB_forms.Models;
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
    public partial class CourseForm : Form
    {
        ITIEFContext db = new ITIEFContext();
        public CourseForm()
        {
            InitializeComponent();
        }

        private void LoadBtn_Click(object sender, EventArgs e)
        {
            db.Courses.Load();
            GridCrs.DataSource = db.Courses.Local.ToBindingList();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            GridCrs.EndEdit();
            db.SaveChanges();
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            db.Courses.Add(new Course
            {
                Crs_Name = TxtName.Text,
                Duration = int.Parse(TxtDuration.Text),
                Top_Id = int.Parse(TxtTopic.Text),

            });

            db.SaveChanges();

            MessageBox.Show("Course added successfully!");

            // Clear input fields
            TxtName.Clear();
            TxtDuration.Clear();
            TxtTopic.Clear();
        }

        private void MenueBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
