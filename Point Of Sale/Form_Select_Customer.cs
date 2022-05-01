using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Point_Of_Sale
{
    public partial class Form_Select_Customer : KryptonForm
    {
        public Form_Select_Customer()
        {
            InitializeComponent();
        }

        // load customer details to the form
        private void Form_Select_Customer_Load(object sender, EventArgs e)
        {
            Class_Customer Customers = new Class_Customer();
            List<CustomerStruct> CustomerList = Customers.Retrieve_Customers();
            foreach (CustomerStruct Customer in CustomerList)
            {
                Insert_Customer(Customer.Id, Customer.Name);
            }
        }

        // used to change selected customer from other classes
        public int Selected_Customer = 1;

        // stores previous clicked customer panel
        private Panel PreviousClicked = new Panel();

        // insert customer to the customer main panel
        private void Insert_Customer(int Number, string Name)
        {
            Panel ChildCustomer = new Panel
            {
                Name = $"Panel_Customer_{Number}",
                BackColor = Color.FromArgb(41, 41, 41),
                Dock = DockStyle.Top,
                Height = 50
            };

            // Create Label Name
            Label LblName = new Label
            {
                Name = $"Customer_Label_Name_{Number}",
                Font = new Font("Arial", 18),
                Text = Name,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleLeft,
                ForeColor = Color.White
            };
            LblName.Click += Customer_Label_Clicked;
            LblName.DoubleClick += Cutomer_Label_DoubleClicked;
            //Create Table Panel
            TableLayoutPanel Table = new TableLayoutPanel
            {
                Name = $"Table_Customer_Details_{Number}",
                Dock = DockStyle.Fill,
                RowCount = 1,
                ColumnCount = 1
            };
            Table.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            Table.Controls.Add(LblName, 0, 0);

            // Insert to Main Panel
            ChildCustomer.Controls.Add(Table);
            Panel_Customer_Main.Controls.Add(ChildCustomer);
            Panel_Customer_Main.Controls.SetChildIndex(ChildCustomer, 0);
        }

        // change clicked status for the customer
        private void Customer_Label_Clicked(object sender, EventArgs e)
        {
            PreviousClicked.BackColor = Color.FromArgb(41, 41, 41);
            Label Clicked = sender as Label;
            Panel ClickedPanel = Clicked.Parent as Panel;
            ClickedPanel.BackColor = Color.FromArgb(57, 57, 57);
            PreviousClicked = ClickedPanel;
        }

        // change customer to selected customer and close the form
        private void Cutomer_Label_DoubleClicked(object sender, EventArgs e)
        {
            Label Clicked = sender as Label;
            Selected_Customer = int.Parse(Clicked.Name.Split('_')[3]);
            this.Close();
        }

        // close the form
        private void Lbl_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
