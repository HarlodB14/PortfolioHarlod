using Microsoft.AspNetCore.Mvc;
using System.IO;

namespace PortfolioHarlod.Controllers
{
    public class ContactController : Controller
    {
        private readonly string _pdfFolderPath = "Document";
        private readonly IWebHostEnvironment _hostingEnvironment;

        public ContactController(IWebHostEnvironment hostEnvironment)
        {
            _hostingEnvironment = hostEnvironment;
        }

        public IActionResult DownloadCV()
        {
            string fileName = "CV-Harlod.pdf";
            string webRootPath = _hostingEnvironment.WebRootPath;
            string filePath = Path.Combine(webRootPath, _pdfFolderPath, fileName);

            if (!System.IO.File.Exists(filePath))
            {
                return NotFound();
            }

            var fileBytes = System.IO.File.ReadAllBytes(filePath);
            return File(fileBytes, "application/pdf", fileName);
        }

        public IActionResult Contact()
        {
            return View();
        }
    }
}
