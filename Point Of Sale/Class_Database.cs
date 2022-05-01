using System.Data.SqlClient;
using System.IO;
using System;
using System.Windows.Forms;
namespace Point_Of_Sale
{
    internal class Class_Database
    {
        // Create connection by passing conenction string for database file in the same directory
        // to get filled database comment first connection string and uncomment second one
        private readonly SqlConnection Conn = new SqlConnection($"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={Path.Combine(Directory.GetCurrentDirectory(), "DatabasePOSDatabase.mdf")};Integrated Security=True;Connect Timeout=30");
        //private readonly SqlConnection Conn = new SqlConnection($"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={Path.Combine(Directory.GetCurrentDirectory(), "DatabasePOSDatabase-filled.mdf")};Integrated Security=True;Connect Timeout=30");
        //return connection string (Connection Getter)
        public SqlConnection GetConn()
        {
            return Conn;
        }    
        
        // check the connection status by connecting to database and update statment
        public bool TestConnection()
        {
            bool success = false;
            SqlConnection Conn = GetConn();
            string sql = "UPDATE Customer SET Name = 'none' WHERE Id = 1";
            SqlCommand Command = new SqlCommand(sql, Conn);
            try
            {
                Conn.Open();
                Command.ExecuteNonQuery();
                success = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error Connecting to database");
                success = false;
            }
            finally
            {
                Conn.Close();
            }
            return success;
        }
    }
}
