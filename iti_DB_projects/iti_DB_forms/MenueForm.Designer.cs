namespace iti_DB_forms
{
    partial class MenueForm
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
            StuBtn = new Button();
            crsBtn = new Button();
            TopicBtn = new Button();
            DeptBtn = new Button();
            Stu_crs_btn = new Button();
            InsBtn = new Button();
            ins_crs_btn = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // StuBtn
            // 
            StuBtn.BackColor = Color.Violet;
            StuBtn.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            StuBtn.ForeColor = Color.LavenderBlush;
            StuBtn.Location = new Point(138, 109);
            StuBtn.Name = "StuBtn";
            StuBtn.Size = new Size(160, 37);
            StuBtn.TabIndex = 0;
            StuBtn.Text = "Student";
            StuBtn.UseVisualStyleBackColor = false;
            StuBtn.Click += StuBtn_Click;
            // 
            // crsBtn
            // 
            crsBtn.BackColor = Color.Violet;
            crsBtn.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            crsBtn.ForeColor = Color.LavenderBlush;
            crsBtn.Location = new Point(484, 109);
            crsBtn.Name = "crsBtn";
            crsBtn.Size = new Size(160, 37);
            crsBtn.TabIndex = 0;
            crsBtn.Text = "Course ";
            crsBtn.UseVisualStyleBackColor = false;
            crsBtn.Click += crsBtn_Click;
            // 
            // TopicBtn
            // 
            TopicBtn.BackColor = Color.Violet;
            TopicBtn.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TopicBtn.ForeColor = Color.LavenderBlush;
            TopicBtn.Location = new Point(484, 192);
            TopicBtn.Name = "TopicBtn";
            TopicBtn.Size = new Size(160, 37);
            TopicBtn.TabIndex = 0;
            TopicBtn.Text = "Topic ";
            TopicBtn.UseVisualStyleBackColor = false;
            TopicBtn.Click += TopicBtn_Click;
            // 
            // DeptBtn
            // 
            DeptBtn.BackColor = Color.Violet;
            DeptBtn.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DeptBtn.ForeColor = Color.LavenderBlush;
            DeptBtn.Location = new Point(138, 192);
            DeptBtn.Name = "DeptBtn";
            DeptBtn.Size = new Size(160, 37);
            DeptBtn.TabIndex = 0;
            DeptBtn.Text = "Department";
            DeptBtn.UseVisualStyleBackColor = false;
            DeptBtn.Click += DeptBtn_Click;
            // 
            // Stu_crs_btn
            // 
            Stu_crs_btn.BackColor = Color.Violet;
            Stu_crs_btn.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Stu_crs_btn.ForeColor = Color.LavenderBlush;
            Stu_crs_btn.Location = new Point(484, 282);
            Stu_crs_btn.Name = "Stu_crs_btn";
            Stu_crs_btn.Size = new Size(160, 37);
            Stu_crs_btn.TabIndex = 0;
            Stu_crs_btn.Text = "Student Course Form";
            Stu_crs_btn.UseVisualStyleBackColor = false;
            Stu_crs_btn.Click += Stu_crs_btn_Click;
            // 
            // InsBtn
            // 
            InsBtn.BackColor = Color.Violet;
            InsBtn.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            InsBtn.ForeColor = Color.LavenderBlush;
            InsBtn.Location = new Point(138, 282);
            InsBtn.Name = "InsBtn";
            InsBtn.Size = new Size(160, 37);
            InsBtn.TabIndex = 0;
            InsBtn.Text = "Instructor Form";
            InsBtn.UseVisualStyleBackColor = false;
            InsBtn.Click += InsBtn_Click;
            // 
            // ins_crs_btn
            // 
            ins_crs_btn.BackColor = Color.Violet;
            ins_crs_btn.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ins_crs_btn.ForeColor = Color.LavenderBlush;
            ins_crs_btn.Location = new Point(289, 378);
            ins_crs_btn.Name = "ins_crs_btn";
            ins_crs_btn.Size = new Size(201, 37);
            ins_crs_btn.TabIndex = 0;
            ins_crs_btn.Text = "Instructor Course";
            ins_crs_btn.UseVisualStyleBackColor = false;
            ins_crs_btn.Click += ins_crs_btn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Violet;
            label1.Font = new Font("Showcard Gothic", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LavenderBlush;
            label1.Location = new Point(250, 9);
            label1.Name = "label1";
            label1.Size = new Size(264, 46);
            label1.TabIndex = 1;
            label1.Text = "Choose Forn";
            // 
            // MenueForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkMagenta;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(ins_crs_btn);
            Controls.Add(InsBtn);
            Controls.Add(Stu_crs_btn);
            Controls.Add(DeptBtn);
            Controls.Add(TopicBtn);
            Controls.Add(crsBtn);
            Controls.Add(StuBtn);
            Name = "MenueForm";
            Text = "MenueForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button StuBtn;
        private Button crsBtn;
        private Button TopicBtn;
        private Button DeptBtn;
        private Button Stu_crs_btn;
        private Button InsBtn;
        private Button ins_crs_btn;
        private Label label1;
    }
}