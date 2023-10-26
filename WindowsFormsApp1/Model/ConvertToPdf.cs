using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
  public static  class ConvertToPdf
    {
        public static void ToPdf(this List<OrderViewModel> models)
        {
            string CountOrders = models.Count.ToString();
            string TotalPrice = models.Select(x => new { total = x.Total }).Sum(x => x.total).ToString();
            Document document = new Document();

            // Set the file stream and writer
            //FileStream fs = new FileStream("Invoice.pdf", FileMode.Create);

            FileStream fs = new FileStream("file.pdf", FileMode.Create);
            
                PdfWriter writer = PdfWriter.GetInstance(document, fs);

            // Open the document for writing

            document.Open();
            // Add content to the document
            
                document.Add(new Paragraph("Count Orders:" +CountOrders));
                document.Add(new Paragraph("Total " +TotalPrice));
               
            


            // Close the document
            document.Close();
            fs.Close();
            writer.Close();


        }
    }
}
