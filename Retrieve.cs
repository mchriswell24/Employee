using System;
using MySql.Data.MySqlClient;
using System.Data;

namespace Employee
{
    internal class Retrieve
    {
        string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=employee";

        public DataTable RetrieveEmployee(int Eid)
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM employeeinfo WHERE Eid = @Eid";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Eid", Eid);
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            adapter.Fill(dt);
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error retrieving employee: " + ex.Message);
                }
            }

            return dt;
        }

        public DataTable RetrieveLoan(int Eid)
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM loan WHERE Eid = @Eid";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Eid", Eid);
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            adapter.Fill(dt);
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error retrieving loan: " + ex.Message);
                }
            }

            return dt;
        }
        public DataTable RetrieveDepartment(string deptCode)
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM departmentinfo WHERE DeptCode = @DeptCode";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@DeptCode", deptCode);
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            adapter.Fill(dt);
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error retrieving department: " + ex.Message);
                }
            }

            return dt;
        }

    }
}

