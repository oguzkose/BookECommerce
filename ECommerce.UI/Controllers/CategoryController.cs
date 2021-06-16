using AutoMapper;
using ECommerce.ClientService.Client;
using ECommerce.UI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ECommerce.UI.Controllers
{
    public class CategoryController : Controller
    {

        private readonly CategoryAPIClient _categoryAPIClient;
        private readonly IMapper _mapper;
        public CategoryController(CategoryAPIClient categoryAPIClient, IMapper mapper)
        {
            _categoryAPIClient = categoryAPIClient;
            _mapper = mapper;
        }

<<<<<<< HEAD
=======

>>>>>>> df3c8afce25b87a713b989fee67f9aca24b4298b
        public async Task< IActionResult> Index()
        {
            var categories = await _categoryAPIClient.GetAllCategories();
            var model = new CategoryIndexModel()
            {
                Categories = _mapper.Map<List<CategoryViewModel>>(categories)
            };
            return View(model);
        }

<<<<<<< HEAD
        public async Task<IActionResult> Delete(int id)
        {
            var category = await _categoryAPIClient.DeleteCategory(id);
            return RedirectToAction("Index", "Category");
        }

        public async Task<IActionResult> Detail(int id)
=======

        public async Task<IActionResult> GetById(int id)
>>>>>>> df3c8afce25b87a713b989fee67f9aca24b4298b
        {
            var category =await _categoryAPIClient.GetByCategoryId(id);
            var model = new CategoryDetailModel()
            {
                Category = _mapper.Map<CategoryViewModel>(category)
            };
            return View(model);
        }
        
    }
}
