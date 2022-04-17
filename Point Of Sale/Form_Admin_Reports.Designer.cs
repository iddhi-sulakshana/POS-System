namespace Point_Of_Sale
{
    partial class Form_Admin_Reports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Admin_Reports));
            this.Panel_Footer = new System.Windows.Forms.TableLayoutPanel();
            this.Lbl_Generated_Time = new System.Windows.Forms.Label();
            this.Panel_Today_Report = new System.Windows.Forms.Panel();
            this.Lbl_Today_Amount_Value = new System.Windows.Forms.Label();
            this.Lbl_Today_Count_Value = new System.Windows.Forms.Label();
            this.Lbl_Today_Count = new System.Windows.Forms.Label();
            this.Lbl_Today_Amount = new System.Windows.Forms.Label();
            this.Lbl_Today_Report = new System.Windows.Forms.Label();
            this.Panel_Generate_Report = new System.Windows.Forms.Panel();
            this.Btn_Generate_Report = new System.Windows.Forms.Button();
            this.DateTime_Generate_Report_To = new System.Windows.Forms.DateTimePicker();
            this.DateTime_Generate_Report_From = new System.Windows.Forms.DateTimePicker();
            this.Lbl_Generate_Report = new System.Windows.Forms.Label();
            this.Lbl_Sales_Generate_To = new System.Windows.Forms.Label();
            this.Lbl_Sales_Generate_From = new System.Windows.Forms.Label();
            this.Panel_Yearly_Report = new System.Windows.Forms.Panel();
            this.Graph_Yearly_Report = new XanderUI.XUIBarGraph();
            this.Lbl_Yearly_Report = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.Panel_14Days_Report = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Graph_14Days_Report = new XanderUI.XUILineGraph();
            this.Lbl_Date8 = new System.Windows.Forms.Label();
            this.Lbl_Date12 = new System.Windows.Forms.Label();
            this.Lbl_Date4 = new System.Windows.Forms.Label();
            this.Lbl_Date7 = new System.Windows.Forms.Label();
            this.Lbl_Date14 = new System.Windows.Forms.Label();
            this.Lbl_Date6 = new System.Windows.Forms.Label();
            this.Lbl_Date11 = new System.Windows.Forms.Label();
            this.Lbl_Date3 = new System.Windows.Forms.Label();
            this.Lbl_Date13 = new System.Windows.Forms.Label();
            this.Lbl_Date5 = new System.Windows.Forms.Label();
            this.Lbl_Date10 = new System.Windows.Forms.Label();
            this.Lbl_Date2 = new System.Windows.Forms.Label();
            this.Lbl_Date9 = new System.Windows.Forms.Label();
            this.Lbl_Date1 = new System.Windows.Forms.Label();
            this.Lbl_14Days_Report = new System.Windows.Forms.Label();
            this.Panel_Report_Container = new System.Windows.Forms.FlowLayoutPanel();
            this.Lbl_Report_Header = new System.Windows.Forms.Label();
            this.Panel_Header = new System.Windows.Forms.TableLayoutPanel();
            this.Btn_Refresh = new System.Windows.Forms.Button();
            this.Panel_Footer.SuspendLayout();
            this.Panel_Today_Report.SuspendLayout();
            this.Panel_Generate_Report.SuspendLayout();
            this.Panel_Yearly_Report.SuspendLayout();
            this.Panel_14Days_Report.SuspendLayout();
            this.Panel_Report_Container.SuspendLayout();
            this.Panel_Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_Footer
            // 
            this.Panel_Footer.ColumnCount = 1;
            this.Panel_Footer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Panel_Footer.Controls.Add(this.Lbl_Generated_Time, 0, 0);
            this.Panel_Footer.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Footer.Location = new System.Drawing.Point(3, 581);
            this.Panel_Footer.Name = "Panel_Footer";
            this.Panel_Footer.RowCount = 1;
            this.Panel_Footer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Panel_Footer.Size = new System.Drawing.Size(1002, 30);
            this.Panel_Footer.TabIndex = 6;
            // 
            // Lbl_Generated_Time
            // 
            this.Lbl_Generated_Time.AutoSize = true;
            this.Lbl_Generated_Time.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lbl_Generated_Time.Font = new System.Drawing.Font("NSimSun", 12.5F, System.Drawing.FontStyle.Italic);
            this.Lbl_Generated_Time.Location = new System.Drawing.Point(3, 0);
            this.Lbl_Generated_Time.Name = "Lbl_Generated_Time";
            this.Lbl_Generated_Time.Size = new System.Drawing.Size(996, 30);
            this.Lbl_Generated_Time.TabIndex = 0;
            this.Lbl_Generated_Time.Text = "Report Generated at 2022.04.06 20:11PM";
            this.Lbl_Generated_Time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Panel_Today_Report
            // 
            this.Panel_Today_Report.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel_Today_Report.Controls.Add(this.Lbl_Today_Amount_Value);
            this.Panel_Today_Report.Controls.Add(this.Lbl_Today_Count_Value);
            this.Panel_Today_Report.Controls.Add(this.Lbl_Today_Count);
            this.Panel_Today_Report.Controls.Add(this.Lbl_Today_Amount);
            this.Panel_Today_Report.Controls.Add(this.Lbl_Today_Report);
            this.Panel_Today_Report.Location = new System.Drawing.Point(559, 299);
            this.Panel_Today_Report.Margin = new System.Windows.Forms.Padding(2, 5, 5, 5);
            this.Panel_Today_Report.Name = "Panel_Today_Report";
            this.Panel_Today_Report.Size = new System.Drawing.Size(438, 274);
            this.Panel_Today_Report.TabIndex = 5;
            // 
            // Lbl_Today_Amount_Value
            // 
            this.Lbl_Today_Amount_Value.AutoSize = true;
            this.Lbl_Today_Amount_Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Today_Amount_Value.Location = new System.Drawing.Point(12, 81);
            this.Lbl_Today_Amount_Value.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Today_Amount_Value.Name = "Lbl_Today_Amount_Value";
            this.Lbl_Today_Amount_Value.Size = new System.Drawing.Size(423, 63);
            this.Lbl_Today_Amount_Value.TabIndex = 2;
            this.Lbl_Today_Amount_Value.Text = "Rs.1,000,000.00";
            // 
            // Lbl_Today_Count_Value
            // 
            this.Lbl_Today_Count_Value.AutoSize = true;
            this.Lbl_Today_Count_Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Today_Count_Value.Location = new System.Drawing.Point(11, 193);
            this.Lbl_Today_Count_Value.Margin = new System.Windows.Forms.Padding(0);
            this.Lbl_Today_Count_Value.Name = "Lbl_Today_Count_Value";
            this.Lbl_Today_Count_Value.Size = new System.Drawing.Size(411, 69);
            this.Lbl_Today_Count_Value.TabIndex = 1;
            this.Lbl_Today_Count_Value.Text = "100,000 Sales";
            // 
            // Lbl_Today_Count
            // 
            this.Lbl_Today_Count.AutoSize = true;
            this.Lbl_Today_Count.Font = new System.Drawing.Font("Segoe UI Black", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Today_Count.Location = new System.Drawing.Point(16, 151);
            this.Lbl_Today_Count.Name = "Lbl_Today_Count";
            this.Lbl_Today_Count.Size = new System.Drawing.Size(119, 46);
            this.Lbl_Today_Count.TabIndex = 1;
            this.Lbl_Today_Count.Text = "Count";
            // 
            // Lbl_Today_Amount
            // 
            this.Lbl_Today_Amount.AutoSize = true;
            this.Lbl_Today_Amount.Font = new System.Drawing.Font("Segoe UI Black", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Today_Amount.Location = new System.Drawing.Point(16, 37);
            this.Lbl_Today_Amount.Name = "Lbl_Today_Amount";
            this.Lbl_Today_Amount.Size = new System.Drawing.Size(156, 46);
            this.Lbl_Today_Amount.TabIndex = 1;
            this.Lbl_Today_Amount.Text = "Amount";
            // 
            // Lbl_Today_Report
            // 
            this.Lbl_Today_Report.AutoSize = true;
            this.Lbl_Today_Report.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Today_Report.Location = new System.Drawing.Point(128, 8);
            this.Lbl_Today_Report.Name = "Lbl_Today_Report";
            this.Lbl_Today_Report.Size = new System.Drawing.Size(206, 27);
            this.Lbl_Today_Report.TabIndex = 0;
            this.Lbl_Today_Report.Text = "Today Sales Report";
            // 
            // Panel_Generate_Report
            // 
            this.Panel_Generate_Report.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel_Generate_Report.Controls.Add(this.Btn_Generate_Report);
            this.Panel_Generate_Report.Controls.Add(this.DateTime_Generate_Report_To);
            this.Panel_Generate_Report.Controls.Add(this.DateTime_Generate_Report_From);
            this.Panel_Generate_Report.Controls.Add(this.Lbl_Generate_Report);
            this.Panel_Generate_Report.Controls.Add(this.Lbl_Sales_Generate_To);
            this.Panel_Generate_Report.Controls.Add(this.Lbl_Sales_Generate_From);
            this.Panel_Generate_Report.Location = new System.Drawing.Point(5, 299);
            this.Panel_Generate_Report.Margin = new System.Windows.Forms.Padding(5);
            this.Panel_Generate_Report.Name = "Panel_Generate_Report";
            this.Panel_Generate_Report.Size = new System.Drawing.Size(547, 274);
            this.Panel_Generate_Report.TabIndex = 5;
            // 
            // Btn_Generate_Report
            // 
            this.Btn_Generate_Report.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Btn_Generate_Report.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.Btn_Generate_Report.FlatAppearance.BorderSize = 3;
            this.Btn_Generate_Report.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(70)))), ((int)(((byte)(200)))));
            this.Btn_Generate_Report.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(65)))), ((int)(((byte)(70)))), ((int)(((byte)(200)))));
            this.Btn_Generate_Report.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Generate_Report.Font = new System.Drawing.Font("Arial Black", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Generate_Report.Location = new System.Drawing.Point(0, 209);
            this.Btn_Generate_Report.Name = "Btn_Generate_Report";
            this.Btn_Generate_Report.Size = new System.Drawing.Size(545, 63);
            this.Btn_Generate_Report.TabIndex = 3;
            this.Btn_Generate_Report.Text = "Generate";
            this.Btn_Generate_Report.UseVisualStyleBackColor = true;
            this.Btn_Generate_Report.Click += new System.EventHandler(this.Btn_Generate_Report_Click);
            // 
            // DateTime_Generate_Report_To
            // 
            this.DateTime_Generate_Report_To.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTime_Generate_Report_To.Location = new System.Drawing.Point(33, 155);
            this.DateTime_Generate_Report_To.Name = "DateTime_Generate_Report_To";
            this.DateTime_Generate_Report_To.Size = new System.Drawing.Size(503, 38);
            this.DateTime_Generate_Report_To.TabIndex = 2;
            this.DateTime_Generate_Report_To.ValueChanged += new System.EventHandler(this.DateTime_Generate_Report_Validate);
            // 
            // DateTime_Generate_Report_From
            // 
            this.DateTime_Generate_Report_From.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTime_Generate_Report_From.Location = new System.Drawing.Point(33, 73);
            this.DateTime_Generate_Report_From.Name = "DateTime_Generate_Report_From";
            this.DateTime_Generate_Report_From.Size = new System.Drawing.Size(503, 38);
            this.DateTime_Generate_Report_From.TabIndex = 2;
            this.DateTime_Generate_Report_From.ValueChanged += new System.EventHandler(this.DateTime_Generate_Report_Validate);
            // 
            // Lbl_Generate_Report
            // 
            this.Lbl_Generate_Report.AutoSize = true;
            this.Lbl_Generate_Report.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Generate_Report.Location = new System.Drawing.Point(188, 8);
            this.Lbl_Generate_Report.Name = "Lbl_Generate_Report";
            this.Lbl_Generate_Report.Size = new System.Drawing.Size(178, 27);
            this.Lbl_Generate_Report.TabIndex = 0;
            this.Lbl_Generate_Report.Text = "Generate Report";
            // 
            // Lbl_Sales_Generate_To
            // 
            this.Lbl_Sales_Generate_To.AutoSize = true;
            this.Lbl_Sales_Generate_To.Font = new System.Drawing.Font("Segoe UI Black", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Sales_Generate_To.Location = new System.Drawing.Point(3, 114);
            this.Lbl_Sales_Generate_To.Name = "Lbl_Sales_Generate_To";
            this.Lbl_Sales_Generate_To.Size = new System.Drawing.Size(51, 37);
            this.Lbl_Sales_Generate_To.TabIndex = 1;
            this.Lbl_Sales_Generate_To.Text = "To";
            // 
            // Lbl_Sales_Generate_From
            // 
            this.Lbl_Sales_Generate_From.AutoSize = true;
            this.Lbl_Sales_Generate_From.Font = new System.Drawing.Font("Segoe UI Black", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Sales_Generate_From.Location = new System.Drawing.Point(3, 31);
            this.Lbl_Sales_Generate_From.Name = "Lbl_Sales_Generate_From";
            this.Lbl_Sales_Generate_From.Size = new System.Drawing.Size(87, 37);
            this.Lbl_Sales_Generate_From.TabIndex = 1;
            this.Lbl_Sales_Generate_From.Text = "From";
            // 
            // Panel_Yearly_Report
            // 
            this.Panel_Yearly_Report.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel_Yearly_Report.Controls.Add(this.Graph_Yearly_Report);
            this.Panel_Yearly_Report.Controls.Add(this.Lbl_Yearly_Report);
            this.Panel_Yearly_Report.Controls.Add(this.label24);
            this.Panel_Yearly_Report.Controls.Add(this.label22);
            this.Panel_Yearly_Report.Controls.Add(this.label17);
            this.Panel_Yearly_Report.Controls.Add(this.label23);
            this.Panel_Yearly_Report.Controls.Add(this.label21);
            this.Panel_Yearly_Report.Controls.Add(this.label16);
            this.Panel_Yearly_Report.Controls.Add(this.label20);
            this.Panel_Yearly_Report.Controls.Add(this.label14);
            this.Panel_Yearly_Report.Controls.Add(this.label19);
            this.Panel_Yearly_Report.Controls.Add(this.label15);
            this.Panel_Yearly_Report.Controls.Add(this.label18);
            this.Panel_Yearly_Report.Controls.Add(this.label13);
            this.Panel_Yearly_Report.Location = new System.Drawing.Point(455, 5);
            this.Panel_Yearly_Report.Margin = new System.Windows.Forms.Padding(5);
            this.Panel_Yearly_Report.Name = "Panel_Yearly_Report";
            this.Panel_Yearly_Report.Size = new System.Drawing.Size(542, 284);
            this.Panel_Yearly_Report.TabIndex = 5;
            // 
            // Graph_Yearly_Report
            // 
            this.Graph_Yearly_Report.FilledColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.Graph_Yearly_Report.GraphOrientation = XanderUI.XUIBarGraph.Orientation.Vertical;
            this.Graph_Yearly_Report.GraphStyle = XanderUI.XUIBarGraph.Style.Material;
            this.Graph_Yearly_Report.Items = ((System.Collections.Generic.List<int>)(resources.GetObject("Graph_Yearly_Report.Items")));
            this.Graph_Yearly_Report.Location = new System.Drawing.Point(3, 35);
            this.Graph_Yearly_Report.Name = "Graph_Yearly_Report";
            this.Graph_Yearly_Report.ShowGrid = false;
            this.Graph_Yearly_Report.Size = new System.Drawing.Size(538, 229);
            this.Graph_Yearly_Report.Sorting = XanderUI.XUIBarGraph.SortStyle.Normal;
            this.Graph_Yearly_Report.SplitterColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(62)))), ((int)(((byte)(71)))));
            this.Graph_Yearly_Report.TabIndex = 4;
            this.Graph_Yearly_Report.Text = "xuiBarGraph1";
            this.Graph_Yearly_Report.TextAlignment = XanderUI.XUIBarGraph.Aligning.Far;
            this.Graph_Yearly_Report.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.Graph_Yearly_Report.UnfilledColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            // 
            // Lbl_Yearly_Report
            // 
            this.Lbl_Yearly_Report.AutoSize = true;
            this.Lbl_Yearly_Report.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Yearly_Report.Location = new System.Drawing.Point(98, 5);
            this.Lbl_Yearly_Report.Name = "Lbl_Yearly_Report";
            this.Lbl_Yearly_Report.Size = new System.Drawing.Size(336, 27);
            this.Lbl_Yearly_Report.TabIndex = 0;
            this.Lbl_Yearly_Report.Text = "Yearly Sales Report (Sale Count)";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(497, 267);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(27, 13);
            this.label24.TabIndex = 2;
            this.label24.Text = "Dec";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(412, 267);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(24, 13);
            this.label22.TabIndex = 2;
            this.label22.Text = "Oct";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(190, 267);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(27, 13);
            this.label17.TabIndex = 2;
            this.label17.Text = "May";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(455, 267);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(27, 13);
            this.label23.TabIndex = 2;
            this.label23.Text = "Nov";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(366, 267);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(26, 13);
            this.label21.TabIndex = 2;
            this.label21.Text = "Sep";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(147, 267);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(23, 13);
            this.label16.TabIndex = 2;
            this.label16.Text = "Apr";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(280, 267);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(20, 13);
            this.label20.TabIndex = 2;
            this.label20.Text = "Jul";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(57, 267);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(25, 13);
            this.label14.TabIndex = 2;
            this.label14.Text = "Feb";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(324, 267);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(26, 13);
            this.label19.TabIndex = 2;
            this.label19.Text = "Aug";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(102, 267);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(25, 13);
            this.label15.TabIndex = 2;
            this.label15.Text = "Mar";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(235, 267);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(24, 13);
            this.label18.TabIndex = 2;
            this.label18.Text = "Jun";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 267);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(24, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "Jan";
            // 
            // Panel_14Days_Report
            // 
            this.Panel_14Days_Report.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel_14Days_Report.Controls.Add(this.panel1);
            this.Panel_14Days_Report.Controls.Add(this.Graph_14Days_Report);
            this.Panel_14Days_Report.Controls.Add(this.Lbl_Date8);
            this.Panel_14Days_Report.Controls.Add(this.Lbl_Date12);
            this.Panel_14Days_Report.Controls.Add(this.Lbl_Date4);
            this.Panel_14Days_Report.Controls.Add(this.Lbl_Date7);
            this.Panel_14Days_Report.Controls.Add(this.Lbl_Date14);
            this.Panel_14Days_Report.Controls.Add(this.Lbl_Date6);
            this.Panel_14Days_Report.Controls.Add(this.Lbl_Date11);
            this.Panel_14Days_Report.Controls.Add(this.Lbl_Date3);
            this.Panel_14Days_Report.Controls.Add(this.Lbl_Date13);
            this.Panel_14Days_Report.Controls.Add(this.Lbl_Date5);
            this.Panel_14Days_Report.Controls.Add(this.Lbl_Date10);
            this.Panel_14Days_Report.Controls.Add(this.Lbl_Date2);
            this.Panel_14Days_Report.Controls.Add(this.Lbl_Date9);
            this.Panel_14Days_Report.Controls.Add(this.Lbl_Date1);
            this.Panel_14Days_Report.Controls.Add(this.Lbl_14Days_Report);
            this.Panel_14Days_Report.Location = new System.Drawing.Point(5, 5);
            this.Panel_14Days_Report.Margin = new System.Windows.Forms.Padding(5);
            this.Panel_14Days_Report.Name = "Panel_14Days_Report";
            this.Panel_14Days_Report.Size = new System.Drawing.Size(440, 284);
            this.Panel_14Days_Report.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.panel1.Location = new System.Drawing.Point(428, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(16, 229);
            this.panel1.TabIndex = 3;
            // 
            // Graph_14Days_Report
            // 
            this.Graph_14Days_Report.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Graph_14Days_Report.BelowLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Graph_14Days_Report.BorderColor = System.Drawing.Color.White;
            this.Graph_14Days_Report.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Graph_14Days_Report.GraphStyle = XanderUI.XUILineGraph.Style.Material;
            this.Graph_14Days_Report.GraphTitle = "XUI LineGraph";
            this.Graph_14Days_Report.GraphTitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Graph_14Days_Report.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Graph_14Days_Report.Items = ((System.Collections.Generic.List<int>)(resources.GetObject("Graph_14Days_Report.Items")));
            this.Graph_14Days_Report.LineColor = System.Drawing.Color.White;
            this.Graph_14Days_Report.Location = new System.Drawing.Point(-1, 35);
            this.Graph_14Days_Report.Name = "Graph_14Days_Report";
            this.Graph_14Days_Report.PointSize = 10;
            this.Graph_14Days_Report.ShowBorder = false;
            this.Graph_14Days_Report.ShowPoints = true;
            this.Graph_14Days_Report.ShowTitle = false;
            this.Graph_14Days_Report.ShowVerticalLines = false;
            this.Graph_14Days_Report.Size = new System.Drawing.Size(436, 229);
            this.Graph_14Days_Report.TabIndex = 1;
            this.Graph_14Days_Report.Text = "xuiLineGraph1";
            this.Graph_14Days_Report.TitleAlignment = System.Drawing.StringAlignment.Far;
            this.Graph_14Days_Report.VerticalLineColor = System.Drawing.Color.Empty;
            // 
            // Lbl_Date8
            // 
            this.Lbl_Date8.AutoSize = true;
            this.Lbl_Date8.Location = new System.Drawing.Point(225, 267);
            this.Lbl_Date8.Name = "Lbl_Date8";
            this.Lbl_Date8.Size = new System.Drawing.Size(13, 13);
            this.Lbl_Date8.TabIndex = 2;
            this.Lbl_Date8.Text = "8";
            // 
            // Lbl_Date12
            // 
            this.Lbl_Date12.AutoSize = true;
            this.Lbl_Date12.Location = new System.Drawing.Point(338, 267);
            this.Lbl_Date12.Name = "Lbl_Date12";
            this.Lbl_Date12.Size = new System.Drawing.Size(19, 13);
            this.Lbl_Date12.TabIndex = 2;
            this.Lbl_Date12.Text = "12";
            // 
            // Lbl_Date4
            // 
            this.Lbl_Date4.AutoSize = true;
            this.Lbl_Date4.Location = new System.Drawing.Point(109, 267);
            this.Lbl_Date4.Name = "Lbl_Date4";
            this.Lbl_Date4.Size = new System.Drawing.Size(13, 13);
            this.Lbl_Date4.TabIndex = 2;
            this.Lbl_Date4.Text = "4";
            // 
            // Lbl_Date7
            // 
            this.Lbl_Date7.AutoSize = true;
            this.Lbl_Date7.Location = new System.Drawing.Point(195, 267);
            this.Lbl_Date7.Name = "Lbl_Date7";
            this.Lbl_Date7.Size = new System.Drawing.Size(13, 13);
            this.Lbl_Date7.TabIndex = 0;
            this.Lbl_Date7.Text = "7";
            // 
            // Lbl_Date14
            // 
            this.Lbl_Date14.AutoSize = true;
            this.Lbl_Date14.Location = new System.Drawing.Point(395, 267);
            this.Lbl_Date14.Name = "Lbl_Date14";
            this.Lbl_Date14.Size = new System.Drawing.Size(19, 13);
            this.Lbl_Date14.TabIndex = 2;
            this.Lbl_Date14.Text = "14";
            // 
            // Lbl_Date6
            // 
            this.Lbl_Date6.AutoSize = true;
            this.Lbl_Date6.Location = new System.Drawing.Point(167, 267);
            this.Lbl_Date6.Name = "Lbl_Date6";
            this.Lbl_Date6.Size = new System.Drawing.Size(13, 13);
            this.Lbl_Date6.TabIndex = 2;
            this.Lbl_Date6.Text = "6";
            // 
            // Lbl_Date11
            // 
            this.Lbl_Date11.AutoSize = true;
            this.Lbl_Date11.Location = new System.Drawing.Point(309, 267);
            this.Lbl_Date11.Name = "Lbl_Date11";
            this.Lbl_Date11.Size = new System.Drawing.Size(19, 13);
            this.Lbl_Date11.TabIndex = 0;
            this.Lbl_Date11.Text = "11";
            // 
            // Lbl_Date3
            // 
            this.Lbl_Date3.AutoSize = true;
            this.Lbl_Date3.Location = new System.Drawing.Point(81, 267);
            this.Lbl_Date3.Name = "Lbl_Date3";
            this.Lbl_Date3.Size = new System.Drawing.Size(13, 13);
            this.Lbl_Date3.TabIndex = 0;
            this.Lbl_Date3.Text = "3";
            // 
            // Lbl_Date13
            // 
            this.Lbl_Date13.AutoSize = true;
            this.Lbl_Date13.Location = new System.Drawing.Point(367, 267);
            this.Lbl_Date13.Name = "Lbl_Date13";
            this.Lbl_Date13.Size = new System.Drawing.Size(19, 13);
            this.Lbl_Date13.TabIndex = 2;
            this.Lbl_Date13.Text = "13";
            // 
            // Lbl_Date5
            // 
            this.Lbl_Date5.AutoSize = true;
            this.Lbl_Date5.Location = new System.Drawing.Point(137, 267);
            this.Lbl_Date5.Name = "Lbl_Date5";
            this.Lbl_Date5.Size = new System.Drawing.Size(13, 13);
            this.Lbl_Date5.TabIndex = 2;
            this.Lbl_Date5.Text = "5";
            // 
            // Lbl_Date10
            // 
            this.Lbl_Date10.AutoSize = true;
            this.Lbl_Date10.Location = new System.Drawing.Point(281, 267);
            this.Lbl_Date10.Name = "Lbl_Date10";
            this.Lbl_Date10.Size = new System.Drawing.Size(19, 13);
            this.Lbl_Date10.TabIndex = 2;
            this.Lbl_Date10.Text = "10";
            // 
            // Lbl_Date2
            // 
            this.Lbl_Date2.AutoSize = true;
            this.Lbl_Date2.Location = new System.Drawing.Point(50, 267);
            this.Lbl_Date2.Name = "Lbl_Date2";
            this.Lbl_Date2.Size = new System.Drawing.Size(13, 13);
            this.Lbl_Date2.TabIndex = 2;
            this.Lbl_Date2.Text = "2";
            // 
            // Lbl_Date9
            // 
            this.Lbl_Date9.AutoSize = true;
            this.Lbl_Date9.Location = new System.Drawing.Point(254, 267);
            this.Lbl_Date9.Name = "Lbl_Date9";
            this.Lbl_Date9.Size = new System.Drawing.Size(13, 13);
            this.Lbl_Date9.TabIndex = 2;
            this.Lbl_Date9.Text = "9";
            // 
            // Lbl_Date1
            // 
            this.Lbl_Date1.AutoSize = true;
            this.Lbl_Date1.Location = new System.Drawing.Point(19, 267);
            this.Lbl_Date1.Name = "Lbl_Date1";
            this.Lbl_Date1.Size = new System.Drawing.Size(13, 13);
            this.Lbl_Date1.TabIndex = 2;
            this.Lbl_Date1.Text = "1";
            // 
            // Lbl_14Days_Report
            // 
            this.Lbl_14Days_Report.AutoSize = true;
            this.Lbl_14Days_Report.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_14Days_Report.Location = new System.Drawing.Point(19, 5);
            this.Lbl_14Days_Report.Name = "Lbl_14Days_Report";
            this.Lbl_14Days_Report.Size = new System.Drawing.Size(410, 27);
            this.Lbl_14Days_Report.TabIndex = 0;
            this.Lbl_14Days_Report.Text = "Last 14 Days Sales Report (Sales Count)";
            // 
            // Panel_Report_Container
            // 
            this.Panel_Report_Container.Controls.Add(this.Panel_14Days_Report);
            this.Panel_Report_Container.Controls.Add(this.Panel_Yearly_Report);
            this.Panel_Report_Container.Controls.Add(this.Panel_Generate_Report);
            this.Panel_Report_Container.Controls.Add(this.Panel_Today_Report);
            this.Panel_Report_Container.Controls.Add(this.Panel_Footer);
            this.Panel_Report_Container.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panel_Report_Container.Location = new System.Drawing.Point(10, 39);
            this.Panel_Report_Container.Name = "Panel_Report_Container";
            this.Panel_Report_Container.Size = new System.Drawing.Size(1002, 627);
            this.Panel_Report_Container.TabIndex = 2;
            // 
            // Lbl_Report_Header
            // 
            this.Lbl_Report_Header.AutoSize = true;
            this.Lbl_Report_Header.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lbl_Report_Header.Font = new System.Drawing.Font("Microsoft YaHei", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Report_Header.Location = new System.Drawing.Point(3, 0);
            this.Lbl_Report_Header.Name = "Lbl_Report_Header";
            this.Lbl_Report_Header.Size = new System.Drawing.Size(949, 33);
            this.Lbl_Report_Header.TabIndex = 0;
            this.Lbl_Report_Header.Text = "Reports";
            this.Lbl_Report_Header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Panel_Header
            // 
            this.Panel_Header.ColumnCount = 2;
            this.Panel_Header.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Panel_Header.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.Panel_Header.Controls.Add(this.Btn_Refresh, 1, 0);
            this.Panel_Header.Controls.Add(this.Lbl_Report_Header, 0, 0);
            this.Panel_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Header.Location = new System.Drawing.Point(10, 0);
            this.Panel_Header.Name = "Panel_Header";
            this.Panel_Header.RowCount = 1;
            this.Panel_Header.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Panel_Header.Size = new System.Drawing.Size(1002, 33);
            this.Panel_Header.TabIndex = 5;
            // 
            // Btn_Refresh
            // 
            this.Btn_Refresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Refresh.BackgroundImage")));
            this.Btn_Refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Refresh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Btn_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Refresh.Location = new System.Drawing.Point(958, 3);
            this.Btn_Refresh.Name = "Btn_Refresh";
            this.Btn_Refresh.Size = new System.Drawing.Size(41, 27);
            this.Btn_Refresh.TabIndex = 6;
            this.Btn_Refresh.UseVisualStyleBackColor = true;
            this.Btn_Refresh.Click += new System.EventHandler(this.Btn_Refresh_Click);
            // 
            // Form_Admin_Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1022, 666);
            this.Controls.Add(this.Panel_Header);
            this.Controls.Add(this.Panel_Report_Container);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1022, 666);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1022, 666);
            this.Name = "Form_Admin_Reports";
            this.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form_Admin_Reports";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form_Admin_Reports_Load);
            this.Panel_Footer.ResumeLayout(false);
            this.Panel_Footer.PerformLayout();
            this.Panel_Today_Report.ResumeLayout(false);
            this.Panel_Today_Report.PerformLayout();
            this.Panel_Generate_Report.ResumeLayout(false);
            this.Panel_Generate_Report.PerformLayout();
            this.Panel_Yearly_Report.ResumeLayout(false);
            this.Panel_Yearly_Report.PerformLayout();
            this.Panel_14Days_Report.ResumeLayout(false);
            this.Panel_14Days_Report.PerformLayout();
            this.Panel_Report_Container.ResumeLayout(false);
            this.Panel_Header.ResumeLayout(false);
            this.Panel_Header.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel Panel_Footer;
        private System.Windows.Forms.Label Lbl_Generated_Time;
        private System.Windows.Forms.Panel Panel_Today_Report;
        private System.Windows.Forms.Label Lbl_Today_Amount_Value;
        private System.Windows.Forms.Label Lbl_Today_Count_Value;
        private System.Windows.Forms.Label Lbl_Today_Count;
        private System.Windows.Forms.Label Lbl_Today_Amount;
        private System.Windows.Forms.Label Lbl_Today_Report;
        private System.Windows.Forms.Panel Panel_Generate_Report;
        private System.Windows.Forms.Button Btn_Generate_Report;
        private System.Windows.Forms.DateTimePicker DateTime_Generate_Report_To;
        private System.Windows.Forms.DateTimePicker DateTime_Generate_Report_From;
        private System.Windows.Forms.Label Lbl_Generate_Report;
        private System.Windows.Forms.Label Lbl_Sales_Generate_To;
        private System.Windows.Forms.Label Lbl_Sales_Generate_From;
        private System.Windows.Forms.Panel Panel_Yearly_Report;
        private System.Windows.Forms.Label Lbl_Yearly_Report;
        private System.Windows.Forms.Panel Panel_14Days_Report;
        private System.Windows.Forms.Label Lbl_14Days_Report;
        private System.Windows.Forms.FlowLayoutPanel Panel_Report_Container;
        private System.Windows.Forms.Label Lbl_Report_Header;
        private System.Windows.Forms.TableLayoutPanel Panel_Header;
        private System.Windows.Forms.Button Btn_Refresh;
        private System.Windows.Forms.Label Lbl_Date1;
        private System.Windows.Forms.Label Lbl_Date8;
        private System.Windows.Forms.Label Lbl_Date12;
        private System.Windows.Forms.Label Lbl_Date4;
        private System.Windows.Forms.Label Lbl_Date7;
        private System.Windows.Forms.Label Lbl_Date14;
        private System.Windows.Forms.Label Lbl_Date6;
        private System.Windows.Forms.Label Lbl_Date11;
        private System.Windows.Forms.Label Lbl_Date3;
        private System.Windows.Forms.Label Lbl_Date13;
        private System.Windows.Forms.Label Lbl_Date5;
        private System.Windows.Forms.Label Lbl_Date10;
        private System.Windows.Forms.Label Lbl_Date2;
        private System.Windows.Forms.Label Lbl_Date9;
        private XanderUI.XUILineGraph Graph_14Days_Report;
        private System.Windows.Forms.Panel panel1;
        private XanderUI.XUIBarGraph Graph_Yearly_Report;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label13;
    }
}