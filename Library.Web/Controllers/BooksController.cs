using AutoMapper;
using Library.Core.Service;
using Library.Service.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Library.Web.Controllers
{
    public class BooksController : Controller
    {
        private readonly ICategoryService _categoryService;
        private readonly IBooksService _booksService;
        private readonly IMapper _mapper;

        public BooksController(ICategoryService categoryService, IBooksService booksService, IMapper mapper)
        {
            _mapper = mapper;
            _categoryService = categoryService;
            _booksService = booksService;
        }
        public async Task<IActionResult> Index()
        {
            var books = await _booksService.GetAllAsync();
            return View(books);
        }

    }
}
