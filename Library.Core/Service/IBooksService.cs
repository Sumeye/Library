using Library.Core.Models;
using Library.Core.DTO;

namespace Library.Core.Service
{
    public interface IBooksService: IService<Books>
    {
        Task<List<BooksDto>> GetBooksWithLoan();
    }
}
