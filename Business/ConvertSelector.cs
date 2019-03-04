using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class ConvertSelector
    {
        public static string PathPreConvertEvents(ConverterLibrary lib, string htmlPath, string cssPath, string jsPath, string outPath, string fileName)
        {
            if (string.IsNullOrWhiteSpace(htmlPath))
                return "";


            string html = "";
            string css = "";
            string js = "";

            using (StreamReader reader = new StreamReader(htmlPath))
            {
                String line = String.Empty;
                while ((line = reader.ReadLine()) != null)
                {
                    html += line;
                }
                reader.Close();
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
                    reader.Close();
                }
            }

            if (!string.IsNullOrWhiteSpace(jsPath))
            {
                using (StreamReader reader = new StreamReader(jsPath))
                {
                    String line = String.Empty;
                    while ((line = reader.ReadLine()) != null)
                    {
                        js += line;
                    }
                }
            }

            return HtmlCssToPdfConvert(lib, html, css: css, js:js, outPath: outPath, fileName: fileName);
        }

        public static string HtmlCssToPdfConvert(ConverterLibrary lib, string html, string css = "", string js = "", string outPath = "", string fileName = "")
        {
            string pdfLocation = getFullPath(outPath, fileName);

            if (string.IsNullOrWhiteSpace(html))
                return "";
            

            if (lib == ConverterLibrary.ITextSharp)
            {
                Convert cn = new Convert();

                if (string.IsNullOrWhiteSpace(css))
                    cn.HtmlAndInlineLinkedCssToPdfConvert(html, pdfLocation);
                
                cn.HtmlCssInDifferentDocToPdfConvert(html, css, pdfLocation);
            }
            else if (lib == ConverterLibrary.IronPDF)
            {
                if (!string.IsNullOrWhiteSpace(css))
                {
                    css = (css.Contains("<style>")) ? (css) : ("<style>" + css + "</style>");
                    html += css;
                }

                if (!string.IsNullOrWhiteSpace(js))
                {
                    js = (js.Contains("<script>")) ? (js) : ("<script>" + js + "</script>");
                    html += js;
                }

                ConvertWithIronPdf cipdf = new ConvertWithIronPdf();
                cipdf.ConvertPdf(html, pdfLocation);
            }
            else
            {
                return "Can't find library";
            }


            return pdfLocation;
        }


        private static string getFullPath(string outPath, string fileName)
        {
            if (string.IsNullOrWhiteSpace(outPath))
                outPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            if (string.IsNullOrWhiteSpace(fileName))
                fileName = Path.GetRandomFileName().Replace(".", "");

            return Path.Combine(outPath, fileName + ".pdf");
        }
    }

    public enum ConverterLibrary
    {
        ITextSharp = 1,
        IronPDF = 2
    }
}
