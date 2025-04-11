namespace iti_DB_forms
{
    partial class TopicForm
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
            TxtName = new TextBox();
            SaveBtn = new Button();
            LoadBtn = new Button();
            GridTopic = new DataGridView();
            MenueBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)GridTopic).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(4, 299);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 48;
            label1.Text = "Topic Name";
            // 
            // BtnInsert
            // 
            BtnInsert.BackColor = Color.Snow;
            BtnInsert.Location = new Point(12, 337);
            BtnInsert.Name = "BtnInsert";
            BtnInsert.Size = new Size(296, 23);
            BtnInsert.TabIndex = 41;
            BtnInsert.Text = "Insert";
            BtnInsert.UseVisualStyleBackColor = false;
            BtnInsert.Click += BtnInsert_Click;
            // 
            // TxtName
            // 
            TxtName.Location = new Point(90, 296);
            TxtName.Name = "TxtName";
            TxtName.Size = new Size(210, 23);
            TxtName.TabIndex = 45;
            // 
            // SaveBtn
            // 
            SaveBtn.BackColor = Color.Snow;
            SaveBtn.Location = new Point(459, 357);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(176, 23);
            SaveBtn.TabIndex = 42;
            SaveBtn.Text = "Save";
            SaveBtn.UseVisualStyleBackColor = false;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // LoadBtn
            // 
            LoadBtn.BackColor = Color.Snow;
            LoadBtn.Location = new Point(459, 319);
            LoadBtn.Name = "LoadBtn";
            LoadBtn.Size = new Size(176, 23);
            LoadBtn.TabIndex = 40;
            LoadBtn.Text = "Load";
            LoadBtn.UseVisualStyleBackColor = false;
            LoadBtn.Click += LoadBtn_Click;
            // 
            // GridTopic
            // 
            GridTopic.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridTopic.Location = new Point(4, 25);
            GridTopic.Name = "GridTopic";
            GridTopic.Size = new Size(793, 242);
            GridTopic.TabIndex = 39;
            // 
            // MenueBtn
            // 
            MenueBtn.BackColor = Color.Snow;
            MenueBtn.Location = new Point(459, 386);
            MenueBtn.Name = "MenueBtn";
            MenueBtn.Size = new Size(176, 23);
            MenueBtn.TabIndex = 42;
            MenueBtn.Text = "Return Menue";
            MenueBtn.UseVisualStyleBackColor = false;
            MenueBtn.Click += MenueBtn_Click;
            // 
            // TopicForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(BtnInsert);
            Controls.Add(TxtName);
            Controls.Add(MenueBtn);
            Controls.Add(SaveBtn);
            Controls.Add(LoadBtn);
            Controls.Add(GridTopic);
            Name = "TopicForm";
            Text = "TopicForm";
            ((System.ComponentModel.ISupportInitialize)GridTopic).EndInit();
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
        private DataGridView GridTopic;
        private Button MenueBtn;
    }
}