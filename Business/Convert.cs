using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Business
{
    public class Convert
    {
        //https://stackoverflow.com/questions/25164257/how-to-convert-html-to-pdf-using-itextsharp
        /**************************************************
        * Example #1                                     *
        *                                                *
        * Use the built-in HTMLWorker to parse the HTML. *
        * Only inline CSS is supported.                  *
        * ************************************************/
        public void HtmlAndInlineCssToPdfConvert(string html, string pdfLocation)
        {
            Byte[] bytes;

            using (MemoryStream ms = new MemoryStream())
            {
                using (Document doc = new Document())
                {
                    using (PdfWriter writer = PdfWriter.GetInstance(doc, ms))
                    {
                        doc.Open();
                        
                        using (iTextSharp.text.html.simpleparser.HTMLWorker htmlWorker = new iTextSharp.text.html.simpleparser.HTMLWorker(doc))
                        {
                            using (var sr = new StringReader(html))
                            {
                                htmlWorker.Parse(sr);
                            }
                        }

                        doc.Close();
                    }
                }

                bytes = ms.ToArray();

                string testFile = pdfLocation;
                File.WriteAllBytes(testFile, bytes);
            }
        }


        
        /**************************************************
        * Example #2                                     *
        *                                                *
        * Use the XMLWorker to parse the HTML.           *
        * Only inline CSS and absolutely linked          *
        * CSS is supported                               *
        * ************************************************/
        public void HtmlAndInlineLinkedCssToPdfConvert(string html, string pdfLocation)
        {
            Byte[] bytes;

            using (MemoryStream ms = new MemoryStream())
            {
                using (Document doc = new Document())
                {
                    using (PdfWriter writer = PdfWriter.GetInstance(doc, ms))
                    {
                        doc.Open();
                        
                        using (var srHtml = new StringReader(html))
                        {
                            iTextSharp.tool.xml.XMLWorkerHelper.GetInstance().ParseXHtml(writer, doc, srHtml);
                        }

                        doc.Close();
                    }
                }

                bytes = ms.ToArray();

                string testFile = pdfLocation;
                File.WriteAllBytes(testFile, bytes);
            }
        }


        
        /**************************************************
        * Example #3                                     *
        *                                                *
        * Use the XMLWorker to parse HTML and CSS        *
        * ************************************************/
        public void HtmlCssInDifferentDocToPdfConvert(string html, string css, string pdfLocation)
        {
            Byte[] bytes;

            using (MemoryStream ms = new MemoryStream())
            {
                using (Document doc = new Document())
                {
                    using (PdfWriter writer = PdfWriter.GetInstance(doc, ms))
                    {
                        doc.Open();

                        
                        using (MemoryStream msCss = new MemoryStream(Encoding.UTF8.GetBytes(css)))
                        {
                            using (var msHtml = new MemoryStream(Encoding.UTF8.GetBytes(html)))
                            {
                                iTextSharp.tool.xml.XMLWorkerHelper.GetInstance().ParseXHtml(writer, doc, msHtml, msCss);
                            }
                        }
                        
                        doc.Close();
                    }
                }

                bytes = ms.ToArray();

                string testFile = pdfLocation;
                File.WriteAllBytes(testFile, bytes);
            }
        }




        public string PathPreConvertEvents(string htmlPath, string cssPath, string jsPath, string outPath, string fileName)
        {
            if (string.IsNullOrWhiteSpace(htmlPath))
                return "";

            
            string html = "";
            string css = "";
            //string js = "";
            
            using (StreamReader reader = new StreamReader(htmlPath))
            {
                String line = String.Empty;
                while ((line = reader.ReadLine()) != null)
                {
                    html += line;
                }
            }

            if (!string.IsNullOrWhiteSpace(cssPath))
            {
                using (StreamReader reader = new StreamReader(cssPath))
                {
                    String line = String.Empty;
                    while ((line = reader.ReadLine()) != null)
                    {
                        css += line;
                    }
                }
            }

            //if (!string.IsNullOrWhiteSpace(jsPath))
            //{
            //    using (StreamReader reader = new StreamReader(jsPath))
            //    {
            //        String line = String.Empty;
            //        while ((line = reader.ReadLine()) != null)
            //        {
            //            js += line;
            //        }
            //    }
            //}

            return HtmlCssToPdfConvert(html, css: css, outPath: outPath,fileName: fileName);
        }
            
        public string HtmlCssToPdfConvert(string html, string css = "", string outPath = "", string fileName = "")
        {
            string pdfLocation = getFullPath(outPath, fileName);

            if (string.IsNullOrWhiteSpace(html))
                return "";


            if (string.IsNullOrWhiteSpace(css))
                HtmlAndInlineLinkedCssToPdfConvert(html, pdfLocation);

            HtmlCssInDifferentDocToPdfConvert(html, css, pdfLocation);

            return pdfLocation;
        }

        private string getFullPath(string outPath, string fileName)
        {
            if (string.IsNullOrWhiteSpace(outPath))
                outPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            if (string.IsNullOrWhiteSpace(fileName))
                outPath = Path.GetRandomFileName().Replace(".", "");

            return outPath + fileName;
        }
    }
}
