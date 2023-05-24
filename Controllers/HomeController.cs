using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using تحويل_الى_view.Models;

namespace تحويل_الى_view.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult about()
        {
            return View();
        }
        public IActionResult blog()
        {
            return View();
        }
        public IActionResult contact()
        {
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult services()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

    }
}