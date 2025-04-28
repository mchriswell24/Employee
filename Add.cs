using MySql.Data.MySqlClient;
using System;

namespace Employee
{
    internal class Add
    {
        string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=employee";

        public void AddEmployee(int Eid, string name, string position, decimal salary, int age, string address, string deptCode)
        {
            string query = "INSERT INTO employeeinfo (EID, NAME, POSITION, SALARY, AGE, ADDRESS, DEPTCODE) " +
                           "VALUES (@Eid, @name, @position, @salary, @age, @address, @deptCode)";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@eid", Eid);
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@position", position);
                    command.Parameters.AddWithValue("@salary", salary);
                    command.Parameters.AddWithValue("@age", age);
                    command.Parameters.AddWithValue("@address", address);
                    command.Parameters.AddWithValue("@deptCode", deptCode);

                    command.ExecuteNonQuery();
                }
            }
        }
        public void AddLoan(int Eid, decimal loanAmount, DateTime Date)
        {
            string query = "INSERT INTO loan (Eid, LoanAmount, Date) " +
                           "VALUES (@Eid, @LoanAmount, @Date)";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Eid", Eid);
                    command.Parameters.AddWithValue("@LoanAmount", loanAmount);
                    command.Parameters.AddWithValue("@Date", Date);

                    command.ExecuteNonQuery();
                }
            }
        }
        public void AddDepartment(string deptCode, string deptDescription)
        {
            string query = "INSERT INTO departmentinfo (DeptCode, DeptDescription) " +
                           "VALUES (@DeptCode, @DeptDescription)";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@DeptCode", deptCode);
                    command.Parameters.AddWithValue("@DeptDescription", deptDescription);

                    command.ExecuteNonQuery();
                }
            }
        }

    }

}

    

