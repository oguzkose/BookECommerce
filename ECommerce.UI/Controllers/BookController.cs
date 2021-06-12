using AutoMapper;
using ECommerce.UI.Client;
using ECommerce.UI.Models;
using ECommerce.UI.Models.Response;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
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
                Books=_mapper.Map<List<BookViewModel>>(books)
                
            };

            return View(model);
        }
    }
}
