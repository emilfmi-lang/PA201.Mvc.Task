using Pustok.Mvc.Models.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pustok.Mvc.Models;

public class Book:BaseEntity
{
    [Required]
    public string Name { get; set; }
    public string Description { get; set; }
    [Required]
    [Column(TypeName = "decimal(18,2)")]
    public decimal Price { get; set; }
    public int DiscountedPercent { get; set; }
    public string Code { get; set; }
    public bool InStock { get; set; }  
    public bool IsFeatured { get; set; }
    public string MainImageUrl { get; set; }
    public string HoverImageUrl { get; set; }
    public int AuthorId { get; set; }
    public bool IsNew { get; set; }
    public Author Author { get; set; }
    public List<BookImage> BookImages { get; set; }

}
