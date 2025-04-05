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
            DeleteBtn = new Button();
            UpdateBtn = new Button();
            InsertBtn = new Button();
            LoanAmountBtn = new TextBox();
            textBox8 = new TextBox();
            dataGridView3 = new DataGridView();
            SearchBtn = new TextBox();
            textBox1 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            textBox3 = new TextBox();
            BackBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            SuspendLayout();
            // 
            // EIDBtn
            // 
            EIDBtn.Location = new Point(202, 261);
            EIDBtn.Name = "EIDBtn";
            EIDBtn.Size = new Size(115, 23);
            EIDBtn.TabIndex = 52;
            EIDBtn.TextChanged += EIDBtn_TextChanged;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.LightCyan;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            textBox2.Location = new Point(21, 320);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(159, 22);
            textBox2.TabIndex = 51;
            textBox2.Text = "LOAN AMOUNT";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // DeleteBtn
            // 
            DeleteBtn.FlatStyle = FlatStyle.Popup;
            DeleteBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            DeleteBtn.Location = new Point(720, 499);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(75, 29);
            DeleteBtn.TabIndex = 50;
            DeleteBtn.Text = "Delete";
            DeleteBtn.UseVisualStyleBackColor = true;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // UpdateBtn
            // 
            UpdateBtn.FlatStyle = FlatStyle.Popup;
            UpdateBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            UpdateBtn.Location = new Point(507, 499);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(86, 29);
            UpdateBtn.TabIndex = 49;
            UpdateBtn.Text = "Update";
            UpdateBtn.UseVisualStyleBackColor = true;
            UpdateBtn.Click += UpdateBtn_Click;
            // 
            // InsertBtn
            // 
            InsertBtn.FlatStyle = FlatStyle.Popup;
            InsertBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            InsertBtn.Location = new Point(359, 499);
            InsertBtn.Name = "InsertBtn";
            InsertBtn.Size = new Size(75, 29);
            InsertBtn.TabIndex = 48;
            InsertBtn.Text = "Insert";
            InsertBtn.UseVisualStyleBackColor = true;
            InsertBtn.Click += InsertBtn_Click;
            // 
            // LoanAmountBtn
            // 
            LoanAmountBtn.Location = new Point(202, 319);
            LoanAmountBtn.Name = "LoanAmountBtn";
            LoanAmountBtn.Size = new Size(115, 23);
            LoanAmountBtn.TabIndex = 47;
            LoanAmountBtn.TextChanged += LoanAmountBtn_TextChanged;
            // 
            // textBox8
            // 
            textBox8.BackColor = Color.LightCyan;
            textBox8.BorderStyle = BorderStyle.None;
            textBox8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            textBox8.Location = new Point(49, 262);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(100, 22);
            textBox8.TabIndex = 46;
            textBox8.Text = "EID";
            textBox8.TextAlign = HorizontalAlignment.Center;
            // 
            // dataGridView3
            // 
            dataGridView3.BackgroundColor = Color.Azure;
            dataGridView3.BorderStyle = BorderStyle.None;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(359, 149);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.Size = new Size(612, 322);
            dataGridView3.TabIndex = 45;
            dataGridView3.CellContentClick += dataGridView3_CellContentClick;
            // 
            // SearchBtn
            // 
            SearchBtn.BackColor = Color.Azure;
            SearchBtn.BorderStyle = BorderStyle.None;
            SearchBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            SearchBtn.Location = new Point(64, 101);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(474, 22);
            SearchBtn.TabIndex = 44;
            SearchBtn.Text = "Search:";
            SearchBtn.TextChanged += SearchBtn_TextChanged;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.LightCyan;
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
            dateTimePicker1.Location = new Point(202, 391);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(115, 23);
            dateTimePicker1.TabIndex = 53;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.LightCyan;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            textBox3.Location = new Point(49, 391);
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
            BackBtn.Location = new Point(932, -1);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(61, 31);
            BackBtn.TabIndex = 55;
            BackBtn.Text = "X";
            BackBtn.UseVisualStyleBackColor = true;
            BackBtn.Click += BackBtn_Click;
            // 
            // LoanInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(992, 571);
            Controls.Add(BackBtn);
            Controls.Add(textBox3);
            Controls.Add(dateTimePicker1);
            Controls.Add(EIDBtn);
            Controls.Add(textBox2);
            Controls.Add(DeleteBtn);
            Controls.Add(UpdateBtn);
            Controls.Add(InsertBtn);
            Controls.Add(LoanAmountBtn);
            Controls.Add(textBox8);
            Controls.Add(dataGridView3);
            Controls.Add(SearchBtn);
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
        private Button DeleteBtn;
        private Button UpdateBtn;
        private Button InsertBtn;
        private TextBox LoanAmountBtn;
        private TextBox textBox8;
        private DataGridView dataGridView3;
        private TextBox SearchBtn;
        private TextBox textBox1;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox3;
        private Button BackBtn;
    }
}