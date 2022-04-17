using System;
using System.Collections.Generic;
using System.IO;
using System.Diagnostics;
using System.Drawing;
using System.Threading.Tasks;
// used framework for create and edit excel file
using Microsoft.Office.Interop.Excel;

namespace Point_Of_Sale
{
    internal class Class_Generate_Reports
    {
        // path for the excel file (Users/MyDocument/PointOfSale/Reports)
        string ExcelPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "PointOfSale\\Reports");
        
        // generate report for Send sale list Report, Product report, Customer Report, User report and out of stock report
        public void Generate_Reports(List<SaleStruct> Sales)
        {
            // check if directory is not exist then create new
            if (!Directory.Exists(ExcelPath))
            {
                Directory.CreateDirectory(ExcelPath);
            }
            // add excel name for path to access it easily later on
            ExcelPath = Path.Combine(ExcelPath, "Generated Report.xlsx");
            // check if excel file is exist in the path with same name
            if (File.Exists(ExcelPath))
            {
                /// if the excel file exist and opened it need to close otherwise
                /// encounter exception for file in used by another process and cant 
                /// save/update or delete file
                if (IsFileLocked(ExcelPath))
                {
                    foreach (var process in Process.GetProcessesByName("excel")) 
                    {
                            process.Kill();
                    }
                    /// there is taking some time to kill the process so need to sleep for
                    /// few seconds otherwise delete command will quickly execute before closing
                    /// the application
                    System.Threading.Thread.Sleep(1500);
                }
                File.Delete(ExcelPath);
            }
            // create excel and add sheets to the excel book
            Application ExcelApp = new Application();
            Workbook workbook = ExcelApp.Workbooks.Add();

            Worksheet worksheet = workbook.ActiveSheet;
            Worksheet worksheet1 = workbook.Worksheets.Add(worksheet);
            Worksheet worksheet2 = workbook.Worksheets.Add(worksheet);
            Worksheet worksheet3 = workbook.Worksheets.Add(worksheet);

            Task task1 = Task.Run(() =>
            {
                worksheet = Get_Customer_Sheet(worksheet);
            });
            Task task2 = Task.Run(() =>
            {
                worksheet1 = Get_OutOfStock_Report_Sheet(worksheet1);
            });
            Task task3 = Task.Run(() =>
            {
                worksheet2 = Get_Product_Report_Sheet(worksheet2);
            });
            Task task4 = Task.Run(() =>
            {
                worksheet3 = Get_Sale_Report_Sheet(worksheet3, Sales);
            });
            task1.Wait();
            task2.Wait();
            task3.Wait();
            task4.Wait();
            //saving excel and close
            workbook.SaveAs(ExcelPath);
            workbook.Close();
            System.Threading.Thread.Sleep(1000);
            // open the saved excel file
            Process.Start(ExcelPath);
        }
        
        // check if file is using another process
        private bool IsFileLocked(string filePath)
        {
            bool lockStatus = false;
            try
            {
                using (FileStream fileStream = File.Open(filePath, FileMode.Open, FileAccess.ReadWrite, FileShare.None))
                {
                    lockStatus = !fileStream.CanWrite;
                }
            }
            catch
            {
                lockStatus = true;
            }
            return lockStatus;
        }
        
