using Microsoft.EntityFrameworkCore;

namespace Library.Core.Models
{
    public class Books
    {
        public int BooksId { get; set; }

        public string Name { get; set; }
        public string ISBN { get; set; }
        public string Image { get; set; }
        public string Author { get; set; }

        public bool BookStatus { get; set; }
        public string Description { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public int? CurrentLoanId { get; set; }
    }
}
