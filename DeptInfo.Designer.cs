namespace Employee
{
    partial class DeptInfo
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
            DeleteBtn = new Button();
            UpdateBtn = new Button();
            textBox8 = new TextBox();
            dataGridView2 = new DataGridView();
            SearchBtn = new TextBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            DeptDescriBtn = new TextBox();
            DeptCodeBtn = new TextBox();
            BackBtn = new Button();
            CreateBtn = new Button();
            EditBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // DeleteBtn
            // 
            DeleteBtn.FlatStyle = FlatStyle.Popup;
            DeleteBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            DeleteBtn.Location = new Point(647, 417);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(75, 36);
            DeleteBtn.TabIndex = 40;
            DeleteBtn.Text = "Delete";
            DeleteBtn.UseVisualStyleBackColor = true;
            // 
            // UpdateBtn
            // 
            UpdateBtn.FlatStyle = FlatStyle.Popup;
            UpdateBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            UpdateBtn.Location = new Point(457, 417);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(86, 36);
            UpdateBtn.TabIndex = 39;
            UpdateBtn.Text = "Update";
            UpdateBtn.UseVisualStyleBackColor = true;
            // 
            // textBox8
            // 
            textBox8.BackColor = Color.LightCyan;
            textBox8.BorderStyle = BorderStyle.None;
            textBox8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            textBox8.Location = new Point(40, 262);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(100, 22);
            textBox8.TabIndex = 31;
            textBox8.Text = "DEPT CODE";
            textBox8.TextAlign = HorizontalAlignment.Center;
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = Color.Azure;
            dataGridView2.BorderStyle = BorderStyle.None;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(472, 216);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(250, 129);
            dataGridView2.TabIndex = 24;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // SearchBtn
            // 
            SearchBtn.BackColor = Color.Azure;
            SearchBtn.BorderStyle = BorderStyle.None;
            SearchBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            SearchBtn.Location = new Point(55, 101);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(474, 22);
            SearchBtn.TabIndex = 23;
            SearchBtn.Text = "Search:";
            SearchBtn.TextChanged += SearchBtn_TextChanged;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.LightCyan;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe Script", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(305, 43);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(458, 52);
            textBox1.TabIndex = 22;
            textBox1.Text = "Department  Information";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.LightCyan;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            textBox2.Location = new Point(12, 320);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(159, 22);
            textBox2.TabIndex = 41;
            textBox2.Text = "DEPT DESCRIPTION";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // DeptDescriBtn
            // 
            DeptDescriBtn.Location = new Point(208, 322);
            DeptDescriBtn.Name = "DeptDescriBtn";
            DeptDescriBtn.Size = new Size(115, 23);
            DeptDescriBtn.TabIndex = 42;
            DeptDescriBtn.TextChanged += DeptDescriBtn_TextChanged;
            // 
            // DeptCodeBtn
            // 
            DeptCodeBtn.Location = new Point(208, 262);
            DeptCodeBtn.Name = "DeptCodeBtn";
            DeptCodeBtn.Size = new Size(115, 23);
            DeptCodeBtn.TabIndex = 43;
            DeptCodeBtn.TextChanged += DeptCodeBtn_TextChanged;
            // 
            // BackBtn
            // 
            BackBtn.FlatStyle = FlatStyle.Popup;
            BackBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            BackBtn.Location = new Point(859, -2);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(66, 37);
            BackBtn.TabIndex = 44;
            BackBtn.Text = "X";
            BackBtn.UseVisualStyleBackColor = true;
            BackBtn.Click += BackBtn_Click;
            // 
            // CreateBtn
            // 
            CreateBtn.FlatStyle = FlatStyle.Popup;
            CreateBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            CreateBtn.Location = new Point(110, 417);
            CreateBtn.Name = "CreateBtn";
            CreateBtn.Size = new Size(75, 36);
            CreateBtn.TabIndex = 45;
            CreateBtn.Text = "Create";
            CreateBtn.UseVisualStyleBackColor = true;
            // 
            // EditBtn
            // 
            EditBtn.FlatStyle = FlatStyle.Popup;
            EditBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            EditBtn.Location = new Point(275, 417);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(75, 36);
            EditBtn.TabIndex = 46;
            EditBtn.Text = "Edit";
            EditBtn.UseVisualStyleBackColor = true;
            // 
            // DeptInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(926, 505);
            Controls.Add(EditBtn);
            Controls.Add(CreateBtn);
            Controls.Add(BackBtn);
            Controls.Add(DeptCodeBtn);
            Controls.Add(DeptDescriBtn);
            Controls.Add(textBox2);
            Controls.Add(DeleteBtn);
            Controls.Add(UpdateBtn);
            Controls.Add(textBox8);
            Controls.Add(dataGridView2);
            Controls.Add(SearchBtn);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DeptInfo";
            Text = "DeptInfo";
            Load += DeptInfo_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button DeleteBtn;
        private Button UpdateBtn;
        private TextBox textBox8;
        private DataGridView dataGridView2;
        private TextBox SearchBtn;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox DeptDescriBtn;
        private TextBox DeptCodeBtn;
        private Button BackBtn;
        private Button CreateBtn;
        private Button EditBtn;
    }
}