        // Generate sale report sheet data
        private Worksheet Get_Sale_Report_Sheet(Worksheet worksheet, List<SaleStruct> Sales)
        {
            worksheet.Name = "Sale Report";
            // Insert Header
            worksheet.Cells.Font.Size = 12;
            worksheet.Columns.get_Range("A:A").ColumnWidth = 13;
            worksheet.Cells[1, 1].Value = "Sale Id";
            worksheet.Columns.get_Range("B:B").ColumnWidth = 15;
            worksheet.Cells[1, 2].Value = "Customer";
            worksheet.Columns.get_Range("C:C").ColumnWidth = 18;
            worksheet.Cells[1, 3].Value = "Date";
            worksheet.Columns.get_Range("D:D").ColumnWidth = 12;
            worksheet.Cells[1, 4].Value = "Payment";
            worksheet.Columns.get_Range("E:E").ColumnWidth = 18;
            worksheet.Columns.get_Range("E:E").NumberFormat = "[$රු-si-LK] #,###,##0.00";
            worksheet.Cells[1, 5].Value = "Total";
            worksheet.Columns.get_Range("F:F").ColumnWidth = 18;
            worksheet.Columns.get_Range("F:F").NumberFormat = "##0%";
            worksheet.Cells[1, 6].Value = "Discount";
            worksheet.Columns.get_Range("G:G").ColumnWidth = 25;
            worksheet.Columns.get_Range("G:G").NumberFormat = "[$රු-si-LK] #,###,##0.00";
            worksheet.Cells[1, 7].Value = "Subtotal";
            worksheet.Columns.get_Range("A:B,D:D").HorizontalAlignment = XlHAlign.xlHAlignCenter;
            // Header Formatting
            Range Formatting;
            Formatting = worksheet.get_Range("a1", "g1");
            Formatting.EntireRow.Font.Bold = true;
            Formatting.EntireRow.Font.Size = 14;
            Formatting.EntireRow.Font.Name = "Arial";
            Formatting.EntireRow.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            worksheet.Columns.VerticalAlignment = XlHAlign.xlHAlignCenter;

            // Insert sale items
            if(Sales.Count > 0)
            {
                int i = 2;
                foreach (SaleStruct Sale in Sales)
                {
                    worksheet.Cells[i, 1].Value = Sale.Id;
                    worksheet.Cells[i, 2].Value = Sale.Customer;
                    worksheet.Cells[i, 3].Value = Sale.Date;
                    worksheet.Cells[i, 4].Value = Sale.Payment;
                    worksheet.Cells[i, 5].Value = (Sale.Subtotal / (100 - Sale.Discount) * 100);
                    worksheet.Cells[i, 6].Value = Sale.Discount/100;
                    worksheet.Cells[i, 7].Formula = $"={worksheet.Cells[i, 5].Address}-({worksheet.Cells[i, 5].Address}*{worksheet.Cells[i, 6].Address})";
                    i++;
                }
                worksheet.Cells[i, 6].Value = "Total Sales";
                Formatting = worksheet.Cells[i, 6];
                Formatting.Cells.Font.Bold = true;
                Formatting.Cells.Font.Size = 14;
                Formatting.Cells.Font.Name = "Arial Black";
                Formatting.Cells.HorizontalAlignment = XlHAlign.xlHAlignRight;
                worksheet.Cells[i, 7].Formula = $"=SUM({worksheet.Cells[2,7].Address}:{worksheet.Cells[i-1,7].Address})";
                Formatting = worksheet.Cells[i, 7];
                Formatting.Cells.Font.Bold = true;
                Formatting.Cells.Font.Size = 14;
                Formatting.Cells.NumberFormat = "[$රු-si-LK] #,###,##0.00";

            }
            else
            {
                worksheet.Range[worksheet.Cells[2, 1], worksheet.Cells[2, 7]].Merge();
                worksheet.Cells[2, 1].Value = "No results were Found in this time range";
                Formatting = worksheet.Cells[2,1];
                Formatting.Rows.Font.Bold = true;
                Formatting.Rows.Font.Size = 16;
                Formatting.Rows.Interior.Color = Color.Red;
            }
            return worksheet;
        }
        
