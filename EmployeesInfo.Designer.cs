namespace Employee
{
    partial class EmployeesInfo
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
            AddressBtn = new TextBox();
            DeleteBtn = new Button();
            UpdateBtn = new Button();
            InsertBtn = new Button();
            DeptCodeBtn = new TextBox();
            AgeBtn = new TextBox();
            SalBtn = new TextBox();
            PosBtn = new TextBox();
            NameBtn = new TextBox();
            EDIBtn = new TextBox();
            textBox8 = new TextBox();
            textBox7 = new TextBox();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            dataGridView1 = new DataGridView();
            SearchBtn = new TextBox();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // AddressBtn
            // 
            AddressBtn.Location = new Point(184, 409);
            AddressBtn.Name = "AddressBtn";
            AddressBtn.Size = new Size(100, 23);
            AddressBtn.TabIndex = 41;
            AddressBtn.TextChanged += AddressBtn_TextChanged;
            // 
            // DeleteBtn
            // 
            DeleteBtn.FlatStyle = FlatStyle.Popup;
            DeleteBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            DeleteBtn.Location = new Point(711, 511);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(75, 29);
            DeleteBtn.TabIndex = 40;
            DeleteBtn.Text = "Delete";
            DeleteBtn.UseVisualStyleBackColor = true;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // UpdateBtn
            // 
            UpdateBtn.FlatStyle = FlatStyle.Popup;
            UpdateBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            UpdateBtn.Location = new Point(498, 511);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(86, 29);
            UpdateBtn.TabIndex = 39;
            UpdateBtn.Text = "Update";
            UpdateBtn.UseVisualStyleBackColor = true;
            UpdateBtn.Click += UpdateBtn_Click;
            // 
            // InsertBtn
            // 
            InsertBtn.FlatStyle = FlatStyle.Popup;
            InsertBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            InsertBtn.Location = new Point(350, 511);
            InsertBtn.Name = "InsertBtn";
            InsertBtn.Size = new Size(75, 29);
            InsertBtn.TabIndex = 38;
            InsertBtn.Text = "Insert";
            InsertBtn.UseVisualStyleBackColor = true;
            InsertBtn.Click += InsertBtn_Click;
            // 
            // DeptCodeBtn
            // 
            DeptCodeBtn.Location = new Point(184, 452);
            DeptCodeBtn.Name = "DeptCodeBtn";
            DeptCodeBtn.Size = new Size(100, 23);
            DeptCodeBtn.TabIndex = 37;
            DeptCodeBtn.TextChanged += DeptCodeBtn_TextChanged;
            // 
            // AgeBtn
            // 
            AgeBtn.Location = new Point(184, 366);
            AgeBtn.Name = "AgeBtn";
            AgeBtn.Size = new Size(100, 23);
            AgeBtn.TabIndex = 36;
            AgeBtn.TextChanged += AgeBtn_TextChanged;
            // 
            // SalBtn
            // 
            SalBtn.Location = new Point(184, 318);
            SalBtn.Name = "SalBtn";
            SalBtn.Size = new Size(100, 23);
            SalBtn.TabIndex = 35;
            SalBtn.TextChanged += SalBtn_TextChanged;
            // 
            // PosBtn
            // 
            PosBtn.Location = new Point(184, 266);
            PosBtn.Name = "PosBtn";
            PosBtn.Size = new Size(100, 23);
            PosBtn.TabIndex = 34;
            PosBtn.TextChanged += PosBtn_TextChanged;
            // 
            // NameBtn
            // 
            NameBtn.Location = new Point(184, 221);
            NameBtn.Name = "NameBtn";
            NameBtn.Size = new Size(100, 23);
            NameBtn.TabIndex = 33;
            NameBtn.TextChanged += NameBtn_TextChanged;
            // 
            // EDIBtn
            // 
            EDIBtn.Location = new Point(184, 175);
            EDIBtn.Name = "EDIBtn";
            EDIBtn.Size = new Size(100, 23);
            EDIBtn.TabIndex = 32;
            EDIBtn.TextChanged += EDIBtn_TextChanged;
            // 
            // textBox8
            // 
            textBox8.BackColor = Color.LightCyan;
            textBox8.BorderStyle = BorderStyle.None;
            textBox8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            textBox8.Location = new Point(30, 450);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(100, 22);
            textBox8.TabIndex = 31;
            textBox8.Text = "DEPT CODE";
            textBox8.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox7
            // 
            textBox7.BackColor = Color.LightCyan;
            textBox7.BorderStyle = BorderStyle.None;
            textBox7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            textBox7.Location = new Point(30, 316);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(100, 22);
            textBox7.TabIndex = 30;
            textBox7.Text = "SALARY";
            textBox7.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.LightCyan;
            textBox6.BorderStyle = BorderStyle.None;
            textBox6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            textBox6.Location = new Point(30, 367);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 22);
            textBox6.TabIndex = 29;
            textBox6.Text = "AGE";
            textBox6.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.LightCyan;
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            textBox5.Location = new Point(30, 407);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 22);
            textBox5.TabIndex = 28;
            textBox5.Text = "ADDRESS";
            textBox5.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.LightCyan;
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            textBox4.Location = new Point(30, 264);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 22);
            textBox4.TabIndex = 27;
            textBox4.Text = "POSITION   ";
            textBox4.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.LightCyan;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            textBox3.Location = new Point(30, 222);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 22);
            textBox3.TabIndex = 26;
            textBox3.Text = "NAME:";
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.LightCyan;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(30, 173);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 22);
            textBox2.TabIndex = 25;
            textBox2.Text = "EID";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Azure;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(350, 161);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(612, 322);
            dataGridView1.TabIndex = 24;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // SearchBtn
            // 
            SearchBtn.BackColor = Color.Azure;
            SearchBtn.BorderStyle = BorderStyle.None;
            SearchBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            SearchBtn.Location = new Point(55, 113);
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
            textBox1.Location = new Point(311, 31);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(429, 52);
            textBox1.TabIndex = 22;
            textBox1.Text = "Employee's Information";
            // 
            // EmployeesInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(992, 571);
            Controls.Add(AddressBtn);
            Controls.Add(DeleteBtn);
            Controls.Add(UpdateBtn);
            Controls.Add(InsertBtn);
            Controls.Add(DeptCodeBtn);
            Controls.Add(AgeBtn);
            Controls.Add(SalBtn);
            Controls.Add(PosBtn);
            Controls.Add(NameBtn);
            Controls.Add(EDIBtn);
            Controls.Add(textBox8);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(dataGridView1);
            Controls.Add(SearchBtn);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EmployeesInfo";
            Text = "EmployeesInfo";
            Load += EmployeesInfo_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox AddressBtn;
        private Button DeleteBtn;
        private Button UpdateBtn;
        private Button InsertBtn;
        private TextBox DeptCodeBtn;
        private TextBox AgeBtn;
        private TextBox SalBtn;
        private TextBox PosBtn;
        private TextBox NameBtn;
        private TextBox EDIBtn;
        private TextBox textBox8;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private DataGridView dataGridView1;
        private TextBox SearchBtn;
        private TextBox textBox1;
    }
}