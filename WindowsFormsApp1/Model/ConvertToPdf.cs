﻿using iTextSharp.text;
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
