namespace Employee
{
    partial class MenuInfo
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
            LoanInfoBtn = new Button();
            DeptInfoBtn = new Button();
            EmployeesBtn = new TextBox();
            EmployeeInfoBtn = new Button();
            SuspendLayout();
            // 
            // LoanInfoBtn
            // 
            LoanInfoBtn.FlatStyle = FlatStyle.Popup;
            LoanInfoBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            LoanInfoBtn.Location = new Point(151, 165);
            LoanInfoBtn.Name = "LoanInfoBtn";
            LoanInfoBtn.Size = new Size(215, 54);
            LoanInfoBtn.TabIndex = 0;
            LoanInfoBtn.Text = "Loan Information";
            LoanInfoBtn.UseVisualStyleBackColor = true;
            LoanInfoBtn.Click += LoanInfoBtn_Click;
            // 
            // DeptInfoBtn
            // 
            DeptInfoBtn.FlatStyle = FlatStyle.Popup;
            DeptInfoBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            DeptInfoBtn.Location = new Point(151, 294);
            DeptInfoBtn.Name = "DeptInfoBtn";
            DeptInfoBtn.Size = new Size(215, 54);
            DeptInfoBtn.TabIndex = 1;
            DeptInfoBtn.Text = "Department Information";
            DeptInfoBtn.UseVisualStyleBackColor = true;
            DeptInfoBtn.Click += DeptInfoBtn_Click;
            // 
            // EmployeesBtn
            // 
            EmployeesBtn.BackColor = Color.LightCyan;
            EmployeesBtn.BorderStyle = BorderStyle.None;
            EmployeesBtn.Font = new Font("Segoe Script", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            EmployeesBtn.Location = new Point(41, 61);
            EmployeesBtn.Name = "EmployeesBtn";
            EmployeesBtn.Size = new Size(449, 44);
            EmployeesBtn.TabIndex = 3;
            EmployeesBtn.Text = "EMPLOYEE'S INFORMATION";
            EmployeesBtn.TextAlign = HorizontalAlignment.Center;
            // 
            // EmployeeInfoBtn
            // 
            EmployeeInfoBtn.FlatStyle = FlatStyle.Popup;
            EmployeeInfoBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            EmployeeInfoBtn.Location = new Point(151, 406);
            EmployeeInfoBtn.Name = "EmployeeInfoBtn";
            EmployeeInfoBtn.Size = new Size(215, 58);
            EmployeeInfoBtn.TabIndex = 4;
            EmployeeInfoBtn.Text = "Employee's Information";
            EmployeeInfoBtn.UseVisualStyleBackColor = true;
            EmployeeInfoBtn.Click += EmployeeInfoBtn_Click;
            // 
            // MenuInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(561, 613);
            Controls.Add(EmployeeInfoBtn);
            Controls.Add(EmployeesBtn);
            Controls.Add(DeptInfoBtn);
            Controls.Add(LoanInfoBtn);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MenuInfo";
            Text = "Menu";
            Load += MenuInfo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button LoanInfoBtn;
        private Button DeptInfoBtn;
        private TextBox EmployeesBtn;
        private Button EmployeeInfoBtn;
    }
}