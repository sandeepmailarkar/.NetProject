using System;
using System.Collections.Generic;
using System.Linq;
using System.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SQL_Configuration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            {
                string connectionString = "Data Source=serverName;Initial Catalog=databaseName;User ID=userName;Password=password";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Execute SQL command to retrieve data
                    string selectQuery = "SELECT * FROM Customers";
                    SqlCommand selectCommand = new SqlCommand(selectQuery, connection);

                    SqlDataReader reader = selectCommand.ExecuteReader();

                    while (reader.Read())
                    {
                        string customerName = reader["Name"].ToString();
                        string address = reader["Address"].ToString();

                        Console.WriteLine("Customer: " + customerName);
                        Console.WriteLine("Address: " + address);
                        Console.WriteLine();
                    }

                    reader.Close();

                    // Execute SQL command to insert data
                    string insertQuery = "INSERT INTO Customers (Name, Address) VALUES ('John Doe', '123 Main St')";
                    SqlCommand insertCommand = new SqlCommand(insertQuery, connection);

                    int rowsAffected = insertCommand.ExecuteNonQuery();

                    Console.WriteLine("Rows Affected: " + rowsAffected);

                    connection.Close();
                }

                // Wait for user input before closing the console window
                Console.ReadLine();
            }
        }
    }
}
