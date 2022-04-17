namespace Point_Of_Sale
{
    partial class Form_Welcome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Welcome));
            this.Lbl_Welcome = new System.Windows.Forms.Label();
            this.Lbl_Description = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_Password_Show = new System.Windows.Forms.Button();
            this.Txt_Password = new System.Windows.Forms.TextBox();
            this.Txt_UName = new System.Windows.Forms.TextBox();
            this.Lbl_Password = new System.Windows.Forms.Label();
            this.Lbl_UName = new System.Windows.Forms.Label();
            this.Lbl_Error = new System.Windows.Forms.Label();
            this.Btn_Submit = new System.Windows.Forms.Button();
            this.Lbl_Contact = new System.Windows.Forms.Label();
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.Pic_Top_Icon = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Top_Icon)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_Welcome
            // 
            this.Lbl_Welcome.AutoSize = true;
            this.Lbl_Welcome.Font = new System.Drawing.Font("Microsoft JhengHei Light", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Welcome.Location = new System.Drawing.Point(502, 199);
            this.Lbl_Welcome.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Lbl_Welcome.Name = "Lbl_Welcome";
            this.Lbl_Welcome.Size = new System.Drawing.Size(261, 59);
            this.Lbl_Welcome.TabIndex = 100;
            this.Lbl_Welcome.Text = "WELCOME";
            // 
            // Lbl_Description
            // 
            this.Lbl_Description.AutoSize = true;
            this.Lbl_Description.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12.5F);
            this.Lbl_Description.Location = new System.Drawing.Point(301, 281);
            this.Lbl_Description.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Lbl_Description.Name = "Lbl_Description";
            this.Lbl_Description.Size = new System.Drawing.Size(661, 22);
            this.Lbl_Description.TabIndex = 101;
            this.Lbl_Description.Text = "With this software you can issue sale for customer, generate sales report and so " +
    "on\r\n";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Btn_Password_Show);
            this.panel1.Controls.Add(this.Txt_Password);
            this.panel1.Controls.Add(this.Txt_UName);
            this.panel1.Controls.Add(this.Lbl_Password);
            this.panel1.Controls.Add(this.Lbl_UName);
            this.panel1.Location = new System.Drawing.Point(374, 386);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(516, 94);
            this.panel1.TabIndex = 102;
            // 
            // Btn_Password_Show
            // 
            this.Btn_Password_Show.BackgroundImage = global::Point_Of_Sale.Properties.Resources.show_eye;
            this.Btn_Password_Show.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Password_Show.FlatAppearance.BorderSize = 0;
            this.Btn_Password_Show.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Password_Show.ForeColor = System.Drawing.Color.White;
            this.Btn_Password_Show.Location = new System.Drawing.Point(473, 56);
            this.Btn_Password_Show.Name = "Btn_Password_Show";
            this.Btn_Password_Show.Size = new System.Drawing.Size(39, 29);
            this.Btn_Password_Show.TabIndex = 105;
            this.Btn_Password_Show.TabStop = false;
            this.Btn_Password_Show.UseVisualStyleBackColor = true;
            this.Btn_Password_Show.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Show_Password);
            this.Btn_Password_Show.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Hide_Password);
            // 
            // Txt_Password
            // 
            this.Txt_Password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Txt_Password.ForeColor = System.Drawing.Color.White;
            this.Txt_Password.Location = new System.Drawing.Point(197, 56);
            this.Txt_Password.Name = "Txt_Password";
            this.Txt_Password.PasswordChar = '*';
            this.Txt_Password.Size = new System.Drawing.Size(270, 29);
            this.Txt_Password.TabIndex = 2;
            // 
            // Txt_UName
            // 
            this.Txt_UName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Txt_UName.ForeColor = System.Drawing.Color.White;
            this.Txt_UName.Location = new System.Drawing.Point(197, 3);
            this.Txt_UName.Name = "Txt_UName";
            this.Txt_UName.Size = new System.Drawing.Size(315, 29);
            this.Txt_UName.TabIndex = 1;
            // 
            // Lbl_Password
            // 
            this.Lbl_Password.AutoSize = true;
            this.Lbl_Password.Font = new System.Drawing.Font("Microsoft JhengHei UI", 13F);
            this.Lbl_Password.Location = new System.Drawing.Point(5, 59);
            this.Lbl_Password.Name = "Lbl_Password";
            this.Lbl_Password.Padding = new System.Windows.Forms.Padding(1);
            this.Lbl_Password.Size = new System.Drawing.Size(141, 25);
            this.Lbl_Password.TabIndex = 103;
            this.Lbl_Password.Text = "Password         :";
            this.Lbl_Password.UseMnemonic = false;
            // 
            // Lbl_UName
            // 
            this.Lbl_UName.AutoSize = true;
            this.Lbl_UName.Font = new System.Drawing.Font("Microsoft JhengHei UI", 13F);
            this.Lbl_UName.Location = new System.Drawing.Point(5, 6);
            this.Lbl_UName.Name = "Lbl_UName";
            this.Lbl_UName.Padding = new System.Windows.Forms.Padding(1);
            this.Lbl_UName.Size = new System.Drawing.Size(141, 25);
            this.Lbl_UName.TabIndex = 104;
            this.Lbl_UName.Text = "User Name      :";
            this.Lbl_UName.UseMnemonic = false;
            // 
            // Lbl_Error
            // 
            this.Lbl_Error.AutoSize = true;
            this.Lbl_Error.Font = new System.Drawing.Font("Microsoft JhengHei Light", 12F);
            this.Lbl_Error.ForeColor = System.Drawing.Color.Red;
            this.Lbl_Error.Location = new System.Drawing.Point(507, 491);
            this.Lbl_Error.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Lbl_Error.Name = "Lbl_Error";
            this.Lbl_Error.Size = new System.Drawing.Size(249, 20);
            this.Lbl_Error.TabIndex = 103;
            this.Lbl_Error.Text = "Wrong User Name OR Password";
            this.Lbl_Error.Visible = false;
            // 
            // Btn_Submit
            // 
            this.Btn_Submit.AutoSize = true;
            this.Btn_Submit.BackColor = System.Drawing.Color.Green;
            this.Btn_Submit.FlatAppearance.BorderSize = 0;
            this.Btn_Submit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.Btn_Submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Submit.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15F, System.Drawing.FontStyle.Bold);
            this.Btn_Submit.ForeColor = System.Drawing.Color.White;
            this.Btn_Submit.Location = new System.Drawing.Point(552, 523);
            this.Btn_Submit.Name = "Btn_Submit";
            this.Btn_Submit.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.Btn_Submit.Size = new System.Drawing.Size(160, 55);
            this.Btn_Submit.TabIndex = 104;
            this.Btn_Submit.Text = "SUBMIT";
            this.Btn_Submit.UseVisualStyleBackColor = false;
            this.Btn_Submit.Click += new System.EventHandler(this.Btn_Submit_Click);
            // 
            // Lbl_Contact
            // 
            this.Lbl_Contact.AutoSize = true;
            this.Lbl_Contact.Font = new System.Drawing.Font("Microsoft JhengHei Light", 12F);
            this.Lbl_Contact.Location = new System.Drawing.Point(321, 640);
            this.Lbl_Contact.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Lbl_Contact.Name = "Lbl_Contact";
            this.Lbl_Contact.Size = new System.Drawing.Size(621, 20);
            this.Lbl_Contact.TabIndex = 105;
            this.Lbl_Contact.Text = "If you dont remember login credintials. Please contact for the help. +94 11 123 1" +
    "234";
            // 
            // kryptonPalette1
            // 
            this.kryptonPalette1.BasePaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black;
            this.kryptonPalette1.ButtonSpecs.FormClose.Image = global::Point_Of_Sale.Properties.Resources.headerclose;
            this.kryptonPalette1.ButtonSpecs.FormMax.Image = global::Point_Of_Sale.Properties.Resources.headermax;
            this.kryptonPalette1.ButtonSpecs.FormMin.Image = global::Point_Of_Sale.Properties.Resources.headermin;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateCommon.Border.Width = 0;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Border.Width = 0;
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
            // Pic_Top_Icon
            // 
            this.Pic_Top_Icon.Image = global::Point_Of_Sale.Properties.Resources.icon;
            this.Pic_Top_Icon.Location = new System.Drawing.Point(552, 20);
            this.Pic_Top_Icon.Margin = new System.Windows.Forms.Padding(5);
            this.Pic_Top_Icon.Name = "Pic_Top_Icon";
            this.Pic_Top_Icon.Size = new System.Drawing.Size(160, 160);
            this.Pic_Top_Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic_Top_Icon.TabIndex = 0;
            this.Pic_Top_Icon.TabStop = false;
            // 
            // Form_Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.Lbl_Contact);
            this.Controls.Add(this.Btn_Submit);
            this.Controls.Add(this.Lbl_Error);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Lbl_Description);
            this.Controls.Add(this.Lbl_Welcome);
            this.Controls.Add(this.Pic_Top_Icon);
            this.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12.5F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "Form_Welcome";
            this.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Top_Icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Pic_Top_Icon;
        private System.Windows.Forms.Label Lbl_Welcome;
        private System.Windows.Forms.Label Lbl_Description;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Txt_Password;
        private System.Windows.Forms.TextBox Txt_UName;
        private System.Windows.Forms.Label Lbl_Password;
        private System.Windows.Forms.Label Lbl_UName;
        private System.Windows.Forms.Label Lbl_Error;
        private System.Windows.Forms.Button Btn_Submit;
        private System.Windows.Forms.Label Lbl_Contact;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private System.Windows.Forms.Button Btn_Password_Show;
    }
}

