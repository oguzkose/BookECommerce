using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Service.Response
{
    public class BookResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public double Price { get; set; }
        public int StockCount { get; set; }
        public int CategoryId { get; set; }
    }
}
