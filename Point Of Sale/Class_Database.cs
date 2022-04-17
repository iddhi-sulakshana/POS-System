using System.Data.SqlClient;
using System.IO;

namespace Point_Of_Sale
{
    internal class Class_Database
    {
        // Create connection by passing conenction string for database file in the same directory
        private readonly SqlConnection Conn = new SqlConnection($"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={Path.Combine(Directory.GetCurrentDirectory(), "DatabasePOSDatabase.mdf")};Integrated Security=True;Connect Timeout=30");
        
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
            catch
            {
                return false;
            }
            finally
            {
                Conn.Close();
            }
            return success;
        }
    }
}
