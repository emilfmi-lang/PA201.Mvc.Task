using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
                Sliders = dbContext.Sliders.ToList(),
                FeaturedBooks = dbContext.Books.
                Include(b => b.Author).
                Include(b => b.BookImages).

                Where(b => b.IsFeatured).ToList(),
                NewBooks = dbContext.Books.
                Include(b => b.Author).
                Include(b => b.BookImages).

                Where(b => b.IsNew).ToList(),
                DiscountedBooks = dbContext.Books.
                Include(b => b.Author).

                Include(b => b.BookImages).
                Where(b => b.DiscountedPercent > 0).ToList()
            };
            return View(homeVm);
        }
    }
}
