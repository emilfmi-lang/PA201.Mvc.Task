using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pustok.Mvc.Data;
using Pustok.Mvc.ViewModels;

namespace Pustok.Mvc.Controllers;

public class BooksController(AppDbContext appDbContext) : Controller
{
    public IActionResult Details(int id)
    {
        var book = appDbContext.Books
            .Include(x => x.Author)
            .Include(x => x.BookImages)
            .Include(x => x.BookTags)
                .ThenInclude(bt => bt.Tag)
            .FirstOrDefault(x => x.Id == id);
        if (book == null) return NotFound();
        BookVm bookVm = new()
        {
            Book = book
        };
        return View("BooksDetails", bookVm);
    }

    public IActionResult BookModal(int id)
    {
        var book = appDbContext.Books
            .Include(x => x.Author)
            .Include(x => x.BookImages)
            .Include(x => x.BookTags)
                .ThenInclude(bt => bt.Tag)
            .FirstOrDefault(x => x.Id == id);
        if (book == null) return NotFound();
        return PartialView("_BookModalPartial", book);
    }
}

