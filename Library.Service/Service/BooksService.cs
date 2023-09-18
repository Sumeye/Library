using Library.Core.Models;
using Library.Core.Repositories;
using Library.Core.Service;
using Library.Core.UnitofWork;

namespace Library.Service.Service
{
    internal class BooksService : Service<Books>, IBooksService
    {
        private readonly IBooksRepository _booksRepository;
        public BooksService(IGenericRepository<Books> repository, IUnitOfWork unitOfWork, IBooksRepository booksRepository) : base(repository, unitOfWork)
        {
            _booksRepository = booksRepository;
        }


    }
}
