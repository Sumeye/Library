namespace Library.Core.DTO
{
    public class BooksSaveDto
    {
        public int BooksId { get; set; }
        public string Name { get; set; }

        public string ISBN { get; set; }
        public string? Image { get; set; }
        public bool BookStatus { get; set; }
        public int Description { get; set; }
        public int CategoryId { get; set; }
        public string Author { get; set; }
    }
}
