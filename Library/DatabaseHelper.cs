using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Library
{
    public static class DatabaseHelper
    {

        private static readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Mohammadreza\source\repos\Library\Library\Database1.mdf;Integrated Security=True";

        public static SqlConnection GetConnection()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            return connection;
        }

        // Executes a command and returns the number of rows affected.
        public static int ExecuteNonQuery(string query, Dictionary<string, object> parameters)
        {
            using (SqlConnection conn = GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    foreach (var param in parameters)
                    {
                        cmd.Parameters.AddWithValue(param.Key, param.Value);
                    }
                    return cmd.ExecuteNonQuery();
                }
            }
        }




        public static int ExecutenewNonQuery(string query, Dictionary<string, object> parameters)
        {
            using (SqlConnection conn = GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    try
                    {
                        foreach (var param in parameters)
                        {
                            cmd.Parameters.AddWithValue(param.Key, param.Value);
                        }
                        return cmd.ExecuteNonQuery();
                    }
                    catch (SqlException e)
                    {
                        // Log error (to file, event log, etc.) or handle it as needed
                        Console.WriteLine("SQL Error: " + e.Message);
                        return -1;  // Return an indicator of failure
                    }
                }
            }
        }

        // Executes a command that returns the first column of the first row.
        public static object ExecuteScalar(string query, Dictionary<string, object> parameters)
        {
            using (SqlConnection conn = GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    foreach (var param in parameters)
                    {
                        cmd.Parameters.AddWithValue(param.Key, param.Value);
                    }
                    return cmd.ExecuteScalar();
                }
            }
        }


        public static SqlDataReader ExecuteQuery(string query, Dictionary<string, object> parameters)
        {
            SqlConnection conn = GetConnection();  // Utilize the existing GetConnection method that opens the connection.
            SqlCommand cmd = new SqlCommand(query, conn);

            foreach (KeyValuePair<string, object> param in parameters)
            {
                cmd.Parameters.AddWithValue(param.Key, param.Value);
            }

            try
            {
                return cmd.ExecuteReader(CommandBehavior.CloseConnection); // Use CommandBehavior.CloseConnection to ensure the connection is closed when the reader is closed.
            }
            catch (Exception ex)
            {
                Console.WriteLine("Failed to execute query: " + ex.Message);
                conn.Close(); // Make sure to close the connection if an error occurs
                throw; // Optionally re-throw to handle the exception outside of this method
            }
        }


        public static DataTable ExecutenewQuery(string query, Dictionary<string, object> parameters)
        {
            using (var conn = new SqlConnection(connectionString))  // Ensure you have defined your connection string
            {
                conn.Open();
                using (var cmd = new SqlCommand(query, conn))
                {
                    foreach (KeyValuePair<string, object> param in parameters)
                    {
                        if (param.Value != null)
                            cmd.Parameters.AddWithValue(param.Key, param.Value);
                    }

                    using (var adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        return table;
                    }
                }
            }
        }




    }
}
