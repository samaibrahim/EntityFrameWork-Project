namespace iti_DB_forms
{
    partial class InstructorCourseForm
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
            label1 = new Label();
            BtnInsert = new Button();
            TxtEvaluation = new TextBox();
            SaveBtn = new Button();
            LoadBtn = new Button();
            GridIns_crs = new DataGridView();
            comboBoxCourse = new ComboBox();
            comboBoxInstructor = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            MenueBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)GridIns_crs).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 286);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 54;
            label1.Text = "Evaluation";
            // 
            // BtnInsert
            // 
            BtnInsert.BackColor = Color.Snow;
            BtnInsert.Location = new Point(20, 324);
            BtnInsert.Name = "BtnInsert";
            BtnInsert.Size = new Size(252, 23);
            BtnInsert.TabIndex = 51;
            BtnInsert.Text = "Insert";
            BtnInsert.UseVisualStyleBackColor = false;
            BtnInsert.Click += BtnInsert_Click;
            // 
            // TxtEvaluation
            // 
            TxtEvaluation.Location = new Point(98, 283);
            TxtEvaluation.Name = "TxtEvaluation";
            TxtEvaluation.Size = new Size(210, 23);
            TxtEvaluation.TabIndex = 53;
            // 
            // SaveBtn
            // 
            SaveBtn.BackColor = Color.Snow;
            SaveBtn.Location = new Point(345, 324);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(176, 23);
            SaveBtn.TabIndex = 52;
            SaveBtn.Text = "Save";
            SaveBtn.UseVisualStyleBackColor = false;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // LoadBtn
            // 
            LoadBtn.BackColor = Color.Snow;
            LoadBtn.Location = new Point(345, 282);
            LoadBtn.Name = "LoadBtn";
            LoadBtn.Size = new Size(176, 23);
            LoadBtn.TabIndex = 50;
            LoadBtn.Text = "Load";
            LoadBtn.UseVisualStyleBackColor = false;
            LoadBtn.Click += LoadBtn_Click;
            // 
            // GridIns_crs
            // 
            GridIns_crs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridIns_crs.Location = new Point(12, 12);
            GridIns_crs.Name = "GridIns_crs";
            GridIns_crs.Size = new Size(759, 242);
            GridIns_crs.TabIndex = 49;
            // 
            // comboBoxCourse
            // 
            comboBoxCourse.FormattingEnabled = true;
            comboBoxCourse.Location = new Point(633, 286);
            comboBoxCourse.Name = "comboBoxCourse";
            comboBoxCourse.Size = new Size(121, 23);
            comboBoxCourse.TabIndex = 55;
            // 
            // comboBoxInstructor
            // 
            comboBoxInstructor.FormattingEnabled = true;
            comboBoxInstructor.Location = new Point(639, 376);
            comboBoxInstructor.Name = "comboBoxInstructor";
            comboBoxInstructor.Size = new Size(121, 23);
            comboBoxInstructor.TabIndex = 56;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(542, 291);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 57;
            label2.Text = "course name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(542, 379);
            label3.Name = "label3";
            label3.Size = new Size(91, 15);
            label3.TabIndex = 58;
            label3.Text = "Instructor name";
            // 
            // MenueBtn
            // 
            MenueBtn.BackColor = Color.Snow;
            MenueBtn.Location = new Point(345, 371);
            MenueBtn.Name = "MenueBtn";
            MenueBtn.Size = new Size(176, 23);
            MenueBtn.TabIndex = 52;
            MenueBtn.Text = "Return Menue";
            MenueBtn.UseVisualStyleBackColor = false;
            MenueBtn.Click += MenueBtn_Click;
            // 
            // InstructorCourseForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(comboBoxInstructor);
            Controls.Add(comboBoxCourse);
            Controls.Add(label1);
            Controls.Add(BtnInsert);
            Controls.Add(TxtEvaluation);
            Controls.Add(MenueBtn);
            Controls.Add(SaveBtn);
            Controls.Add(LoadBtn);
            Controls.Add(GridIns_crs);
            Name = "InstructorCourseForm";
            Text = "InstructorCourseForm";
            Load += InstructorCourseForm_Load;
            ((System.ComponentModel.ISupportInitialize)GridIns_crs).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button BtnInsert;
        private TextBox TxtEvaluation;
        private Button SaveBtn;
        private Button LoadBtn;
        private DataGridView GridIns_crs;
        private ComboBox comboBoxCourse;
        private ComboBox comboBoxInstructor;
        private Label label2;
        private Label label3;
        private Button MenueBtn;
    }
}