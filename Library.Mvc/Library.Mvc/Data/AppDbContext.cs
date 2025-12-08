using Library.Mvc.Models;
using Microsoft.EntityFrameworkCore;

namespace Library.Mvc.Data;

public class AppDbContext : DbContext
{
    public DbSet<Slider> Sliders { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
}
