using Pustok.Mvc.Models.Common;

namespace Pustok.Mvc.Models;

public class Author :BaseEntity
{
    public string Name { get; set; }
    public List<Book> Books { get; set; }
}