        // Generate product report sheet data
        private Worksheet Get_Product_Report_Sheet(Worksheet worksheet)
        {
            worksheet.Name = "Product Report";
            // Insert Header
            worksheet.Cells.Font.Size = 12;
            worksheet.Columns.get_Range("A:A").ColumnWidth = 15;
            worksheet.Cells[1, 1].Value = "Product Id";
            worksheet.Columns.get_Range("B:B").ColumnWidth = 22;
            worksheet.Cells[1, 2].Value = "Product Name";
            worksheet.Columns.get_Range("C:C").ColumnWidth = 16;
            worksheet.Columns.get_Range("C:C").NumberFormat = "[$රු-si-LK] #,###,##0.00";
            worksheet.Cells[1, 3].Value = "Price";
            worksheet.Columns.get_Range("D:D").ColumnWidth = 14;
            worksheet.Cells[1, 4].Value = "Quantity";
            worksheet.Columns.get_Range("A:B,D:D").HorizontalAlignment = XlHAlign.xlHAlignCenter;
            // Header Formatting
            Range Formatting;
            Formatting = worksheet.get_Range("a1", "d1");
            Formatting.EntireRow.Font.Bold = true;
            Formatting.EntireRow.Font.Size = 14;
            Formatting.EntireRow.Font.Name = "Arial";
            Formatting.EntireRow.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            worksheet.Columns.VerticalAlignment = XlHAlign.xlHAlignCenter;

            // get products from database
            Class_Products Products = new Class_Products();
            List<ProductStruct> ProductList = Products.Retrieve_Products(false);
            // insert products
            if (ProductList.Count > 0)
            {
                int i = 2;
                foreach (ProductStruct Product in ProductList)
                {
                    worksheet.Cells[i, 1].Value = Product.Id;
                    worksheet.Cells[i, 2].Value = Product.Name;
                    worksheet.Cells[i, 3].Value = Product.Price;
                    worksheet.Cells[i, 4].Value = Product.Unit;
                    i++;
                }
                ChartObjects ExcelCharts = worksheet.ChartObjects();
                ChartObject ExcelChartObject = ExcelCharts.Add(460, 0, 432, 360);
                Chart ExcelChart = ExcelChartObject.Chart;
                ExcelChart.HasTitle = true;
                ExcelChart.ChartTitle.Text = "Product Stock";
                ExcelChart.ChartType = XlChartType.xlPie;
                Formatting = worksheet.get_Range($"=$B$1:$B${i-1}, $D$1:$D${i-1}");
                ExcelChart.SetSourceData(Formatting);
                ExcelChart.ApplyDataLabels(XlDataLabelsType.xlDataLabelsShowValue);
            }
            else
            {
                worksheet.Range[worksheet.Cells[2, 1], worksheet.Cells[2, 4]].Merge();
                worksheet.Cells[2, 1].Value = "No results were Found";
                Formatting = worksheet.Cells[2, 1];
                Formatting.Rows.Font.Bold = true;
                Formatting.Rows.Font.Size = 16;
                Formatting.Rows.Interior.Color = Color.Red;
            }
            return worksheet;
        }
        
