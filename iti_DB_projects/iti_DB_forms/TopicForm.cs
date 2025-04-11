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
    public partial class TopicForm : Form
    {

        ITIEFContext db = new ITIEFContext();
        public TopicForm()
        {
            InitializeComponent();
        }

        private void LoadBtn_Click(object sender, EventArgs e)
        {
            db.Topics.Load();
            GridTopic.DataSource = db.Topics.Local.ToBindingList();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            GridTopic.EndEdit();
            db.SaveChanges();
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            db.Topics.Add(new Topic
            {
                Name = TxtName.Text
            });

            db.SaveChanges();

            MessageBox.Show("topic added successfully!");

            // Clear input fields
            TxtName.Clear();
        }

        private void MenueBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
