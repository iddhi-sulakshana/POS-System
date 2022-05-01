using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Point_Of_Sale
{
    internal class Class_Customer : Class_Database
    {
        // Insert customer to the database by using name, address, phone as parameters
        public void Insert_Customer(string Name, string Address, string Phone)
        {
            SqlConnection Conn = GetConn();
            string sql = $"INSERT INTO Customer(Name, Address, Phone) VALUES('{Name}', '{Address}', '{Phone}')";
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

        // Update customer in the database by using id, name, adderss and phone as parmater
        public void Update_Customer(int Id, string Name, string Address, string Phone)
        {
            SqlConnection Conn = GetConn();
            string sql = $"UPDATE Customer SET Name = '{Name}', Address = '{Address}', Phone = '{Phone}' WHERE Id = {Id}";
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

        // get all the customer data from the database and assign it to the customertruct list
        public List<CustomerStruct> Retrieve_Customers()
        {
            List<CustomerStruct> Customer_List = new List<CustomerStruct>();
            SqlConnection Conn = GetConn();
            string sql = "SELECT * FROM Customer";
            SqlCommand Command = new SqlCommand(sql, Conn);
            try
            {
                Conn.Open();
                SqlDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    CustomerStruct Item = new CustomerStruct
                    {
                        Id = DataReader.GetInt32(0),
                        Name = DataReader.GetString(1),
                        Address = DataReader.GetString(2),
                        Phone = DataReader.GetString(3)
                    };
                    Customer_List.Add(Item);
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
            return Customer_List;
        }

        // delete customer from database by using id as paramter
        public void Delete_Customer(int Id)
        {
            SqlConnection Conn = GetConn();
            string sql = $"DELETE FROM Customer WHERE Id = {Id}";
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

        // get customer name from database by using id as parameter
        public string Get_Customer_Name(int CustomerId)
        {
            SqlConnection Conn = GetConn();
            string sql = $"SELECT Name FROM Customer WHERE Id = {CustomerId}";
            SqlCommand Command = new SqlCommand(sql, Conn);
            string Name = "";
            try
            {
                Conn.Open();
                SqlDataReader DataReader = Command.ExecuteReader();
                DataReader.Read();
                Name = DataReader.GetString(0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conn.Close();
            }
            return Name;
        }
    }
}
