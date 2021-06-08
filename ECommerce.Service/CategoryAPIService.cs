using ECommerce.Data.Context;
using ECommerce.Service.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ECommerce.Service
{
    public class CategoryAPIService
    {
        private readonly ECommerceDbContext _context;
        public CategoryAPIService(ECommerceDbContext context)
        {
            _context = context;
        }
        /// <summary>
        /// Tüm kategorileri getiren metot
        /// </summary>
        /// <returns>List<CategoryResponse></returns>
        public List<CategoryResponse> GetAllCategories()
        {
            var category = _context.Categories
                .Select(x => new CategoryResponse
            {
                Id = x.Id,
                Name = x.Name

            }).ToList();

            return category;
        }
    }
}
