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
    public partial class DeptInfo : Form
    {
        MySQLConnector mmm = new MySQLConnector();

        public DeptInfo()
        {
            InitializeComponent();
        }

        private void SearchBtn_TextChanged(object sender, EventArgs e)
        {

        }

        private void DeptInfo_Load(object sender, EventArgs e)
        {
            dataGridView2.DataSource = mmm.Fetchdepartmentinfo();

        }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DeptDescriBtn_TextChanged(object sender, EventArgs e)
        {

        }

        private void DeptCodeBtn_TextChanged(object sender, EventArgs e)
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
