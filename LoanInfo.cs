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
        Add add = new Add();
        Retrieve retrieve = new Retrieve();

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
        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BackBtn_Click(object sender, EventArgs e)
        {

            MenuInfo menuForm = new MenuInfo();
            menuForm.Show();
            this.Close();
        }

        private void RetrieveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int Eid = int.Parse(EIDBtn.Text);

                Retrieve retrieve = new Retrieve(); // make sure you created an object
                DataTable dt = retrieve.RetrieveLoan(Eid); // assuming you created RetrieveLoan function

                if (dt.Rows.Count > 0)
                {
                    LoanAmountBtn.Text = dt.Rows[0]["LoanAmount"].ToString();
                    dateTimePicker1.Value = Convert.ToDateTime(dt.Rows[0]["Date"]); // <-- FIXED
                    MessageBox.Show("Loan retrieved successfully!");
                }
                else
                {
                    MessageBox.Show("No loan found for this EID.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving loan: " + ex.Message);
            }
        }

        

        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int Eid = int.Parse(EIDBtn.Text);
                decimal loanAmount = decimal.Parse(LoanAmountBtn.Text);
                DateTime Date = dateTimePicker1.Value;

                Add add = new Add();
                add.AddLoan(Eid, loanAmount, Date);

                MessageBox.Show("Loan added successfully!");

                dataGridView3.DataSource = mmm.Fetchloan();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding loan: " + ex.Message);
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
