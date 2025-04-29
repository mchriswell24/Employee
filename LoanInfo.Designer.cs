namespace Employee
{
    partial class LoanInfo
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
            EIDBtn = new TextBox();
            textBox2 = new TextBox();
            LoanAmountBtn = new TextBox();
            textBox8 = new TextBox();
            dataGridView3 = new DataGridView();
            SearchBox = new TextBox();
            textBox1 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            textBox3 = new TextBox();
            BackBtn = new Button();
            RetrieveBtn = new Button();
            AddBtn = new Button();
            DeleteBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            SuspendLayout();
            // 
            // EIDBtn
            // 
            EIDBtn.Location = new Point(205, 175);
            EIDBtn.Name = "EIDBtn";
            EIDBtn.Size = new Size(115, 23);
            EIDBtn.TabIndex = 52;
            EIDBtn.TextChanged += EIDBtn_TextChanged;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.MediumAquamarine;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            textBox2.Location = new Point(24, 234);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(159, 22);
            textBox2.TabIndex = 51;
            textBox2.Text = "LOAN AMOUNT";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // LoanAmountBtn
            // 
            LoanAmountBtn.Location = new Point(205, 233);
            LoanAmountBtn.Name = "LoanAmountBtn";
            LoanAmountBtn.Size = new Size(115, 23);
            LoanAmountBtn.TabIndex = 47;
            LoanAmountBtn.TextChanged += LoanAmountBtn_TextChanged;
            // 
            // textBox8
            // 
            textBox8.BackColor = Color.MediumAquamarine;
            textBox8.BorderStyle = BorderStyle.None;
            textBox8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            textBox8.Location = new Point(52, 176);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(100, 22);
            textBox8.TabIndex = 46;
            textBox8.Text = "EID";
            textBox8.TextAlign = HorizontalAlignment.Center;
            // 
            // dataGridView3
            // 
            dataGridView3.BackgroundColor = Color.Aquamarine;
            dataGridView3.BorderStyle = BorderStyle.None;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(433, 154);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.Size = new Size(352, 173);
            dataGridView3.TabIndex = 45;
            dataGridView3.CellContentClick += dataGridView3_CellContentClick;
            // 
            // SearchBox
            // 
            SearchBox.BackColor = Color.Azure;
            SearchBox.BorderStyle = BorderStyle.None;
            SearchBox.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            SearchBox.Location = new Point(64, 101);
            SearchBox.Name = "SearchBox";
            SearchBox.Size = new Size(474, 22);
            SearchBox.TabIndex = 44;
            SearchBox.TextChanged += SearchBox_TextChanged;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.MediumAquamarine;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe Script", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(359, 43);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(317, 52);
            textBox1.TabIndex = 43;
            textBox1.Text = "Loan Information";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(205, 305);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(115, 23);
            dateTimePicker1.TabIndex = 53;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.MediumAquamarine;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            textBox3.Location = new Point(52, 305);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 22);
            textBox3.TabIndex = 54;
            textBox3.Text = "DATE";
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // BackBtn
            // 
            BackBtn.FlatStyle = FlatStyle.Popup;
            BackBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            BackBtn.Location = new Point(838, 1);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(61, 31);
            BackBtn.TabIndex = 55;
            BackBtn.Text = "X";
            BackBtn.UseVisualStyleBackColor = true;
            BackBtn.Click += BackBtn_Click;
            // 
            // RetrieveBtn
            // 
            RetrieveBtn.FlatStyle = FlatStyle.Popup;
            RetrieveBtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            RetrieveBtn.Location = new Point(433, 346);
            RetrieveBtn.Name = "RetrieveBtn";
            RetrieveBtn.Size = new Size(90, 33);
            RetrieveBtn.TabIndex = 56;
            RetrieveBtn.Text = "Retrieve";
            RetrieveBtn.UseVisualStyleBackColor = true;
            RetrieveBtn.Click += RetrieveBtn_Click;
            // 
            // AddBtn
            // 
            AddBtn.FlatStyle = FlatStyle.Popup;
            AddBtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            AddBtn.Location = new Point(565, 346);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(75, 33);
            AddBtn.TabIndex = 57;
            AddBtn.Text = "Add";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // DeleteBtn
            // 
            DeleteBtn.FlatStyle = FlatStyle.Popup;
            DeleteBtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            DeleteBtn.Location = new Point(681, 346);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(75, 33);
            DeleteBtn.TabIndex = 60;
            DeleteBtn.Text = "Delete";
            DeleteBtn.UseVisualStyleBackColor = true;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // LoanInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumAquamarine;
            ClientSize = new Size(897, 450);
            Controls.Add(DeleteBtn);
            Controls.Add(AddBtn);
            Controls.Add(RetrieveBtn);
            Controls.Add(BackBtn);
            Controls.Add(textBox3);
            Controls.Add(dateTimePicker1);
            Controls.Add(EIDBtn);
            Controls.Add(textBox2);
            Controls.Add(LoanAmountBtn);
            Controls.Add(textBox8);
            Controls.Add(dataGridView3);
            Controls.Add(SearchBox);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoanInfo";
            Text = "LoanInfo";
            Load += LoanInfo_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox EIDBtn;
        private TextBox textBox2;
        private TextBox LoanAmountBtn;
        private TextBox textBox8;
        private DataGridView dataGridView3;
        private TextBox SearchBox;
        private TextBox textBox1;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox3;
        private Button BackBtn;
        private Button RetrieveBtn;
        private Button AddBtn;
        private Button DeleteBtn;
    }
}