namespace iti_DB_forms
{
    partial class InstructorForm
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
            label1 = new Label();
            TxtSalary = new TextBox();
            TxtDegree = new TextBox();
            BtnInsert = new Button();
            TxtName = new TextBox();
            SaveBtn = new Button();
            LoadBtn = new Button();
            GridInst = new DataGridView();
            MenueBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)GridInst).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(4, 321);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 26;
            label3.Text = "Salary";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(4, 289);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 27;
            label2.Text = "Degree";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(4, 261);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 28;
            label1.Text = "Name";
            // 
            // TxtSalary
            // 
            TxtSalary.Location = new Point(111, 313);
            TxtSalary.Name = "TxtSalary";
            TxtSalary.Size = new Size(210, 23);
            TxtSalary.TabIndex = 23;
            // 
            // TxtDegree
            // 
            TxtDegree.Location = new Point(111, 282);
            TxtDegree.Name = "TxtDegree";
            TxtDegree.Size = new Size(210, 23);
            TxtDegree.TabIndex = 24;
            // 
            // BtnInsert
            // 
            BtnInsert.BackColor = Color.Snow;
            BtnInsert.Location = new Point(12, 365);
            BtnInsert.Name = "BtnInsert";
            BtnInsert.Size = new Size(296, 23);
            BtnInsert.TabIndex = 21;
            BtnInsert.Text = "Insert";
            BtnInsert.UseVisualStyleBackColor = false;
            BtnInsert.Click += BtnInsert_Click;
            // 
            // TxtName
            // 
            TxtName.Location = new Point(111, 253);
            TxtName.Name = "TxtName";
            TxtName.Size = new Size(210, 23);
            TxtName.TabIndex = 25;
            // 
            // SaveBtn
            // 
            SaveBtn.BackColor = Color.Snow;
            SaveBtn.Location = new Point(459, 319);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(176, 23);
            SaveBtn.TabIndex = 22;
            SaveBtn.Text = "Save";
            SaveBtn.UseVisualStyleBackColor = false;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // LoadBtn
            // 
            LoadBtn.BackColor = Color.Snow;
            LoadBtn.Location = new Point(459, 281);
            LoadBtn.Name = "LoadBtn";
            LoadBtn.Size = new Size(176, 23);
            LoadBtn.TabIndex = 20;
            LoadBtn.Text = "Load";
            LoadBtn.UseVisualStyleBackColor = false;
            LoadBtn.Click += LoadBtn_Click;
            // 
            // GridInst
            // 
            GridInst.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridInst.Location = new Point(4, 12);
            GridInst.Name = "GridInst";
            GridInst.Size = new Size(793, 217);
            GridInst.TabIndex = 19;
            // 
            // MenueBtn
            // 
            MenueBtn.BackColor = Color.Snow;
            MenueBtn.Location = new Point(459, 365);
            MenueBtn.Name = "MenueBtn";
            MenueBtn.Size = new Size(176, 23);
            MenueBtn.TabIndex = 22;
            MenueBtn.Text = "Return Menue";
            MenueBtn.UseVisualStyleBackColor = false;
            MenueBtn.Click += MenueBtn_Click;
            // 
            // InstructorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TxtSalary);
            Controls.Add(TxtDegree);
            Controls.Add(BtnInsert);
            Controls.Add(TxtName);
            Controls.Add(MenueBtn);
            Controls.Add(SaveBtn);
            Controls.Add(LoadBtn);
            Controls.Add(GridInst);
            Name = "InstructorForm";
            Text = "InstructorForm";
            ((System.ComponentModel.ISupportInitialize)GridInst).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox TxtSalary;
        private TextBox TxtDegree;
        private Button BtnInsert;
        private TextBox TxtName;
        private Button SaveBtn;
        private Button LoadBtn;
        private DataGridView GridInst;
        private Button MenueBtn;
    }
}