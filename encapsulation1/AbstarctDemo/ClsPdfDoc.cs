using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstarctDemo
{
    public abstract class ClsPdfDoc
    {
        public abstract class ClsPdfCreation
        {
            public void CreatePdfDoc()
            {
                string pdfName = "User";
               // Response.AddHeader("Content-Disposition", "attachment; filename=" + pdfName + ".pdf");
             //   Response.ContentType = "application/pdf";
               // Response.Buffer = true;
                //Response.Cache.SetCacheability(System.Web.HttpCacheability.NoCache);
                //Response.BinaryWrite(bytes);
                //Response.End();
               // Response.Close();
            }

            public void Printproduct()
            {
                //string Filepath = @"C:\Users\sdkca\Desktop\path-to-your-pdf\pdf-sample.pdf";

            }

            public abstract string GetFilePath();

            public virtual string GetFileDetails()
            {
                string fileContant = "Testing Abstract and virtual";
                return fileContant;
            }


            public abstract string GetFilePath();

            public virtual string GetFileDetails()
            {
                string fileContant = "Testing Abstract and virtual";
                return fileContant;
            }


        }
    }
}
