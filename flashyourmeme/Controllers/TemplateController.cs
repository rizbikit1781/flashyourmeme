using flashyourmeme.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace flashyourmeme.Controllers
{
    [Route("templates")]
    public class TemplateController : Controller
    {
        [HttpGet("")]
        public IActionResult Index(int page = 1, int pageSize = 8)
        {
            var templates = new List<TemplateModel>
            {
                new TemplateModel { Id = 1, ImageUrl = "~/template-1.png", Title = "Image 1", File ="4x6-1" },
                new TemplateModel { Id = 2, ImageUrl = "~/template-2.png", Title = "Image 2", File ="4x6-1" },
                new TemplateModel { Id = 3, ImageUrl = "~/template-3.png", Title = "Image 3", File ="4x6-1" },
                new TemplateModel { Id = 4, ImageUrl = "~/template-4.png", Title = "Image 4", File ="4x6-1" },
                new TemplateModel { Id = 5, ImageUrl = "~/template-1.png", Title = "Image 5", File ="4x6-1" },
                new TemplateModel { Id = 6, ImageUrl = "~/template-2.png", Title = "Image 6", File ="4x6-1" },
                new TemplateModel { Id = 7, ImageUrl = "~/template-3.png", Title = "Image 7", File ="4x6-1" },
                new TemplateModel { Id = 8, ImageUrl = "~/template-4.png", Title = "Image 8", File ="4x6-1" },
                new TemplateModel { Id = 9, ImageUrl = "~/template-1.png", Title = "Image 9", File ="4x6-1" },
                new TemplateModel { Id = 10, ImageUrl = "~/template-2.png", Title = "Image 10", File ="4x6-1" },
            };

            var paginatedTemplates = templates.Skip((page - 1) * pageSize).Take(pageSize).ToList();
            ViewBag.CurrentPage = page;
            ViewBag.TotalPages = (int)Math.Ceiling((double)templates.Count / pageSize);

            return View(paginatedTemplates);
        }
    }
}