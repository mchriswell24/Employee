using System;
using MySql.Data.MySqlClient;

namespace Employee
{
    internal class Delete
    {
        string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=employee";

        public void DeleteEmployee(int Eid)
        {
            string deleteLoanQuery = "DELETE FROM loan WHERE Eid = @Eid";
            string deleteEmployeeQuery = "DELETE FROM employeeinfo WHERE Eid = @Eid";

            using (MySqlConnection connection = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=employee"))
            {
                connection.Open();
                using (MySqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        // First delete from loan
                        using (MySqlCommand deleteLoanCommand = new MySqlCommand(deleteLoanQuery, connection, transaction))
                        {
                            deleteLoanCommand.Parameters.AddWithValue("@Eid", Eid);
                            deleteLoanCommand.ExecuteNonQuery();
                        }

                        // Then delete from employeeinfo
                        using (MySqlCommand deleteEmployeeCommand = new MySqlCommand(deleteEmployeeQuery, connection, transaction))
                        {
                            deleteEmployeeCommand.Parameters.AddWithValue("@Eid", Eid);
                            deleteEmployeeCommand.ExecuteNonQuery();
                        }

                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw new Exception("Error deleting employee: " + ex.Message);
                    }
                }
            }
        }

        public void DeleteDepartment(string deptCode)
        {
            string query = "DELETE FROM departmentinfo WHERE DeptCode = @DeptCode";

            using (MySqlConnection connection = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=employee"))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@DeptCode", deptCode);
                        int affectedRows = cmd.ExecuteNonQuery();

                        if (affectedRows == 0)
                        {
                            throw new Exception("No department was deleted. Please check the DeptCode.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error deleting department: " + ex.Message);
                }
            }
        }
        public void DeleteLoan(int Eid)
        {
            string deleteQuery = "DELETE FROM loan WHERE Eid = @Eid";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand cmd = new MySqlCommand(deleteQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@Eid", Eid);
                        int rows = cmd.ExecuteNonQuery();

                        if (rows == 0)
                        {
                            throw new Exception("No loan found to delete.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error deleting loan: " + ex.Message);
                }
            }
        }

    }

}

    
