using System.Threading.Tasks;
using Abp.Application.Services;
using WkHtmlToPdfDotNet;
using WkHtmlToPdfDotNet.Contracts;

namespace RevisionControl.Report
{
    public class ReportAppService : ApplicationService, IReportAppService
    {
        private readonly IConverter _converter;

        public ReportAppService(IConverter converter)
        {
            _converter = converter;
        }
        
        public byte[] GenerateTestReport()
        {
            var doc = new HtmlToPdfDocument()
            {
                GlobalSettings = {
                    ColorMode = ColorMode.Color,
                    Orientation = Orientation.Landscape,
                    PaperSize = PaperKind.A4Plus,
                },
                Objects = {
                    new ObjectSettings() {
                        PagesCount = true,
                        HtmlContent = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit. In consectetur mauris eget ultrices  iaculis. Ut odio viverra, molestie lectus nec, venenatis turpis.",
                        WebSettings = { DefaultEncoding = "utf-8" },
                        HeaderSettings = { FontSize = 9, Right = "Page [page] of [toPage]", Line = true, Spacing = 2.812 }
                    }
                }
            };
            return _converter.Convert(doc);
        }
    }
}