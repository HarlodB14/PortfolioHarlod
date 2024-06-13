using Microsoft.AspNetCore.Mvc;

namespace PortfolioHarlod.Controllers
{
    public class ProjectController : Controller
    {
        public IActionResult Projects()
        {
            return View();
        }
    }
}
