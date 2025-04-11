namespace iti_DB_forms
{
    partial class StudentCrsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label3 = new Label();
            label2 = new Label();
            comboBoxStudent = new ComboBox();
            comboBoxCourse = new ComboBox();
            label1 = new Label();
            BtnInsert = new Button();
            TxtGrade = new TextBox();
            SaveBtn = new Button();
            LoadBtn = new Button();
            GridStu_crs = new DataGridView();
            MenueBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)GridStu_crs).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(551, 399);
            label3.Name = "label3";
            label3.Size = new Size(81, 15);
            label3.TabIndex = 68;
            label3.Text = "Student name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(551, 311);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 67;
            label2.Text = "course name";
            // 
            // comboBoxStudent
            // 
            comboBoxStudent.FormattingEnabled = true;
            comboBoxStudent.Location = new Point(648, 396);
            comboBoxStudent.Name = "comboBoxStudent";
            comboBoxStudent.Size = new Size(121, 23);
            comboBoxStudent.TabIndex = 66;
            // 
            // comboBoxCourse
            // 
            comboBoxCourse.FormattingEnabled = true;
            comboBoxCourse.Location = new Point(642, 306);
            comboBoxCourse.Name = "comboBoxCourse";
            comboBoxCourse.Size = new Size(121, 23);
            comboBoxCourse.TabIndex = 65;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 306);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 64;
            label1.Text = "Grade";
            // 
            // BtnInsert
            // 
            BtnInsert.BackColor = Color.Snow;
            BtnInsert.Location = new Point(29, 344);
            BtnInsert.Name = "BtnInsert";
            BtnInsert.Size = new Size(252, 23);
            BtnInsert.TabIndex = 61;
            BtnInsert.Text = "Insert";
            BtnInsert.UseVisualStyleBackColor = false;
            BtnInsert.Click += BtnInsert_Click;
            // 
            // TxtGrade
            // 
            TxtGrade.Location = new Point(107, 303);
            TxtGrade.Name = "TxtGrade";
            TxtGrade.Size = new Size(210, 23);
            TxtGrade.TabIndex = 63;
            // 
            // SaveBtn
            // 
            SaveBtn.BackColor = Color.Snow;
            SaveBtn.Location = new Point(354, 344);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(176, 23);
            SaveBtn.TabIndex = 62;
            SaveBtn.Text = "Save";
            SaveBtn.UseVisualStyleBackColor = false;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // LoadBtn
            // 
            LoadBtn.BackColor = Color.Snow;
            LoadBtn.Location = new Point(354, 302);
            LoadBtn.Name = "LoadBtn";
            LoadBtn.Size = new Size(176, 23);
            LoadBtn.TabIndex = 60;
            LoadBtn.Text = "Load";
            LoadBtn.UseVisualStyleBackColor = false;
            LoadBtn.Click += LoadBtn_Click;
            // 
            // GridStu_crs
            // 
            GridStu_crs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridStu_crs.Location = new Point(21, 32);
            GridStu_crs.Name = "GridStu_crs";
            GridStu_crs.Size = new Size(759, 242);
            GridStu_crs.TabIndex = 59;
            // 
            // MenueBtn
            // 
            MenueBtn.BackColor = Color.Snow;
            MenueBtn.Location = new Point(354, 391);
            MenueBtn.Name = "MenueBtn";
            MenueBtn.Size = new Size(176, 23);
            MenueBtn.TabIndex = 62;
            MenueBtn.Text = "Return Menue";
            MenueBtn.UseVisualStyleBackColor = false;
            MenueBtn.Click += MenueBtn_Click;
            // 
            // StudentCrsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(comboBoxStudent);
            Controls.Add(comboBoxCourse);
            Controls.Add(label1);
            Controls.Add(BtnInsert);
            Controls.Add(TxtGrade);
            Controls.Add(MenueBtn);
            Controls.Add(SaveBtn);
            Controls.Add(LoadBtn);
            Controls.Add(GridStu_crs);
            Name = "StudentCrsForm";
            Text = "StudentCrsForm";
            Load += StudentCrsForm_Load;
            ((System.ComponentModel.ISupportInitialize)GridStu_crs).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private ComboBox comboBoxStudent;
        private ComboBox comboBoxCourse;
        private Label label1;
        private Button BtnInsert;
        private TextBox TxtGrade;
        private Button SaveBtn;
        private Button LoadBtn;
        private DataGridView GridStu_crs;
        private Button MenueBtn;
    }
}