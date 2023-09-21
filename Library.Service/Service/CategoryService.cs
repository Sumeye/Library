using Library.Core.Models;
using Library.Core.Repositories;
using Library.Core.Service;
using Library.Core.UnitofWork;

namespace Library.Service.Service
{
    public class CategoryService: Service<Category>, ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        public CategoryService(IGenericRepository<Category> repository, IUnitOfWork unitOfWork,  ICategoryRepository categoryRepository) : base(repository, unitOfWork)
        {
            _categoryRepository = categoryRepository;
        }

        
    }
}
