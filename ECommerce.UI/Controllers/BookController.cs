using AutoMapper;
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
<<<<<<< HEAD

=======
>>>>>>> df3c8afce25b87a713b989fee67f9aca24b4298b
        public async Task<IActionResult> Index()
        {
            var books = await _bookAPIClient.GetAllBooks();

            var model = new BookIndexModel()
            {
<<<<<<< HEAD
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
=======
                Books=_mapper.Map<List<BookViewModel>>(books)
            
>>>>>>> df3c8afce25b87a713b989fee67f9aca24b4298b
            };

            return View(model);
        }
    }
}
