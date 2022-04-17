namespace Point_Of_Sale
{
    partial class Form_Admin_Products
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
            this.Btn_Products_Delete = new System.Windows.Forms.Button();
            this.Panel_Header = new System.Windows.Forms.TableLayoutPanel();
            this.Lbl_Product_Header = new System.Windows.Forms.Label();
            this.Btn_Products_Add = new System.Windows.Forms.Button();
            this.Btn_Products_Edit = new System.Windows.Forms.Button();
            this.Panel_Products_Main = new System.Windows.Forms.Panel();
            this.Panel_Products_Loader = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Panel_Product_Header = new System.Windows.Forms.TableLayoutPanel();
            this.Lbl_Products_Header_Price = new System.Windows.Forms.Label();
            this.Lbl_Products_Header_Quantity = new System.Windows.Forms.Label();
            this.Lbl_Products_Header_Name = new System.Windows.Forms.Label();
            this.Panel_Header.SuspendLayout();
            this.Panel_Products_Main.SuspendLayout();
            this.panel2.SuspendLayout();
            this.Panel_Product_Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_Products_Delete
            // 
            this.Btn_Products_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Btn_Products_Delete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.Btn_Products_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Products_Delete.Font = new System.Drawing.Font("Arial Black", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Products_Delete.ForeColor = System.Drawing.Color.White;
            this.Btn_Products_Delete.Location = new System.Drawing.Point(788, 589);
            this.Btn_Products_Delete.Name = "Btn_Products_Delete";
            this.Btn_Products_Delete.Size = new System.Drawing.Size(229, 75);
            this.Btn_Products_Delete.TabIndex = 19;
            this.Btn_Products_Delete.Text = "Delete";
            this.Btn_Products_Delete.UseVisualStyleBackColor = false;
            this.Btn_Products_Delete.Click += new System.EventHandler(this.Btn_Product_Delete_Click);
            // 
            // Panel_Header
            // 
            this.Panel_Header.ColumnCount = 1;
            this.Panel_Header.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Panel_Header.Controls.Add(this.Lbl_Product_Header, 0, 0);
            this.Panel_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Header.Location = new System.Drawing.Point(0, 0);
            this.Panel_Header.Name = "Panel_Header";
            this.Panel_Header.RowCount = 1;
            this.Panel_Header.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Panel_Header.Size = new System.Drawing.Size(1022, 47);
            this.Panel_Header.TabIndex = 20;
            // 
            // Lbl_Product_Header
            // 
            this.Lbl_Product_Header.AutoSize = true;
            this.Lbl_Product_Header.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lbl_Product_Header.Font = new System.Drawing.Font("Microsoft YaHei", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Product_Header.Location = new System.Drawing.Point(3, 0);
            this.Lbl_Product_Header.Name = "Lbl_Product_Header";
            this.Lbl_Product_Header.Size = new System.Drawing.Size(1016, 47);
            this.Lbl_Product_Header.TabIndex = 0;
            this.Lbl_Product_Header.Text = "Products";
            this.Lbl_Product_Header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Btn_Products_Add
            // 
            this.Btn_Products_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(0)))));
            this.Btn_Products_Add.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.Btn_Products_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Products_Add.Font = new System.Drawing.Font("Arial Black", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Products_Add.ForeColor = System.Drawing.Color.White;
            this.Btn_Products_Add.Location = new System.Drawing.Point(11, 589);
            this.Btn_Products_Add.Name = "Btn_Products_Add";
            this.Btn_Products_Add.Size = new System.Drawing.Size(229, 75);
            this.Btn_Products_Add.TabIndex = 17;
            this.Btn_Products_Add.Text = "Add";
            this.Btn_Products_Add.UseVisualStyleBackColor = false;
            this.Btn_Products_Add.Click += new System.EventHandler(this.Btn_Products_Add_Click);
            // 
            // Btn_Products_Edit
            // 
            this.Btn_Products_Edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.Btn_Products_Edit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.Btn_Products_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Products_Edit.Font = new System.Drawing.Font("Arial Black", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Products_Edit.ForeColor = System.Drawing.Color.White;
            this.Btn_Products_Edit.Location = new System.Drawing.Point(399, 589);
            this.Btn_Products_Edit.Name = "Btn_Products_Edit";
            this.Btn_Products_Edit.Size = new System.Drawing.Size(229, 75);
            this.Btn_Products_Edit.TabIndex = 18;
            this.Btn_Products_Edit.Text = "Edit";
            this.Btn_Products_Edit.UseVisualStyleBackColor = false;
            this.Btn_Products_Edit.Click += new System.EventHandler(this.Btn_Product_Edit_Click);
            // 
            // Panel_Products_Main
            // 
            this.Panel_Products_Main.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel_Products_Main.Controls.Add(this.Panel_Products_Loader);
            this.Panel_Products_Main.Controls.Add(this.panel2);
            this.Panel_Products_Main.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Products_Main.Location = new System.Drawing.Point(0, 47);
            this.Panel_Products_Main.Name = "Panel_Products_Main";
            this.Panel_Products_Main.Size = new System.Drawing.Size(1022, 534);
            this.Panel_Products_Main.TabIndex = 22;
            // 
            // Panel_Products_Loader
            // 
            this.Panel_Products_Loader.AutoScroll = true;
            this.Panel_Products_Loader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Products_Loader.Location = new System.Drawing.Point(0, 52);
            this.Panel_Products_Loader.Name = "Panel_Products_Loader";
            this.Panel_Products_Loader.Size = new System.Drawing.Size(1020, 480);
            this.Panel_Products_Loader.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.panel2.Controls.Add(this.Panel_Product_Header);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1020, 52);
            this.panel2.TabIndex = 0;
            // 
            // Panel_Product_Header
            // 
            this.Panel_Product_Header.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.Panel_Product_Header.ColumnCount = 3;
            this.Panel_Product_Header.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.Panel_Product_Header.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Panel_Product_Header.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.Panel_Product_Header.Controls.Add(this.Lbl_Products_Header_Price, 0, 0);
            this.Panel_Product_Header.Controls.Add(this.Lbl_Products_Header_Quantity, 0, 0);
            this.Panel_Product_Header.Controls.Add(this.Lbl_Products_Header_Name, 0, 0);
            this.Panel_Product_Header.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Product_Header.Location = new System.Drawing.Point(0, 0);
            this.Panel_Product_Header.Name = "Panel_Product_Header";
            this.Panel_Product_Header.RowCount = 1;
            this.Panel_Product_Header.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Panel_Product_Header.Size = new System.Drawing.Size(1020, 52);
            this.Panel_Product_Header.TabIndex = 0;
            // 
            // Lbl_Products_Header_Price
            // 
            this.Lbl_Products_Header_Price.AutoSize = true;
            this.Lbl_Products_Header_Price.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lbl_Products_Header_Price.Font = new System.Drawing.Font("Microsoft YaHei", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Products_Header_Price.Location = new System.Drawing.Point(666, 1);
            this.Lbl_Products_Header_Price.Name = "Lbl_Products_Header_Price";
            this.Lbl_Products_Header_Price.Size = new System.Drawing.Size(350, 50);
            this.Lbl_Products_Header_Price.TabIndex = 3;
            this.Lbl_Products_Header_Price.Text = "Price";
            this.Lbl_Products_Header_Price.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lbl_Products_Header_Quantity
            // 
            this.Lbl_Products_Header_Quantity.AutoSize = true;
            this.Lbl_Products_Header_Quantity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lbl_Products_Header_Quantity.Font = new System.Drawing.Font("Microsoft YaHei", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Products_Header_Quantity.Location = new System.Drawing.Point(411, 1);
            this.Lbl_Products_Header_Quantity.Name = "Lbl_Products_Header_Quantity";
            this.Lbl_Products_Header_Quantity.Size = new System.Drawing.Size(248, 50);
            this.Lbl_Products_Header_Quantity.TabIndex = 2;
            this.Lbl_Products_Header_Quantity.Text = "Quantity";
            this.Lbl_Products_Header_Quantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lbl_Products_Header_Name
            // 
            this.Lbl_Products_Header_Name.AutoSize = true;
            this.Lbl_Products_Header_Name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lbl_Products_Header_Name.Font = new System.Drawing.Font("Microsoft YaHei", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Products_Header_Name.Location = new System.Drawing.Point(4, 1);
            this.Lbl_Products_Header_Name.Name = "Lbl_Products_Header_Name";
            this.Lbl_Products_Header_Name.Size = new System.Drawing.Size(400, 50);
            this.Lbl_Products_Header_Name.TabIndex = 1;
            this.Lbl_Products_Header_Name.Text = "Name";
            this.Lbl_Products_Header_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form_Admin_Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1022, 666);
            this.Controls.Add(this.Panel_Products_Main);
            this.Controls.Add(this.Btn_Products_Delete);
            this.Controls.Add(this.Panel_Header);
            this.Controls.Add(this.Btn_Products_Add);
            this.Controls.Add(this.Btn_Products_Edit);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1022, 666);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1022, 666);
            this.Name = "Form_Admin_Products";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form_Admin_Products";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form_Admin_Products_Load);
            this.Panel_Header.ResumeLayout(false);
            this.Panel_Header.PerformLayout();
            this.Panel_Products_Main.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.Panel_Product_Header.ResumeLayout(false);
            this.Panel_Product_Header.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Products_Delete;
        private System.Windows.Forms.TableLayoutPanel Panel_Header;
        private System.Windows.Forms.Label Lbl_Product_Header;
        private System.Windows.Forms.Button Btn_Products_Add;
        private System.Windows.Forms.Button Btn_Products_Edit;
        private System.Windows.Forms.Panel Panel_Products_Main;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel Panel_Product_Header;
        private System.Windows.Forms.Label Lbl_Products_Header_Price;
        private System.Windows.Forms.Label Lbl_Products_Header_Quantity;
        private System.Windows.Forms.Label Lbl_Products_Header_Name;
        private System.Windows.Forms.Panel Panel_Products_Loader;
    }
}