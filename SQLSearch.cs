using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Employee
{
    public class SQLSearch
    {
        string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=employee";

        public void SearchEmployee(string searchTerm, DataGridView dataGridView)
        {
            string query = @"SELECT * FROM employeeinfo WHERE 
                            Eid LIKE @SearchTerm OR 
                            Name LIKE @SearchTerm OR 
                            Position LIKE @SearchTerm OR 
                            Salary LIKE @SearchTerm OR 
                            Age LIKE @SearchTerm OR 
                            Address LIKE @SearchTerm OR 
                            DeptCode LIKE @SearchTerm";

            ExecuteSearch(query, searchTerm, dataGridView);
        }

       
        public void SearchLoan(string searchTerm, DataGridView dataGridView)
        {
            string query = @"SELECT * FROM loan WHERE 
                            Eid LIKE @SearchTerm OR 
                            LoanAmount LIKE @SearchTerm OR 
                            Date LIKE @SearchTerm";

            ExecuteSearch(query, searchTerm, dataGridView);
        }

     
        public void SearchDepartment(string searchTerm, DataGridView dataGridView)
        {
            string query = @"SELECT * FROM department WHERE 
                            DeptCode LIKE @SearchTerm OR 
                            DeptDescription LIKE @SearchTerm";

            ExecuteSearch(query, searchTerm, dataGridView);
        }

        private void ExecuteSearch(string query, string searchTerm, DataGridView dataGridView)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@SearchTerm", "%" + searchTerm + "%");

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    dataGridView.DataSource = table;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}
