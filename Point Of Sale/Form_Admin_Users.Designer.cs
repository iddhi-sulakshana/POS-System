namespace Point_Of_Sale
{
    partial class Form_Admin_Users
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Lbl_User_Header = new System.Windows.Forms.Label();
            this.Panel_User_Main = new System.Windows.Forms.Panel();
            this.Panel_User_Loader = new System.Windows.Forms.Panel();
            this.Panel_Header = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Lbl_User_Header_Password = new System.Windows.Forms.Label();
            this.Lbl_User_Header_Name = new System.Windows.Forms.Label();
            this.Btn_User_Delete = new System.Windows.Forms.Button();
            this.Btn_User_Edit = new System.Windows.Forms.Button();
            this.Btn_User_Add = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.Panel_User_Main.SuspendLayout();
            this.Panel_Header.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.Lbl_User_Header, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1012, 47);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // Lbl_User_Header
            // 
            this.Lbl_User_Header.AutoSize = true;
            this.Lbl_User_Header.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lbl_User_Header.Font = new System.Drawing.Font("Microsoft YaHei", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_User_Header.Location = new System.Drawing.Point(3, 0);
            this.Lbl_User_Header.Name = "Lbl_User_Header";
            this.Lbl_User_Header.Size = new System.Drawing.Size(1006, 47);
            this.Lbl_User_Header.TabIndex = 0;
            this.Lbl_User_Header.Text = "Users";
            this.Lbl_User_Header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Panel_User_Main
            // 
            this.Panel_User_Main.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel_User_Main.Controls.Add(this.Panel_User_Loader);
            this.Panel_User_Main.Controls.Add(this.Panel_Header);
            this.Panel_User_Main.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel_User_Main.Location = new System.Drawing.Point(10, 47);
            this.Panel_User_Main.Name = "Panel_User_Main";
            this.Panel_User_Main.Size = new System.Drawing.Size(770, 619);
            this.Panel_User_Main.TabIndex = 7;
            // 
            // Panel_User_Loader
            // 
            this.Panel_User_Loader.AutoScroll = true;
            this.Panel_User_Loader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_User_Loader.Location = new System.Drawing.Point(0, 50);
            this.Panel_User_Loader.Name = "Panel_User_Loader";
            this.Panel_User_Loader.Size = new System.Drawing.Size(768, 567);
            this.Panel_User_Loader.TabIndex = 1;
            // 
            // Panel_Header
            // 
            this.Panel_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.Panel_Header.Controls.Add(this.tableLayoutPanel2);
            this.Panel_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Header.Location = new System.Drawing.Point(0, 0);
            this.Panel_Header.Name = "Panel_Header";
            this.Panel_Header.Size = new System.Drawing.Size(768, 50);
            this.Panel_Header.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanel2.Controls.Add(this.Lbl_User_Header_Password, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.Lbl_User_Header_Name, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(768, 50);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // Lbl_User_Header_Password
            // 
            this.Lbl_User_Header_Password.AutoSize = true;
            this.Lbl_User_Header_Password.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lbl_User_Header_Password.Font = new System.Drawing.Font("Microsoft YaHei", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_User_Header_Password.Location = new System.Drawing.Point(358, 1);
            this.Lbl_User_Header_Password.Name = "Lbl_User_Header_Password";
            this.Lbl_User_Header_Password.Size = new System.Drawing.Size(347, 48);
            this.Lbl_User_Header_Password.TabIndex = 2;
            this.Lbl_User_Header_Password.Text = "Password";
            this.Lbl_User_Header_Password.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lbl_User_Header_Name
            // 
            this.Lbl_User_Header_Name.AutoSize = true;
            this.Lbl_User_Header_Name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lbl_User_Header_Name.Font = new System.Drawing.Font("Microsoft YaHei", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_User_Header_Name.Location = new System.Drawing.Point(4, 1);
            this.Lbl_User_Header_Name.Name = "Lbl_User_Header_Name";
            this.Lbl_User_Header_Name.Size = new System.Drawing.Size(347, 48);
            this.Lbl_User_Header_Name.TabIndex = 1;
            this.Lbl_User_Header_Name.Text = "Name";
            this.Lbl_User_Header_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Btn_User_Delete
            // 
            this.Btn_User_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Btn_User_Delete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.Btn_User_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_User_Delete.Font = new System.Drawing.Font("Arial Black", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_User_Delete.ForeColor = System.Drawing.Color.White;
            this.Btn_User_Delete.Location = new System.Drawing.Point(790, 580);
            this.Btn_User_Delete.Name = "Btn_User_Delete";
            this.Btn_User_Delete.Size = new System.Drawing.Size(229, 75);
            this.Btn_User_Delete.TabIndex = 8;
            this.Btn_User_Delete.Text = "Delete";
            this.Btn_User_Delete.UseVisualStyleBackColor = false;
            this.Btn_User_Delete.Click += new System.EventHandler(this.Btn_User_Delete_Click);
            // 
            // Btn_User_Edit
            // 
            this.Btn_User_Edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.Btn_User_Edit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.Btn_User_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_User_Edit.Font = new System.Drawing.Font("Arial Black", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_User_Edit.ForeColor = System.Drawing.Color.White;
            this.Btn_User_Edit.Location = new System.Drawing.Point(790, 499);
            this.Btn_User_Edit.Name = "Btn_User_Edit";
            this.Btn_User_Edit.Size = new System.Drawing.Size(229, 75);
            this.Btn_User_Edit.TabIndex = 8;
            this.Btn_User_Edit.Text = "Edit";
            this.Btn_User_Edit.UseVisualStyleBackColor = false;
            this.Btn_User_Edit.Click += new System.EventHandler(this.Btn_User_Edit_Click);
            // 
            // Btn_User_Add
            // 
            this.Btn_User_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(0)))));
            this.Btn_User_Add.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.Btn_User_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_User_Add.Font = new System.Drawing.Font("Arial Black", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_User_Add.ForeColor = System.Drawing.Color.White;
            this.Btn_User_Add.Location = new System.Drawing.Point(790, 418);
            this.Btn_User_Add.Name = "Btn_User_Add";
            this.Btn_User_Add.Size = new System.Drawing.Size(229, 75);
            this.Btn_User_Add.TabIndex = 8;
            this.Btn_User_Add.Text = "Add";
            this.Btn_User_Add.UseVisualStyleBackColor = false;
            this.Btn_User_Add.Click += new System.EventHandler(this.Btn_User_Add_Click);
            // 
            // Form_Admin_Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1022, 666);
            this.Controls.Add(this.Btn_User_Add);
            this.Controls.Add(this.Btn_User_Edit);
            this.Controls.Add(this.Btn_User_Delete);
            this.Controls.Add(this.Panel_User_Main);
            this.Controls.Add(this.tableLayoutPanel1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1022, 666);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1022, 666);
            this.Name = "Form_Admin_Users";
            this.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form_Admin_User";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form_Admin_Users_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.Panel_User_Main.ResumeLayout(false);
            this.Panel_Header.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label Lbl_User_Header;
        private System.Windows.Forms.Panel Panel_User_Main;
        private System.Windows.Forms.Panel Panel_Header;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button Btn_User_Delete;
        private System.Windows.Forms.Button Btn_User_Edit;
        private System.Windows.Forms.Button Btn_User_Add;
        private System.Windows.Forms.Label Lbl_User_Header_Password;
        private System.Windows.Forms.Label Lbl_User_Header_Name;
        private System.Windows.Forms.Panel Panel_User_Loader;
    }
}