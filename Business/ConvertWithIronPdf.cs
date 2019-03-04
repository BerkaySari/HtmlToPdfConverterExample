using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IronPdf;

namespace Business
{
    //https://ironpdf.com/tutorials/html-to-pdf/
    public class ConvertWithIronPdf
    {
        public void ConvertPdf(string html, string pdfLocation)
        {
            HtmlToPdf renderer = new HtmlToPdf();

            renderer.PrintOptions.EnableJavaScript = true;
            renderer.PrintOptions.RenderDelay = 500;

            renderer.PrintOptions.CssMediaType = PdfPrintOptions.PdfCssMediaType.Print;

            PdfDocument pdf = renderer.RenderHtmlAsPdf(html);
            pdf.SaveAs(pdfLocation);
        }
    }
}
