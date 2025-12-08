using Pustok.Mvc.Models.Common;
using System.Diagnostics.Contracts;

namespace Pustok.Mvc.Models;

public class BookImage : BaseEntity
{
    public string ImageUrl { get; set; }
    public int BookId { get; set; }
    public Book Book { get; set; }

}