        // Generate out of stock report sheet data
        private Worksheet Get_OutOfStock_Report_Sheet(Worksheet worksheet)
        {
            worksheet.Name = "Out Of Stock";
            // Insert Header
            worksheet.Cells.Font.Size = 12;
            worksheet.Columns.get_Range("A:A").ColumnWidth = 15;
            worksheet.Cells[1, 1].Value = "Product Id";
            worksheet.Columns.get_Range("B:B").ColumnWidth = 22;
            worksheet.Cells[1, 2].Value = "Product Name";
            worksheet.Columns.get_Range("C:C").ColumnWidth = 16;
            worksheet.Columns.get_Range("C:C").NumberFormat = "[$රු-si-LK] #,###,##0.00";
            worksheet.Cells[1, 3].Value = "Price";
            worksheet.Columns.get_Range("D:D").ColumnWidth = 14;
            worksheet.Cells[1, 4].Value = "Quantity";
            worksheet.Columns.get_Range("A:B,D:D").HorizontalAlignment = XlHAlign.xlHAlignCenter;
            // Header Formatting
            Range Formatting;
            Formatting = worksheet.get_Range("a1", "d1");
            Formatting.EntireRow.Font.Bold = true;
            Formatting.EntireRow.Font.Size = 14;
            Formatting.EntireRow.Font.Name = "Arial";
            Formatting.EntireRow.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            worksheet.Columns.VerticalAlignment = XlHAlign.xlHAlignCenter;

            // get products from database
            Class_Products Products = new Class_Products();
            List<ProductStruct> ProductList = Products.Get_Empty_Products();
            // insert products
            if (ProductList.Count > 0)
            {
                int i = 2;
                foreach (ProductStruct Product in ProductList)
                {
                    worksheet.Cells[i, 1].Value = Product.Id;
                    worksheet.Cells[i, 2].Value = Product.Name;
                    worksheet.Cells[i, 3].Value = Product.Price;
                    worksheet.Cells[i, 4].Value = Product.Unit;
                    i++;
                }
            }
            else
            {
                worksheet.Range[worksheet.Cells[2, 1], worksheet.Cells[2, 4]].Merge();
                worksheet.Cells[2, 1].Value = "No results were Found";
                Formatting = worksheet.Cells[2, 1];
                Formatting.Rows.Font.Bold = true;
                Formatting.Rows.Font.Size = 16;
                Formatting.Rows.Interior.Color = Color.Red;
            }
            return worksheet;
        }
        
        // Generate customer report sheet data
        private Worksheet Get_Customer_Sheet(Worksheet worksheet)
        {
            worksheet.Name = "Customers";
            // Insert Header
            worksheet.Cells.Font.Size = 12;
            worksheet.Columns.get_Range("A:A").ColumnWidth = 15;
            worksheet.Cells[1, 1].Value = "Customer Id";
            worksheet.Columns.get_Range("B:B").ColumnWidth = 20;
            worksheet.Cells[1, 2].Value = "Customer Name";
            worksheet.Columns.get_Range("C:C").ColumnWidth = 30;
            worksheet.Columns.get_Range("C:C").WrapText = true;
            worksheet.Cells[1, 3].Value = "Address";
            worksheet.Columns.get_Range("D:D").NumberFormat = "@";
            worksheet.Columns.get_Range("D:D").ColumnWidth = 14;
            worksheet.Cells[1, 4].Value = "Phone";
            worksheet.Columns.get_Range("A:B,D:D").HorizontalAlignment = XlHAlign.xlHAlignCenter;
            // Header Formatting
            Range Formatting;
            Formatting = worksheet.get_Range("a1", "d1");
            Formatting.EntireRow.Font.Bold = true;
            Formatting.EntireRow.Font.Size = 14;
            Formatting.EntireRow.Font.Name = "Arial";
            Formatting.EntireRow.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            worksheet.Columns.VerticalAlignment = XlHAlign.xlHAlignCenter;

            // get products from database
            Class_Customer Customers = new Class_Customer();
            List<CustomerStruct> CustomerList = Customers.Retrieve_Customers();
            // insert customers
            if (CustomerList.Count > 0)
            {
                int i = 2;
                foreach (CustomerStruct Customer in CustomerList)
                {
                    worksheet.Cells[i, 1].Value = Customer.Id;
                    worksheet.Cells[i, 2].Value = Customer.Name;
                    worksheet.Cells[i, 3].Value = Customer.Address;
                    worksheet.Cells[i, 4].Value = Customer.Phone;
                    i++;
                }
            }
            else
            {
                worksheet.Range[worksheet.Cells[2, 1], worksheet.Cells[2, 4]].Merge();
                worksheet.Cells[2, 1].Value = "No results were Found";
                Formatting = worksheet.Cells[2, 1];
                Formatting.Rows.Font.Bold = true;
                Formatting.Rows.Font.Size = 16;
                Formatting.Rows.Interior.Color = Color.Red;
            }
            return worksheet;
        }
    }
}
