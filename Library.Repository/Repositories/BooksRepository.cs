using AutoMapper;
using Library.Core.DTO;
using Library.Core.Models;
using Library.Core.Repositories;

namespace Library.Repository.Repositories
{
    public class BooksRepository : GenericRepository<Books>, IBooksRepository
    {
        private readonly IMapper _mapper;
        public BooksRepository(AppDbContext context, IMapper mapper) : base(context)
        {
            _mapper = mapper;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public async Task<List<BooksDto>> GetBooksWithLoan()
        {
            var result = (from books in _context.Books
                          join loans in _context.Loans
                          on books.CurrentLoanId equals loans.LoanId into loanGroup
                          from loan in loanGroup.DefaultIfEmpty()
                          select (new BooksDto()
                          {
                              CategoryId = books.CategoryId,
                              BooksId= books.BooksId,
                              BookStatus = books.BookStatus,
                              ISBN = books.ISBN,
                              Image = books.Image,
                              Author = books.Author,
                              Name = books.Name,
                              Loan = (loan != null) ? new LoanDto
                              {
                                  Name = loan.Name,
                                  SurName = loan.SurName,
                                  DeliveryDate = loan.DeliveryDate,
                                  ReturnDate = loan.ReturnDate,
                                  BooksId = loan.BooksId
                              } : null
                          })).OrderBy(x => x.Name).ToList();

            return result;

        }



    }
}
