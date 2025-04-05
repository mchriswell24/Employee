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
    public partial class EmployeesInfo : Form
    {
        MySQLConnector mmm = new MySQLConnector();

        public EmployeesInfo()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void EmployeesInfo_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = mmm.Fetchemployeeinfo();

        }

        private void SearchBtn_TextChanged(object sender, EventArgs e)
        {

        }

        private void EDIBtn_TextChanged(object sender, EventArgs e)
        {

        }

        private void NameBtn_TextChanged(object sender, EventArgs e)
        {

        }

        private void PosBtn_TextChanged(object sender, EventArgs e)
        {

        }

        private void SalBtn_TextChanged(object sender, EventArgs e)
        {

        }

        private void AgeBtn_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddressBtn_TextChanged(object sender, EventArgs e)
        {

        }

        private void DeptCodeBtn_TextChanged(object sender, EventArgs e)
        {

        }
        private void UpdateBtn_Click(object sender, EventArgs e)
        {

        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            MenuInfo menuForm = new MenuInfo();
            menuForm.Show();
            this.Close();
        }
    }
}
