using Library.Core.DTO;
using Library.Core.Models;

namespace Library.Core.Repositories
{
    public interface IBooksRepository : IGenericRepository<Books>
    {
        Task<List<BooksDto>> GetBooksWithLoan();
    }
}
