using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Globalization;
namespace Point_Of_Sale
{
    public partial class Form_Admin_Reports : Form
    {
        // used for change currency for rupees
        readonly CultureInfo Lanka = new CultureInfo("si-LK");

        public Form_Admin_Reports()
        {
            InitializeComponent();
        }

        readonly Class_Sale Sales = new Class_Sale();

        // load report details
        private void Form_Admin_Reports_Load(object sender, EventArgs e)
        {
            Refresh_Reports();
        }

        // reload refresh details
        private void Btn_Refresh_Click(object sender, EventArgs e)
        {
            Refresh_Reports();
        }

        // refresh all the reports
        private void Refresh_Reports()
        {
            // Refresh all the reports in the Admin_Reports
            Update_14Days_Report();
            Update_Yearly_Report();
            Update_Today_Report();
            DateTime date = DateTime.Now;
            Lbl_Generated_Time.Text = $"Report Generated at {date.Year}.{date.Month}.{date.Day} {date.Hour}:{date.Minute}:{date.Second}{date.ToString("tt")}";
        }

        // validate date user inserted
        private void DateTime_Generate_Report_Validate(object sender, EventArgs e)
        {
            // validate user input From and To Date
            string[] FromDate = DateTime_Generate_Report_From.Value.ToShortDateString().Split('/');
            string[] ToDate = DateTime_Generate_Report_To.Value.ToShortDateString().Split('/');
            int From = int.Parse(FromDate[2] + FromDate[0] + FromDate[1]);
            int To = int.Parse(ToDate[2] + ToDate[0] + ToDate[1]);
            string Date = DateTime.Now.ToShortDateString();
            int Current_Date = int.Parse(Date.Split('/')[2] + Date.Split('/')[0] + Date.Split('/')[1]);
            if (To > Current_Date)
            {
                To = Current_Date;
                DateTime_Generate_Report_To.Value = Convert.ToDateTime(Date);
            }
            if (From > To)
            {
                DateTime_Generate_Report_From.Value = DateTime_Generate_Report_To.Value;
            }
        }

        // update 14 days report graph by usign getting sale count from the database
        private void Update_14Days_Report()
        {
            DateTime CurrentDate = DateTime.Now;
            List<Label> Labels = new List<Label> { Lbl_Date1, Lbl_Date2, Lbl_Date3, Lbl_Date4, Lbl_Date5, Lbl_Date6, Lbl_Date7, Lbl_Date8, Lbl_Date9, Lbl_Date10, Lbl_Date11, Lbl_Date12, Lbl_Date13, Lbl_Date14};
            TimeSpan ADay = new TimeSpan(1, 0, 0, 0);
            CurrentDate = CurrentDate.Subtract(new TimeSpan(13, 0, 0, 0));
            for(int i = 0; i < 14; i++)
            {
                Labels[i].Text = CurrentDate.ToString("dd");
                Graph_14Days_Report.Items[i] = Sales.Get_Date_Sale_Count(CurrentDate)+1;
                CurrentDate = CurrentDate.Add(ADay);
            }
            Graph_14Days_Report.Items[14] = Graph_14Days_Report.Items[13];
            Graph_14Days_Report.Refresh();
        }

        // update yearly report graph by usign getting sale count from the database
        private void Update_Yearly_Report()
        {
            for(int i = 0; i < 12; i++)
            {
                Graph_Yearly_Report.Items[i] = Sales.Get_Monthly_Sale_Count(int.Parse(DateTime.Now.Year.ToString()), i+1);
                Graph_Yearly_Report.Refresh();
            }
        }

        // update today sale count and amount by getting details from database
        private void Update_Today_Report()
        {
            Lbl_Today_Amount_Value.Text = string.Format(Lanka, "{0:c}", Sales.Get_Today_Sale_Amount());
            Lbl_Today_Count_Value.Text = $"{Sales.Get_Today_Sale_Count().ToString("0,0")} Sales";
        }

        // generate report and open it
        private void Btn_Generate_Report_Click(object sender, EventArgs e)
        {
            Btn_Generate_Report.Text = "Generating";
            this.Cursor = Cursors.WaitCursor;
            Btn_Generate_Report.Enabled = false;
            //Generate report and show window to save it to the local machine
            Class_Generate_Reports Generate = new Class_Generate_Reports();
            Generate.Generate_Reports(Sales.Get_Timed_Sales(DateTime_Generate_Report_From.Value, DateTime_Generate_Report_To.Value));
            Btn_Generate_Report.Enabled = true;
            this.Cursor = Cursors.Default;
            Btn_Generate_Report.Text = "Generate";
        }
    }
}
