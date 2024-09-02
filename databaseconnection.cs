using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
namespace summer2
{
    internal class databaseconnection
    {
        static string connectionString = "server=localhost;user id=root;port=3306;database=coffee_shop";

        public static DataTable GetData(string sql, Dictionary<string, object> parameters = null)
        {
            DataSet ds = new DataSet();
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(sql, connection))
                    {
                        // Add parameters if provided
                        if (parameters != null)
                        {
                            foreach (var param in parameters)
                            {
                                command.Parameters.AddWithValue(param.Key, param.Value);
                            }
                        }

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            adapter.Fill(ds, "table");
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception("An error occurred while retrieving data", ex);
            }
            return ds.Tables["table"];
        }

        // Method to execute a non-query command (INSERT, UPDATE, DELETE) with parameters
        public static void ExecuteQuery(string sql, Dictionary<string, object> parameters = null)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(sql, connection))
                    {
                        // Add parameters if provided
                        if (parameters != null)
                        {
                            foreach (var param in parameters)
                            {
                                command.Parameters.AddWithValue(param.Key, param.Value);
                            }
                        }

                        // Execute the non-query command
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (MySqlException ex)
            {
                string paramDetails = parameters != null
                    ? string.Join(", ", parameters.Select(p => $"{p.Key}={p.Value}"))
                    : "No parameters";
                throw new Exception($"An error occurred while executing the SQL command: {ex.Message}\nSQL: {sql}\nParameters: {paramDetails}", ex);
            }
        }
    }
}
