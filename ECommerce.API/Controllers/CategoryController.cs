using ECommerce.Service;
using ECommerce.Service.Request;
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
    public class CategoryController : ControllerBase
    {
        private readonly CategoryAPIService _categoryAPIService;
        public CategoryController(CategoryAPIService categoryAPIService)
        {
            _categoryAPIService = categoryAPIService;
        }

        [HttpGet]
        public List<CategoryResponse> GetAll()
        {
            return _categoryAPIService.GetAllCategories();
        }


        [HttpGet("{id}")]
        public CategoryResponse GetById([FromRoute] int id)
        {
            return _categoryAPIService.GetByCategoryId(id);
        }


        [HttpPost]
        public int Insert([FromBody] CategoryRequest categoryRequest)
        {
            return _categoryAPIService.InsertCategory(categoryRequest);
        }


        [HttpDelete]
        public int Delete([FromBody] CategoryRequest categoryRequest)
        {
            return _categoryAPIService.DeleteCategory(categoryRequest);
        }


        [HttpPut]
        public int Update([FromBody] CategoryRequest categoryRequest)
        {
            return _categoryAPIService.UpdateCategory(categoryRequest);
        }
    }
}
