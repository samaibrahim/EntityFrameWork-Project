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
    public partial class InstructorForm : Form
    {
        ITIEFContext db = new ITIEFContext();
        public InstructorForm()
        {
            InitializeComponent();
        }

        private void LoadBtn_Click(object sender, EventArgs e)
        {
            db.Instructors.Load();
            GridInst.DataSource = db.Instructors.Local.ToBindingList();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            GridInst.EndEdit();
            db.SaveChanges();
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            db.Instructors.Add(new Instructor
            {
                Ins_Name = TxtName.Text,
                Salary = int.Parse(TxtSalary.Text),
                Ins_Degree = TxtDegree.Text

            });

            db.SaveChanges();

            MessageBox.Show("instructor added successfully!");

            // Clear input fields
            TxtName.Clear();
            TxtSalary.Clear();
            TxtDegree.Clear();
        }

        private void MenueBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
