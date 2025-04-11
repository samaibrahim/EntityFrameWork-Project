using iti_DB_forms.Context;
using iti_DB_forms.Models;
using Microsoft.EntityFrameworkCore;

namespace iti_DB_forms
{
    public partial class StudentForm : Form
    {
        ITIEFContext db = new ITIEFContext();
        public StudentForm()
        {
            InitializeComponent();
        }

        private void LoadBtn_Click(object sender, EventArgs e)
        {
            db.Students.Load();
            GridStd.DataSource = db.Students.Local.ToBindingList();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            GridStd.EndEdit();
            db.SaveChanges();
        }

        private void InsertBtn_Click(object sender, EventArgs e)
        {
            db.Students.Add(new Student
            {
                FName = TxtFname.Text,
                LName = TxtLname.Text,
                St_Age = int.Parse(TxtAge.Text),
                St_Address = TxtAddress.Text,
                Dept_Id = int.Parse(TxtDeptId.Text)

            });

            db.SaveChanges();

            MessageBox.Show("Student added successfully!");

            // Clear input fields
            TxtFname.Clear();
            TxtLname.Clear();
            TxtAddress.Clear();
            TxtAge.Clear();
            TxtDeptId.Clear();

        }

        private void MenueBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
