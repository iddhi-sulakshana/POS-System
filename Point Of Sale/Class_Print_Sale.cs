using System;
using System.Collections.Generic;
using System.IO;
using System.Diagnostics;
// used framework for edit and create pdf
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Point_Of_Sale
{
    internal class Class_Print_Sale : Form_Preview_Sale
    {
        // Custom Fonts for editing pdf
        readonly private Font ArialBI = FontFactory.GetFont("Arial", 25, iTextSharp.text.Font.BOLDITALIC);
        readonly private Font ArialB = FontFactory.GetFont("Arial", 15, iTextSharp.text.Font.BOLD);
        readonly private Font Calibri = FontFactory.GetFont("Calibri Light", 15);

        // create printable pdf and display it to the user
        public void Print_Sale(SaleStruct SaleReceived)
        {
            SaleDetails = SaleReceived;
            // sinhala font for add currency sign in the report
            BaseFont Bindumathi = BaseFont.CreateFont(Path.Combine(Directory.GetCurrentDirectory(), "Resources\\FM Bindumathi.TTF"), BaseFont.IDENTITY_H, BaseFont.EMBEDDED, true, Properties.Resources.FM_Bindumathi, null);
            Font Sinhala = new Font(Bindumathi, 15);
            // check if directory exist otherwise create new directory
            if (!Directory.Exists(Path.Combine(UserPath, "Sale")))
            {
                Directory.CreateDirectory(Path.Combine(UserPath, "Sale"));
            }
            // check if file is already exist then delete
            if(File.Exists(Path.Combine(UserPath, $"Sale\\Sale_{SaleDetails.Id}.pdf")))
            {
                File.Delete(Path.Combine(UserPath, $"Sale\\Sale_{SaleDetails.Id}.pdf"));
            }
            // create pdffile and use
            FileStream PdfFile = new FileStream(Path.Combine(UserPath, $"Sale\\Sale_{SaleDetails.Id}.pdf"), FileMode.Append, FileAccess.Write, FileShare.None);
            // create pdf file
            Rectangle Rec = new Rectangle(PageSize.A4)
            {
                BackgroundColor = new CMYKColor(0, 5, 20, 0)
            };
            Document Sale_Document = new Document(Rec, 35, 35, 35, 35);
            _ = PdfWriter.GetInstance(Sale_Document, PdfFile);
            Sale_Document.Open();

            // insert company logo
            Image Logo = Image.GetInstance(Path.Combine(UserPath, "Logo.png"));
            Logo.Alignment = Element.ALIGN_CENTER;
            Logo.ScaleToFitHeight = true;
            Logo.ScaleToFit(120f, 120f);
            Sale_Document.Add(Logo);

            // get company details and insert
            string[] Lines = File.ReadAllLines(Path.Combine(UserPath, "Company.txt"));
            Paragraph ParagraphTxt = Get_Paragraph(Lines[0], ArialBI, "center", -1, 8);
            Sale_Document.Add(ParagraphTxt);

            ParagraphTxt = Get_Paragraph(Lines[2], Calibri, "center", 0, 0);
            Sale_Document.Add(ParagraphTxt);

            ParagraphTxt = Get_Paragraph(Lines[3], Calibri, "center", 0, 0);
            Sale_Document.Add(ParagraphTxt);

            ParagraphTxt = Get_Paragraph(Lines[1], Calibri, "center", 0, 0);
            Sale_Document.Add(ParagraphTxt);

            ParagraphTxt = Get_Paragraph(" ", Calibri, "center", -1, -1);
            Sale_Document.Add(ParagraphTxt);

            // get customer name and insert
            Class_Customer Customer = new Class_Customer();
            ParagraphTxt = Get_Paragraph($"Bill To : {Customer.Get_Customer_Name(SaleDetails.Customer)}", Calibri, "left", 5, 5);
            Sale_Document.Add(ParagraphTxt);

            // insert sale id and date
            PdfPTable Table = new PdfPTable(2);
            float[] headers = { 50, 50 };
            Table.SetWidths(headers);
            Table.WidthPercentage = 100;
            Table.AddCell(new PdfPCell(Get_Paragraph($"Sale : #{SaleDetails.Id}", Calibri, "left", -1, -1)) { HorizontalAlignment = Element.ALIGN_LEFT}).Border = Rectangle.NO_BORDER;
            Table.AddCell(new PdfPCell(Get_Paragraph($"Date : {SaleDetails.Date.ToString("yyyy/MM/dd hh:mm:ss tt")}", Calibri, "right", -1, -1)) { HorizontalAlignment = Element.ALIGN_RIGHT }).Border = Rectangle.NO_BORDER;
            Sale_Document.Add(Table);
            
            //insert some blank space
            ParagraphTxt = Get_Paragraph(" ", Calibri, "center", -1, -1);
            Sale_Document.Add(ParagraphTxt);

            // insert products
            Table = Get_Products(SaleDetails.Products);
            Sale_Document.Add(Table);

            //insert some blank space
            ParagraphTxt = Get_Paragraph(" ", Calibri, "center", -1, -1);
            Sale_Document.Add(ParagraphTxt);

            // insert total, discount and subtotal
            headers = new float[] { 75, 25 };
            Table = new PdfPTable(2);
            Table.SetWidths(headers);
            Table.WidthPercentage = 100;
            Table.AddCell(new PdfPCell(Get_Paragraph("Total ", ArialB, "left", -1, -1)) { HorizontalAlignment = Element.ALIGN_RIGHT }).Border = Rectangle.NO_BORDER;

            ParagraphTxt = new Paragraph
            {
                new Chunk("re ", Sinhala),
                new Chunk(Math.Round(SaleDetails.Total, 2).ToString("0,0.00"), Calibri)
            };

            Table.AddCell(new PdfPCell(ParagraphTxt) { HorizontalAlignment = Element.ALIGN_RIGHT }).Border = Rectangle.NO_BORDER;
            Table.AddCell(new PdfPCell(Get_Paragraph("Discount ", ArialB, "left", -1, -1)) { HorizontalAlignment = Element.ALIGN_RIGHT }).Border = Rectangle.NO_BORDER;
            Table.AddCell(new PdfPCell(Get_Paragraph((SaleDetails.Discount / 100).ToString("P02"), Calibri, "right", -1, -1)) { HorizontalAlignment = Element.ALIGN_RIGHT }).Border = Rectangle.NO_BORDER;
            Table.AddCell(new PdfPCell(Get_Paragraph("Subtotal ", ArialB, "left", -1, -1)) { HorizontalAlignment = Element.ALIGN_RIGHT }).Border = Rectangle.NO_BORDER;

            ParagraphTxt = new Paragraph
            {
                new Chunk("re ", Sinhala),
                new Chunk((SaleDetails.Total - (SaleDetails.Total * SaleDetails.Discount / 100)).ToString("0,0.00"), Calibri)
            };

            Table.AddCell(new PdfPCell(ParagraphTxt) { HorizontalAlignment = Element.ALIGN_RIGHT }).Border = Rectangle.NO_BORDER;

            Sale_Document.Add(Table);

            //insert some blank space
            ParagraphTxt = Get_Paragraph(" ", Calibri, "center", -1, -1);
            Sale_Document.Add(ParagraphTxt);

            // insert footer note
            ParagraphTxt = Get_Paragraph($"Issued @ {DateTime.Now:yyyy/MM/dd hh:mm:ss tt}", Calibri, "left", -1, -1);
            Sale_Document.Add(ParagraphTxt);

            // close the pdf editor and open the file
            Sale_Document.Close();
            Process.Start(Path.Combine(UserPath, $"Sale\\Sale_{SaleDetails.Id}.pdf"));
        }

        // return paragraph by passing paragraph's text,style, alignment space before and space after
        private Paragraph Get_Paragraph(String Text, Font Style, string Alignment, int SBefore, int SAfter)
        {
            Paragraph Paragraph = new Paragraph(Text, Style);
            switch (Alignment)
            {
                case "center":
                    Paragraph.Alignment = Element.ALIGN_CENTER;
                    break;
                case "left":
                    Paragraph.Alignment = Element.ALIGN_LEFT;
                    break;
                case "right":
                    Paragraph.Alignment = Element.ALIGN_RIGHT;
                    break;
            }
            if(SBefore != -1)
            {
                Paragraph.SpacingBefore = SBefore;
            }
            if(SAfter != -1)
            {
                Paragraph.SpacingAfter = SAfter;
            }
            return Paragraph;
        }
        
        // return table that consist of product details by using productstruct list as parameters
        private PdfPTable Get_Products(List<ProductStruct> Products)
        {
            float[] headers = { 35, 15, 25, 25 };
            PdfPTable TableProduct = new PdfPTable(4);
            TableProduct.SetWidths(headers);
            TableProduct.WidthPercentage = 100;
            //Add Headers
            TableProduct.AddCell(new PdfPCell(Get_Paragraph("Name ", ArialB, "left", -1, -1)) { HorizontalAlignment = Element.ALIGN_LEFT, VerticalAlignment = Element.ALIGN_MIDDLE, UseAscender = true, Padding = 8 });
            TableProduct.AddCell(new PdfPCell(Get_Paragraph("Quantity ", ArialB, "left", -1, -1)) { HorizontalAlignment = Element.ALIGN_CENTER, VerticalAlignment = Element.ALIGN_MIDDLE, UseAscender = true, Padding = 8 });
            TableProduct.AddCell(new PdfPCell(Get_Paragraph("Price ", ArialB, "left", -1, -1)) { HorizontalAlignment = Element.ALIGN_RIGHT, VerticalAlignment = Element.ALIGN_MIDDLE, UseAscender = true, Padding = 8 });
            TableProduct.AddCell(new PdfPCell(Get_Paragraph("Amount ", ArialB, "left", -1, -1)) { HorizontalAlignment = Element.ALIGN_RIGHT, VerticalAlignment = Element.ALIGN_MIDDLE, UseAscender = true, Padding = 8 });

            foreach(ProductStruct Product in Products)
            {
                TableProduct.AddCell(new PdfPCell(Get_Paragraph(Product.Name, Calibri, "left", -1, -1)) { HorizontalAlignment = Element.ALIGN_LEFT, VerticalAlignment = Element.ALIGN_MIDDLE, UseAscender = true, Padding = 4 });
                TableProduct.AddCell(new PdfPCell(Get_Paragraph(Product.Unit.ToString(), Calibri, "left", -1, -1)) { HorizontalAlignment = Element.ALIGN_CENTER, VerticalAlignment = Element.ALIGN_MIDDLE, UseAscender = true, Padding = 4 });
                TableProduct.AddCell(new PdfPCell(Get_Paragraph(Math.Round(Product.Price, 2).ToString("0.00"), Calibri, "left", -1, -1)) { HorizontalAlignment = Element.ALIGN_RIGHT, VerticalAlignment = Element.ALIGN_MIDDLE, UseAscender = true, Padding = 4 });
                TableProduct.AddCell(new PdfPCell(Get_Paragraph(Math.Round(Product.Price * Product.Unit, 2).ToString("0.00"), Calibri, "left", -1, -1)) { HorizontalAlignment = Element.ALIGN_RIGHT, VerticalAlignment = Element.ALIGN_MIDDLE, UseAscender = true, Padding = 4 });
            }

            return TableProduct;
        }
    }
}
