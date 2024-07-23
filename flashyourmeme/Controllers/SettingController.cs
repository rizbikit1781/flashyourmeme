using Microsoft.AspNetCore.Mvc;

namespace flashyourmeme.Controllers
{
    public class SettingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
