using Microsoft.EntityFrameworkCore;

namespace LibrarySystem.Controllers
{
    public class LibraryDbContext : DbContext
    {
        public LibraryDbContext(DbContextOptions<LibraryDbContext> options) : base(options)
        { 
        }

        public DbSet<BooksAttributes> Books { get; set; }
    }
}
