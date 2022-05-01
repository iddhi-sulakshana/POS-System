using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace Point_Of_Sale
{
    public partial class Form_Admin_Products : Form
    {
        public Form_Admin_Products()
        {
            InitializeComponent();
        }

        // used for change currency for rupees
        private readonly CultureInfo Lanka = new CultureInfo("si-LK");
        private readonly Class_Products Product = new Class_Products();

        // store previously clicked panel and clicked id
        private Panel PreviouslyClicked = new Panel();
        private int Selected = -1;

        // load products to the panel product loader
        private void Form_Admin_Products_Load(object sender, EventArgs e)
        {
            Update_Product_List();
        }

        // insert product to the panel product loader by using id, name, price and quantity as parameters
        private void Insert_Product(int Number, string Name, double Price, int Quantity)
        {
            Panel ChildProduct = new Panel
            {
                Name = $"Panel_Products_{Number}",
                Dock = DockStyle.Top,
                Height = 50
            };
            Font font = new Font("Arial", 18);
            // Create Label Name
            Label LblName = new Label
            {
                Name = $"Product_Label_Name_{Number}",
                Font = font,
                Text = Name,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleLeft,
                ForeColor = Color.White
            };
            LblName.Click += Product_Label_Clicked;
            // Create Label Address
            Label LblQuantity = new Label
            {
                Name = $"Product_Label_Quantity_{Number}",
                Font = font,
                Text = Quantity.ToString(),
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = Color.White
            };
            LblQuantity.Click += Product_Label_Clicked;
            // Create Label Phone
            Label LblPrice = new Label
            {
                Name = $"Product_Label_Price_{Number}",
                Font = font,
                Text = string.Format(Lanka, "{0:c}", Price)
            };
            ;
            LblPrice.Dock = DockStyle.Fill;
            LblPrice.TextAlign = ContentAlignment.MiddleCenter;
            LblPrice.ForeColor = Color.White;
            LblPrice.Click += Product_Label_Clicked;

            //Create Table Panel
            TableLayoutPanel Table = new TableLayoutPanel
            {
                Name = $"Table_Product_Details_{Number}",
                Dock = DockStyle.Fill,
                RowCount = 1,
                ColumnCount = 3
            };
            Table.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            Table.Controls.Add(LblName, 0, 0);
            Table.Controls.Add(LblQuantity, 1, 0);
            Table.Controls.Add(LblPrice, 2, 0);

            // Insert to Main Panel
            ChildProduct.Controls.Add(Table);
            Panel_Products_Loader.Controls.Add(ChildProduct);
            Panel_Products_Loader.Controls.SetChildIndex(ChildProduct, 0);
        }

        // change clicked status to the current clicked label
        private void Product_Label_Clicked(object sender, EventArgs e)
        {
            PreviouslyClicked.BackColor = Color.FromArgb(51, 51, 51);
            Label Clicked = sender as Label;
            Selected = int.Parse(Clicked.Name.Split('_')[3]);
            Clicked.Parent.BackColor = Color.FromArgb(65, 70, 200);
            PreviouslyClicked = Clicked.Parent as Panel;
            Update_Buttons();
        }

        // update buttons based on the clicked status
        private void Update_Buttons()
        {
            if (Selected != -1)
            {
                Btn_Products_Edit.Enabled = true;
                Btn_Products_Delete.Enabled = true;
                Btn_Products_Edit.BackColor = Color.FromArgb(31, 31, 31);
                Btn_Products_Delete.BackColor = Color.FromArgb(215, 0, 0);
            }
            else
            {
                Btn_Products_Edit.Enabled = false;
                Btn_Products_Delete.Enabled = false;
                Btn_Products_Edit.BackColor = Color.FromArgb(51, 51, 51);
                Btn_Products_Delete.BackColor = Color.FromArgb(255, 60, 60);
            }
        }

        // delete selected product from the database and reload the product list
        private void Btn_Product_Delete_Click(object sender, EventArgs e)
        {
            DialogResult UserAccept = MessageBox.Show("Are you sure you want to delete this", "Deleting Item", MessageBoxButtons.YesNo);
            if (UserAccept == DialogResult.Yes)
            {
                Product.Delete_Product(Selected);
                Update_Product_List();
            }
        }

        /// edit selected product details in the database by using user inserted 
        /// values for name, price and quantity
        private void Btn_Product_Edit_Click(object sender, EventArgs e)
        {
            // used for get user inputs
            Form_User_Input GetInput = new Form_User_Input();

            GetInput.Set_Values("Edit Name", "Edit Price", "Edit Quantity", PreviouslyClicked.Controls[0].Text, double.Parse(PreviouslyClicked.Controls[2].Text, NumberStyles.Currency, Lanka).ToString("0.00"), PreviouslyClicked.Controls[1].Text);
            GetInput.ShowDialog();
            if (!GetInput.Cancel)
            {
                try
                {
                    Product.Update_Product(Selected, GetInput.Get_Value1(), double.Parse(GetInput.Get_Value2()), int.Parse(GetInput.Get_Value3()));
                    Update_Product_List();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        /// insert product to the database by using user inserted values for
        /// name, price and quantity
        private void Btn_Products_Add_Click(object sender, EventArgs e)
        {
            // used for get user inputs
            Form_User_Input GetInput = new Form_User_Input();

            GetInput.Set_Values("Name", "Price", "Quantity");
            GetInput.ShowDialog();
            if (!GetInput.Cancel)
            {
                try
                {
                    Product.Insert_Product(GetInput.Get_Value1(), double.Parse(GetInput.Get_Value2()), int.Parse(GetInput.Get_Value3()));
                    Update_Product_List();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        /// update product list in the product loader panel by getting product
        /// list from the database
        private void Update_Product_List()
        {
            PreviouslyClicked = new Panel();
            Selected = -1;
            Panel_Products_Loader.Controls.Clear();
            List<ProductStruct> Products = Product.Retrieve_Products(false);
            foreach (ProductStruct Product in Products)
            {
                Insert_Product(Product.Id, Product.Name, Product.Price, Product.Unit);
            }
            Update_Buttons();
        }
    }
}
