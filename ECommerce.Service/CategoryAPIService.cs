using ECommerce.Data.Context;
using ECommerce.Data.Entities;
using ECommerce.Service.Request;
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
                .ToList()
                .Select(x => new CategoryResponse
            {
                Id = x.Id,
                Name = x.Name

            }).ToList();

            return category;
        }


        /// <summary>
        /// Id'ye göre kategori getiren metot
        /// </summary>
        /// <param name="id"></param>
        /// <returns>CategoryResponse</returns>
        public CategoryResponse GetByCategoryId(int id)
        {
            var category = _context.Categories
                .FirstOrDefault(x => x.Id == id);
            var result = new CategoryResponse
            {
                Id = category.Id,
                Name = category.Name
            };
            return result;                       
                
        }


        /// <summary>
        /// Body'den gelen kategori'yi database ' e ekleyen metot.
        /// </summary>
        /// <param name="categoryRequest"></param>
        /// <returns>int</returns>
        public int InsertCategory(CategoryRequest categoryRequest)
        {
            var category = new Category
            {
                Name = categoryRequest.Name
            };
            _context.Categories.Add(category);
            return _context.SaveChanges();
            
        }
    }
}
