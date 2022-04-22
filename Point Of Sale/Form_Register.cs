using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using System.Globalization;

namespace Point_Of_Sale
{
    public partial class Form_Register : KryptonForm
    {
        // used for change currency for rupees
        readonly CultureInfo Lanka = new CultureInfo("si-LK");

        readonly Class_Products ProductClass = new Class_Products();
        readonly Class_Sale Sales = new Class_Sale();

        // Used for Store User Selected Panels
        private Panel SelectedProduct = null;

        // Used for Calculations and other data needs for store in the database
        private SaleStruct SaleDetails = new SaleStruct() 
        { 
            Id = -1, 
            Total = 0, 
            Discount = 0, 
            Payment = null, 
            Customer = -1, 
            Products = new List<ProductStruct>() 
        };

        // store all the non zero product for searching purpose
        private List<ProductStruct> SearchedProducts = null;

        public Form_Register()
        {
            InitializeComponent();
        }

        // Set all the buttons and values to default
        private void Form_Register_Load(object sender, EventArgs e)
        {
            Get_Products();
            Update_Buttons();
            Update_Total();
        }

        // reload searched product list
        private void Btn_Refresh_Products_Click(object sender, EventArgs e)
        {
            Get_Products();
        }

        // Close the Form
        private void Btn_Logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Get all the products from the database and Store inside the searchedproduct list
        private void Get_Products()
        {
            if (SearchedProducts != null)
            {
                SearchedProducts.Clear();
            }
            SearchedProducts = ProductClass.Retrieve_Products(true);
        }

        // change the image of delete button
        private void Btn_Delete_MouseHover(object sender, EventArgs e)
        {
            // change the image of delete button
            Btn_Delete.Image = new Bitmap(Properties.Resources.delete);
        }
        private void Btn_Delete_MouseLeave(object sender, EventArgs e)
        {
            Btn_Delete.Image = new Bitmap(Properties.Resources.deletec);
        }

        // Change quantity of selected product by getting quantity as user input
        private void Btn_Quantity_Click(object sender, EventArgs e)
        {
            int Value = int.Parse(Get_NumberPad(double.Parse(Btn_Quantity.Text.Split(' ')[1])).ToString());
            if (Value != int.Parse(SelectedProduct.Controls[1].Text) && Value > 0)
            {
                int Quantity = ProductClass.Get_Quantity(int.Parse(SelectedProduct.Name.Split('_')[3]));
                if (Quantity >= Value)
                {
                    SelectedProduct.Controls[1].Text = Value.ToString();
                    SelectedProduct.Controls[3].Text = (double.Parse(SelectedProduct.Controls[2].Text) * int.Parse(SelectedProduct.Controls[1].Text)).ToString("0.00");
                    Btn_Quantity.Text = $"Quantity {Value}";
                    Update_Total();
                }
                else
                {
                    MessageBox.Show("Not Enough Quantity");
                }
            }
        }

        // Display Numberpad
        private double Get_NumberPad(double Value)
        {
            var NumPad = new Form_NumberPad();
            NumPad.Txt_Value.Text = Value.ToString();
            NumPad.ShowDialog();
            return NumPad.Form_Return;
        }

        // Change Payment Type to cash or card
        private void Btn_Cash_Click(object sender, EventArgs e)
        {
            SaleDetails.Payment = "Cash";
            Update_Buttons();
        }
        private void Btn_Card_Click(object sender, EventArgs e)
        {
            SaleDetails.Payment = "Card";
            Update_Buttons();
        }

        // Change the customer by selecting customer from select customer form
        private void Btn_Customer_Click(object sender, EventArgs e)
        {
            var CustomerForm = new Form_Select_Customer()
            {
                Selected_Customer = SaleDetails.Customer
            };
            CustomerForm.ShowDialog();
            SaleDetails.Customer = CustomerForm.Selected_Customer;
            CustomerForm.Selected_Customer = 1;
            Update_Buttons();
        }

        // Update Discount amount for sale
        private void Btn_Discount_Click(object sender, EventArgs e)
        {
            double Value = Get_NumberPad(SaleDetails.Discount);
            if (Value >= 0 && Value <= 100)
            {
                SaleDetails.Discount = Value;
                Update_Total();
            }
        }

