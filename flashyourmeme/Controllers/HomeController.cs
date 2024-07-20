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
            return View();
        }

        public IActionResult Filter()
        {
            return View();
        }

        public IActionResult Voucher()
        {
            return View();
        }

        public IActionResult Branch()
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
