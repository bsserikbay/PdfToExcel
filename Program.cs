using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using PdfSharp.Pdf.IO;
using PdfSharp.Pdf;
using PdfSharp.Pdf.AcroForms;
using System.Reflection.Metadata;

namespace PdfToExcel
{

    internal class Program
    {
        private static void Main(string[] args)
        {
            string path = @"C:\Users\vfkw\2\043-0000-PPP-GAD-000-000-00017-01_U01_RED_43-9100-SH-SH3-SH3_K-500-182-ON.pdf";
            PdfDocument pdfDocument = PdfReader.Open(path, PdfDocumentOpenMode.ReadOnly);
            PdfAcroForm form = pdfDocument.AcroForm;
            PdfAcroField.PdfAcroFieldCollection fields = form.Fields;

            for(var i =0; i< fields.Count(); i++)
            {
                if(fields[i] is )
                    Console.WriteLine($"{fields[i]}");
            }
            


        }

    }
}
