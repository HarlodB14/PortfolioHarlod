using Microsoft.AspNetCore.Mvc;
using PortfolioHarlod.Models;
using PortfolioHarlod.Viewmodels;
using System.Diagnostics;

namespace PortfolioHarlod.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var blogItems = new List<BlogItemViewmodel>
            {
                new BlogItemViewmodel { title = "TreePainterProject", creationDate = DateTime.Now, description = "A JavaFX-Application where you can draw trees by adding them, let them move and save a picture", imageUrl = "/Images/treepainter_image.png", Url ="https://github.com/HarlodB14/TreePainterProject"},
                new BlogItemViewmodel { title = "Sagrada Group Project", creationDate = DateTime.Now, description = "A JavaFX-Application where you play Sagrada the game from floodgate games", imageUrl = "/Images/Sagrada-inGame.png", Url = "https://github.com/HarlodB14/SagradaGame-Group-project"},
                new BlogItemViewmodel { title = "ebay meets marktplaats meets IBood Project", creationDate = DateTime.Now, description = "A PHP/Laravel-application where I created a Ebay/Marktplaats like marketplace-system", imageUrl = "/Images/Advertisements.png", Url = "https://github.com/HarlodB14/WEBPHP-bazaar"},
                new BlogItemViewmodel { title = "Temple of Doom", creationDate = DateTime.Now, description = "A Duo-project where I contributed in. Based on the Indiana Jones movie, C#-console-game ", imageUrl = "/Images/TempleOfDoom.png" , Url ="https://github.com/HarlodB14/TempleOfDoom"},
            };

            var viewmodel = new BlogItemListViewmodel { blogItems = blogItems };
            return View(viewmodel);
        }

        public IActionResult Contact()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
