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
        SQLSearch search = new SQLSearch();

        public DeptInfo()
        {
            InitializeComponent();
        }

        private void PerformSearch()
        {
            string searchTerm = SearchBox.Text.Trim();
            if (!string.IsNullOrEmpty(searchTerm))
            {
                search.SearchEmployee(searchTerm, dataGridView2);
            }
            else
            {
                // Load all employees again if search is empty
                dataGridView2.DataSource = mmm.Fetchemployeeinfo();
            }
        }
        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            PerformSearch();

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

        private void RetrieveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string deptCode = DeptCodeBtn.Text.Trim();

                if (string.IsNullOrEmpty(deptCode))
                {
                    MessageBox.Show("Please enter a Department Code to retrieve.");
                    return;
                }

                Retrieve retrieve = new Retrieve(); // Create Retrieve object
                DataTable dt = retrieve.RetrieveDepartment(deptCode); // New method we will add

                if (dt.Rows.Count > 0)
                {
                    DeptDescriBtn.Text = dt.Rows[0]["DeptDescription"].ToString(); // Fill the description textbox
                    MessageBox.Show("Department retrieved successfully!");
                }
                else
                {
                    MessageBox.Show("No department found with that code.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving department: " + ex.Message);
            }
        }


        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string deptCode = DeptCodeBtn.Text.Trim();
                string deptDescription = DeptDescriBtn.Text.Trim();

                if (string.IsNullOrEmpty(deptCode) || string.IsNullOrEmpty(deptDescription))
                {
                    MessageBox.Show("Please fill in both Dept Code and Dept Description.");
                    return;
                }

                Add add = new Add();
                add.AddDepartment(deptCode, deptDescription);

                MessageBox.Show("Department added successfully!");

                dataGridView2.DataSource = mmm.Fetchdepartmentinfo();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding department: " + ex.Message);
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string deptCode = DeptCodeBtn.Text.Trim();

                if (string.IsNullOrEmpty(deptCode))
                {
                    MessageBox.Show("Please enter a Department Code to delete.");
                    return;
                }

                Delete delete = new Delete();
                delete.DeleteDepartment(deptCode);

                MessageBox.Show("Department deleted successfully!");

                dataGridView2.DataSource = mmm.Fetchdepartmentinfo(); // Refresh
                DeptCodeBtn.Text = "";
                DeptDescriBtn.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
