using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Collections.Generic;
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

                    // Open the document for writing
                    document.Open();

                    // Add content to the document
                    document.Add(new Paragraph("Count Orders: " + CountOrders));
                    document.Add(new Paragraph("Total Price: " + TotalPrice.ToString("C"))); // Format as currency

                    // Close the document
                    document.Close();
                    writer.Close();
                }


            }
        }
    }
}
