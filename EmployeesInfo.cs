using System;
using System.Data;
using System.Windows.Forms;

namespace Employee
{
    public partial class EmployeesInfo : Form
    {
        MySQLConnector mmm = new MySQLConnector();
        SQLSearch search = new SQLSearch();
        Add add = new Add();
        Retrieve retrieve = new Retrieve();

        public EmployeesInfo()
        {
            InitializeComponent();
        }

        private void EmployeesInfo_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = mmm.Fetchemployeeinfo();
        }

        private void PerformSearch()
        {
            string searchTerm = SearchBox.Text.Trim();
            if (!string.IsNullOrEmpty(searchTerm))
            {
                search.SearchEmployee(searchTerm, dataGridView1);
            }
            else
            {
                dataGridView1.DataSource = mmm.Fetchemployeeinfo();
            }
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            PerformSearch();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void EDIBtn_TextChanged(object sender, EventArgs e) { }
        private void NameBtn_TextChanged(object sender, EventArgs e) { }
        private void PosBtn_TextChanged(object sender, EventArgs e) { }
        private void SalBtn_TextChanged(object sender, EventArgs e) { }
        private void AgeBtn_TextChanged(object sender, EventArgs e) { }
        private void AddressBtn_TextChanged(object sender, EventArgs e) { }
        private void DeptCodeBtn_TextChanged(object sender, EventArgs e) { }

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
                int Eid = int.Parse(EDIBtn.Text);

                DataTable dt = retrieve.RetrieveEmployee(Eid);

                if (dt.Rows.Count > 0)
                {
                    NameBtn.Text = dt.Rows[0]["Name"].ToString();
                    PosBtn.Text = dt.Rows[0]["Position"].ToString();
                    SalBtn.Text = dt.Rows[0]["Salary"].ToString();
                    AgeBtn.Text = dt.Rows[0]["Age"].ToString();
                    AddressBtn.Text = dt.Rows[0]["Address"].ToString();
                    DeptCodeBtn.Text = dt.Rows[0]["DeptCode"].ToString();

                    MessageBox.Show("Employee retrieved successfully!");
                }
                else
                {
                    MessageBox.Show("No employee found with that EID.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving employee: " + ex.Message);
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int Eid = int.Parse(EDIBtn.Text);
                string name = NameBtn.Text;
                string position = PosBtn.Text;
                decimal salary = decimal.Parse(SalBtn.Text);
                int age = int.Parse(AgeBtn.Text);
                string address = AddressBtn.Text;
                string deptCode = DeptCodeBtn.Text;

                add.AddEmployee(Eid, name, position, salary, age, address, deptCode);

                MessageBox.Show("Employee added successfully!");

                dataGridView1.DataSource = mmm.Fetchemployeeinfo();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding employee: " + ex.Message);
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int Eid = int.Parse(EDIBtn.Text);

                Delete delete = new Delete();
                delete.DeleteEmployee(Eid);

                MessageBox.Show("Employee deleted successfully!");

                dataGridView1.DataSource = mmm.Fetchemployeeinfo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
