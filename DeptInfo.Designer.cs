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
            textBox8 = new TextBox();
            dataGridView2 = new DataGridView();
            SearchBox = new TextBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            DeptDescriBtn = new TextBox();
            DeptCodeBtn = new TextBox();
            BackBtn = new Button();
            RetrieveBtn = new Button();
            AddBtn = new Button();
            DeleteBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // textBox8
            // 
            textBox8.BackColor = Color.MediumAquamarine;
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
            dataGridView2.BackgroundColor = Color.Aquamarine;
            dataGridView2.BorderStyle = BorderStyle.None;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(370, 185);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(465, 157);
            dataGridView2.TabIndex = 24;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // SearchBox
            // 
            SearchBox.BackColor = Color.Azure;
            SearchBox.BorderStyle = BorderStyle.None;
            SearchBox.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            SearchBox.Location = new Point(55, 101);
            SearchBox.Name = "SearchBox";
            SearchBox.Size = new Size(474, 22);
            SearchBox.TabIndex = 23;
            SearchBox.TextChanged += SearchBox_TextChanged;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.MediumAquamarine;
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
            textBox2.BackColor = Color.MediumAquamarine;
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
            // RetrieveBtn
            // 
            RetrieveBtn.FlatStyle = FlatStyle.Popup;
            RetrieveBtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            RetrieveBtn.Location = new Point(588, 368);
            RetrieveBtn.Name = "RetrieveBtn";
            RetrieveBtn.Size = new Size(90, 33);
            RetrieveBtn.TabIndex = 45;
            RetrieveBtn.Text = "Retrieve";
            RetrieveBtn.UseVisualStyleBackColor = true;
            RetrieveBtn.Click += RetrieveBtn_Click;
            // 
            // AddBtn
            // 
            AddBtn.FlatStyle = FlatStyle.Popup;
            AddBtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            AddBtn.Location = new Point(472, 368);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(75, 33);
            AddBtn.TabIndex = 58;
            AddBtn.Text = "Add";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // DeleteBtn
            // 
            DeleteBtn.FlatStyle = FlatStyle.Popup;
            DeleteBtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            DeleteBtn.Location = new Point(527, 419);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(75, 42);
            DeleteBtn.TabIndex = 60;
            DeleteBtn.Text = "Delete";
            DeleteBtn.UseVisualStyleBackColor = true;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // DeptInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumAquamarine;
            ClientSize = new Size(926, 505);
            Controls.Add(DeleteBtn);
            Controls.Add(AddBtn);
            Controls.Add(RetrieveBtn);
            Controls.Add(BackBtn);
            Controls.Add(DeptCodeBtn);
            Controls.Add(DeptDescriBtn);
            Controls.Add(textBox2);
            Controls.Add(textBox8);
            Controls.Add(dataGridView2);
            Controls.Add(SearchBox);
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
        private TextBox textBox8;
        private DataGridView dataGridView2;
        private TextBox SearchBox;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox DeptDescriBtn;
        private TextBox DeptCodeBtn;
        private Button BackBtn;
        private Button RetrieveBtn;
        private Button AddBtn;
        private Button DeleteBtn;
    }
}