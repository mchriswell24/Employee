using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Employee
{
    public class MySQLConnector
    {
        string connectionString = "datasource=127.0.0.1;port=3307;username=root;password=;database=employee;";
        public DataTable Fetchdepartmentinfo()
        {
            var result = new DataTable();
            // Select all
            string query = "SELECT * FROM departmentinfo";
            try
            {
                try
                {
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();
                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                            {
                                adapter.Fill(result);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return result;
        }
        public DataTable Fetchemployeeinfo()
        {
            var result = new DataTable();
            // Select all
            string query = "SELECT * FROM employeeinfo";
            try
            {
                try
                {
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();
                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                            {
                                adapter.Fill(result);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return result;
        }
        public DataTable Fetchloan()
        {

            var result = new DataTable();
            // Select all
            string query = "SELECT * FROM loan";
            try
            {
                try
                {
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();
                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                            {
                                adapter.Fill(result);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return result;
        }
    }
}