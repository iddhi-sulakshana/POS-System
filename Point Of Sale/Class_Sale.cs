using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Point_Of_Sale
{
    internal class Class_Sale
    {
        readonly Class_Database Database = new Class_Database();
        
        // get all the sales from database and return them as sale list
        public List<SaleStruct> Retrieve_Sales()
        {
            List<SaleStruct> Sales_List = new List<SaleStruct>();
            SqlConnection Conn = Database.GetConn();
            string sql = "SELECT * FROM Sale ORDER BY Id DESC";
            SqlCommand Command = new SqlCommand(sql, Conn);
            try
            {
                Conn.Open();
                SqlDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    SaleStruct Item = new SaleStruct
                    {
                        Id = DataReader.GetInt32(0),
                        Subtotal = double.Parse(DataReader.GetDecimal(1).ToString()),
                        Discount = double.Parse(DataReader.GetDecimal(2).ToString()),
                        Customer = DataReader.GetInt32(3),
                        Payment = DataReader.GetString(4)
                    };
                    Sales_List.Add(Item);
                }
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
            return Sales_List;
        }
        
        // get specified sale from database by using saleid as parameter and return sale
        public SaleStruct Load_Sale_Details(int SaleId)
        {
            SqlConnection Conn = Database.GetConn();
            SaleStruct Sale = new SaleStruct();
            string sql = $"SELECT Sale.Subtotal, Sale.Discount, Sale.CustomerId, Sale.Payment, Product.Id, Product.Name, Product.Price, SaleProduct.Quantity, Sale.DateTime FROM Sale LEFT JOIN SaleProduct ON Sale.Id = SaleProduct.SalesId LEFT JOIN Product ON SaleProduct.ProductId = Product.Id WHERE Sale.Id = {SaleId}";
            SqlCommand Command = new SqlCommand(sql, Conn);
            try
            {
                Conn.Open();
                SqlDataReader DataReader = Command.ExecuteReader();
                Sale.Id = SaleId;
                List<ProductStruct> Products = new List<ProductStruct>();
                bool first = true;
                while (DataReader.Read())
                {
                    if (first)
                    {
                        Sale.Subtotal = double.Parse(DataReader.GetDecimal(0).ToString());
                        Sale.Discount = double.Parse(DataReader.GetDecimal(1).ToString());
                        Sale.Customer = DataReader.GetInt32(2);
                        Sale.Payment = DataReader.GetString(3);
                        Sale.Date = DataReader.GetDateTime(8);
                    }
                    ProductStruct Item = new ProductStruct
                    {
                        Id = DataReader.GetInt32(4),
                        Name = DataReader.GetString(5),
                        Price = double.Parse(DataReader.GetDecimal(6).ToString()),
                        Unit = DataReader.GetInt32(7)
                    };
                    Products.Add(Item);
                }
                DataReader.Close();
                Sale.Products = Products;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conn.Close();
            }
            return Sale;
        }
        
        // save new sale to database by using sale structure as parameter and return inserted id
        public int Save_New_Sale(SaleStruct SaleDetails)
        {
            SqlConnection Conn = Database.GetConn();
            string sql = $"INSERT INTO Sale(Subtotal, Discount, CustomerId, Payment) OUTPUT INSERTED.Id VALUES('{SaleDetails.Subtotal}', '{SaleDetails.Discount}', {SaleDetails.Customer}, '{SaleDetails.Payment}')";
            SqlCommand Command = new SqlCommand(sql, Conn);
            try
            {
                Conn.Open();
                SqlDataReader DataReader = Command.ExecuteReader();
                DataReader.Read();
                SaleDetails.Id = DataReader.GetInt32(0);
                DataReader.Close();
                foreach (ProductStruct Item in SaleDetails.Products)
                {
                    sql = $"INSERT INTO SaleProduct VALUES({SaleDetails.Id}, {Item.Id}, {Item.Unit})";
                    Command = new SqlCommand(sql, Conn);
                    Command.ExecuteNonQuery();
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
            return SaleDetails.Id;
        }
        
        // update existing sale by using sale structure as parameter
        public void Update_Existing_Sale(SaleStruct SaleDetails)
        {
            SqlConnection Conn = Database.GetConn();
            string sql = $"UPDATE Sale SET Subtotal = '{SaleDetails.Subtotal}', Discount = '{SaleDetails.Discount}', CustomerId = {SaleDetails.Customer}, Payment = '{SaleDetails.Payment}' WHERE Id = {SaleDetails.Id}";
            SqlCommand Command = new SqlCommand(sql, Conn);
            try
            {
                Conn.Open();
                Command.ExecuteNonQuery();
                foreach (ProductStruct Item in SaleDetails.Products)
                {
                    /// check if product is already assigned to the current sale then update quantity
                    /// of the product otherwise insert new one
                    sql = $"IF EXISTS(SELECT * FROM SaleProduct WHERE SalesId = {SaleDetails.Id} AND ProductId = {Item.Id}) BEGIN UPDATE SaleProduct SET Quantity = {Item.Unit} WHERE ProductId = {Item.Id} END ELSE BEGIN INSERT INTO SaleProduct VALUES({SaleDetails.Id}, {Item.Id}, {Item.Unit}) END";
                    Command = new SqlCommand(sql, Conn);
                    Command.ExecuteNonQuery();
                }
                sql = $"SELECT ProductId FROM SaleProduct WHERE SalesId = {SaleDetails.Id}";
                Command = new SqlCommand(sql, Conn);
                SqlDataReader DataReader = Command.ExecuteReader();
                sql = "";
                bool deleted;
                /// check database prodcut with recieved product and check database product
                /// is equals to recieved products then no deletion happend otherwise deleted item from
                /// existing sale
                while (DataReader.Read())
                {
                    deleted = true;
                    foreach (ProductStruct Item in SaleDetails.Products)
                    {
                        if (DataReader.GetInt32(0) == Item.Id)
                        {
                            deleted = false;
                            break;
                        }
                    }
                    if (deleted)
                    {
                        sql += $"DELETE FROM SaleProduct WHERE SalesId = {SaleDetails.Id} AND ProductId = {DataReader.GetInt32(0)}; ";
                    }
                }
                DataReader.Close();
                if(sql != "")
                {
                    Command = new SqlCommand(sql, Conn);
                    Command.ExecuteNonQuery();
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
        }
        
        // delete sale from the database by using id as parameter
        public void Delete_Sale(int SaleId)
        {
            SqlConnection Conn = Database.GetConn();
            string sql = $"DELETE FROM SaleProduct WHERE SalesId = {SaleId}; DELETE FROM Sale WHERE Id = {SaleId}";
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
        
        // update stock of the products that has saled by using sale details as parameter
        public void Update_Stock(SaleStruct SaleDetails)
        {
            SqlConnection Conn = Database.GetConn();
            try
            {
                Conn.Open();
                foreach (ProductStruct Product in SaleDetails.Products)
                {
                    string sql = $"SELECT Unit FROM Product WHERE Id = {Product.Id}";
                    SqlCommand Command = new SqlCommand(sql, Conn);
                    SqlDataReader DataReader = Command.ExecuteReader();
                    DataReader.Read();
                    sql = $"UPDATE Product SET Unit = {DataReader.GetInt32(0) - Product.Unit} WHERE Id = {Product.Id}";
                    Command = new SqlCommand(sql, Conn);
                    DataReader.Close();
                    Command.ExecuteNonQuery();
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
        }
        
        // get today sale count from the database and return count as integer
        public int Get_Today_Sale_Count()
        {
            SqlConnection Conn = Database.GetConn();
            string sql = $"SELECT COUNT(*) FROM Sale WHERE CAST(DateTime AS DATE) = CAST(GETDATE() AS DATE) AND NOT(Payment = 'Not Paid')";
            SqlCommand Command = new SqlCommand(sql, Conn);
            int Count = 0;
            try
            {
                Conn.Open();
                SqlDataReader DataReader = Command.ExecuteReader();
                DataReader.Read();
                Count = DataReader.GetInt32(0);
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
            return Count;
        }
        
        // get today sale amount from the database and return amount as the double
        public double Get_Today_Sale_Amount()
        {
            SqlConnection Conn = Database.GetConn();
            string sql = $"SELECT Subtotal FROM Sale WHERE CAST(DateTime AS DATE) = CAST(GETDATE() AS DATE) AND NOT(Payment = 'Not Paid')";
            SqlCommand Command = new SqlCommand(sql, Conn);
            double amount = 0;
            try
            {
                Conn.Open();
                SqlDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    amount += double.Parse(DataReader.GetDecimal(0).ToString());
                }
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
            return amount;
        }
        
        // get specified date sale count by using date as parameter and return sale count as integer
        public int Get_Date_Sale_Count(DateTime Date)
        {
            SqlConnection Conn = Database.GetConn();
            string sql = $"SELECT COUNT(*) FROM Sale WHERE CAST(DateTime AS DATE) = CAST('{Date}' AS DATE) AND NOT(Payment = 'Not Paid')";
            SqlCommand Command = new SqlCommand(sql, Conn);
            int Count = 0;
            try
            {
                Conn.Open();
                SqlDataReader DataReader = Command.ExecuteReader();
                DataReader.Read();
                Count = DataReader.GetInt32(0);
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
            return Count;
        }
        
        // get specified month sale count by using year and month as parameter and return sale count as integer
        public int Get_Monthly_Sale_Count(int Year, int Month)
        {
            SqlConnection Conn = Database.GetConn();
            string sql = $"SELECT COUNT(*) FROM Sale WHERE MONTH(DateTime) = {Month} AND YEAR(DateTime) = {Year} AND NOT(Payment = 'Not Paid')";
            SqlCommand Command = new SqlCommand(sql, Conn);
            int Count = 0;
            try
            {
                Conn.Open();
                SqlDataReader DataReader = Command.ExecuteReader();
                DataReader.Read();
                Count = DataReader.GetInt32(0);
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
            return Count;
        }
        
        // get sale details in specified time period by using from date and to date and return sale list
        public List<SaleStruct> Get_Timed_Sales(DateTime From, DateTime To)
        {
            List<SaleStruct> Sales_List = new List<SaleStruct>();
            SqlConnection Conn = Database.GetConn();
            string sql = $"SELECT * FROM Sale WHERE CAST(DateTime AS DATE) BETWEEN CAST('{From}' AS DATE) AND CAST('{To}' AS DATE)";
            SqlCommand Command = new SqlCommand(sql, Conn);
            try
            {
                Conn.Open();
                SqlDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    SaleStruct Item = new SaleStruct
                    {
                        Id = DataReader.GetInt32(0),
                        Subtotal = double.Parse(DataReader.GetDecimal(1).ToString()),
                        Discount = double.Parse(DataReader.GetDecimal(2).ToString()),
                        Customer = DataReader.GetInt32(3),
                        Payment = DataReader.GetString(4),
                        Date = DataReader.GetDateTime(5)
                    };
                    Sales_List.Add(Item);
                }
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
            return Sales_List;
        }
    }
}
