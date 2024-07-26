using flashyourmeme.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace flashyourmeme.Controllers
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
            return View();
        }

        public IActionResult Photo()
        {
            return View();
        }

        public IActionResult Template()
        {
            var images = new List<ImageModel>
        {
            new ImageModel { Id = 1, ImageUrl = "~/template-1.png", Title = "Image 1", File ="4x6-1" },
            new ImageModel { Id = 2, ImageUrl = "~/template-2.png", Title = "Image 2", File ="4x6-1" },
            new ImageModel { Id = 3, ImageUrl = "~/template-3.png", Title = "Image 3", File ="4x6-1" },
            new ImageModel { Id = 4, ImageUrl = "~/template-4.png", Title = "Image 4", File ="4x6-1" },
            new ImageModel { Id = 5, ImageUrl = "~/template-1.png", Title = "Image 5", File ="4x6-1" },
            new ImageModel { Id = 6, ImageUrl = "~/template-2.png", Title = "Image 6", File ="4x6-1" },
            new ImageModel { Id = 7, ImageUrl = "~/template-3.png", Title = "Image 7", File ="4x6-1" },
            new ImageModel { Id = 8, ImageUrl = "~/template-4.png", Title = "Image 8", File ="4x6-1" },
            new ImageModel { Id = 9, ImageUrl = "~/template-1.png", Title = "Image 9", File ="4x6-1" },
            new ImageModel { Id = 10, ImageUrl = "~/template-2.png", Title = "Image 10", File ="4x6-1" },
           
        };

            return View(images);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