        // Update Total for sale
        private void Update_Total()
        {
            SaleDetails.Total = 0;
            foreach (Panel Item in Panel_Product_Sale_Main.Controls)
            {
                SaleDetails.Total += double.Parse(Item.Controls[0].Controls[3].Text);
            }
            Txt_Total.Text = string.Format(Lanka, "{0:c}", SaleDetails.Total);
            Txt_Discount.Text = (SaleDetails.Discount / 100).ToString("P02");
            Txt_Subtotal.Text = string.Format(Lanka, "{0:c}", SaleDetails.Total - ((SaleDetails.Total * SaleDetails.Discount) / 100));
            /// To convert back to normal double value
            /// MessageBox.Show(double.Parse(Txt_Total.Text, NumberStyles.Currency, Lanka).ToString("0.00"));
        }

        // --Start-- Sale Section --Start--
        // select clicked product from sale
        private void Sale_Label_Clicked(object sender, EventArgs e)
        {
            /// change the colors of seleceted product and previus one and assign
            /// them to use later
            if (SelectedProduct != null)
            {
                SelectedProduct.BackColor = Color.FromArgb(37,37,37);
            }
            Label Clicked = sender as Label;
            SelectedProduct = Clicked.Parent as Panel;
            SelectedProduct.BackColor = Color.FromArgb(65, 70, 200);
            Update_Buttons();
        }

        // delete selected product from sale
        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            if (SelectedProduct != null)
            {
                Panel_Product_Sale_Main.Controls.Remove(SelectedProduct.Parent);
                SelectedProduct = null;
                Update_Buttons();
                Update_Total();
            }
        }

        // clear all the values from the sale
        private void Clear_Sale()
        {
            if (Panel_Product_Sale_Main.HasChildren)
            {
                Panel_Product_Sale_Main.Controls.Clear();
                SelectedProduct = null;
                SaleDetails = new SaleStruct();
                SaleDetails.Id = -1;
                SaleDetails.Total = 0;
                SaleDetails.Discount = 0;
                SaleDetails.Payment = null;
                SaleDetails.Customer = -1;
                SaleDetails.Products = new List<ProductStruct>();
                Update_Buttons();
                Update_Total();
            }
        }

