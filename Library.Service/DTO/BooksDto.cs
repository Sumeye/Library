using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Service.DTO
{
    public class BooksDto
    {
        public string Name { get; set; }
        public string Image { get; set; }
        public DateTime ReleaseDate { get; set; }
        public bool BookStatus { get; set; }
        public string Author { get; set; }


    }
}
