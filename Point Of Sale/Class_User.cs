using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Point_Of_Sale
{
    internal class Class_User
    {
        readonly Class_Database Database = new Class_Database();
        
        // check if username is already exist as name recived as parameter and retunr boolean value
        public bool Is_UserName_Exist(string UserName)
        {
            SqlConnection Conn = Database.GetConn();
            bool exist = false;
            try
            {
                // select count username and password equals to parameters
                string sql = $"SELECT COUNT(*) FROM UserDetails WHERE UserName = '{UserName}'";
                SqlCommand Command = new SqlCommand(sql, Conn);
                Conn.Open();
                if((int)Command.ExecuteScalar() > 0)
                {
                    exist = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conn.Close();
            }
            return exist;
        }
        
        // validate userdetails by using username and password as parameter and return boolean value
        public bool Is_Valid_Credintials(string UserName, string Password)
        {
            SqlConnection Conn = Database.GetConn();
            bool valid = false;
            try
            {
                // select count username and password equals to parameters
                string sql = $"SELECT COUNT(*) FROM UserDetails WHERE UserName = '{UserName}' AND UserPwd = '{Password}'";
                SqlCommand Command = new SqlCommand(sql, Conn);
                Conn.Open();
                if((int)Command.ExecuteScalar() > 0)
                {
                    valid = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conn.Close();
            }
            return valid;
        }
        
        // insert user into the database by using username and password as parameters
        public void Insert_User(string UserName, string Password)
        {
            SqlConnection Conn = Database.GetConn();
            string sql = $"INSERT INTO UserDetails(UserName, UserPwd) VALUES('{UserName}', '{Password}')";
            SqlCommand Command = new SqlCommand(sql, Conn);
            try
            {
                Conn.Open();
                Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conn.Close();
            }
        }
        
        // update user in the database by usign id username and password as parameters
        public void Update_User(int Id, string UserName, string Password)
        {
            SqlConnection Conn = Database.GetConn();
            string sql = $"UPDATE UserDetails SET UserName = '{UserName}', UserPwd = '{Password}' WHERE ID = {Id}";
            SqlCommand Command = new SqlCommand(sql, Conn);
            try
            {
                Conn.Open();
                Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conn.Close();
            }
        }
        
        // get all the users except admin from the database and return user list
        public List<UserStruct> Retrieve_Users()
        {
            List<UserStruct> Users_List = new List<UserStruct>();
            SqlConnection Conn = Database.GetConn();
            string sql = "SELECT * FROM UserDetails WHERE NOT(UserName = 'admin')";
            SqlCommand Command = new SqlCommand(sql, Conn);
            try
            {
                Conn.Open();
                SqlDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    UserStruct Item = new UserStruct
                    {
                        Id = DataReader.GetInt32(0),
                        Name = DataReader.GetString(1),
                        Password = DataReader.GetString(2)
                    };
                    Users_List.Add(Item);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conn.Close();
            }
            return Users_List;
        }
        
        // delete user from the database by using id as parameter
        public void Delete_User(int Id)
        {
            SqlConnection Conn = Database.GetConn();
            string sql = $"DELETE FROM UserDetails WHERE ID = {Id}";
            SqlCommand Command = new SqlCommand(sql, Conn);
            try
            {
                Conn.Open();
                Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conn.Close();
            }
        }
        
        // update admin password in the database by using password as parameter
        public void Update_Admin(string Password)
        {
            SqlConnection Conn = Database.GetConn();
            string sql = $"UPDATE UserDetails SET UserPwd = '{Password}' WHERE UserName = 'admin'";
            SqlCommand Command = new SqlCommand(sql, Conn);
            try
            {
                Conn.Open();
                Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conn.Close();
            }
        }
        
        // get admin password from the database and return password as string
        public string Retrieve_Admin_Password()
        {
            string Password=null;
            SqlConnection Conn = Database.GetConn();
            string sql = "SELECT UserPwd FROM UserDetails WHERE UserName = 'admin'";
            SqlCommand Command = new SqlCommand(sql, Conn);
            try
            {
                Conn.Open();
                SqlDataReader DataReader = Command.ExecuteReader();
                DataReader.Read();
                Password = DataReader.GetString(0);
                DataReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conn.Close();
            }
            return Password;
        }
    }
}
