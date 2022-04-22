namespace Point_Of_Sale
{
    partial class Form_Select_Customer
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
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.Panel_Customer_Main = new System.Windows.Forms.Panel();
            this.Panel_Top_SearchBar = new System.Windows.Forms.Panel();
            this.Lbl_Cancel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.Panel_Top_SearchBar.SuspendLayout();
            this.SuspendLayout();
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
            // panel1
            // 
            this.panel1.Controls.Add(this.Panel_Customer_Main);
            this.panel1.Controls.Add(this.Panel_Top_SearchBar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(780, 480);
            this.panel1.TabIndex = 0;
            // 
            // Panel_Customer_Main
            // 
            this.Panel_Customer_Main.AutoScroll = true;
            this.Panel_Customer_Main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.Panel_Customer_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Customer_Main.Location = new System.Drawing.Point(0, 40);
            this.Panel_Customer_Main.Name = "Panel_Customer_Main";
            this.Panel_Customer_Main.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.Panel_Customer_Main.Size = new System.Drawing.Size(780, 440);
            this.Panel_Customer_Main.TabIndex = 3;
            // 
            // Panel_Top_SearchBar
            // 
            this.Panel_Top_SearchBar.Controls.Add(this.Lbl_Cancel);
            this.Panel_Top_SearchBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Top_SearchBar.Location = new System.Drawing.Point(0, 0);
            this.Panel_Top_SearchBar.Name = "Panel_Top_SearchBar";
            this.Panel_Top_SearchBar.Size = new System.Drawing.Size(780, 40);
            this.Panel_Top_SearchBar.TabIndex = 2;
            // 
            // Lbl_Cancel
            // 
            this.Lbl_Cancel.AutoSize = true;
            this.Lbl_Cancel.Font = new System.Drawing.Font("Arial Black", 15F);
            this.Lbl_Cancel.Location = new System.Drawing.Point(744, 6);
            this.Lbl_Cancel.Name = "Lbl_Cancel";
            this.Lbl_Cancel.Size = new System.Drawing.Size(28, 28);
            this.Lbl_Cancel.TabIndex = 13;
            this.Lbl_Cancel.Text = "X";
            this.Lbl_Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Lbl_Cancel.Click += new System.EventHandler(this.Lbl_Cancel_Click);
            // 
            // Form_Select_Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "Form_Select_Customer";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Customer";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form_Select_Customer_Load);
            this.panel1.ResumeLayout(false);
            this.Panel_Top_SearchBar.ResumeLayout(false);
            this.Panel_Top_SearchBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel Panel_Top_SearchBar;
        private System.Windows.Forms.Panel Panel_Customer_Main;
        private System.Windows.Forms.Label Lbl_Cancel;
    }
}