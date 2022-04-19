using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Point_Of_Sale
{
    internal class Class_Products : Class_Database
    {
        // insert product to the database by using name, price and unit as parameters
        public void Insert_Product(string Name, double Price, int Unit)
        {
            SqlConnection Conn = GetConn();
            string sql = $"INSERT INTO Product(Name, Price, Unit) VALUES('{Name}', '{Price}', {Unit})"; 
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
        
        // update product in the database by using id, name, price and unit as parameters
        public void Update_Product(int Id, string Name, double Price, int Unit)
        {
            SqlConnection Conn = GetConn();
            string sql = $"UPDATE Product SET Name = '{Name}', Price = '{decimal.Parse(Price.ToString())}', Unit = {Unit} WHERE Id = {Id}";
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
        
        // delete product from the database by using id as parameter
        public void Delete_Product(int Id)
        {
            SqlConnection Conn = GetConn();
            string sql = $"DELETE FROM Product WHERE Id = {Id}";
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
        
        /// get all the products from the database and return them as product list and get
        /// nonzero as parameter to check is there need to include nonzero products or not
        public List<ProductStruct> Retrieve_Products(bool NonZero)
        {
            List<ProductStruct> Product_List = new List<ProductStruct>();
            SqlConnection Conn = GetConn();
            string sql;
            if (NonZero)
            {
                sql = $"SELECT * FROM Product WHERE Unit > 0";
            }
            else
            {
                sql = "SELECT * FROM Product";
            }
            SqlCommand Command = new SqlCommand(sql, Conn);
            try
            {
                Conn.Open();
                SqlDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    ProductStruct Item = new ProductStruct
                    {
                        Id = DataReader.GetInt32(0),
                        Name = DataReader.GetString(1),
                        Price = double.Parse(DataReader.GetDecimal(2).ToString()),
                        Unit = DataReader.GetInt32(3)
                    };
                    Product_List.Add(Item);
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
            return Product_List;
        }
        
        // get one product from the database by using id as parameter and return product
        public ProductStruct Get_Product(int Id)
        {
            ProductStruct Item = new ProductStruct();
            SqlConnection Conn = GetConn();
            string sql = $"SELECT * FROM Product WHERE Id = {Id}";
            SqlCommand Command = new SqlCommand(sql, Conn);
            try
            {
                Conn.Open();
                SqlDataReader DataReader = Command.ExecuteReader();
                DataReader.Read();
                Item.Id = DataReader.GetInt32(0);
                Item.Name = DataReader.GetString(1);
                Item.Price = double.Parse(DataReader.GetDecimal(2).ToString());
                Item.Unit = DataReader.GetInt32(3);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conn.Close();
            }
            return Item;
        }
        
        // get quantity of a product by using id as parameter and return quantity as integer
        public int Get_Quantity(int Id)
        {
            SqlConnection Conn = GetConn();
            string sql = $"SELECT Unit FROM Product WHERE Id = {Id}";
            SqlCommand Command = new SqlCommand(sql, Conn);
            int quantity = 0;
            try
            {
                Conn.Open();
                SqlDataReader DataReader = Command.ExecuteReader();
                DataReader.Read();
                quantity = DataReader.GetInt32(0);
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
            return quantity;
        }
        
        // get all the empty products from the database and return them as product list
        public List<ProductStruct> Get_Empty_Products()
        {
            List<ProductStruct> Product_List = new List<ProductStruct>();
            SqlConnection Conn = GetConn();
            string sql = $"SELECT * FROM Product WHERE Unit = 0";
            SqlCommand Command = new SqlCommand(sql, Conn);
            try
            {
                Conn.Open();
                SqlDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    ProductStruct Item = new ProductStruct
                    {
                        Id = DataReader.GetInt32(0),
                        Name = DataReader.GetString(1),
                        Price = double.Parse(DataReader.GetDecimal(2).ToString()),
                        Unit = DataReader.GetInt32(3)
                    };
                    Product_List.Add(Item);
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
            return Product_List;
        }
    }
}
