using AutoMapper;
using ECommerce.Service.Request;
using ECommerce.UI.Client;
using ECommerce.UI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ECommerce.UI.Controllers
{
    public class BookController : Controller
    {

        private readonly IMapper _mapper;
        private readonly BookAPIClient _bookAPIClient;
        public BookController(IMapper mapper, BookAPIClient bookAPIClient)
        {
            _mapper = mapper;
            _bookAPIClient = bookAPIClient;
        }

        public async Task<IActionResult> Index()
        {
            var books = await _bookAPIClient.GetAllBooks();

            var model = new BookIndexModel()
            {
                Books = _mapper.Map<List<BookViewModel>>(books)

            };

            return View(model);
        }
        public async Task<IActionResult> Delete(int id)
        {
            var book = await _bookAPIClient.DeleteBook(id);

            return RedirectToAction("index", "book");
        }
        public async Task<IActionResult> Detail(int id)
        {
            var book = await _bookAPIClient.GetByBookId(id);

            var model = new BookDetailModel
            {
                Book = _mapper.Map<BookViewModel>(book)                
            };

            return View(model);
        }

        public async Task< IActionResult> Update(int id)
        {
            var book = await _bookAPIClient.GetByBookId(id);

            //var model = _mapper.Map<BookViewModel>(book);
            var model = new BookViewModel()
            {
                Id = book.Id,
                Author = book.Author,
                CategoryId = book.CategoryId,
                Name = book.Name,
                Price = book.Price,
                Publisher = book.Publisher,
                StockCount = book.StockCount

            };
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Update(BookViewModel bookViewModel)
        {
            //var bookRequest = _mapper.Map<BookRequest>(bookViewModel);
            var bookRequest = new BookRequest()
            {
                Id = bookViewModel.Id,
                Author = bookViewModel.Author,
                CategoryId = bookViewModel.CategoryId,
                Name = bookViewModel.Name,
                Price = bookViewModel.Price,
                Publisher = bookViewModel.Publisher,
                StockCount = bookViewModel.StockCount
            };

            await _bookAPIClient.UpdateBook(bookRequest);

            return RedirectToAction("Index", "Book");
        }

        public IActionResult Insert()
        {
            var model = new BookViewModel();
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Insert(BookViewModel bookViewModel)
        {
            var bookRequest = _mapper.Map<BookRequest>(bookViewModel);

            await _bookAPIClient.InsertBook(bookRequest);

            return RedirectToAction("Index", "Book");
        }
    }
}
