using Pustok.Mvc.Models;

namespace Pustok.Mvc.ViewModels;

public class Homevm
{
    public List<Slider> Sliders { get; set; }
    public List<Book> FeaturedBooks { get; set; }
    public List<Book> NewBooks { get; set; }
    public List<Book> DiscountedBooks { get; set; }
}
