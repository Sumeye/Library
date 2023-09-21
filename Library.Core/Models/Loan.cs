using Library.Core.Models;
using Microsoft.EntityFrameworkCore.Infrastructure.Internal;
using System.Net;

namespace Library.Core.Models
{
    public class Loan
    {
        public int LoanId { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        
        public DateTime ReturnDate { get; set; }
        public DateTime DeliveryDate { get; set; }

        public int BooksId { get; set; }
        public Books Books { get; set; }
    }

}

