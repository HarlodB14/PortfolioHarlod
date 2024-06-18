using Microsoft.AspNetCore.Mvc;
using PortfolioHarlod.Viewmodels;

namespace PortfolioHarlod.Controllers
{
    public class ProjectController : Controller
    {
        public IActionResult Projects()
        {
            var blogItems = new List<BlogItemViewmodel>
            {
                new BlogItemViewmodel { title = "TreePainterProject", creationDate = DateTime.Now, description = "A JavaFX-Application where you can draw trees by adding them, let them move and save a picture", imageUrl = "/Images/treepainter_image.png", Url ="https://github.com/HarlodB14/TreePainterProject"},
                new BlogItemViewmodel { title = "Sagrada Group Project", creationDate = DateTime.Now, description = "A JavaFX-Application where you play Sagrada the game from floodgate games", imageUrl = "/Images/Sagrada-inGame.png", Url = "https://github.com/HarlodB14/SagradaGame-Group-project"},
                new BlogItemViewmodel { title = "ebay meets marktplaats meets IBood Project", creationDate = DateTime.Now, description = "A PHP/Laravel-application where I created a Ebay/Marktplaats like marketplace-system", imageUrl = "/Images/Advertisements.png", Url = "https://github.com/HarlodB14/WEBPHP-bazaar"},
                new BlogItemViewmodel { title = "Temple of Doom", creationDate = DateTime.Now, description = "A Duo-project where I contributed in. Based on the Indiana Jones movie, C#-console-game ", imageUrl = "/Images/TempleOfDoom.png" , Url ="https://github.com/HarlodB14/TempleOfDoom"},
                new BlogItemViewmodel { title = "Dungeon Crawler", creationDate = DateTime.Now, description =  "visually Text-based dungeonCrawlerGame that I made in Java. An Application that will be displayed on the IDE-console. Where the goal is to find the magical weapon with the use of commands. The goals is to find the magical item and to retrieve it back to the starting room :D Have Fun noble adventurer!", imageUrl = "/Images/dungeoncrawler.png", Url = "https://github.com/HarlodB14/DungeonCrawler?tab=readme-ov-file"}
            };

            var viewmodel = new BlogItemListViewmodel { blogItems = blogItems };
            return View(viewmodel);
        }

        public IActionResult showProductDetail()
        {
            return View();
        }
    }
}
