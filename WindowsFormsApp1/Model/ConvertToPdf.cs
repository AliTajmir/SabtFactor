using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace WindowsFormsApp1
{
    public static class ConvertToPdf
    {
        public static void ToPdf(this List<OrderViewModel> models)
        {
            string CountOrders = models.Count.ToString();
            decimal TotalPrice = models.Sum(x => x.Total);
            string filePath = "file.pdf";

            using (FileStream fs = new FileStream(filePath, FileMode.Create))
            {
                using (Document document = new Document())
                {
                    PdfWriter writer = PdfWriter.GetInstance(document, fs);               
                    document.Open();
                    document.Add(new Paragraph("Count Orders: " + CountOrders));
                    document.Add(new Paragraph("Total Price: " + TotalPrice.ToString()));
                    document.Add(new Paragraph("\n\n"));
                    PdfPTable table = new PdfPTable(4); // Create a table with 4 columns
                    table.DefaultCell.Padding = 5;
                    table.AddCell("Product Name");
                    table.AddCell("Count");
                    table.AddCell("Price");
                    table.AddCell("Total");
                    

                    foreach (var product in models)
                    {
                        var totalProductPrice = product.count * product.Price;
                        table.AddCell(product.NameKala);
                        table.AddCell(product.count.ToString());
                        table.AddCell(product.Price.ToString());
                        table.AddCell(totalProductPrice.ToString());
                        
                    }

                    document.Add(table);
                    document.Close();
                    writer.Close();
                    Process.Start(new ProcessStartInfo
                    {
                        FileName = filePath,
                        UseShellExecute = true
                    });
                }


            }
        }
    }
}
