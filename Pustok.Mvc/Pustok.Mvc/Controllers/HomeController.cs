using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Pustok.Mvc.Models;

namespace Pustok.Mvc.Controllers
{
    public class HomeController : Controller
    {


        public IActionResult Index()
        {
            return View();
        }

    }
}
