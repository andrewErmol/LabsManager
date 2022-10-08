using iTextSharp.text;
using iTextSharp.text.pdf;
using LabsManager.Domain;
using LabsManager.Domain.Models;
using System.Text;

namespace LabsManager.API.Services.PDF
{
    public class LabPdfWriter
    {
        public void CreateFile(string filepath, string fontpath, LabTemplate labTemplate)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

            Document document = new Document(PageSize.A4);

            PdfWriter.GetInstance(document, new FileStream(filepath, FileMode.Create));

            BaseFont bf = BaseFont.CreateFont(fontpath, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
            Font times = new Font(bf, 14);

            Paragraph titleTop = new Paragraph(CommonData.GenerateTitleTopText(labTemplate), times);
            titleTop.Alignment = Element.ALIGN_CENTER;

            Paragraph titleRight = new Paragraph(CommonData.GenerateTitleRightText(labTemplate), times);
            titleRight.Alignment = Element.ALIGN_RIGHT;

            Paragraph titleBottom = new Paragraph($"Гомель {DateTime.UtcNow.Year}", times);
            titleBottom.Alignment = Element.ALIGN_CENTER;

            document.Open();

            document.Add(titleTop);
            document.Add(titleRight);
            document.Add(titleBottom);

            document.Close();
        }
    }
}
