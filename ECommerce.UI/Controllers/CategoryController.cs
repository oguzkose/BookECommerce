using AutoMapper;
using ECommerce.ClientService.Client;
using ECommerce.UI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
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
        public async Task< IActionResult> Index()
        {
            var categories = await _categoryAPIClient.GetAllCategories();
            var model = new CategoryIndexModel()
            {
                Categories = _mapper.Map<List<CategoryViewModel>>(categories)
            };
            return View(model);
        }
    }
}
