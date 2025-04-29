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
                    CAST(Eid AS CHAR) LIKE @SearchTerm OR 
                    Name LIKE @SearchTerm OR 
                    Position LIKE @SearchTerm OR 
                    CAST(Salary AS CHAR) LIKE @SearchTerm OR 
                    CAST(Age AS CHAR) LIKE @SearchTerm OR 
                    Address LIKE @SearchTerm OR 
                    DeptCode LIKE @SearchTerm";

            ExecuteSearch(query, searchTerm, dataGridView);
        }



        public void SearchLoan(string searchTerm, DataGridView dataGridView3)
        {
            string query = @"SELECT * FROM loan WHERE 
                            Eid LIKE @SearchTerm OR 
                            LoanAmount LIKE @SearchTerm OR 
                            Date LIKE @SearchTerm";

            ExecuteSearch(query, searchTerm, dataGridView3);
        }

     
        public void SearchDepartment(string searchTerm, DataGridView dataGridView2)
        {
            string query = @"SELECT * FROM department WHERE 
                            DeptCode LIKE @SearchTerm OR 
                            DeptDescription LIKE @SearchTerm";

            ExecuteSearch(query, searchTerm, dataGridView2);
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
