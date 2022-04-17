namespace Point_Of_Sale
{
    partial class Form_Splash_Screen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Splash_Screen));
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.Circle_Progress_1 = new XanderUI.XUICircleProgressBar();
            this.Lbl_Loading = new System.Windows.Forms.Label();
            this.Flat_Progress_1 = new XanderUI.XUIFlatProgressBar();
            this.Flat_Progress_2 = new XanderUI.XUIFlatProgressBar();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
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
            // Circle_Progress_1
            // 
            this.Circle_Progress_1.AnimationSpeed = 5;
            this.Circle_Progress_1.FilledColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(220)))), ((int)(((byte)(210)))));
            this.Circle_Progress_1.FilledColorAlpha = 130;
            this.Circle_Progress_1.FilledThickness = 40;
            this.Circle_Progress_1.IsAnimated = false;
            this.Circle_Progress_1.Location = new System.Drawing.Point(47, 67);
            this.Circle_Progress_1.Name = "Circle_Progress_1";
            this.Circle_Progress_1.Percentage = 50;
            this.Circle_Progress_1.ShowText = true;
            this.Circle_Progress_1.Size = new System.Drawing.Size(200, 200);
            this.Circle_Progress_1.TabIndex = 0;
            this.Circle_Progress_1.TextColor = System.Drawing.Color.Gray;
            this.Circle_Progress_1.TextSize = 25;
            this.Circle_Progress_1.UnFilledColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(114)))), ((int)(((byte)(114)))));
            this.Circle_Progress_1.UnfilledThickness = 24;
            // 
            // Lbl_Loading
            // 
            this.Lbl_Loading.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_Loading.AutoSize = true;
            this.Lbl_Loading.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Loading.Location = new System.Drawing.Point(37, 299);
            this.Lbl_Loading.Name = "Lbl_Loading";
            this.Lbl_Loading.Size = new System.Drawing.Size(230, 39);
            this.Lbl_Loading.TabIndex = 1;
            this.Lbl_Loading.Text = "LOADING . . .";
            this.Lbl_Loading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Flat_Progress_1
            // 
            this.Flat_Progress_1.BarStyle = XanderUI.XUIFlatProgressBar.Style.Material;
            this.Flat_Progress_1.BarThickness = 5;
            this.Flat_Progress_1.CompleteColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(119)))), ((int)(((byte)(215)))));
            this.Flat_Progress_1.InocmpletedColor = System.Drawing.Color.White;
            this.Flat_Progress_1.Location = new System.Drawing.Point(-2, 397);
            this.Flat_Progress_1.MaxValue = 100;
            this.Flat_Progress_1.Name = "Flat_Progress_1";
            this.Flat_Progress_1.Size = new System.Drawing.Size(305, 10);
            this.Flat_Progress_1.TabIndex = 2;
            this.Flat_Progress_1.Text = "xuiFlatProgressBar1";
            this.Flat_Progress_1.Value = 50;
            // 
            // Flat_Progress_2
            // 
            this.Flat_Progress_2.BarStyle = XanderUI.XUIFlatProgressBar.Style.Material;
            this.Flat_Progress_2.BarThickness = 5;
            this.Flat_Progress_2.CompleteColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(119)))), ((int)(((byte)(215)))));
            this.Flat_Progress_2.InocmpletedColor = System.Drawing.Color.White;
            this.Flat_Progress_2.Location = new System.Drawing.Point(-2, -7);
            this.Flat_Progress_2.MaxValue = 100;
            this.Flat_Progress_2.Name = "Flat_Progress_2";
            this.Flat_Progress_2.Size = new System.Drawing.Size(305, 10);
            this.Flat_Progress_2.TabIndex = 2;
            this.Flat_Progress_2.Text = "xuiFlatProgressBar1";
            this.Flat_Progress_2.Value = 50;
            // 
            // Timer1
            // 
            this.Timer1.Interval = 50;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Form_Splash_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(300, 400);
            this.Controls.Add(this.Flat_Progress_2);
            this.Controls.Add(this.Flat_Progress_1);
            this.Controls.Add(this.Lbl_Loading);
            this.Controls.Add(this.Circle_Progress_1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Splash_Screen";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Splash_Screen";
            this.Load += new System.EventHandler(this.Form_Splash_Screen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private XanderUI.XUICircleProgressBar Circle_Progress_1;
        private System.Windows.Forms.Label Lbl_Loading;
        private XanderUI.XUIFlatProgressBar Flat_Progress_1;
        private XanderUI.XUIFlatProgressBar Flat_Progress_2;
        private System.Windows.Forms.Timer Timer1;
    }
}