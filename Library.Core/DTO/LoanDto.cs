namespace Library.Core.DTO
{
    public class LoanDto
    {
        public string Name { get; set; }
        public string SurName { get; set; }

        public DateTime ReturnDate { get; set; }
        public DateTime DeliveryDate { get; set; }
        public int BooksId { get; set; }
    }
}
