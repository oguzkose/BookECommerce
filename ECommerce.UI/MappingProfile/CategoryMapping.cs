using AutoMapper;
using ECommerce.Service.Request;
using ECommerce.Service.Response;
using ECommerce.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.UI.MappingProfile
{
    public class CategoryMapping:Profile
    {
        public CategoryMapping()
        {
            CreateMap<CategoryResponse, CategoryViewModel>();
            CreateMap<CategoryViewModel, CategoryResponse>();

            CreateMap<CategoryViewModel, CategoryRequest>();
        }
    }
}
