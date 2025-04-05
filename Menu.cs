using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee
{
    public partial class MenuInfo : Form
    {
        public MenuInfo()
        {
            InitializeComponent();
        }

        private void MenuInfo_Load(object sender, EventArgs e)
        {

        }

        private void LoanInfoBtn_Click(object sender, EventArgs e)
        {
            LoanInfo loaInfoForm = new LoanInfo();
            loaInfoForm.Show();

            this.Hide();
        }

        private void DeptInfoBtn_Click(object sender, EventArgs e)
        {
            DeptInfo deptInfoForm = new DeptInfo();
            deptInfoForm.Show();

            this.Hide();
        }
        private void EmployeeInfoBtn_Click(object sender, EventArgs e)
        {
            EmployeeInfo empInfoForm = new EmployeeInfo();
            empInfoForm.Show();

            this.Hide();
        }
    }
}
