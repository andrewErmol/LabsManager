using iTextSharp.text;
using iTextSharp.text.pdf;
using LabsManager.API.Services.PDF;
using LabsManager.Domain;
using LabsManager.Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace LabsManager.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class LabTemplatesController : ControllerBase
    {
        private readonly string _filepath = @"D:\Labs\diplom_pdfs";
        private readonly string _fontpath = @"D:\Labs\fonts\TimesNewRomanRegular.ttf";

        private readonly Services.PDF.LabPdfWriter _pdfWriter;

        public LabTemplatesController(Services.PDF.LabPdfWriter pdfWriter)
        {
            _pdfWriter = pdfWriter;
        }

        [HttpPost]
        public IActionResult CreateDocument(string filename)
        {
            LabTemplate labTemplate = new LabTemplate
            {
                Number = 1,
                Theme = "Статические характеристики датчиков тока и напряжения",
                TeacherFullName = "Ковалев А.В.",
                StudentFullName = "Ермоленко А.А.",
                StudentGroup = "ПЭ-31",
                Purpose = "1.Изучить принцип работы датчиков тока и напряжения\n" +
                    "2.Исследовать статические характеристики датчиков тока и напряжения"
            };

            _pdfWriter.CreateFile(_filepath + $"/{filename}.pdf", _fontpath, labTemplate);

            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteDocument(string filename)
        {

            return NoContent();
        }
    }
}
