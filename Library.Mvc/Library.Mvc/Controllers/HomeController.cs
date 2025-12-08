using System.Diagnostics;
using Library.Mvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace Library.Mvc.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
