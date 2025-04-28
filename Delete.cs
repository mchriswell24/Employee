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
    }
}
