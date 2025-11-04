using System;
using System.Data.SqlClient;

namespace AssignmentIOOP
{
    public static class DatabaseHelper
    {
    
        public static string ConnectionString = @"Data Source=DESKTOP-EQ55Q8H;Initial Catalog=SedapMakanManagement;Integrated Security=True";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionString);
        }

        public static object ExecuteScalar(string query)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand(query, conn))
                {
                    return cmd.ExecuteScalar();
                }
            }
        }

        public static int ExecuteNonQuery(string query)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand(query, conn))
                {
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        public static SqlDataReader ExecuteReader(string query)
        {
            var conn = GetConnection();
            conn.Open();
            var cmd = new SqlCommand(query, conn);
            return cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
        }
    }
}
