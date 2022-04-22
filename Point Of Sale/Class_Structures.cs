using System;
using System.Collections.Generic;

namespace Point_Of_Sale
{
    // users details are included id, name, password
    public struct UserStruct
    {
        public int Id;
        public string Name;
        public string Password;
    }
    
    // customer details are included id, name, address, phone
    public struct CustomerStruct
    {
        public int Id;
        public string Name;
        public string Address;
        public string Phone;
    }
    
    // product details are included id, name, price, unit
    public struct ProductStruct
    {
        public int Id;
        public string Name;
        public double Price;
        public int Unit;
    }
    
    /// sale details are included id, subtotal, discount. customer, payment,
    /// date and list of products structure
    public struct SaleStruct
    {
        public int Id;
        public double Total;
        public double Discount;
        public int Customer;
        public string Payment;
        public DateTime Date;
        public List<ProductStruct> Products;
    }
}
