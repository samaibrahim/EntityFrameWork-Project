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
    public partial class DepartmentForm : Form
    {
        ITIEFContext db = new ITIEFContext();

        public DepartmentForm()
        {
            InitializeComponent();
        }



        private void LoadBtn_Click_1(object sender, EventArgs e)
        {
            db.Departments.Load();
            GridDept.DataSource = db.Departments.Local.ToBindingList();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            GridDept.EndEdit();
            db.SaveChanges();
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            db.Departments.Add(new Department
            {
                Dept_Name = TxtDeptName.Text,
                Dept_Location = TxtLoc.Text,
                Dept_Desc = TxtDesc.Text

            });

            db.SaveChanges();

            MessageBox.Show("Department added successfully!");

            // Clear input fields
            TxtDesc.Clear();
            TxtLoc.Clear();
            TxtDeptName.Clear();
        }

        private void menueBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
