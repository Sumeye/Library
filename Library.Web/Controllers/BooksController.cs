using Library.Service.DTO;
using Library.Web.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Library.Web.Controllers
{
    public class BooksController : Controller
    {
        private readonly BooksApiService _booksApiService;
        private readonly CategoryApiService _categoryApiService;
        public BooksController(BooksApiService booksApiService,
                               CategoryApiService categoryApiService)
        {
            _booksApiService = booksApiService;
            _categoryApiService = categoryApiService;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _booksApiService.GetAllBooks());
        }

        [HttpGet]
        public async Task<IActionResult> Save()
        {
            var categoriesDto = await _categoryApiService.GetAllCategory();
            ViewBag.Categories = new SelectList(categoriesDto, "Id", "Name");
            return View();

        }

        [HttpPost]
        public async Task<IActionResult> Save(BooksSaveDto booksDto)
        {
            if (ModelState.IsValid)
            {
                await _booksApiService.SaveAsync(booksDto);
                return RedirectToAction(nameof(Index));
            }
            var categoriesDto = await _categoryApiService.GetAllCategory();
            ViewBag.Categories = new SelectList(categoriesDto, "Id", "Name");
            return View();
        }
    }
}
