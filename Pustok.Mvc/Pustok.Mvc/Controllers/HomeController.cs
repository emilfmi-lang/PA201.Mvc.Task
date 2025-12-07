using Microsoft.AspNetCore.Mvc;
using Pustok.Mvc.Data;
using Pustok.Mvc.ViewModels;

namespace Pustok.Mvc.Controllers
{
    public class HomeController(AppDbContext dbContext) : Controller
    {
        public IActionResult Index()
        {
            Homevm homeVm = new Homevm
            {
                Sliders = dbContext.Sliders.ToList()
                //FeaturedBooks = dbContext.Books.Where(b => b.IsFeatured).ToList(),
                //NewBooks = dbContext.Books.Where(b => b.IsNew).ToList(),
                //DiscountedBooks = dbContext.Books.Where(b => b.DiscountPercent > 0).ToList()
            };
            return View(homeVm);
        }
    }
}
