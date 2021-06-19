using AutoMapper;
using ECommerce.ClientService.Client;
using ECommerce.Service.Request;
using ECommerce.Service.Response;
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



        public async Task<IActionResult> Index()
        {
            var categories = await _categoryAPIClient.GetAllCategories();
            var model = new CategoryIndexModel()
            {
                Categories = _mapper.Map<List<CategoryViewModel>>(categories)
            };
            return View(model);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var category = await _categoryAPIClient.DeleteCategory(id);
            return RedirectToAction("Index", "Category");
        }

        public async Task<IActionResult> Detail(int id)
        {
            var category = await _categoryAPIClient.GetByCategoryId(id);
            var model = new CategoryDetailModel()
            {
                Category = _mapper.Map<CategoryViewModel>(category)
            };
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
            var category =await _categoryAPIClient.GetByCategoryId(id);

            var model = _mapper.Map<CategoryViewModel>(category);

            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Update(CategoryViewModel categoryViewModel)
        {
            var categoryRequest = _mapper.Map<CategoryRequest>(categoryViewModel);

            await _categoryAPIClient.UpdateCategory(categoryRequest);

            return RedirectToAction("Index", "Category");
        }

        public IActionResult Insert()
        {
            var model = new CategoryViewModel();

            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Insert(CategoryViewModel categoryViewModel)
        {
            var categoryRequest = _mapper.Map<CategoryRequest>(categoryViewModel);

            await _categoryAPIClient.InsertCategory(categoryRequest);

            return RedirectToAction("Index", "Category");
        }
    }
}
