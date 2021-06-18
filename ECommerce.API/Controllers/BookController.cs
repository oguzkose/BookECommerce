using ECommerce.Service;
using ECommerce.Service.Response;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.API.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly BookAPIService _bookAPIService;
        public BookController(BookAPIService bookAPIService)
        {
            _bookAPIService = bookAPIService;
        }

        [HttpPost]
        public int Insert([FromBody] BookResponse bookResponse)
        {
            return _bookAPIService.InsertBook(bookResponse);
        }


        [HttpGet("{id}")]
        public BookResponse GetById([FromRoute] int id)
        {
            return _bookAPIService.GetByBookId(id);
        }


        [HttpGet]
        public List<BookResponse> GetAll()
        {
            return _bookAPIService.GetAllBooks();
        }


        [HttpDelete("{id}")]
        public int Delete(int id)
        {
            return _bookAPIService.DeleteBook(id);
        }
       
        [HttpPut]
        public int Update([FromBody] BookResponse bookResponse)
        {
            return _bookAPIService.UpdateBook(bookResponse);
        }
    }
}