        // cancel currently unsaved progress or delete unsaved sale from database
        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            if(SaleDetails.Id != -1)
            {
                Sales.Delete_Sale(SaleDetails.Id);
            }
            Clear_Sale();
        }

        // insert product to the panel sale product main by using id, name, quantity and price as parameters
        private void Insert_Sale_Item(int Id, string Name, int Quantity, double Price)
        {
            Panel ChildItem = new Panel
            {
                Name = $"Panel_Sale_Item_{Id}",
                Dock = DockStyle.Top,
                Height = 40
            };

            // Create Label Name
            Label LblName = new Label
            {
                Name = $"Sale_Label_Name_{Id}",
                Text = Name,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleLeft,
                ForeColor = Color.White
            };
            LblName.Click += Sale_Label_Clicked;
            // Create Label Quantity 
            Label LblQuantity = new Label
            {
                Name = $"Sale_Label_Quantity_{Id}",
                Text = Quantity.ToString(),
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = Color.White
            };
            LblQuantity.Click += Sale_Label_Clicked;
            // Create Label Price 
            Label LblPrice = new Label
            {
                Name = $"Sale_Label_Price_{Id}",
                Text = Math.Round(Price, 2).ToString("0.00"),
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleRight,
                ForeColor = Color.White
            };
            LblPrice.Click += Sale_Label_Clicked;
            // Create Label Amount 
            Label LblAmount = new Label
            {
                Name = $"Sale_Label_Amount_{Id}",
                Text = Math.Round(Price * Quantity, 2).ToString("0.00"),
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleRight,
                ForeColor = Color.White
            };
            LblAmount.Click += Sale_Label_Clicked;

            //Create Table Panel
            TableLayoutPanel Table = new TableLayoutPanel
            {
                Name = $"Table_Product_Details_{Id}",
                Dock = DockStyle.Fill,
                RowCount = 1,
                ColumnCount = 4
            };
            Table.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            Table.Controls.Add(LblName, 0, 0);
            Table.Controls.Add(LblQuantity, 1, 0);
            Table.Controls.Add(LblPrice, 2, 0);
            Table.Controls.Add(LblAmount, 3, 0);

            // Insert to Form
            ChildItem.Controls.Add(Table);
            Panel_Product_Sale_Main.Controls.Add(ChildItem);
            Panel_Product_Sale_Main.Controls.SetChildIndex(ChildItem, 0);
            Update_Buttons();
            Update_Total();
        }
        
        // check sale is valid to save or payment
        private bool Is_Valid_Sale()
        {
            if (Panel_Product_Sale_Main.HasChildren)
            {
                if (SaleDetails.Customer != -1)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Please Select Customer");
                }
            }
            else
            {
                MessageBox.Show("No items in the sale");
            }
            return false;
        }

        // save current sale details to the database
        private void Save_Sale()
        {
            // clear if there is already products
            SaleDetails.Products.Clear();

            // add products to the saledetails product list
            foreach (Panel Item in Panel_Product_Sale_Main.Controls)
            {
                ProductStruct Product = new ProductStruct()
                {
                    Id = int.Parse(Item.Controls[0].Name.Split('_')[3]),
                    Unit = int.Parse(Item.Controls[0].Controls[1].Text)
                };
                SaleDetails.Products.Add(Product);
            }

            if(SaleDetails.Payment == null)
            {
                SaleDetails.Payment = "Not Paid";
            }
            SaleDetails.Total = double.Parse(Txt_Total.Text, NumberStyles.Currency, Lanka);
            
            //check if sale is new or existing sale
            if(SaleDetails.Id == -1)
            {
                SaleDetails.Id = Sales.Save_New_Sale(SaleDetails);
            }
            else
            {
                Sales.Update_Existing_Sale(SaleDetails);
            }
        }

        // Save sale as unpaid
        private void Btn_SaveSale_Click(object sender, EventArgs e)
        {
            if (Is_Valid_Sale())
            {
                SaleDetails.Payment = "Not Paid";
                Save_Sale();
                Clear_Sale();
            }
        }

        // save sale as paid
        private void Btn_Payment_Click(object sender, EventArgs e)
        {
            /// Save Sale into the database || Already saved then update
            /// and display print ready recipt
            if (Is_Valid_Sale())
            {
                if (SaleDetails.Payment != null)
                {
                    Save_Sale();
                    Sales.Update_Stock(SaleDetails);
                    Get_Products();
                    Form_Preview_Sale Preview = new Form_Preview_Sale();
                    Preview.SalesId = SaleDetails.Id;
                    Clear_Sale();
                    Preview.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Please Select Payment Type");
                }
            }
        }
        // --end-- Sale Section --end--

        // --start-- Search Section --start--
        // Search Panel Show and Hide
        private void Search_Panel_Show()
        {
            Panel_Product_Search_Main.Visible = true;
            Panel_Product_Search_Main.Location = new Point(261, 44);
            Panel_Product_Search_Main.Controls.Clear();
        }
        private void Search_Panel_Hide()
        {
            Panel_Product_Search_Main.Visible = false;
            Panel_Product_Search_Main.Location = new Point(261, -400);
            Panel_Product_Search_Main.Controls.Clear();
        }

        // search textbox validations and panel show/hide based on textbox focus
        private void Txt_Search_Product_Name_Enter(object sender, EventArgs e)
        {
            Update_Product_Search();
        }
        private void Txt_Search_Product_Name_Changed(object sender, EventArgs e)
        {
            Update_Product_Search();
        }
        private void Txt_Search_Product_Name_Leave(object sender, EventArgs e)
        {
            Search_Panel_Hide();
        }

        // insert items to the panel search based on searched text
        private void Update_Product_Search()
        {
            int added = 0;
            Search_Panel_Show();

            /// check if products in searched product list matched searched text
            /// if matched then added to the panel
            if (SearchedProducts.Count > 0)
            {
                foreach (ProductStruct Product in SearchedProducts)
                {
                    if (Product.Name.Contains(Txt_Search_Product_Name.Text))
                    {
                        Insert_Search_Item(Product.Id, Product.Name, Product.Unit, Product.Price);
                        added++;
                    }
                }
            }

            // if nothing added to the search panel show No result label 
            if (added == 0)
            {
                Label Result = new Label();
                Result.Text = "No Result";
                Result.Font = new Font("Arial", 25);
                Result.ForeColor = Color.White;
                Result.Dock = DockStyle.Fill;
                Panel_Product_Search_Main.Controls.Add(Result);
            }
        }

        // add selected product to the sale product main
        public void Search_Label_Clicked(object sender, EventArgs e)
        {
            Label Clicked = sender as Label;
            bool found = false;
            /// check if product is already exist in the sale product main then
            /// instead of adding as new change quantity of the existing product
            foreach (Panel panel in Panel_Product_Sale_Main.Controls)
            {
                if (Clicked.Name.Split('_')[3] == panel.Name.Split('_')[3])
                {
                    // check if quantity is enough
                    int Quantity = ProductClass.Get_Quantity(int.Parse(Clicked.Name.Split('_')[3]));
                    if (Quantity >= int.Parse(panel.Controls[0].Controls[1].Text) + 1)
                    {
                        panel.Controls[0].Controls[1].Text = (int.Parse(panel.Controls[0].Controls[1].Text) + 1).ToString();
                        panel.Controls[0].Controls[3].Text = (double.Parse(panel.Controls[0].Controls[2].Text) * int.Parse(panel.Controls[0].Controls[1].Text)).ToString("0.00");
                        Update_Total();
                    }
                    else
                    {
                        MessageBox.Show("Not Enough Quantity");
                    }
                    found = true;
                }
            }
            if (!found)
            {
                int Quantity = ProductClass.Get_Quantity(int.Parse(Clicked.Name.Split('_')[3]));
                if (Quantity > 0)
                {
                    ProductStruct Product = ProductClass.Get_Product(int.Parse(Clicked.Name.Split('_')[3]));
                    Insert_Sale_Item(Product.Id, Product.Name, 1, Product.Price);
                }
                else
                {
                    MessageBox.Show("Empty Stock");
                }
            }
            this.ActiveControl = null;
            //Btn_Payment.Focus();
            Search_Panel_Hide();
        }
        
        // Insert Item to the Search Panel by using id, name, quantity and price as parameters
        private void Insert_Search_Item(int Number, string Name, int Quantity, double Price)
        {
            Panel ChildSearch = new Panel
            {
                Name = $"Panel_Search_{Number}",
                Dock = DockStyle.Top,
                Height = 50
            };
            Font font = new Font("Arial", 18);
            // Create Label Name
            Label LblName = new Label
            {
                Name = $"Search_Label_Name_{Number}",
                Font = font,
                Text = Name,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleLeft,
                ForeColor = Color.White
            };
            LblName.Click += Search_Label_Clicked;
            // Create Label Quantity
            Label LblQuantity = new Label
            {
                Name = $"Search_Label_Quantity_{Number}",
                Font = font,
                Text = $"{Quantity}",
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = Color.White
            };
            LblQuantity.Click += Search_Label_Clicked;
            // Create Label Price 
            Label LblPrice = new Label
            {
                Name = $"Search_Label_Price_{Number}",
                Font = font,
                Text = string.Format(Lanka, "{0:c}", Price),
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleRight,
                ForeColor = Color.White
            };
            LblPrice.Click += Search_Label_Clicked;

            //Create Table Panel
            TableLayoutPanel Table = new TableLayoutPanel
            {
                Name = $"Table_Search_Details_{Number}",
                Dock = DockStyle.Fill,
                RowCount = 1,
                ColumnCount = 3
            };
            Table.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            Table.Controls.Add(LblName, 0, 0);
            Table.Controls.Add(LblQuantity, 1, 0);
            Table.Controls.Add(LblPrice, 2, 0);

            // Insert to Main Panel
            ChildSearch.Controls.Add(Table);
            Panel_Product_Search_Main.Controls.Add(ChildSearch);
            Panel_Product_Search_Main.Controls.SetChildIndex(ChildSearch, 0);
        }
        // --end-- Search Section --end--

        // --start-- History Section --start--
        // stores previously clicked panel for sale
        private Panel Previous_Clicked_Sale = null;

        // History Panel Show and Hide
        private void History_Panel_Show()
        {
            Fill_Sales_History_Panel();
            Panel_Sales_History_Parent.Location = new Point(900, 0);
            Panel_Sales_History_Parent.Visible = true;
        }
        private void History_Panel_Hide()
        {
            Panel_Sales_History_Parent.Location = new Point(1275, 0);
            Panel_Sales_History_Parent.Visible = false;
            Panel_Sales_History.Controls.Clear();
        }
        private void Btn_Sales_History_Click(object sender, EventArgs e)
        {
            History_Panel_Show();
        }
        private void Btn_Sale_Close_Click(object sender, EventArgs e)
        {
            History_Panel_Hide();
        }
        
        // change clicked status
        public void History_Label_Clicked(object sender, EventArgs e)
        {
            if (Previous_Clicked_Sale != null)
            {
                Previous_Clicked_Sale.BackColor = Color.FromArgb(37, 37, 37);
            }
            // insert all the data in to the product
            Label Clicked = sender as Label;
            Clicked.Parent.BackColor = Color.FromArgb(57, 57, 57);
            Previous_Clicked_Sale = Clicked.Parent as Panel;
        }

        // load history data to the sale details from databaes
        public void History_Label_DoubleClicked(object sender, EventArgs e)
        {
            Label Clicked = sender as Label;
            /// check if sale is not paid them load to the sale details
            /// otherwise generate printable recipt
            if(Clicked.Parent.Controls[1].Text == "Not Paid")
            {
                Clear_Sale();
                SaleDetails = Sales.Load_Sale_Details(int.Parse(Clicked.Name.Split('_')[3]));
                foreach(ProductStruct Item in SaleDetails.Products)
                {
                    Insert_Sale_Item(Item.Id, Item.Name, Item.Unit, Item.Price);
                }
                // check if quantity is enough
                bool deleted = false, changed = false;
                foreach (Panel panel in Panel_Product_Sale_Main.Controls)
                {
                    int Quantity = ProductClass.Get_Quantity(int.Parse(panel.Name.Split('_')[3]));
                    if (Quantity == 0)
                    {
                        Panel_Product_Sale_Main.Controls.Remove(panel);
                        deleted = true;
                    }
                    else if (Quantity < int.Parse(panel.Controls[0].Controls[1].Text))
                    {
                        panel.Controls[0].Controls[1].Text = Quantity.ToString();
                        panel.Controls[0].Controls[3].Text = (double.Parse(panel.Controls[0].Controls[2].Text) * int.Parse(panel.Controls[0].Controls[1].Text)).ToString("0.00");
                        changed = true;
                    }
                }
                if (deleted || changed)
                {
                    if (deleted)
                    {
                        MessageBox.Show("Some Products are empty they will be delete from the sale");
                    }
                    if (changed)
                    {
                        MessageBox.Show("Some Products dont have enough quantity they will adjust for maximum value");
                    }
                }
                Update_Buttons();
                Update_Total();
                History_Panel_Hide();
            }
            else
            {
                Form_Preview_Sale Preview = new Form_Preview_Sale
                {
                    SalesId = int.Parse(Clicked.Name.Split('_')[3])
                };
                Clear_Sale();
                Preview.ShowDialog();
            }
        }
        
        // load history data to the history panel by getting all the sales from database
        public void Fill_Sales_History_Panel()
        {
            List<SaleStruct> SalesList = Sales.Retrieve_Sales();
            if(SalesList.Count > 0)
            {
                foreach (SaleStruct Sale in SalesList)
                {
                    Insert_History_Item(Sale.Id, Sale.Total, Sale.Payment);
                }
            }
            else
            {
                Label Result = new Label
                {
                    Text = "No Result",
                    Font = new Font("Arial", 25),
                    ForeColor = Color.White,
                    Dock = DockStyle.Fill
                };
                Panel_Sales_History.Controls.Add(Result);
            }
        }

        // insert item to the history panel by using id, amount and paid status as parameters
        private void Insert_History_Item(int Number, double Amount, string Paid)
        {
            Panel ChildSale = new Panel
            {
                Name = $"Panel_Sale_{Number}",
                Dock = DockStyle.Top,
                Height = 80
            };

            // Create Label Name
            Label LblName = new Label
            {
                Name = $"Sale_Label_Name_{Number}",
                Text = $"Sale {Number}",
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleLeft,
                ForeColor = Color.White
            };
            LblName.Click += History_Label_Clicked;
            LblName.DoubleClick += History_Label_DoubleClicked;
            // Create Label Name
            Label LblPaid = new Label
            {
                Name = $"Sale_Label_Padid_{Number}",
                Text = $"{Paid}",
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = Color.White
            };
            LblPaid.Click += History_Label_Clicked;
            LblPaid.DoubleClick += History_Label_DoubleClicked;
            // Create Label Amount 
            Label LblAmount = new Label
            {
                Name = $"Sale_Label_Amount_{Number}",
                Text = string.Format(Lanka, "{0:c}", Amount),
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleRight,
                ForeColor = Color.White
            };
            LblAmount.Click += History_Label_Clicked;
            LblAmount.DoubleClick += History_Label_DoubleClicked;

            //Create Table Panel
            TableLayoutPanel Table = new TableLayoutPanel
            {
                Name = $"Table_Sale_Details_{Number}",
                Dock = DockStyle.Fill,
                RowCount = 1,
                ColumnCount = 3
            };
            Table.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            Table.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            Table.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            Table.Controls.Add(LblName, 0, 0);
            Table.Controls.Add(LblPaid, 1, 0);
            Table.Controls.Add(LblAmount, 2, 0);

            // Insert to Main Panel
            ChildSale.Controls.Add(Table);
            Panel_Sales_History.Controls.Add(ChildSale);
            Panel_Sales_History.Controls.SetChildIndex(ChildSale, 0);
        }
        // --end-- History Section --end--
        
        // Update Buttons States
        private void Update_Buttons()
        {
            if (SelectedProduct == null)
            {
                Btn_Delete.Enabled = false;
                Btn_Delete.BackColor = Color.FromArgb(84, 84, 84);
                Btn_Quantity.Enabled = false;
                Btn_Quantity.BackColor = Color.FromArgb(84, 84, 84);
                Btn_Quantity.Text = "Quantity 1";
            }
            else
            {
                Btn_Delete.Enabled = true;
                Btn_Delete.BackColor = Color.FromArgb(255, 51, 51, 51);
                Btn_Quantity.Enabled = true;
                Btn_Quantity.BackColor = Color.FromArgb(255, 51, 51, 51);
                Btn_Quantity.Text = $"Quantity {SelectedProduct.Controls[1].Text}";
            }
            if (Panel_Product_Sale_Main.HasChildren)
            {
                Btn_Payment.Enabled = true;
                Btn_Cancel.Enabled = true;
                Btn_Discount.Enabled = true;
                Btn_SaveSale.Enabled = true;
                Btn_Discount.BackColor = Color.FromArgb(51, 51, 51);
                Btn_Cancel.BackColor = Color.FromArgb(215, 0, 0);
                Btn_Payment.BackColor = Color.FromArgb(0, 160, 0);
                Btn_SaveSale.BackColor = Color.FromArgb(51, 51, 51);
            }
            else
            {
                SaleDetails.Discount = 0;
                Btn_Cancel.Enabled = false;
                Btn_Payment.Enabled = false;
                Btn_Discount.Enabled = false;
                Btn_SaveSale.Enabled = false;
                Btn_Discount.BackColor = Color.FromArgb(84, 84, 84);
                Btn_SaveSale.BackColor = Color.FromArgb(84, 84, 84);
                Btn_Cancel.BackColor = Color.FromArgb(255, 60, 60);
                Btn_Payment.BackColor = Color.FromArgb(60, 255, 60);
            }
            if (SaleDetails.Payment == "Cash")
            {
                Btn_Cash.BackColor = Color.FromArgb(0, 160, 0);
                Btn_Card.BackColor = Color.FromArgb(51, 51, 51);
                Lbl_Payment_Type_Display.Text = "Payment Type : Cash";
            }
            else if(SaleDetails.Payment == "Card")
            {
                Btn_Card.BackColor = Color.FromArgb(0, 160, 0);
                Btn_Cash.BackColor = Color.FromArgb(51, 51, 51);
                Lbl_Payment_Type_Display.Text = "Payment Type : Card";
            }
            else
            {
                Btn_Card.BackColor = Color.FromArgb(51, 51, 51);
                Btn_Cash.BackColor = Color.FromArgb(51, 51, 51);
                Lbl_Payment_Type_Display.Text = "Payment Type : None";
                SaleDetails.Payment = null;
            }
            if(SaleDetails.Customer != -1)
            {
                Class_Customer Customers = new Class_Customer();
                Lbl_Customer_Name_Display.Text = $"Customer : {Customers.Get_Customer_Name(SaleDetails.Customer)}";
            }
            else
            {
                Lbl_Customer_Name_Display.Text = "Customer : None";
            }
        }
        
        // remove active state for all controllers
        private void Form_Register_MouseDown(object sender, MouseEventArgs e)
        {
            this.ActiveControl = null;
        }
    }
}
