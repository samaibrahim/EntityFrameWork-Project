namespace iti_DB_forms
{
    partial class CourseForm
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
            TxtTopic = new TextBox();
            TxtDuration = new TextBox();
            BtnInsert = new Button();
            TxtName = new TextBox();
            SaveBtn = new Button();
            LoadBtn = new Button();
            GridCrs = new DataGridView();
            MenueBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)GridCrs).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(4, 346);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 36;
            label3.Text = "Topic_id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(4, 314);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 37;
            label2.Text = "Duration";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(4, 286);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 38;
            label1.Text = "Name";
            // 
            // TxtTopic
            // 
            TxtTopic.Location = new Point(111, 338);
            TxtTopic.Name = "TxtTopic";
            TxtTopic.Size = new Size(210, 23);
            TxtTopic.TabIndex = 33;
            // 
            // TxtDuration
            // 
            TxtDuration.Location = new Point(111, 307);
            TxtDuration.Name = "TxtDuration";
            TxtDuration.Size = new Size(210, 23);
            TxtDuration.TabIndex = 34;
            // 
            // BtnInsert
            // 
            BtnInsert.BackColor = Color.Snow;
            BtnInsert.Location = new Point(12, 390);
            BtnInsert.Name = "BtnInsert";
            BtnInsert.Size = new Size(296, 23);
            BtnInsert.TabIndex = 31;
            BtnInsert.Text = "Insert";
            BtnInsert.UseVisualStyleBackColor = false;
            BtnInsert.Click += BtnInsert_Click;
            // 
            // TxtName
            // 
            TxtName.Location = new Point(111, 278);
            TxtName.Name = "TxtName";
            TxtName.Size = new Size(210, 23);
            TxtName.TabIndex = 35;
            // 
            // SaveBtn
            // 
            SaveBtn.BackColor = Color.Snow;
            SaveBtn.Location = new Point(459, 344);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(176, 23);
            SaveBtn.TabIndex = 32;
            SaveBtn.Text = "Save";
            SaveBtn.UseVisualStyleBackColor = false;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // LoadBtn
            // 
            LoadBtn.BackColor = Color.Snow;
            LoadBtn.Location = new Point(459, 306);
            LoadBtn.Name = "LoadBtn";
            LoadBtn.Size = new Size(176, 23);
            LoadBtn.TabIndex = 30;
            LoadBtn.Text = "Load";
            LoadBtn.UseVisualStyleBackColor = false;
            LoadBtn.Click += LoadBtn_Click;
            // 
            // GridCrs
            // 
            GridCrs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridCrs.Location = new Point(4, 12);
            GridCrs.Name = "GridCrs";
            GridCrs.Size = new Size(793, 242);
            GridCrs.TabIndex = 29;
            // 
            // MenueBtn
            // 
            MenueBtn.BackColor = Color.Snow;
            MenueBtn.Location = new Point(459, 373);
            MenueBtn.Name = "MenueBtn";
            MenueBtn.Size = new Size(176, 23);
            MenueBtn.TabIndex = 32;
            MenueBtn.Text = "Return Menue";
            MenueBtn.UseVisualStyleBackColor = false;
            MenueBtn.Click += MenueBtn_Click;
            // 
            // CourseForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TxtTopic);
            Controls.Add(TxtDuration);
            Controls.Add(BtnInsert);
            Controls.Add(TxtName);
            Controls.Add(MenueBtn);
            Controls.Add(SaveBtn);
            Controls.Add(LoadBtn);
            Controls.Add(GridCrs);
            Name = "CourseForm";
            Text = "CourseForm";
            ((System.ComponentModel.ISupportInitialize)GridCrs).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox TxtTopic;
        private TextBox TxtDuration;
        private Button BtnInsert;
        private TextBox TxtName;
        private Button SaveBtn;
        private Button LoadBtn;
        private DataGridView GridCrs;
        private Button MenueBtn;
    }
}