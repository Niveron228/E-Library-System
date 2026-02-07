using Microsoft.VisualBasic;
using System.Security;
using System.ComponentModel.DataAnnotations;

namespace LibrarySystem.Controllers
{
    public class BooksAttributes
    {
        [Key]
        public int id { get; set; }
        public string title {  get; set; } = string.Empty;
        public string author {  get; set; } = string.Empty;
        public int totalpages { get; set; }

        public int publishyear { get; set; }


    }
}
