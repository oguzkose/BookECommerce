using ECommerce.Data.Context;
using ECommerce.Data.Entities;
using ECommerce.Service.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ECommerce.Service
{
    public class BookAPIService
    {
        private readonly ECommerceDbContext _context;
        public BookAPIService(ECommerceDbContext context)
        {
            _context = context;
        }
        /// <summary>
        /// Body'den gelen kitabı DB'ye ekleyen metot
        /// </summary>
        /// <param name="bookResponse"></param>
        /// <returns>int</returns>
        public int InsertBook(BookResponse bookResponse)
        {
            var book = new Book
            {
                Author = bookResponse.Author,
                CategoryId = bookResponse.CategoryId,
                Name = bookResponse.Name,
                Price = bookResponse.Price,
                Publisher = bookResponse.Publisher,
                StockCount = bookResponse.StockCount
            };
            _context.Add(book);

            return _context.SaveChanges();
        }



        /// <summary>
        /// Route'den gelen id'ye göre kitabı getiren metot
        /// </summary>
        /// <param name="id"></param>
        /// <returns>BookResponse</returns>
        public BookResponse GetByBookId(int id)
        {
            var book = _context.Books.FirstOrDefault(x => x.Id == id);
            var result = new BookResponse
            {
                Id = book.Id,
                Name = book.Name,
                Author = book.Author,
                Publisher = book.Publisher,
                Price = book.Price,
                StockCount = book.StockCount,
                CategoryId = book.CategoryId
            };
            return result;
        }



        /// <summary>
        /// Tüm kitapları getiren metot
        /// </summary>
        /// <returns>List<BookResponse></returns>
        public List<BookResponse> GetAllBooks()
        {
            var books = _context.Books.ToList()
                .Select(x => new BookResponse
                {
                    Id = x.Id,
                    Name = x.Name,
                    Author = x.Author,
                    Publisher = x.Publisher,
                    Price = x.Price,
                    StockCount = x.StockCount,
                    CategoryId = x.CategoryId
                }).ToList();
            return books;
        }



        /// <summary>
        /// Body'den gelen Id'ye göre kitabı silen metot
        /// </summary>
        /// <param name="bookResponse"></param>
        /// <returns>int</returns>
        public int DeleteBook(BookResponse bookResponse)
        {
            var book = _context.Books.FirstOrDefault(x => x.Id == bookResponse.Id);
            _context.Remove(book);
            return _context.SaveChanges();
        }



        /// <summary>
        /// Body'den gelen Id'ye göre önce entity'i bulup ardından yine Body'den aldığı diğer bilgilerle entity'i güncelleyen metot.
        /// </summary>
        /// <param name="bookResponse"></param>
        /// <returns>int</returns>
        public int UpdateBook(BookResponse bookResponse)
        {
            var bookToBeUpdated = _context.Books.FirstOrDefault(x => x.Id == bookResponse.Id);

            bookToBeUpdated.Name = bookResponse.Name;
            bookToBeUpdated.Author = bookResponse.Author;
            bookToBeUpdated.Publisher = bookResponse.Publisher;
            bookToBeUpdated.Price = bookResponse.Price;
            bookToBeUpdated.StockCount = bookResponse.StockCount;
            bookToBeUpdated.CategoryId = bookResponse.CategoryId;

            return _context.SaveChanges();
        }
    }
}
