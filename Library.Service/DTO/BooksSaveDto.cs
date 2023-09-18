using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Service.DTO
{
    public class BooksSaveDto
    {
        public int BooksId { get; set; }
        public string Name { get; set; }

        public string ISBN { get; set; }
        public string Image { get; set; }
        public DateTime ReleaseDate { get; set; }
        public bool BookStatus { get; set; }
        public int Description { get; set; }
        public int CategoryId { get; set; }
        public int AuthorId { get; set; }
    }
}
