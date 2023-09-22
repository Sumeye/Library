using AutoMapper;
using Library.Core.DTO;
using Library.Core.Models;
using Library.Core.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Library.UI.Controllers
{

    public class BooksController : Controller
    {
        private readonly ICategoryService _categoryService;
        private readonly IBooksService _booksService;
        private readonly ILoanService _loanService;
        private readonly IMapper _mapper;

        public BooksController(ICategoryService categoryService, IBooksService booksService, ILoanService loanService,
            IMapper mapper)
        {
            _mapper = mapper;
            _categoryService = categoryService;
            _booksService = booksService;
            _loanService = loanService;
        }
        public async Task<IActionResult> Index()
        {
            var books = await _booksService.GetBooksWithLoan();
            return View(books);
        }

        [HttpGet]
        public async Task<IActionResult> Save()
        {
            var categoriesDto = await _categoryService.GetAllAsync();
            ViewBag.Categories = new SelectList(categoriesDto, "CategoryId", "Name");
            return View();

        }
        [HttpPost]
        public async Task<IActionResult> Save(BooksSaveDto booksDto, IFormFile file)
        {
            if (file != null && file.Length > 0)
            {
                var resource = Directory.GetCurrentDirectory();
                var extension = Path.GetExtension(file.FileName);
                var imagename = Guid.NewGuid() + extension;
                var savelocation = resource + "/wwwroot/image/" + imagename;
                var stream = new FileStream(savelocation, FileMode.Create);
                await file.CopyToAsync(stream);
                booksDto.Image = imagename;
                await _booksService.AddAsync(_mapper.Map<Books>(booksDto));
                return RedirectToAction(nameof(Index));
            }

            var categoriesDto = await _categoryService.GetAllAsync();
            ViewBag.Categories = new SelectList(categoriesDto, "CategoryId", "Name");
            return View();
        }

        [HttpGet]
        [Route("Books/SaveLoan/{booksId}")]
        public async Task<IActionResult> SaveLoan(int booksId)
        {
            ViewBag.BooksId = booksId;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SaveLoan(LoanDto loanDto)
        {

            if (ModelState.IsValid)
            {
                Loan loan = await _loanService.AddAsync(_mapper.Map<Loan>(loanDto));

                if (loan.LoanId > 0)
                {
                    Books book = await _booksService.GetByIdAsync(loan.BooksId);

                    book.BookStatus = true;
                    book.CurrentLoanId = loan.LoanId;

                    await _booksService.UpdateAsync(book);

                    return RedirectToAction("Index");
                }

            }

            ViewBag.BooksId = loanDto.BooksId;
            return View();
        }


    }
}