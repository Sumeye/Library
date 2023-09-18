namespace Library.Core.Models
{
    public class Loan
    {
        public int LoanId { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public DateTime ReturnDate { get; set; }
        public DateTime DeliveryDate { get; set; }
    }
}
