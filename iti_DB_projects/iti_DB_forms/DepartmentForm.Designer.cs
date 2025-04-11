namespace iti_DB_forms
{
    partial class DepartmentForm
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
            TxtLoc = new TextBox();
            TxtDesc = new TextBox();
            BtnInsert = new Button();
            TxtDeptName = new TextBox();
            SaveBtn = new Button();
            LoadBtn = new Button();
            GridDept = new DataGridView();
            menueBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)GridDept).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(4, 290);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 16;
            label3.Text = "Location";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(4, 258);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 17;
            label2.Text = "Description";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(4, 230);
            label1.Name = "label1";
            label1.Size = new Size(107, 15);
            label1.TabIndex = 18;
            label1.Text = "Department_Name";
            // 
            // TxtLoc
            // 
            TxtLoc.Location = new Point(111, 282);
            TxtLoc.Name = "TxtLoc";
            TxtLoc.Size = new Size(210, 23);
            TxtLoc.TabIndex = 11;
            // 
            // TxtDesc
            // 
            TxtDesc.Location = new Point(111, 251);
            TxtDesc.Name = "TxtDesc";
            TxtDesc.Size = new Size(210, 23);
            TxtDesc.TabIndex = 12;
            // 
            // BtnInsert
            // 
            BtnInsert.BackColor = Color.Snow;
            BtnInsert.Location = new Point(12, 334);
            BtnInsert.Name = "BtnInsert";
            BtnInsert.Size = new Size(296, 23);
            BtnInsert.TabIndex = 7;
            BtnInsert.Text = "Insert";
            BtnInsert.UseVisualStyleBackColor = false;
            BtnInsert.Click += BtnInsert_Click;
            // 
            // TxtDeptName
            // 
            TxtDeptName.Location = new Point(111, 222);
            TxtDeptName.Name = "TxtDeptName";
            TxtDeptName.Size = new Size(210, 23);
            TxtDeptName.TabIndex = 13;
            // 
            // SaveBtn
            // 
            SaveBtn.BackColor = Color.Snow;
            SaveBtn.Location = new Point(459, 288);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(176, 23);
            SaveBtn.TabIndex = 8;
            SaveBtn.Text = "Save";
            SaveBtn.UseVisualStyleBackColor = false;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // LoadBtn
            // 
            LoadBtn.BackColor = Color.Snow;
            LoadBtn.Location = new Point(459, 250);
            LoadBtn.Name = "LoadBtn";
            LoadBtn.Size = new Size(176, 23);
            LoadBtn.TabIndex = 6;
            LoadBtn.Text = "Load";
            LoadBtn.UseVisualStyleBackColor = false;
            LoadBtn.Click += LoadBtn_Click_1;
            // 
            // GridDept
            // 
            GridDept.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridDept.Location = new Point(4, 32);
            GridDept.Name = "GridDept";
            GridDept.Size = new Size(793, 181);
            GridDept.TabIndex = 5;
            // 
            // menueBtn
            // 
            menueBtn.BackColor = Color.Snow;
            menueBtn.Location = new Point(459, 334);
            menueBtn.Name = "menueBtn";
            menueBtn.Size = new Size(176, 23);
            menueBtn.TabIndex = 8;
            menueBtn.Text = "Return Menue";
            menueBtn.UseVisualStyleBackColor = false;
            menueBtn.Click += menueBtn_Click;
            // 
            // DepartmentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TxtLoc);
            Controls.Add(TxtDesc);
            Controls.Add(BtnInsert);
            Controls.Add(TxtDeptName);
            Controls.Add(menueBtn);
            Controls.Add(SaveBtn);
            Controls.Add(LoadBtn);
            Controls.Add(GridDept);
            Name = "DepartmentForm";
            Text = "DepartmentForm";
            ((System.ComponentModel.ISupportInitialize)GridDept).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox TxtLoc;
        private TextBox TxtDesc;
        private Button BtnInsert;
        private TextBox TxtDeptName;
        private Button SaveBtn;
        private Button LoadBtn;
        private DataGridView GridDept;
        private Button menueBtn;
    }
}