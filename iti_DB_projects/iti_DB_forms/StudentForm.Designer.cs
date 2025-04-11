namespace iti_DB_forms
{
    partial class StudentForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            GridStd = new DataGridView();
            LoadBtn = new Button();
            SaveBtn = new Button();
            TxtDeptId = new TextBox();
            TxtFname = new TextBox();
            TxtLname = new TextBox();
            TxtAddress = new TextBox();
            TxtAge = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            BtnInsert = new Button();
            MenueBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)GridStd).BeginInit();
            SuspendLayout();
            // 
            // GridStd
            // 
            GridStd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridStd.Location = new Point(3, 12);
            GridStd.Name = "GridStd";
            GridStd.Size = new Size(793, 181);
            GridStd.TabIndex = 0;
            // 
            // LoadBtn
            // 
            LoadBtn.BackColor = Color.Snow;
            LoadBtn.Location = new Point(458, 230);
            LoadBtn.Name = "LoadBtn";
            LoadBtn.Size = new Size(176, 23);
            LoadBtn.TabIndex = 1;
            LoadBtn.Text = "Load";
            LoadBtn.UseVisualStyleBackColor = false;
            LoadBtn.Click += LoadBtn_Click;
            // 
            // SaveBtn
            // 
            SaveBtn.BackColor = Color.Snow;
            SaveBtn.Location = new Point(458, 268);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(176, 23);
            SaveBtn.TabIndex = 2;
            SaveBtn.Text = "Save";
            SaveBtn.UseVisualStyleBackColor = false;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // TxtDeptId
            // 
            TxtDeptId.Location = new Point(110, 202);
            TxtDeptId.Name = "TxtDeptId";
            TxtDeptId.Size = new Size(210, 23);
            TxtDeptId.TabIndex = 3;
            // 
            // TxtFname
            // 
            TxtFname.Location = new Point(110, 231);
            TxtFname.Name = "TxtFname";
            TxtFname.Size = new Size(210, 23);
            TxtFname.TabIndex = 3;
            // 
            // TxtLname
            // 
            TxtLname.Location = new Point(110, 262);
            TxtLname.Name = "TxtLname";
            TxtLname.Size = new Size(210, 23);
            TxtLname.TabIndex = 3;
            // 
            // TxtAddress
            // 
            TxtAddress.Location = new Point(110, 292);
            TxtAddress.Name = "TxtAddress";
            TxtAddress.Size = new Size(210, 23);
            TxtAddress.TabIndex = 3;
            // 
            // TxtAge
            // 
            TxtAge.Location = new Point(110, 327);
            TxtAge.Name = "TxtAge";
            TxtAge.Size = new Size(210, 23);
            TxtAge.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 210);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 4;
            label1.Text = "Department_id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 239);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 4;
            label2.Text = "FirstName";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 268);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 4;
            label3.Text = "LastName";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 300);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 4;
            label4.Text = "Address";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 330);
            label5.Name = "label5";
            label5.Size = new Size(28, 15);
            label5.TabIndex = 4;
            label5.Text = "Age";
            // 
            // BtnInsert
            // 
            BtnInsert.BackColor = Color.Snow;
            BtnInsert.Location = new Point(24, 376);
            BtnInsert.Name = "BtnInsert";
            BtnInsert.Size = new Size(296, 23);
            BtnInsert.TabIndex = 2;
            BtnInsert.Text = "Insert";
            BtnInsert.UseVisualStyleBackColor = false;
            BtnInsert.Click += InsertBtn_Click;
            // 
            // MenueBtn
            // 
            MenueBtn.BackColor = Color.Snow;
            MenueBtn.Location = new Point(458, 322);
            MenueBtn.Name = "MenueBtn";
            MenueBtn.Size = new Size(176, 23);
            MenueBtn.TabIndex = 2;
            MenueBtn.Text = "Return Menue";
            MenueBtn.UseVisualStyleBackColor = false;
            MenueBtn.Click += MenueBtn_Click;
            // 
            // StudentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TxtAge);
            Controls.Add(TxtAddress);
            Controls.Add(TxtLname);
            Controls.Add(TxtFname);
            Controls.Add(BtnInsert);
            Controls.Add(TxtDeptId);
            Controls.Add(MenueBtn);
            Controls.Add(SaveBtn);
            Controls.Add(LoadBtn);
            Controls.Add(GridStd);
            Name = "StudentForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)GridStd).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView GridStd;
        private Button LoadBtn;
        private Button SaveBtn;
        private TextBox TxtDeptId;
        private TextBox TxtFname;
        private TextBox TxtLname;
        private TextBox TxtAddress;
        private TextBox TxtAge;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button BtnInsert;
        private Button MenueBtn;
        //private Button BtnDelete;
    }
}
