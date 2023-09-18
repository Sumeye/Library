using Library.Core.Models;
using Library.Core.Repositories;

namespace Library.Repository.Repositories
{
    public class BooksRepository : GenericRepository<Books>, IBooksRepository
    {
        public BooksRepository(AppDbContext context) : base(context)
        {
        }

    }
}
