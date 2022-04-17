using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Point_Of_Sale
{
    public partial class Form_Admin_Customers : Form
    {
        public Form_Admin_Customers()
        {
            InitializeComponent();
        }

        readonly Class_Customer Customer = new Class_Customer();

        // used for get user input
        readonly Form_User_Input GetInput = new Form_User_Input();

        // store previously clicked panel and selected id
        Panel PreviouslyClicked = new Panel();
        int Selected = -1;

        // load customer details to the form
        private void Form_Admin_Customers_Load(object sender, EventArgs e)
        {
            Update_Customer_List();
        }

        // insert customer to the panel customer loader by using id,name,address and phone
        private void Insert_Customer(int Number, string Name, string Address, string Phone)
        {
            Panel ChildCustomer = new Panel
            {
                Name = $"Panel_Customer_{Number}",
                Dock = DockStyle.Top,
                Height = 50
            };
            Font font = new Font("Arial", 18);
            // Create Label Name
            Label LblName = new Label
            {
                Name = $"Customer_Label_Name_{Number}",
                Font = font,
                Text = Name,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleLeft,
                ForeColor = Color.White
            };
            LblName.Click += Customer_Label_Clicked;
            // Create Label Address
            Label LblAddress = new Label
            {
                Name = $"Customer_Label_Address_{Number}",
                Font = font,
                Text = Address,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleLeft,
                ForeColor = Color.White
            };
            LblAddress.Click += Customer_Label_Clicked;
            // Create Label Phone
            Label LblPhone = new Label
            {
                Name = $"Customer_Label_Phone_{Number}",
                Font = font,
                Text = Phone,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = Color.White
            };
            LblPhone.Click += Customer_Label_Clicked;

            //Create Table Panel
            TableLayoutPanel Table = new TableLayoutPanel
            {
                Name = $"Table_Customer_Details_{Number}",
                Dock = DockStyle.Fill,
                RowCount = 1,
                ColumnCount = 3,
            };
            Table.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            Table.Controls.Add(LblName, 0, 0);
            Table.Controls.Add(LblAddress, 1, 0);
            Table.Controls.Add(LblPhone, 2, 0);

            // Insert to Main Panel
            ChildCustomer.Controls.Add(Table);
            Panel_Customer_Loader.Controls.Add(ChildCustomer);
            Panel_Customer_Loader.Controls.SetChildIndex(ChildCustomer, 0);
        }

        // change clicked status to the current clicked label
        private void Customer_Label_Clicked(object sender, EventArgs e)
        {
            Label clicked = sender as Label;
            if(clicked.Parent.Name.Split('_')[3] != "1")
            {
                PreviouslyClicked.BackColor = Color.FromArgb(51, 51, 51);
                Label Clicked = sender as Label;
                Selected = int.Parse(Clicked.Name.Split('_')[3]);
                Clicked.Parent.BackColor = Color.FromArgb(65, 70, 200);
                PreviouslyClicked = Clicked.Parent as Panel;
                Update_Buttons();
            }
        }

        // update buttons based on the clicked status
        private void Update_Buttons()
        {
            if (Selected != -1)
            {
                Btn_Customer_Edit.Enabled = true;
                Btn_Customer_Delete.Enabled = true;
                Btn_Customer_Edit.BackColor = Color.FromArgb(31, 31, 31);
                Btn_Customer_Delete.BackColor = Color.FromArgb(215, 0, 0);
            }
            else
            {
                Btn_Customer_Edit.Enabled = false;
                Btn_Customer_Delete.Enabled = false;
                Btn_Customer_Edit.BackColor = Color.FromArgb(51, 51, 51);
                Btn_Customer_Delete.BackColor = Color.FromArgb(255, 60, 60);
            }
        }

        // delete selected customer from the database and reload the customer list
        private void Btn_Customer_Delete_Click(object sender, EventArgs e)
        {
            DialogResult UserAccept = MessageBox.Show("Are you sure you want to delete this", "Deleting Item", MessageBoxButtons.YesNo);
            if(UserAccept == DialogResult.Yes)
            {
                //Delete Customer
                Customer.Delete_Customer(Selected);
                Update_Customer_List();
            }
        }

        /// edit selected customer details in the database by using user inserted
        /// value for name, address and phone and reload the customer list
        private void Btn_Customer_Edit_Click(object sender, EventArgs e)
        {
            string Name;
            string Address;
            string Phone;
            // Get Name
            GetInput.Set_Values("Enter Name For Customer ", PreviouslyClicked.Controls[0].Text);
            GetInput.ShowDialog();
            if (!GetInput.Cancel)
            {
                Name = GetInput.Get_Value();
                // Get Address
                GetInput.Set_Values("Enter Address For " + Name, PreviouslyClicked.Controls[1].Text);
                GetInput.ShowDialog();
                if (!GetInput.Cancel)
                {
                    Address = GetInput.Get_Value();
                    // Get Phone
                    GetInput.Set_Values("Enter Phone Number For " + Name + " (10 Digits)", PreviouslyClicked.Controls[2].Text);
                    GetInput.ShowDialog();
                    if (!GetInput.Cancel)
                    {
                        Phone = GetInput.Get_Value();
                        if (Name != "" && Address != "" && Phone != "" && Phone.Length == 10)
                        {
                            Customer.Update_Customer(Selected, Name, Address, Phone);
                            Update_Customer_List();
                        }
                        else
                        {
                            MessageBox.Show("Name, Address and Phone Required. Phone Should be 10 Digits", "Incorredct Field Data");
                        }
                    }
                }
            }
        }

        /// insert new customer to the database by using user inserted value for
        /// name, address and phone and reload the customer list
        private void Btn_Customer_Add_Click(object sender, EventArgs e)
        {
            string Name;
            string Address;
            string Phone;
            // Get UserName
            GetInput.Set_Values("Enter Name For Customer", "");
            GetInput.ShowDialog();
            if (!GetInput.Cancel)
            {
                Name = GetInput.Get_Value();
                GetInput.Set_Values("Enter Address For " + Name, "");
                GetInput.ShowDialog();
                if (!GetInput.Cancel)
                {
                    Address = GetInput.Get_Value();
                    GetInput.Set_Values("Enter Phone Number For " + Name + " (10 Digits)", "");
                    GetInput.ShowDialog();
                    if (!GetInput.Cancel)
                    {
                        Phone = GetInput.Get_Value();
                        if (Name != "" && Address != "" && Phone != "" && Phone.Length == 10)
                        {
                            Customer.Insert_Customer(Name, Address, Phone);
                            Update_Customer_List();
                        }
                        else
                        {
                            MessageBox.Show("Name, Address and Phone Required. Phone Should be 10 Digits", "Incorredct Field Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
        }

        /// update customer list in the customer loader panel by getting customer
        /// details from the database
        private void Update_Customer_List()
        {
            PreviouslyClicked = new Panel();
            Selected = -1;
            Panel_Customer_Loader.Controls.Clear();
            List<CustomerStruct> Customers = Customer.Retrieve_Customers();
            foreach (CustomerStruct Customer in Customers)
            {
                Insert_Customer(Customer.Id, Customer.Name, Customer.Address, Customer.Phone);
            }
            Update_Buttons();
        }
    }
}
