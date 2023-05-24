using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curd_Operation
{
    internal class Program
    {
        static void Main(string[] args)

        {
            string connectionString = "Data Source=.;Initial Catalog=TestDB;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            // Create operation
            string insertQuery = "INSERT INTO Employee (Name, Age) VALUES ('John', 25)";
            SqlCommand insertCommand = new SqlCommand(insertQuery, connection);
            insertCommand.ExecuteNonQuery();

            // Read operation
            string selectQuery = "SELECT * FROM Employee";
            SqlCommand selectCommand = new SqlCommand(selectQuery, connection);
            SqlDataReader reader = selectCommand.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(reader["Name"] + " " + reader["Age"]);
            }
            reader.Close();

            // Update operation
            string updateQuery = "UPDATE Employee SET Age = 30 WHERE Name = 'John'";
            SqlCommand updateCommand = new SqlCommand(updateQuery, connection);
            updateCommand.ExecuteNonQuery();

            // Delete operation
            string deleteQuery = "DELETE FROM Employee WHERE Name = 'John'";
            SqlCommand deleteCommand = new SqlCommand(deleteQuery, connection);
            deleteCommand.ExecuteNonQuery();

            connection.Close();
        }
    }
}
