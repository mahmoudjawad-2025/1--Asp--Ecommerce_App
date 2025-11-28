using BLL.Services.Classes;
using Microsoft.AspNetCore.Mvc;

//using Microsoft.AspNetCore.Mvc;
using QuestPDF.Fluent;

namespace PL.Areas.Admin
{
    [Route("api/[area]/[controller]")]
    [ApiController]
    [Area("Admin")]
    //[Authorize(Roles = "Admin,SuperAdmin")]
    public class ReportsController : ControllerBase
    {
        private readonly ReportService _reportService;

        public ReportsController(ReportService reportService)
        {
            _reportService = reportService;
        }

        [HttpGet(Name = "GeneratePdf")]
        public IResult GetPdfProductReport()
        {
            var document = _reportService.CreateDocument();
            var pdf = document.GeneratePdf();
            return Results.File(pdf, "application/pdf", "KaProducts.pdf");
        }
    }
}
