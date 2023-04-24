using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Cafe
{
    class DataProvider
    {
        private static string connectionString = @"Data Source=LAPTOP-8B1T40PM\SQLEXPRESS;Initial Catalog=Cafe;Integrated Security=True";

        public static DataTable ExecuteQuery(string query)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(DataProvider.connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query,connection);            
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);
                connection.Close();              
            }
            return dt;
        }
        public static int ExecuteNonQuery(string query)
        {
            int rowNumberSuccess = 0;
            using (SqlConnection connection = new SqlConnection(DataProvider.connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                rowNumberSuccess = command.ExecuteNonQuery(); // Method in SqlCommand
                connection.Close();
            }
            return rowNumberSuccess;
        }
        public static object ExecuteScalar(string query)
        {
            object obj = new object();
            using (SqlConnection connection = new SqlConnection(DataProvider.connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                obj = command.ExecuteScalar(); // Method in SqlCommand
                connection.Close();
            }
            return obj;
        }
    }
}
