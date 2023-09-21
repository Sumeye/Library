using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Core.DTO
{
    public class BooksDto
    {
        public int BooksId { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string ISBN { get; set; }
        public bool BookStatus { get; set; }
        public string Author { get; set; }
        public int CategoryId { get; set; }

        public LoanDto? Loan { get; set; }
    }
}
