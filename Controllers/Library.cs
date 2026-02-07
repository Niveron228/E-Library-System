using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LibrarySystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Library : ControllerBase
    {
        private readonly LibraryDbContext? _context;

        public Library(LibraryDbContext? context)
        {

            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<BooksAttributes>>> GetAllBooks() 
        { 
            return Ok(await _context.Books.ToListAsync()); 
        }

        [HttpPost]
        public async Task<ActionResult<BooksAttributes>> AddBook(BooksAttributes newBook)
        {
            _context.Books.Add(newBook);
            await _context.SaveChangesAsync();
            return Ok(newBook);
        }
        [HttpDelete("{id}")]

        public async Task<IActionResult> DeleteBook(int id)
        {
            var book = await (_context.Books.FindAsync(id));
            if (book == null) 
            {
                return NotFound("Error");
            }
            _context.Books.Remove(book);
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpPut("{id}")]

        public async Task<IActionResult> UpdateBook(int id, BooksAttributes updatedBook)
        {
            var book = await(_context.Books.FindAsync(id));
            if (book == null) 
            { 
                return NotFound("Error");
            }
            book.title = updatedBook.title;
            book.author = updatedBook.author;
            book.totalpages = updatedBook.totalpages;
            book.publishyear = updatedBook.publishyear;

            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpGet("{id}")]

        public async Task<ActionResult<BooksAttributes>> GetBookById(int id)
        {
            var book = await (_context.Books.FindAsync(id));
            if(book == null)
            {
                return NotFound("Error");
            }

            return Ok(book);
        }

        [HttpGet("search/{author}")]
        public async Task<ActionResult<List<BooksAttributes>>> GetAllAuthorsBooks(string author)
        {
            var books = await _context.Books.Where(b => b.author == author).ToListAsync();
            if(books == null || books.Count == 0)
            {
                return NotFound($"No books found for author: {author}");
            }
            return Ok(books);
        }

        [HttpGet("year/{publishyear}")]

        public async Task<ActionResult<List<BooksAttributes>>> GetAllBooksFromYear(int publishyear)
        {
            var books = await _context.Books.Where(b => b.publishyear == publishyear).ToListAsync();
            if(books.Count == 0)
            {
                return NotFound($"No books found from {publishyear} year");
            }
            return Ok(books);
        }

        [HttpGet("title/{title}")]

        public async Task<ActionResult<BooksAttributes>> GetBookInfoByTitle(string title)
        {
            var book = await _context.Books.Where(b => b.title.Contains(title)).FirstOrDefaultAsync();
            if(book == null)
            {
                return NotFound("Error");
            }

            return Ok(book);
        }
        

        

    }
}
