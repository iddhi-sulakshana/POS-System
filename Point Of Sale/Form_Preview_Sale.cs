using System;
using System.Drawing;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using System.IO;
using System.Globalization;

namespace Point_Of_Sale
{
    public partial class Form_Preview_Sale : KryptonForm
    {
        // path for the app data folder located inside mydocument (User/MyDocument/PointOfSale)
        protected string UserPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "PointOfSale");

        // used for change currency for rupees
        readonly CultureInfo Lanka = new CultureInfo("si-LK");

        public Form_Preview_Sale()
        {
            InitializeComponent();
        }

        readonly Class_Sale Sales = new Class_Sale();

        // store sale details
        protected SaleStruct SaleDetails = new SaleStruct();

        // give sale id from the other classes
        public int SalesId;

        // load company and sale details if id is greater than 0
        private void Form_Preview_Sale_Load(object sender, EventArgs e)
        {
            if(SalesId > 0)
            {
                Load_Company_Details();
                Load_Sale_Details();
            }
            else
            {
                Clear_Preview();
                this.Close();
            }
        }

        // load company details using text file in the document folder
        private void Load_Company_Details()
        {
            try
            {
                string[] Lines = File.ReadAllLines(Path.Combine(UserPath, "Company.txt"));
                Lbl_CompanyName.Text = Lines[0];
                Lbl_Email.Text = Lines[2];
                Lbl_Phone.Text = Lines[3];
                Lbl_Address.Text = Lines[1];
                Picture_CompanyLogo.Image = Image.FromFile(Path.Combine(UserPath, "Logo.png"));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Clear_Preview();
                this.Close();
            }
        }

        // load sale details from the database
        private void Load_Sale_Details()
        {
            SaleDetails = Sales.Load_Sale_Details(SalesId);
            Class_Customer Customers = new Class_Customer();
            Lbl_Customer.Text = $"Bill To : {Customers.Get_Customer_Name(SaleDetails.Customer)}";
            Lbl_SaleId.Text = $"Sale : #{SaleDetails.Id}";
            Lbl_Date.Text = $"Date : {SaleDetails.Date.ToString("MM/dd/yyyy hh:mm:ss tt")}";
            Lbl_Total_Value.Text = string.Format(Lanka, "{0:c}", SaleDetails.Total);
            Lbl_Discount_Value.Text = (SaleDetails.Discount / 100).ToString("P02");
            Lbl_Subtotal_Value.Text = string.Format(Lanka, "{0:c}", SaleDetails.Total - (SaleDetails.Total * SaleDetails.Discount / 100));
            foreach(ProductStruct Product in SaleDetails.Products)
            {
                Insert_Preview_Item(Product.Id, Product.Name, Product.Unit, Product.Price);
            }
        }

        /// insert product to the item loader panel by using id, name, 
        /// quantity and price as parameters
        private void Insert_Preview_Item(int Id, string Name, int Quantity, double Price)
        {
            // Create Label Name
            Label LblName = new Label
            {
                Name = $"Preview_Label_Name_{Id}",
                Text = Name,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleLeft,
                ForeColor = Color.White
            };
            // Create Label Quantity 
            Label LblQuantity = new Label
            {
                Name = $"Preview_Label_Quantity_{Id}",
                Text = Quantity.ToString(),
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = Color.White
            };
            // Create Label Price 
            Label LblPrice = new Label
            {
                Name = $"Preview_Label_Price_{Id}",
                Text = Math.Round(Price, 2).ToString("0.00"),
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleRight,
                ForeColor = Color.White
            };
            // Create Label Amount 
            Label LblAmount = new Label
            {
                Name = $"Preview_Label_Amount_{Id}",
                Text = Math.Round(Price * Quantity, 2).ToString("0.00"),
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleRight,
                ForeColor = Color.White
            };

            //Create Table Panel
            TableLayoutPanel Table = new TableLayoutPanel
            {
                Name = $"Table_Product_Details_{Id}",
                Height = 40,
                Dock = DockStyle.Top,
                RowCount = 1,
                ColumnCount = 4
            };
            Table.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            Table.Controls.Add(LblName, 0, 0);
            Table.Controls.Add(LblQuantity, 1, 0);
            Table.Controls.Add(LblPrice, 2, 0);
            Table.Controls.Add(LblAmount, 3, 0);

            // Insert to Form
            Panel_Item_Loader.Controls.Add(Table);
            Panel_Item_Loader.Controls.SetChildIndex(Table, 0);
        }
        
        // clear all the details from the form
        protected void Clear_Preview()
        {
            SalesId = -1;
            Panel_Item_Loader.Controls.Clear();
            Lbl_Customer.Text = "";
            Lbl_SaleId.Text = "";
            Lbl_Date.Text = "";
            Lbl_Total_Value.Text = "";
            Lbl_Discount_Value.Text = "";
            Lbl_Subtotal_Value.Text = "";
        }

        // close the form
        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            Clear_Preview();
            this.Close();
        }

        // generate printable pdf based on the sales details and open
        private void Btn_Print_Click(object sender, EventArgs e)
        {
            Btn_Print.Enabled = false;
            Class_Print_Sale Print = new Class_Print_Sale();
            Print.Print_Sale(SaleDetails);
            Btn_Print.Enabled = true;
            this.Close();
        }
    }
}
