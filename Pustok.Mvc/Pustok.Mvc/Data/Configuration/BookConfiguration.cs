using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pustok.Mvc.Models;

namespace Pustok.Mvc.Data.Configuration;

public class BookConfiguration : IEntityTypeConfiguration<Book>
{
    public void Configure(EntityTypeBuilder<Book> builder)
    {
        builder.HasMany(x => x.BookImages)
               .WithOne(x => x.Book)
               .HasForeignKey(x => x.BookId)
               .OnDelete(DeleteBehavior.Cascade);

        builder.Property(x => x.Name)
               .IsRequired()
               .HasMaxLength(200);
    }
}
