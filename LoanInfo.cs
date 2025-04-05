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
    public partial class LoanInfo : Form
    {
        MySQLConnector mmm = new MySQLConnector();

        public LoanInfo()
        {
            InitializeComponent();
        }

        private void LoanInfo_Load(object sender, EventArgs e)
        {
            dataGridView3.DataSource = mmm.Fetchloan();

        }

        private void SearchBtn_TextChanged(object sender, EventArgs e)
        {

        }

        private void EIDBtn_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoanAmountBtn_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void InsertBtn_Click(object sender, EventArgs e)
        {

        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {

        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
