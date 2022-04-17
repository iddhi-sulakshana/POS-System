namespace Point_Of_Sale
{
    partial class Form_Register
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Register));
            this.Panel_Top_SearchBar = new System.Windows.Forms.Panel();
            this.Btn_Refresh_Products = new System.Windows.Forms.Button();
            this.Txt_Search_Product_Name = new System.Windows.Forms.TextBox();
            this.Lbl_Search = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Btn_Discount = new System.Windows.Forms.Button();
            this.Btn_Customer = new System.Windows.Forms.Button();
            this.Btn_Sales = new System.Windows.Forms.Button();
            this.Btn_Cash = new System.Windows.Forms.Button();
            this.Btn_Card = new System.Windows.Forms.Button();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.Btn_Payment = new System.Windows.Forms.Button();
            this.Btn_SaveSale = new System.Windows.Forms.Button();
            this.Lbl_Total = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Txt_Total = new System.Windows.Forms.TextBox();
            this.Txt_Discount = new System.Windows.Forms.TextBox();
            this.Txt_Subtotal = new System.Windows.Forms.TextBox();
            this.Btn_Logout = new System.Windows.Forms.Button();
            this.Btn_Quantity = new System.Windows.Forms.Button();
            this.Btn_Delete = new System.Windows.Forms.Button();
            this.Lbl_PHeader_Name = new System.Windows.Forms.Label();
            this.Lbl_PHeader_Quantity = new System.Windows.Forms.Label();
            this.Lbl_PHeader_Price = new System.Windows.Forms.Label();
            this.Lbl_PHeader_Amount = new System.Windows.Forms.Label();
            this.Table_Products = new System.Windows.Forms.TableLayoutPanel();
            this.Panel_Product_Sale_Main = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.Lbl_Customer_Name_Display = new System.Windows.Forms.Label();
            this.Lbl_Payment_Type_Display = new System.Windows.Forms.Label();
            this.Panel_Product_Search_Main = new System.Windows.Forms.Panel();
            this.Panel_Sales_History_Parent = new System.Windows.Forms.Panel();
            this.Panel_Sales_History = new System.Windows.Forms.Panel();
            this.Panel_Sale_History_Close = new System.Windows.Forms.Panel();
            this.Btn_Sale_Close = new System.Windows.Forms.Button();
            this.Panel_Top_SearchBar.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.Table_Products.SuspendLayout();
            this.Panel_Sales_History_Parent.SuspendLayout();
            this.Panel_Sale_History_Close.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_Top_SearchBar
            // 
            this.Panel_Top_SearchBar.Controls.Add(this.Btn_Refresh_Products);
            this.Panel_Top_SearchBar.Controls.Add(this.Txt_Search_Product_Name);
            this.Panel_Top_SearchBar.Controls.Add(this.Lbl_Search);
            this.Panel_Top_SearchBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Top_SearchBar.Location = new System.Drawing.Point(10, 5);
            this.Panel_Top_SearchBar.Name = "Panel_Top_SearchBar";
            this.Panel_Top_SearchBar.Size = new System.Drawing.Size(1244, 39);
            this.Panel_Top_SearchBar.TabIndex = 1;
            // 
            // Btn_Refresh_Products
            // 
            this.Btn_Refresh_Products.BackgroundImage = global::Point_Of_Sale.Properties.Resources.refresh;
            this.Btn_Refresh_Products.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Refresh_Products.Dock = System.Windows.Forms.DockStyle.Right;
            this.Btn_Refresh_Products.FlatAppearance.BorderSize = 0;
            this.Btn_Refresh_Products.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Refresh_Products.Location = new System.Drawing.Point(1195, 0);
            this.Btn_Refresh_Products.Name = "Btn_Refresh_Products";
            this.Btn_Refresh_Products.Size = new System.Drawing.Size(49, 39);
            this.Btn_Refresh_Products.TabIndex = 13;
            this.Btn_Refresh_Products.UseVisualStyleBackColor = true;
            this.Btn_Refresh_Products.Click += new System.EventHandler(this.Btn_Refresh_Products_Click);
            // 
            // Txt_Search_Product_Name
            // 
            this.Txt_Search_Product_Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Txt_Search_Product_Name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_Search_Product_Name.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.Txt_Search_Product_Name.ForeColor = System.Drawing.Color.White;
            this.Txt_Search_Product_Name.Location = new System.Drawing.Point(251, 5);
            this.Txt_Search_Product_Name.Name = "Txt_Search_Product_Name";
            this.Txt_Search_Product_Name.Size = new System.Drawing.Size(938, 28);
            this.Txt_Search_Product_Name.TabIndex = 12;
            this.Txt_Search_Product_Name.TabStop = false;
            this.Txt_Search_Product_Name.TextChanged += new System.EventHandler(this.Txt_Search_Product_Name_Changed);
            this.Txt_Search_Product_Name.Enter += new System.EventHandler(this.Txt_Search_Product_Name_Enter);
            this.Txt_Search_Product_Name.Leave += new System.EventHandler(this.Txt_Search_Product_Name_Leave);
            // 
            // Lbl_Search
            // 
            this.Lbl_Search.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.Lbl_Search.Image = global::Point_Of_Sale.Properties.Resources.search;
            this.Lbl_Search.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Lbl_Search.Location = new System.Drawing.Point(5, 9);
            this.Lbl_Search.Name = "Lbl_Search";
            this.Lbl_Search.Size = new System.Drawing.Size(226, 20);
            this.Lbl_Search.TabIndex = 0;
            this.Lbl_Search.Text = "Search product by name";
            this.Lbl_Search.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.Btn_Discount);
            this.flowLayoutPanel1.Controls.Add(this.Btn_Customer);
            this.flowLayoutPanel1.Controls.Add(this.Btn_Sales);
            this.flowLayoutPanel1.Controls.Add(this.Btn_Cash);
            this.flowLayoutPanel1.Controls.Add(this.Btn_Card);
            this.flowLayoutPanel1.Controls.Add(this.Btn_Cancel);
            this.flowLayoutPanel1.Controls.Add(this.Btn_Payment);
            this.flowLayoutPanel1.Controls.Add(this.Btn_SaveSale);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(873, 303);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(378, 362);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // Btn_Discount
            // 
            this.Btn_Discount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.Btn_Discount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btn_Discount.Enabled = false;
            this.Btn_Discount.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.Btn_Discount.FlatAppearance.BorderSize = 2;
            this.Btn_Discount.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(70)))), ((int)(((byte)(200)))));
            this.Btn_Discount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(65)))), ((int)(((byte)(70)))), ((int)(((byte)(200)))));
            this.Btn_Discount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Discount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Discount.Image = global::Point_Of_Sale.Properties.Resources.discount;
            this.Btn_Discount.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Discount.Location = new System.Drawing.Point(3, 3);
            this.Btn_Discount.Name = "Btn_Discount";
            this.Btn_Discount.Padding = new System.Windows.Forms.Padding(5);
            this.Btn_Discount.Size = new System.Drawing.Size(120, 115);
            this.Btn_Discount.TabIndex = 4;
            this.Btn_Discount.Text = "Discount";
            this.Btn_Discount.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Discount.UseVisualStyleBackColor = false;
            this.Btn_Discount.Click += new System.EventHandler(this.Btn_Discount_Click);
            // 
            // Btn_Customer
            // 
            this.Btn_Customer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Btn_Customer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btn_Customer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.Btn_Customer.FlatAppearance.BorderSize = 2;
            this.Btn_Customer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(70)))), ((int)(((byte)(200)))));
            this.Btn_Customer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(65)))), ((int)(((byte)(70)))), ((int)(((byte)(200)))));
            this.Btn_Customer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Customer.Image = global::Point_Of_Sale.Properties.Resources.customer;
            this.Btn_Customer.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Customer.Location = new System.Drawing.Point(129, 3);
            this.Btn_Customer.Name = "Btn_Customer";
            this.Btn_Customer.Padding = new System.Windows.Forms.Padding(5);
            this.Btn_Customer.Size = new System.Drawing.Size(120, 115);
            this.Btn_Customer.TabIndex = 5;
            this.Btn_Customer.Text = "Customer";
            this.Btn_Customer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Customer.UseVisualStyleBackColor = false;
            this.Btn_Customer.Click += new System.EventHandler(this.Btn_Customer_Click);
            // 
            // Btn_Sales
            // 
            this.Btn_Sales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Btn_Sales.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btn_Sales.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.Btn_Sales.FlatAppearance.BorderSize = 2;
            this.Btn_Sales.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(70)))), ((int)(((byte)(200)))));
            this.Btn_Sales.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(65)))), ((int)(((byte)(70)))), ((int)(((byte)(200)))));
            this.Btn_Sales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Sales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Sales.Image = global::Point_Of_Sale.Properties.Resources.history;
            this.Btn_Sales.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Sales.Location = new System.Drawing.Point(255, 3);
            this.Btn_Sales.Name = "Btn_Sales";
            this.Btn_Sales.Padding = new System.Windows.Forms.Padding(5);
            this.Btn_Sales.Size = new System.Drawing.Size(120, 115);
            this.Btn_Sales.TabIndex = 6;
            this.Btn_Sales.Text = "Sales";
            this.Btn_Sales.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Sales.UseVisualStyleBackColor = false;
            this.Btn_Sales.Click += new System.EventHandler(this.Btn_Sales_History_Click);
            // 
            // Btn_Cash
            // 
            this.Btn_Cash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Btn_Cash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btn_Cash.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.Btn_Cash.FlatAppearance.BorderSize = 2;
            this.Btn_Cash.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(0)))));
            this.Btn_Cash.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(0)))));
            this.Btn_Cash.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(0)))));
            this.Btn_Cash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Cash.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cash.Image = global::Point_Of_Sale.Properties.Resources.cash;
            this.Btn_Cash.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Cash.Location = new System.Drawing.Point(3, 124);
            this.Btn_Cash.Name = "Btn_Cash";
            this.Btn_Cash.Padding = new System.Windows.Forms.Padding(5);
            this.Btn_Cash.Size = new System.Drawing.Size(120, 115);
            this.Btn_Cash.TabIndex = 7;
            this.Btn_Cash.Text = "Cash";
            this.Btn_Cash.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Cash.UseVisualStyleBackColor = false;
            this.Btn_Cash.Click += new System.EventHandler(this.Btn_Cash_Click);
            // 
            // Btn_Card
            // 
            this.Btn_Card.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Btn_Card.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btn_Card.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.Btn_Card.FlatAppearance.BorderSize = 2;
            this.Btn_Card.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(0)))));
            this.Btn_Card.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(0)))));
            this.Btn_Card.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(0)))));
            this.Btn_Card.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Card.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Card.Image = global::Point_Of_Sale.Properties.Resources.card;
            this.Btn_Card.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Card.Location = new System.Drawing.Point(129, 124);
            this.Btn_Card.Name = "Btn_Card";
            this.Btn_Card.Padding = new System.Windows.Forms.Padding(5);
            this.Btn_Card.Size = new System.Drawing.Size(120, 115);
            this.Btn_Card.TabIndex = 8;
            this.Btn_Card.Text = "Card";
            this.Btn_Card.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Card.UseVisualStyleBackColor = false;
            this.Btn_Card.Click += new System.EventHandler(this.Btn_Card_Click);
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Btn_Cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btn_Cancel.Enabled = false;
            this.Btn_Cancel.FlatAppearance.BorderSize = 0;
            this.Btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cancel.Image = global::Point_Of_Sale.Properties.Resources.close;
            this.Btn_Cancel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Cancel.Location = new System.Drawing.Point(255, 124);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Padding = new System.Windows.Forms.Padding(5);
            this.Btn_Cancel.Size = new System.Drawing.Size(120, 115);
            this.Btn_Cancel.TabIndex = 9;
            this.Btn_Cancel.Text = "Cancel";
            this.Btn_Cancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Cancel.UseVisualStyleBackColor = false;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // Btn_Payment
            // 
            this.Btn_Payment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(160)))), ((int)(((byte)(50)))));
            this.Btn_Payment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btn_Payment.Enabled = false;
            this.Btn_Payment.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.Btn_Payment.FlatAppearance.BorderSize = 2;
            this.Btn_Payment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Payment.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Payment.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Payment.Location = new System.Drawing.Point(3, 245);
            this.Btn_Payment.Name = "Btn_Payment";
            this.Btn_Payment.Padding = new System.Windows.Forms.Padding(5);
            this.Btn_Payment.Size = new System.Drawing.Size(246, 115);
            this.Btn_Payment.TabIndex = 10;
            this.Btn_Payment.Text = "Payment";
            this.Btn_Payment.UseVisualStyleBackColor = false;
            this.Btn_Payment.Click += new System.EventHandler(this.Btn_Payment_Click);
            // 
            // Btn_SaveSale
            // 
            this.Btn_SaveSale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.Btn_SaveSale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btn_SaveSale.Enabled = false;
            this.Btn_SaveSale.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.Btn_SaveSale.FlatAppearance.BorderSize = 2;
            this.Btn_SaveSale.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(70)))), ((int)(((byte)(200)))));
            this.Btn_SaveSale.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(65)))), ((int)(((byte)(70)))), ((int)(((byte)(200)))));
            this.Btn_SaveSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_SaveSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_SaveSale.Image = global::Point_Of_Sale.Properties.Resources.add;
            this.Btn_SaveSale.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_SaveSale.Location = new System.Drawing.Point(255, 245);
            this.Btn_SaveSale.Name = "Btn_SaveSale";
            this.Btn_SaveSale.Padding = new System.Windows.Forms.Padding(5);
            this.Btn_SaveSale.Size = new System.Drawing.Size(120, 115);
            this.Btn_SaveSale.TabIndex = 11;
            this.Btn_SaveSale.Text = "Save Sale";
            this.Btn_SaveSale.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_SaveSale.UseVisualStyleBackColor = false;
            this.Btn_SaveSale.Click += new System.EventHandler(this.Btn_SaveSale_Click);
            // 
            // Lbl_Total
            // 
            this.Lbl_Total.AutoSize = true;
            this.Lbl_Total.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20F);
            this.Lbl_Total.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lbl_Total.Location = new System.Drawing.Point(398, 548);
            this.Lbl_Total.Name = "Lbl_Total";
            this.Lbl_Total.Size = new System.Drawing.Size(79, 35);
            this.Lbl_Total.TabIndex = 12;
            this.Lbl_Total.Text = "Total";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20F);
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Location = new System.Drawing.Point(398, 630);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 35);
            this.label6.TabIndex = 8;
            this.label6.Text = "Subtotal";
            // 
            // Txt_Total
            // 
            this.Txt_Total.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Txt_Total.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Total.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Total.ForeColor = System.Drawing.Color.White;
            this.Txt_Total.Location = new System.Drawing.Point(590, 548);
            this.Txt_Total.Name = "Txt_Total";
            this.Txt_Total.ReadOnly = true;
            this.Txt_Total.Size = new System.Drawing.Size(259, 35);
            this.Txt_Total.TabIndex = 15;
            this.Txt_Total.TabStop = false;
            this.Txt_Total.Text = "00.00";
            this.Txt_Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Txt_Discount
            // 
            this.Txt_Discount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Txt_Discount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Discount.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Discount.ForeColor = System.Drawing.Color.White;
            this.Txt_Discount.Location = new System.Drawing.Point(590, 585);
            this.Txt_Discount.Name = "Txt_Discount";
            this.Txt_Discount.ReadOnly = true;
            this.Txt_Discount.Size = new System.Drawing.Size(259, 35);
            this.Txt_Discount.TabIndex = 14;
            this.Txt_Discount.TabStop = false;
            this.Txt_Discount.Text = "00.00";
            this.Txt_Discount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Txt_Subtotal
            // 
            this.Txt_Subtotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Txt_Subtotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Subtotal.Font = new System.Drawing.Font("Microsoft Tai Le", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Subtotal.ForeColor = System.Drawing.Color.White;
            this.Txt_Subtotal.Location = new System.Drawing.Point(590, 629);
            this.Txt_Subtotal.Name = "Txt_Subtotal";
            this.Txt_Subtotal.ReadOnly = true;
            this.Txt_Subtotal.Size = new System.Drawing.Size(259, 43);
            this.Txt_Subtotal.TabIndex = 13;
            this.Txt_Subtotal.TabStop = false;
            this.Txt_Subtotal.Text = "00.00";
            this.Txt_Subtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Btn_Logout
            // 
            this.Btn_Logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Btn_Logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btn_Logout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.Btn_Logout.FlatAppearance.BorderSize = 2;
            this.Btn_Logout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(70)))), ((int)(((byte)(200)))));
            this.Btn_Logout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(65)))), ((int)(((byte)(70)))), ((int)(((byte)(200)))));
            this.Btn_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Logout.Image = global::Point_Of_Sale.Properties.Resources.logout;
            this.Btn_Logout.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Logout.Location = new System.Drawing.Point(1133, 51);
            this.Btn_Logout.Name = "Btn_Logout";
            this.Btn_Logout.Padding = new System.Windows.Forms.Padding(10);
            this.Btn_Logout.Size = new System.Drawing.Size(120, 160);
            this.Btn_Logout.TabIndex = 3;
            this.Btn_Logout.Text = "Logout";
            this.Btn_Logout.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Logout.UseVisualStyleBackColor = false;
            this.Btn_Logout.Click += new System.EventHandler(this.Btn_Logout_Click);
            // 
            // Btn_Quantity
            // 
            this.Btn_Quantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.Btn_Quantity.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btn_Quantity.Enabled = false;
            this.Btn_Quantity.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.Btn_Quantity.FlatAppearance.BorderSize = 2;
            this.Btn_Quantity.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(70)))), ((int)(((byte)(200)))));
            this.Btn_Quantity.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(65)))), ((int)(((byte)(70)))), ((int)(((byte)(200)))));
            this.Btn_Quantity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Quantity.Image = global::Point_Of_Sale.Properties.Resources.basket;
            this.Btn_Quantity.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Quantity.Location = new System.Drawing.Point(1004, 51);
            this.Btn_Quantity.Name = "Btn_Quantity";
            this.Btn_Quantity.Padding = new System.Windows.Forms.Padding(10);
            this.Btn_Quantity.Size = new System.Drawing.Size(120, 160);
            this.Btn_Quantity.TabIndex = 2;
            this.Btn_Quantity.Text = "Quantity 1";
            this.Btn_Quantity.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Quantity.UseVisualStyleBackColor = false;
            this.Btn_Quantity.Click += new System.EventHandler(this.Btn_Quantity_Click);
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.Btn_Delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btn_Delete.Enabled = false;
            this.Btn_Delete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.Btn_Delete.FlatAppearance.BorderSize = 2;
            this.Btn_Delete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(70)))), ((int)(((byte)(200)))));
            this.Btn_Delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(65)))), ((int)(((byte)(70)))), ((int)(((byte)(200)))));
            this.Btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Delete.Image = global::Point_Of_Sale.Properties.Resources.deletec;
            this.Btn_Delete.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Delete.Location = new System.Drawing.Point(875, 51);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Padding = new System.Windows.Forms.Padding(10);
            this.Btn_Delete.Size = new System.Drawing.Size(120, 160);
            this.Btn_Delete.TabIndex = 1;
            this.Btn_Delete.Text = "Delete";
            this.Btn_Delete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Delete.UseVisualStyleBackColor = false;
            this.Btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            this.Btn_Delete.MouseLeave += new System.EventHandler(this.Btn_Delete_MouseLeave);
            this.Btn_Delete.MouseHover += new System.EventHandler(this.Btn_Delete_MouseHover);
            // 
            // Lbl_PHeader_Name
            // 
            this.Lbl_PHeader_Name.AutoSize = true;
            this.Lbl_PHeader_Name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lbl_PHeader_Name.Font = new System.Drawing.Font("Malgun Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_PHeader_Name.Location = new System.Drawing.Point(4, 4);
            this.Lbl_PHeader_Name.Margin = new System.Windows.Forms.Padding(3);
            this.Lbl_PHeader_Name.Name = "Lbl_PHeader_Name";
            this.Lbl_PHeader_Name.Size = new System.Drawing.Size(416, 36);
            this.Lbl_PHeader_Name.TabIndex = 0;
            this.Lbl_PHeader_Name.Text = "Product Name";
            this.Lbl_PHeader_Name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Lbl_PHeader_Quantity
            // 
            this.Lbl_PHeader_Quantity.AutoSize = true;
            this.Lbl_PHeader_Quantity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lbl_PHeader_Quantity.Font = new System.Drawing.Font("Malgun Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_PHeader_Quantity.Location = new System.Drawing.Point(427, 4);
            this.Lbl_PHeader_Quantity.Margin = new System.Windows.Forms.Padding(3);
            this.Lbl_PHeader_Quantity.Name = "Lbl_PHeader_Quantity";
            this.Lbl_PHeader_Quantity.Size = new System.Drawing.Size(120, 36);
            this.Lbl_PHeader_Quantity.TabIndex = 1;
            this.Lbl_PHeader_Quantity.Text = "Quantity";
            this.Lbl_PHeader_Quantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lbl_PHeader_Price
            // 
            this.Lbl_PHeader_Price.AutoSize = true;
            this.Lbl_PHeader_Price.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lbl_PHeader_Price.Font = new System.Drawing.Font("Malgun Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_PHeader_Price.Location = new System.Drawing.Point(554, 4);
            this.Lbl_PHeader_Price.Margin = new System.Windows.Forms.Padding(3);
            this.Lbl_PHeader_Price.Name = "Lbl_PHeader_Price";
            this.Lbl_PHeader_Price.Size = new System.Drawing.Size(120, 36);
            this.Lbl_PHeader_Price.TabIndex = 2;
            this.Lbl_PHeader_Price.Text = "Price (Rs.)";
            this.Lbl_PHeader_Price.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lbl_PHeader_Amount
            // 
            this.Lbl_PHeader_Amount.AutoSize = true;
            this.Lbl_PHeader_Amount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lbl_PHeader_Amount.Font = new System.Drawing.Font("Malgun Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_PHeader_Amount.Location = new System.Drawing.Point(681, 4);
            this.Lbl_PHeader_Amount.Margin = new System.Windows.Forms.Padding(3);
            this.Lbl_PHeader_Amount.Name = "Lbl_PHeader_Amount";
            this.Lbl_PHeader_Amount.Size = new System.Drawing.Size(164, 36);
            this.Lbl_PHeader_Amount.TabIndex = 3;
            this.Lbl_PHeader_Amount.Text = "Amount (Rs.)";
            this.Lbl_PHeader_Amount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Table_Products
            // 
            this.Table_Products.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.Table_Products.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.Table_Products.ColumnCount = 4;
            this.Table_Products.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Table_Products.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.Table_Products.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.Table_Products.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Table_Products.Controls.Add(this.Panel_Product_Sale_Main, 0, 1);
            this.Table_Products.Controls.Add(this.Lbl_PHeader_Amount, 3, 0);
            this.Table_Products.Controls.Add(this.Lbl_PHeader_Price, 2, 0);
            this.Table_Products.Controls.Add(this.Lbl_PHeader_Quantity, 1, 0);
            this.Table_Products.Controls.Add(this.Lbl_PHeader_Name, 0, 0);
            this.Table_Products.Location = new System.Drawing.Point(10, 51);
            this.Table_Products.Name = "Table_Products";
            this.Table_Products.RowCount = 2;
            this.Table_Products.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.747515F));
            this.Table_Products.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.25249F));
            this.Table_Products.Size = new System.Drawing.Size(849, 491);
            this.Table_Products.TabIndex = 2;
            // 
            // Panel_Product_Sale_Main
            // 
            this.Table_Products.SetColumnSpan(this.Panel_Product_Sale_Main, 4);
            this.Panel_Product_Sale_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Product_Sale_Main.Location = new System.Drawing.Point(4, 47);
            this.Panel_Product_Sale_Main.Name = "Panel_Product_Sale_Main";
            this.Panel_Product_Sale_Main.Size = new System.Drawing.Size(841, 440);
            this.Panel_Product_Sale_Main.TabIndex = 4;
            this.Panel_Product_Sale_Main.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_Register_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(401, 613);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(457, 15);
            this.label1.TabIndex = 502;
            this.label1.Text = "................................................................................." +
    ".....................................................................";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20F);
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(398, 585);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 35);
            this.label5.TabIndex = 503;
            this.label5.Text = "Discount";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(401, 665);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(457, 15);
            this.label7.TabIndex = 504;
            this.label7.Text = "................................................................................." +
    ".....................................................................";
            // 
            // kryptonPalette1
            // 
            this.kryptonPalette1.BasePaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black;
            this.kryptonPalette1.ButtonSpecs.FormClose.Image = global::Point_Of_Sale.Properties.Resources.headerclose;
            this.kryptonPalette1.ButtonSpecs.FormMax.Image = global::Point_Of_Sale.Properties.Resources.headermax;
            this.kryptonPalette1.ButtonSpecs.FormMin.Image = global::Point_Of_Sale.Properties.Resources.headermin;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Rounding = 10;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, -1, -1, -1);
            // 
            // Lbl_Customer_Name_Display
            // 
            this.Lbl_Customer_Name_Display.AutoSize = true;
            this.Lbl_Customer_Name_Display.Font = new System.Drawing.Font("Iskoola Pota", 15F);
            this.Lbl_Customer_Name_Display.Location = new System.Drawing.Point(872, 229);
            this.Lbl_Customer_Name_Display.Name = "Lbl_Customer_Name_Display";
            this.Lbl_Customer_Name_Display.Size = new System.Drawing.Size(143, 23);
            this.Lbl_Customer_Name_Display.TabIndex = 505;
            this.Lbl_Customer_Name_Display.Text = "Customer : None";
            // 
            // Lbl_Payment_Type_Display
            // 
            this.Lbl_Payment_Type_Display.AutoSize = true;
            this.Lbl_Payment_Type_Display.Font = new System.Drawing.Font("Iskoola Pota", 15F);
            this.Lbl_Payment_Type_Display.Location = new System.Drawing.Point(872, 261);
            this.Lbl_Payment_Type_Display.Name = "Lbl_Payment_Type_Display";
            this.Lbl_Payment_Type_Display.Size = new System.Drawing.Size(179, 23);
            this.Lbl_Payment_Type_Display.TabIndex = 505;
            this.Lbl_Payment_Type_Display.Text = "Payment Type : None";
            // 
            // Panel_Product_Search_Main
            // 
            this.Panel_Product_Search_Main.AutoScroll = true;
            this.Panel_Product_Search_Main.AutoSize = true;
            this.Panel_Product_Search_Main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Panel_Product_Search_Main.Location = new System.Drawing.Point(261, -400);
            this.Panel_Product_Search_Main.MaximumSize = new System.Drawing.Size(990, 484);
            this.Panel_Product_Search_Main.MinimumSize = new System.Drawing.Size(990, 110);
            this.Panel_Product_Search_Main.Name = "Panel_Product_Search_Main";
            this.Panel_Product_Search_Main.Padding = new System.Windows.Forms.Padding(5);
            this.Panel_Product_Search_Main.Size = new System.Drawing.Size(990, 110);
            this.Panel_Product_Search_Main.TabIndex = 506;
            this.Panel_Product_Search_Main.Visible = false;
            // 
            // Panel_Sales_History_Parent
            // 
            this.Panel_Sales_History_Parent.AutoScroll = true;
            this.Panel_Sales_History_Parent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.Panel_Sales_History_Parent.Controls.Add(this.Panel_Sales_History);
            this.Panel_Sales_History_Parent.Controls.Add(this.Panel_Sale_History_Close);
            this.Panel_Sales_History_Parent.Location = new System.Drawing.Point(1275, 0);
            this.Panel_Sales_History_Parent.Name = "Panel_Sales_History_Parent";
            this.Panel_Sales_History_Parent.Size = new System.Drawing.Size(365, 687);
            this.Panel_Sales_History_Parent.TabIndex = 507;
            this.Panel_Sales_History_Parent.Visible = false;
            // 
            // Panel_Sales_History
            // 
            this.Panel_Sales_History.AutoScroll = true;
            this.Panel_Sales_History.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Sales_History.Location = new System.Drawing.Point(0, 54);
            this.Panel_Sales_History.Name = "Panel_Sales_History";
            this.Panel_Sales_History.Size = new System.Drawing.Size(365, 633);
            this.Panel_Sales_History.TabIndex = 1;
            // 
            // Panel_Sale_History_Close
            // 
            this.Panel_Sale_History_Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.Panel_Sale_History_Close.Controls.Add(this.Btn_Sale_Close);
            this.Panel_Sale_History_Close.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Sale_History_Close.Location = new System.Drawing.Point(0, 0);
            this.Panel_Sale_History_Close.Name = "Panel_Sale_History_Close";
            this.Panel_Sale_History_Close.Size = new System.Drawing.Size(365, 54);
            this.Panel_Sale_History_Close.TabIndex = 0;
            // 
            // Btn_Sale_Close
            // 
            this.Btn_Sale_Close.BackgroundImage = global::Point_Of_Sale.Properties.Resources.close;
            this.Btn_Sale_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Sale_Close.Dock = System.Windows.Forms.DockStyle.Right;
            this.Btn_Sale_Close.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.Btn_Sale_Close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(70)))), ((int)(((byte)(200)))));
            this.Btn_Sale_Close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(65)))), ((int)(((byte)(70)))), ((int)(((byte)(200)))));
            this.Btn_Sale_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Sale_Close.Location = new System.Drawing.Point(311, 0);
            this.Btn_Sale_Close.Name = "Btn_Sale_Close";
            this.Btn_Sale_Close.Size = new System.Drawing.Size(54, 54);
            this.Btn_Sale_Close.TabIndex = 0;
            this.Btn_Sale_Close.UseVisualStyleBackColor = true;
            this.Btn_Sale_Close.Click += new System.EventHandler(this.Btn_Sale_Close_Click);
            // 
            // Form_Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.Panel_Sales_History_Parent);
            this.Controls.Add(this.Panel_Product_Search_Main);
            this.Controls.Add(this.Lbl_Payment_Type_Display);
            this.Controls.Add(this.Lbl_Customer_Name_Display);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txt_Subtotal);
            this.Controls.Add(this.Txt_Discount);
            this.Controls.Add(this.Txt_Total);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Lbl_Total);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.Btn_Logout);
            this.Controls.Add(this.Btn_Quantity);
            this.Controls.Add(this.Btn_Delete);
            this.Controls.Add(this.Table_Products);
            this.Controls.Add(this.Panel_Top_SearchBar);
            this.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12.5F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "Form_Register";
            this.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Form_Register_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_Register_MouseDown);
            this.Panel_Top_SearchBar.ResumeLayout(false);
            this.Panel_Top_SearchBar.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.Table_Products.ResumeLayout(false);
            this.Table_Products.PerformLayout();
            this.Panel_Sales_History_Parent.ResumeLayout(false);
            this.Panel_Sale_History_Close.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Top_SearchBar;
        private System.Windows.Forms.TextBox Txt_Search_Product_Name;
        private System.Windows.Forms.Label Lbl_Search;
        private System.Windows.Forms.Button Btn_Delete;
        private System.Windows.Forms.Button Btn_Quantity;
        private System.Windows.Forms.Button Btn_Logout;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button Btn_Discount;
        private System.Windows.Forms.Button Btn_Customer;
        private System.Windows.Forms.Button Btn_Sales;
        private System.Windows.Forms.Button Btn_Cash;
        private System.Windows.Forms.Button Btn_Card;
        private System.Windows.Forms.Button Btn_Cancel;
        private System.Windows.Forms.Button Btn_Payment;
        private System.Windows.Forms.Button Btn_SaveSale;
        private System.Windows.Forms.Label Lbl_Total;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Txt_Total;
        private System.Windows.Forms.TextBox Txt_Discount;
        private System.Windows.Forms.TextBox Txt_Subtotal;
        private System.Windows.Forms.Label Lbl_PHeader_Name;
        private System.Windows.Forms.Label Lbl_PHeader_Quantity;
        private System.Windows.Forms.Label Lbl_PHeader_Price;
        private System.Windows.Forms.Label Lbl_PHeader_Amount;
        private System.Windows.Forms.TableLayoutPanel Table_Products;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private System.Windows.Forms.Label Lbl_Customer_Name_Display;
        private System.Windows.Forms.Label Lbl_Payment_Type_Display;
        private System.Windows.Forms.Panel Panel_Product_Search_Main;
        private System.Windows.Forms.Panel Panel_Sales_History_Parent;
        private System.Windows.Forms.Panel Panel_Sale_History_Close;
        private System.Windows.Forms.Button Btn_Sale_Close;
        private System.Windows.Forms.Panel Panel_Product_Sale_Main;
        private System.Windows.Forms.Panel Panel_Sales_History;
        private System.Windows.Forms.Button Btn_Refresh_Products;
    }
}