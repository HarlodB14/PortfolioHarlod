using Microsoft.AspNetCore.Mvc;
using System.IO;

namespace PortfolioHarlod.Controllers
{
    public class ContactController : Controller
    {

        public IActionResult Contact()
        {
            return View();
        }
    }
}
